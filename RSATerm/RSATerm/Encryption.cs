using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace RSATerm
{
    class Encryption
    {
        private int KeySize;
        private int BlockSize;     //11 Byte padding - must be Keysize/8 - 11
        //RSA 
        private System.Security.Cryptography.RSACryptoServiceProvider m_RSADecryptSvc;
        private System.Security.Cryptography.RSACryptoServiceProvider m_RSAEncryptSvc;

        private CommStack m_CommStack;

        public Encryption()
        {
            m_CommStack = new CommStack();
            
        }

        public bool RSASetKeySize(int _size)
        {
            bool ret = false;


            BlockSize = (KeySize / 8) - 1;
            return ret;
        }

        public int RSAGetKeySize()
        {
            return KeySize;
        }

        public KeySizes[] RSAValidKeySizes()
        {
            return m_RSADecryptSvc.LegalKeySizes;
        }

        public bool RSAGenerateNewKeySet()
        {
            bool ret = false;
            m_RSADecryptSvc = new System.Security.Cryptography.RSACryptoServiceProvider(KeySize);
   
            return ret;
        }

        public void RSA_SendString(String _TxData)
        {
            //Pad the string length with whitespace to make a size evenly divisible into blocks:
            int toAdd = _TxData.Length % BlockSize;
            for(int i = 0; i < toAdd; i++)
            {
                _TxData = _TxData.Insert(_TxData.Length, " ");
            }

            //Figure out how many blocks need to be transmitted:
            int numBlocks = _TxData.Length / BlockSize;

            //Start the message transmit:
            m_CommStack.StartEncryptedMessage(numBlocks);

            //Encrypt the blocks and dump into the output stream:
            for (int i = 0; i < numBlocks; i++)
            {
                char[] temp = _TxData.ToCharArray(i * BlockSize, BlockSize);
                byte[] bytes = new byte[BlockSize];

                int j = 0;
                foreach (char c in temp)
                {
                    bytes[j++] = Convert.ToByte(c);
                }

                byte[] encrypted = m_RSAEncryptSvc.Encrypt(bytes, false);

                //Transmit the encrypted block.
                m_CommStack.TransmitEncryptedBlock(BlockSize, encrypted);
            }

            //Transmit end encrypted message
            m_CommStack.EndEncryptedMessage();
        }

    }
}
