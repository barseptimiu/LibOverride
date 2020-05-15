﻿using LibModels;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic
{
    public class ConnectionManager
    {
        private readonly SftpClient _client;
        private readonly LibFactory factory;

        public event Action<long> MaxValueDetermined;
        public event Action<ulong> ProgressChanged;

        public ConnectionManager(ConnectionData connectionData)
        {
            _client = new SftpClient(connectionData.Host,
                connectionData.Port,
                connectionData.Username,
                connectionData.Password);
            factory = new LibFactory();
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

        public void Upload(string libType, string sourcePath)
        {
            ReplaceableLib replaceableLib = factory.Create(libType);
            Stream FileStream = new FileStream(sourcePath + replaceableLib.FileName, FileMode.Open);
            String RemotePath = replaceableLib.Path + replaceableLib.FileName;

            // Set the progressbar max
            OnMaxValueDetermined(FileStream.Length);

            // TODO: Log started uploading..
            if (_client.IsConnected)
            {
                _client.UploadFile(FileStream, RemotePath, OnProgressChanged);
            }
            // TODO: Log uploaded finished

            FileStream.Close();
        }

        public void Download(string libType, string destinationPath)
        {
            throw new NotImplementedException();
        }

        private void OnProgressChanged(ulong progress)
        {
            ProgressChanged?.Invoke(progress);
        }

        private void OnMaxValueDetermined(long value)
        {
            MaxValueDetermined?.Invoke(value);
        }
    }
}