using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace MorseCodeEncoder
{
    public partial class MainWindow : Window
    {
        private const string morseAlphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ0123456789.,?/'!()&:;=+-_\"@ ";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void encodeButton_Click(object sender, RoutedEventArgs e)
        {
            string inputText = inputTextBox.Text.ToUpper();
            string encodedText = EncodeToMorse(inputText);
            outputTextBox.Text = encodedText;
        }

        private void decodeButton_Click(object sender, RoutedEventArgs e)
        {
            string morseText = inputTextBox.Text;
            string decodedText = DecodeFromMorse(morseText);
            outputTextBox.Text = decodedText;
        }

        private string EncodeToMorse(string inputText)
        {
            StringBuilder encodedText = new StringBuilder();
            foreach (char c in inputText)
            {
                if (morseAlphabet.Contains(c.ToString()))
                {
                    string morseCode = GetMorseCode(c);
                    encodedText.Append(morseCode + " ");
                }
                else
                {
                    encodedText.Append(" ");
                }
            }

            return encodedText.ToString();
        }

        private string DecodeFromMorse(string morseText)
        {
            StringBuilder decodedText = new StringBuilder();
            string[] words = morseText.Split('/');
            foreach (string word in words)
            {
                string[] letters = word.Split(' ');
                foreach (string letter in letters)
                {
                    if (!string.IsNullOrEmpty(letter))
                    {
                        char c = GetCharacterFromMorse(letter);
                        decodedText.Append(c);
                    }
                }

                decodedText.Append(' ');
            }

            return decodedText.ToString();
        }

        private string GetMorseCode(char c)
        {
            switch (c)
            {
                case 'А': return ".-";
                case 'Б': return "-...";
                case 'Ц': return "-.-.";
                case 'Д': return "-..";
                case 'Е': return ".";
                case 'Ф': return "..-.";
                case 'Г': return "--.";
                case 'Х': return "....";
                case 'И': return "..";
                case 'Й': return ".---";
                case 'К': return "-.-";
                case 'Л': return ".-..";
                case 'М': return "--";
                case 'Н': return "-.";
                case 'О': return "---";
                case 'П': return ".--.";
                case 'Щ': return "--.-";
                case 'Р': return ".-.";
                case 'С': return "...";
                case 'Т': return "-";
                case 'У': return "..-";
                case 'Ж': return "...-";
                case 'В': return ".--";
                case 'Ь': return "-..-";
                case 'Ы': return "-.--";
                case 'З': return "--..";
                case 'Ч': return "---.";
                case 'Ш': return "----";
                case 'Ъ': return "--.--";
                case 'Э': return "..-..";
                case 'Ю': return "..--";
                case 'Я': return ".-.-";

                case '0': return "-----";
                case '1': return ".----";
                case '2': return "..---";
                case '3': return "...--";
                case '4': return "....-";
                case '5': return ".....";
                case '6': return "-....";
                case '7': return "--...";
                case '8': return "---..";
                case '9': return "----.";

                case '.': return ".-.-.-";
                case ',': return "--..--";
                case '?': return "..--..";
                case '\'': return ".----.";
                case '!': return "-.-.--";
                case '/': return "-..-.";
                case '(': return "-.--.";
                case ')': return "-.--.-";
                case '&': return ".-...";
                case ':': return "---...";
                case ';': return "-.-.-.";
                case '=': return "-...-";
                case '+': return ".-.-.";
                case '-': return "-....-";
                case '_': return "..--.-";
                case '"': return ".-..-.";
                case '$': return "...-..-";
                case '@': return ".--.-.";
                case '¿': return "..-.-";
                case '¡': return "--...-";
                case ' ': return "/";


                default: return "";
            }
        }

        private char GetCharacterFromMorse(string morseCode)
        {
            switch (morseCode)
            {
                case ".-": return 'А';
                case "-...": return 'Б';
                case "-.-.": return 'Ц';
                case "-..": return 'Д';
                case ".": return 'Е';
                case "..-.": return 'Ф';
                case "--.": return 'Г';
                case "....": return 'Х';
                case "..": return 'И';
                case ".---": return 'Й';
                case "-.-": return 'К';
                case ".-..": return 'Л';
                case "--": return 'М';
                case "-.": return 'Н';
                case "---": return 'О';
                case ".--.": return 'П';
                case "--.-": return 'Щ';
                case ".-.": return 'Р';
                case "...": return 'С';
                case "-": return 'Т';
                case "..-": return 'У';
                case "...-": return 'Ж';
                case ".--": return 'В';
                case "-..-": return 'Ь';
                case "-.--": return 'Ы';
                case "--..": return 'З';
                case "---.": return 'Ч';
                case "----": return 'Ш';
                case "--.--": return 'Ъ';
                case "..-..": return 'Э';
                case "..--": return 'Ю';
                case ".-.-": return 'Я';

                case "-----": return '0';
                case ".----": return '1';
                case "..---": return '2';
                case "...--": return '3';
                case "....-": return '4';
                case ".....": return '5';
                case "-....": return '6';
                case "--...": return '7';
                case "---..": return '8';
                case "----.": return '9';

                case ".-.-.-": return '.';
                case "--..--": return ',';
                case "..--..": return '?';
                case ".----.": return '\'';
                case "-.-.--": return '!';
                case "-..-.": return '/';
                case "-.--.": return '(';
                case "-.--.-": return ')';
                case ".-...": return '&';
                case "---...": return ':';
                case "-.-.-.": return ';';
                case "-...-": return '=';
                case ".-.-.": return '+';
                case "-....-": return '-';
                case "..--.-": return '_';
                case ".-..-.": return '"';
                case "...-..-": return '$';
                case ".--.-.": return '@';
                case "..-.-": return '¿';
                case "--...-": return '¡';
                case "/": return ' ';



                default: return ' ';
            }
        }
    }
}