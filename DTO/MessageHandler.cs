using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MessageHandler
    {
        private String message;
        private bool status;
        public MessageHandler(String message, bool status)
        {
            this.message = message;
            this.status = status;
        }
        public String getMessage()
        {
            return message;
        }

        public bool getStatus()
        {
            return status;
        }

        public void setMessage(String message)
        {
            this.message = message;
        }

        public void setStatus(bool status)
        {
            this.status = status;
        }
    }
}
