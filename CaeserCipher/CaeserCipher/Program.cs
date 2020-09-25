using System; 

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your message to be encrypted:");
            string userMessage = Console.ReadLine();
            userMessage = userMessage.ToLower();

            string parsedInput = ParseInput(userMessage);

            Console.Write("Enter your Key E.G. 3:");
            string userKey = Console.ReadLine();
            int key = StringToNumber(userKey);

            char[] secretMessage = parsedInput.ToCharArray();

            char[] encryptedMsg = Encrypt(secretMessage, key);
            string encryptedString = String.Join("", encryptedMsg);
            Console.WriteLine($"Your message has been encrypted: {encryptedString}\n\n");

            char[] decryptedMsg = Decrypt(encryptedMsg, key);
            string decryptedString = String.Join("", decryptedMsg);
            Console.WriteLine($"Your message has been decrypted: {decryptedString}");

            Console.Read();
        }

        static char[] Encrypt(char[] secretMessage, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char c = secretMessage[i];
                int charIndex = Array.IndexOf(alphabet, c);
                charIndex = (charIndex + key) % 26;
                c = alphabet[charIndex];
                encryptedMessage[i] = c;
            }

            return encryptedMessage;
        }

        static char[] Decrypt(char[] encryptedMessage, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] decryptedMessage = new char[encryptedMessage.Length];

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if (Char.IsLetter(encryptedMessage[i]))
                {
                    char c = encryptedMessage[i];
                    int index = Array.IndexOf(alphabet, c);
                    index = Modulo(index - key, 26);
                    c = alphabet[index];
                    decryptedMessage[i] = c;
                }
                else
                {
                    Console.WriteLine($"Is not a letter. Skipping... {encryptedMessage[i]}");
                }
            }

            return decryptedMessage;
        }

        static string ParseInput(string userInput)
        {
            char[] unparsed = userInput.ToCharArray();
            char[] parsed = new char[unparsed.Length];
            int nonLetterCount = 0;
            int count = 0;

            for (int i = 0; i < unparsed.Length; i++)
            {

                if (Char.IsLetter(unparsed[i]))
                {
                    parsed[count] = unparsed[i];
                    count++;
                }
                else
                {
                    Console.WriteLine($"Not a letter. Skipping character...{unparsed[i]}");
                    nonLetterCount++;
                }
            }

            Array.Resize(ref parsed, unparsed.Length - nonLetterCount);


            string parsedInput = String.Join("", parsed);

            return parsedInput;
        }

        static int StringToNumber(string userInput)
        {
            int key = Convert.ToInt32(userInput);

            return key;
        }

        static int Modulo(int x, int m)
        {
            int r = x % m;
            return r < 0 ? r + m : r;
        }
    }
}