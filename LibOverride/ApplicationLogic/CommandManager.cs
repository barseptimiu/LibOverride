using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic
{
    public class CommandManager
    {
        private readonly SshClient _client;

        public CommandManager(ConnectionData connectionData)
        {
            _client = new SshClient(connectionData.Host,
                connectionData.Port,
                connectionData.Username,
                connectionData.Password);
        }

        public void Connect()
        {
            try
            {
                if (!_client.IsConnected)
                    _client.Connect();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Disconnect()
        {
            if (_client.IsConnected)
                _client.Disconnect();
        }

        public void ReadWriteAccess()
        {
            if(_client.IsConnected)
            {
                _client.RunCommand("mount - / -oremount,rw");
            }
        }

        public void StopAndroidAutoService()
        {
            if (_client.IsConnected)
            {
                _client.RunCommand("systemctl stop ovip-sys-connsrv-androidauto");
            }
        }

        public void StartAndroidAutoService()
        {
            if (_client.IsConnected)
            {
                _client.RunCommand("systemctl start ovip-sys-connsrv-androidauto");
            }
        }

        public void Sync()
        {
            if (_client.IsConnected)
            {
                _client.RunCommand("sync");
            }
        }
    }
}
