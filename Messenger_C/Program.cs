using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger_C
{
    [Serializable]
    public class Messenger
    {

        public string NickName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeSend { get; set;  }

        public Messenger(string nickName, string messageText, DateTime timeSend)
        {
            NickName = nickName;
            MessageText = messageText;
            TimeSend = timeSend;
        }

        public Messenger()
        {
            NickName = "User Name";
            MessageText = "Server is Running..";
            TimeSend = DateTime.Now;
        }

        public override string ToString()
        {
            string output = String.Format("{0} <<{2}>> {1}", NickName, MessageText, TimeSend);
            return output;
        }
    }
}
