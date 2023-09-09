// See https://aka.ms/new-console-template for more information
using MorseEncoderDecoder;

int _option;

Console.Write(
    "Select an option:\n " +
    "1: Decode Morse to ASCII\n " +
    "2: Encode ASCII to Morse\n " +
    "3: Quit\n\n");

_option = Convert.ToInt32(Console.ReadLine());

switch (_option)
{
    case 1: DecodeToAscii(); break;
    case 2: EncodeToMorse(); break;
    case 3: return; 
    default: Console.WriteLine("Invalid option."); break;
}

Console.Read();

static void EncodeToMorse()
{
    Console.Write("Insert text to encode to Morse: ");
    var stringToEncode = Console.ReadLine();

    if (string.IsNullOrEmpty(stringToEncode))
    {
        Console.WriteLine("Text must contains at least 1 character");
        return;
    }

    var encoder = new MorseEncoder();
    Console.WriteLine($"Text encoded to Morse: {encoder.Encode(stringToEncode)}");
}

static void DecodeToAscii()
{
    Console.Write("Insert text in Morse to de decoded (each character must be separated by an empty space): ");
    var stringToDecode = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(stringToDecode)) 
    {
        Console.WriteLine("Text must contains at least 1 Morse Symbol");
        return;
    }

    var decoder = new MorseDecoder();
    Console.WriteLine($"Text decoded to ASCII: {decoder.Decode(stringToDecode)}");
}
