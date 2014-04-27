using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pjsip4net.Core.Data;

namespace pjsip4net.Interfaces
{
    public interface IFileSourceMedia
    {
        string File { get; }
        ConferencePortInfo ConferenceSlot { get; }
    }
}
