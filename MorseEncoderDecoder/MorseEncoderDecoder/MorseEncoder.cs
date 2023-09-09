using System.Text;

namespace MorseEncoderDecoder
{
    public class MorseEncoder
    {
        internal Dictionary<char, string> _codesLooukupTable = new Dictionary<char, string>();

        public MorseEncoder()
        {
            InitializeCodesLookupTable();
        }

        public string Encode(string stringToEncode)
        {
            if (string.IsNullOrWhiteSpace(stringToEncode))
            {
                return string.Empty;
            }

            stringToEncode = stringToEncode.Trim().ToLower();
            var stringEncoded = new StringBuilder(string.Empty);

            foreach (char c in stringToEncode)
            {
                stringEncoded.Append(_codesLooukupTable[c]);
            }

            return stringEncoded.ToString();
        }

        private void InitializeCodesLookupTable()
        {
            _codesLooukupTable = new Dictionary<char, string>()
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},

                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'0', "-----"},

                {'?', "..---.."},
                {'!', "-.-.--"},
                {'.', ".-.-.-"},
                {',', "--..--"},
                {';', "-.-.-."},
                {':', "---..."},
                {'+', ".-.-."},
                {'-', "-....-"},
                {'/', "-..-."},
                {'=', "-...-"}
            };
        }
    }
}
