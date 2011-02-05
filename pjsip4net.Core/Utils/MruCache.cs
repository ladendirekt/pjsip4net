using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pjsip4net.Core.Utils
{
    internal class MruCache<TKey, TValue>
        where TKey : class
        where TValue : class
    {
        private int highWatermark;
        private Dictionary<TKey, CacheEntry<TKey, TValue>> items;
        private int lowWatermark;
        private CacheEntry<TKey, TValue> mruEntry;
        private LinkedList<TKey> mruList;

        public MruCache(int watermark)
            : this((watermark*4)/5, watermark)
        {
        }

        public MruCache(int lowWatermark, int highWatermark)
            : this(lowWatermark, highWatermark, null)
        {
        }

        public MruCache(int lowWatermark, int highWatermark, IEqualityComparer<TKey> comparer)
        {
            this.lowWatermark = lowWatermark;
            this.highWatermark = highWatermark;
            mruList = new LinkedList<TKey>();
            if (comparer == null)
            {
                items = new Dictionary<TKey, CacheEntry<TKey, TValue>>();
            }
            else
            {
                items = new Dictionary<TKey, CacheEntry<TKey, TValue>>(comparer);
            }
        }

        public void Add(TKey key, TValue value)
        {
            bool flag = false;
            try
            {
                CacheEntry<TKey, TValue> entry;
                if (items.Count == highWatermark)
                {
                    int num = highWatermark - lowWatermark;
                    for (int i = 0; i < num; i++)
                    {
                        TKey local = mruList.Last.Value;
                        mruList.RemoveLast();
                        TValue item = items[local].value;
                        items.Remove(local);
                        OnSingleItemRemoved(item);
                    }
                }
                entry.node = mruList.AddFirst(key);
                entry.value = value;
                items.Add(key, entry);
                mruEntry = entry;
                flag = true;
            }
            finally
            {
                if (!flag)
                {
                    Clear();
                }
            }
        }

        public void Clear()
        {
            mruList.Clear();
            items.Clear();
            mruEntry.value = default(TValue);
            mruEntry.node = null;
        }

        protected virtual void OnSingleItemRemoved(TValue item)
        {
        }

        public bool Remove(TKey key)
        {
            CacheEntry<TKey, TValue> entry;
            if (!items.TryGetValue(key, out entry))
            {
                return false;
            }
            items.Remove(key);
            OnSingleItemRemoved(entry.value);
            mruList.Remove(entry.node);
            if (ReferenceEquals(mruEntry.node, entry.node))
            {
                mruEntry.value = default(TValue);
                mruEntry.node = null;
            }
            return true;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            CacheEntry<TKey, TValue> entry;
            if (((mruEntry.node != null) && (key != null)) && key.Equals(mruEntry.node.Value))
            {
                value = mruEntry.value;
                return true;
            }
            bool flag = items.TryGetValue(key, out entry);
            value = entry.value;
            if ((flag && (mruList.Count > 1)) && !ReferenceEquals(mruList.First, entry.node))
            {
                mruList.Remove(entry.node);
                mruList.AddFirst(entry.node);
                mruEntry = entry;
            }
            return flag;
        }

        // Nested Types

        #region Nested type: CacheEntry

        [StructLayout(LayoutKind.Sequential)]
        private struct CacheEntry<TKey, TValue>
            where TKey : class
            where TValue : class
        {
            internal TValue value;
            internal LinkedListNode<TKey> node;
        }

        #endregion
    }
}