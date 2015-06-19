using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pjsip4net.Interfaces
{
    public interface IMediaSource
    {
        double RxLevel { get; set; }
        double TxLevel { get; set; }

        void RecordTo(string fileName);
    }
}
