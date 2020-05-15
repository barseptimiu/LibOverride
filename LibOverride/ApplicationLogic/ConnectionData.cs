using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic
{
    public class ConnectionData
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ConnectionData(string Host, string Port, string Username, string Password)
        {
            this.Host = Host;
            this.Port = Int32.Parse(Port);
            this.Username = Username;
            this.Password = Password;
        }
    }
}
