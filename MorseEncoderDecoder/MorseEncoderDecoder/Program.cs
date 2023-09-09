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
    case 1:

        break;

    case 2:
        Console.Write("Insert text to encode to Morse: \n");
        var stringToEncode = Console.ReadLine();

        if (string.IsNullOrEmpty(stringToEncode))
        {
            Console.WriteLine("Text must contains at least 1 character");
            break;
        }

        var encoder = new MorseEncoder();
        Console.WriteLine($"Text encoded to Morse: {encoder.Encode(stringToEncode)}");
        break;

    default:
        Console.WriteLine("Invalid option.");
        break;
}

Console.Read();
