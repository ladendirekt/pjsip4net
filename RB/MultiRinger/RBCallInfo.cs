using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiRinger
{
    [Serializable]
    class RBCallInfo
    {
        public string CallID;
        public string From;
        public string To;
        public string CSeq;
        public string Via;
        public string Contact;
        public DateTime timestamp;
    }
}
