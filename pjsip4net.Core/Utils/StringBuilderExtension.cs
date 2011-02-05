using System.Text;

namespace pjsip4net.Core.Utils
{
    public static class StringBuilderExtension
    {
        public static void Clear(this StringBuilder builder)
        {
            if (builder.Length > 0)
                builder.Remove(0, builder.Length);
        }

        public static string ToStringAndClear(this StringBuilder builder)
        {
            string result = builder.ToString();
            builder.Clear();
            return result;
        }
    }
}