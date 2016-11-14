﻿using System;
using System.IO;

namespace NetMentoring
{
    public class MemoryStreamLogger : IDisposable
    {
        private FileStream memoryStream;
        private StreamWriter streamWriter;

        public MemoryStreamLogger()
        {
            memoryStream = new FileStream(@"\log.txt", FileMode.OpenOrCreate);
            memoryStream.Seek(0, SeekOrigin.End);
            streamWriter = new StreamWriter(memoryStream);
        }

        public void Log(string message)
        {
            streamWriter.Write(message);
        }

        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    streamWriter.Dispose();
                    memoryStream.Dispose();
                }

                disposedValue = true;
            }
        }

       
        public void Dispose()
        {
            Dispose(true);
        }

    }
}