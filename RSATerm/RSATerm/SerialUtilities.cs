using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSATerm
{
    //This class will contain the serial port, and streams/buffers.
    public class SerialUtilities
    {
        protected static Queue<String> SerialIn;
        protected static Queue<String> SerialOut;
        public event System.EventHandler<DataAvailableEventArgs> DataAvailable;

        //The serial port object:
        public System.IO.Ports.SerialPort spIOPort; //{get; set; }


        //The Constructor:
        public SerialUtilities()
        {
            spIOPort = new System.IO.Ports.SerialPort();
            SerialOut = new Queue<String>();
            //Define Events + Link Handlers:
            spIOPort.DataReceived += spIOPort_DataReceived;
            spIOPort.ErrorReceived += spIOPort_ErrorReceived;
        }

        //Event Handler - Error Received:
        void spIOPort_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        
        //Event Handler - Data Received:
        private String m_buffer;
        void spIOPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           m_buffer += spIOPort.ReadChar();
            if (m_buffer.Contains ("\x0D\x0A"))
            {
                DataAvailableEventArgs m_e = new DataAvailableEventArgs();
                m_e.data = m_buffer;
                //We have a newline!  Time to go!
                OnDataAvailable(m_e);
            }
        }


        protected virtual void OnDataAvailable(DataAvailableEventArgs e)
        {
            System.EventHandler<DataAvailableEventArgs> handler = DataAvailable;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public System.IO.Ports.SerialPort getSerialPort()
        {
            return spIOPort;
        }

    }

    public class DataAvailableEventArgs : EventArgs
    {
        public String data;
    }

}
