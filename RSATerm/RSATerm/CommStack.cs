using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RSATerm
{
    public class CommStack
    {
        protected static String sPlaintextOut;
        protected static String sPlaintextIn;
        protected static String sCyphertextOut;
        protected static String sCyphertextIn;

        public event System.EventHandler<DataAvailableEventArgs> PingReceived;          //Ping Frame
        public event System.EventHandler<DataAvailableEventArgs> PlaintextAvailable;    //Plaintext Frame
        public event System.EventHandler<DataAvailableEventArgs> CyphertextAvailable;   //Cyphertext Frame
        public event System.EventHandler<DataAvailableEventArgs> PublicKeyAvailable;    //Serialized RSA Key container object


        public SerialUtilities m_SerialClass;

        //Constructor
        public CommStack():base()
        {
            m_SerialClass = new SerialUtilities();
            //Event + Handler
            m_SerialClass.DataAvailable += m_SerialClass_DataAvailable;
        }

        void m_SerialClass_DataAvailable(object sender, DataAvailableEventArgs e)
        {
            //Parse down the string for the item marker

            //Inspect the frame type, pass it off to the correct signal accordingly


        }

        //Transmission Stuff:
        public void StartEncryptedMessage(int _numblocks)
        {

        }

        public void EndEncryptedMessage()
        {

        }

        public void TransmitEncryptedBlock(int _blocksize, byte[] encrypted)
        {
            //Build a frame, serialize it, and send it.  
        }


    }
}
