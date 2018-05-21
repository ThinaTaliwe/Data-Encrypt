using System;
using System.Linq;
using System.Text;

namespace Caesar_Cipher
{
    // Caesar Cipher Technique for encryption
    class CaesarCipherEnc
    {
        // Attributes
        string message;
        int shift;

        // Constructor
        public CaesarCipherEnc(string msg, int shft)
        {
            this.message = msg;
            this.shift = shft;
            encryptMessage(message, shift);
        }

        // Methods
        public StringBuilder encryptMessage(String message,int shift)
        {
            StringBuilder finalMessage = new StringBuilder();
            for(int msgIndex = 0; msgIndex < message.Length; msgIndex++)
            {
                if(Char.IsUpper(message.ElementAt<char>(msgIndex)))
                {
                    char charEM = (char)(((int)message.ElementAt<char>(msgIndex) + shift - 65) % 26 + 65);
                    finalMessage.Append(charEM);
                }
                else
                {
                    char charEM = (char)(((int)message.ElementAt<char>(msgIndex) + shift - 97) % 26 + 97);
                    finalMessage.Append(charEM);
                }
            }
            return finalMessage;
        }
    }
}
