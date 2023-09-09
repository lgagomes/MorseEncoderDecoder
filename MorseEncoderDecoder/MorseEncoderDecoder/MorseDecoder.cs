using System.Text;

namespace MorseEncoderDecoder
{
    public class MorseDecoder
    {
        internal Dictionary<string, char> _codesLooukupTable = new Dictionary<string, char>();

        public MorseDecoder()
        {
            InitializeCodesLookupTable();
        }

        public string Decode(string stringToDecode)
        {
            if (string.IsNullOrWhiteSpace(stringToDecode))
            {
                return string.Empty;
            }

            stringToDecode = stringToDecode.ToLower();
            var symbolsToDecode = stringToDecode.Split(' ');
            var stringDecoded = new StringBuilder(string.Empty);

            foreach (var symbol in symbolsToDecode ) 
            {
                stringDecoded.Append(_codesLooukupTable[symbol]);
            }

            return stringDecoded.ToString();
        }

        private void InitializeCodesLookupTable()
        {
            _codesLooukupTable = new Dictionary<string, char>()
            {
                {".-", 'a'},
                {"-...", 'b'},
                {"-.-.", 'c'},
                {"-..", 'd'},
                {".", 'e'},
                {"..-.", 'f'},
                {"--.", 'g'},
                {"....", 'h'},
                {"..", 'i'},
                {".---", 'j'},
                {"-.-", 'k'},
                {".-..", 'l'},
                {"--", 'm'},
                {"-.", 'n'},
                {"---", 'o'},
                {".--.", 'p'},
                {"--.-", 'q'},
                {".-.", 'r'},
                {"...", 's'},
                {"-", 't'},
                {"..-", 'u'},
                {"...-", 'v'},
                {".--", 'w'},
                {"-..-", 'x'},
                {"-.--", 'y'},
                {"--..", 'z'},

                {".----", '1'},
                {"..---", '2'},
                {"...--", '3'},
                {"....-", '4'},
                {".....", '5'},
                {"-....", '6'},
                {"--...", '7'},
                {"---..", '8'},
                {"----.", '9'},
                {"-----", '0'},

                {"..---..", '?'},
                {"-.-.--", '!'},
                {".-.-.-", '.'},
                {"--..--", ','},
                {"-.-.-.", ';'},
                {"---...", ':'},
                {".-.-.", '+'},
                {"-....-", '-'},
                {"-..-.", '/'},
                {"-...-", '='}
            };
        }
    }
}
