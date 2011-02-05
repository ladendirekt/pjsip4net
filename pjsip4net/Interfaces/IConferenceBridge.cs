namespace pjsip4net.Interfaces
{
    public interface IConferenceBridge
    {
        bool IsConferenceActive { get; }
        uint MaxPorts { get; }
        uint ActivePorts { get; }
        double? RxLevel { get; set; }
        double? TxLevel { get; set; }

        void Interconnect(int slotX, int slotY);
        void Disconnect(int slotX, int slotY);
        void ConnectToSoundDevice(int slotId);
        void DisconnectFromSoundDevice(int slotId);
        void ConnectCall(ICall call);
        void DisconnectCall(ICall call);
    }
}