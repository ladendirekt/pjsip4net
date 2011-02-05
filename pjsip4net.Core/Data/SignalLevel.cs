namespace pjsip4net.Core.Data
{
    public struct SignalLevel
    {
        private uint _rx;
        public uint Rx
        {
            get { return _rx; }
        }

        private uint _tx;
        public uint Tx
        {
            get { return _tx; }
        }

        public SignalLevel(uint rx, uint tx)
        {
            _rx = rx;
            _tx = tx;
        }
    }
}