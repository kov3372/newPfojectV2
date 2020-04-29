using System;
using System.Text;
using System.IO;
using System.Linq;


namespace frequency_analysisv4
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string pathForTableCharacterInCp1251 = @"d:\newProjectV2\\newProjectV2\UkrAlpIncp1251.txt";
            string pathForTableCharacterInCp866 = @"c:\text\UkrAlpIncp866.txt";
            string pathForTableCharacterInKoiu8 = @"c:\text\UkrAlpInKoiu8-u.txt";

            string pathForText = @"d:\newProjectV2\\newProjectV2\text4.txt";
            //         string pathForNormalText = @"c:\text\text1.txt";
            string textFromFile = ReadTextFromFile(pathForText);
            byte[] byteOfText = ReadByteOfText(pathForText);

            byte[] byteOfAlphabetCp1251 = ReadByteOfCharacter(pathForTableCharacterInCp1251);
            byte[] byteOfAlphabetCp866 = ReadByteOfCharacter(pathForTableCharacterInCp866);
            byte[] byteOfAlphabetKoiu8 = ReadByteOfCharacter(pathForTableCharacterInKoiu8);

            EncodingCharacterFrequency[] encodingArrayCp866 = CountOfCharactersInNormalText(byteOfAlphabetCp866, byteOfText);
            EncodingCharacterFrequency[] encodingArrayCp1251 = CountOfCharactersInNormalText(byteOfAlphabetCp1251, byteOfText);
            EncodingCharacterFrequency[] encodingArrayKoiu8 = CountOfCharactersInNormalText(byteOfAlphabetKoiu8, byteOfText);

            for (int i = 0; i < byteOfText.Length; i++)
            {
                //      Console.Write(byteOfText[i] + " ");
            }

            for (int i = 0; i < encodingArrayCp1251.Length; i++)
            {
                //   Console.WriteLine(encodingArrayCp1251[i] );
            }


            for (int i = 0; i < encodingArrayKoiu8.Length; i++)
            {
                //   Console.WriteLine(encodingArrayKoiu8[i]);
            }

            for (int i = 0; i < encodingArrayCp866.Length; i++)
            {
                //      Console.WriteLine( encodingArrayCp866[i] );
            }

            UkrСharacterFrequency[] ukrArray = UkrСharactersFrequency();
            string rez1 = GenereteTextResult(byteOfText, encodingArrayCp866, ukrArray);
            string rez2 = GenereteTextResult(byteOfText, encodingArrayCp1251, ukrArray);
            string rez3 = GenereteTextResult(byteOfText, encodingArrayKoiu8, ukrArray);


            // Console.WriteLine(textFromFile);
            Console.WriteLine();
            // Console.WriteLine(rez1);
            Console.WriteLine();
            //  Console.WriteLine(rez2);
            Console.WriteLine();
            //  Console.WriteLine(rez3);
        }

        public static string ReadTextFromFile(string pathForText)
        {
            string readText = File.ReadAllText(pathForText);
            return readText;
        }

        public static byte[] ReadByteOfText(string pathForText)
        {
            byte[] readByteOfText = File.ReadAllBytes(pathForText);
            return readByteOfText;
        }

        public static byte[] ReadByteOfCharacter(string pathForTableCharacter)
        {
            byte[] readByteOfCharacter = File.ReadAllBytes(pathForTableCharacter);
            return readByteOfCharacter;
        }

        public static UkrСharacterFrequency[] UkrСharactersFrequency()
        {
            UkrСharacterFrequency[] array = new UkrСharacterFrequency[33];

            UkrСharacterFrequency item = new UkrСharacterFrequency("a", 0.091);
            array[0] = item;
            item = new UkrСharacterFrequency("б", 0.013);
            array[1] = item;
            item = new UkrСharacterFrequency("в", 0.062);
            array[2] = item;
            item = new UkrСharacterFrequency("г", 0.018);
            array[3] = item;
            item = new UkrСharacterFrequency("д", 0.039);
            array[4] = item;
            item = new UkrСharacterFrequency("е", 0.050);
            array[5] = item;
            item = new UkrСharacterFrequency("ж", 0.009);
            array[6] = item;
            item = new UkrСharacterFrequency("з", 0.028);
            array[7] = item;
            item = new UkrСharacterFrequency("и", 0.064);
            array[8] = item;
            item = new UkrСharacterFrequency("й", 0.008);
            array[9] = item;
            item = new UkrСharacterFrequency("к", 0.038);
            array[10] = item;
            item = new UkrСharacterFrequency("л", 0.026);
            array[11] = item;
            item = new UkrСharacterFrequency("м", 0.031);
            array[12] = item;
            item = new UkrСharacterFrequency("н", 0.095);
            array[13] = item;
            item = new UkrСharacterFrequency("о", 0.107);
            array[14] = item;
            item = new UkrСharacterFrequency("п", 0.036);
            array[15] = item;
            item = new UkrСharacterFrequency("р", 0.055);
            array[16] = item;
            item = new UkrСharacterFrequency("с", 0.043);
            array[17] = item;
            item = new UkrСharacterFrequency("т", 0.057);
            array[18] = item;
            item = new UkrСharacterFrequency("у", 0.035);
            array[19] = item;
            item = new UkrСharacterFrequency("ф", 0.004);
            array[20] = item;
            item = new UkrСharacterFrequency("х", 0.012);
            array[21] = item;
            item = new UkrСharacterFrequency("ц", 0.010);
            array[22] = item;
            item = new UkrСharacterFrequency("ч", 0.011);
            array[23] = item;
            item = new UkrСharacterFrequency("ш", 0.003);
            array[24] = item;
            item = new UkrСharacterFrequency("щ", 0.004);
            array[25] = item;
            item = new UkrСharacterFrequency("і", 0.045);
            array[26] = item;
            item = new UkrСharacterFrequency("ї", 0.009);
            array[27] = item;
            item = new UkrСharacterFrequency("ь", 0.014);
            array[28] = item;
            item = new UkrСharacterFrequency("є", 0.003);
            array[29] = item;
            item = new UkrСharacterFrequency("ю", 0.008);
            array[30] = item;
            item = new UkrСharacterFrequency("я", 0.026);
            array[31] = item;
            item = new UkrСharacterFrequency("ґ", 0.001);
            array[32] = item;
            return array;
        }

        public static UkrСharacterFrequency[] UkrСharactersFrequencyV2()
        {
            UkrСharacterFrequency[] array = new UkrСharacterFrequency[33];

            UkrСharacterFrequency item = new UkrСharacterFrequency("a", 0.064);
            array[0] = item;
            item = new UkrСharacterFrequency("б", 0.013);
            array[1] = item;
            item = new UkrСharacterFrequency("в", 0.046);
            array[2] = item;
            item = new UkrСharacterFrequency("г", 0.013);
            array[3] = item;
            item = new UkrСharacterFrequency("д", 0.027);
            array[4] = item;
            item = new UkrСharacterFrequency("е", 0.042);
            array[5] = item;
            item = new UkrСharacterFrequency("ж", 0.007);
            array[6] = item;
            item = new UkrСharacterFrequency("з", 0.020);
            array[7] = item;
            item = new UkrСharacterFrequency("и", 0.055);
            array[8] = item;
            item = new UkrСharacterFrequency("й", 0.008);
            array[9] = item;
            item = new UkrСharacterFrequency("к", 0.033);
            array[10] = item;
            item = new UkrСharacterFrequency("л", 0.027);
            array[11] = item;
            item = new UkrСharacterFrequency("м", 0.029);
            array[12] = item;
            item = new UkrСharacterFrequency("н", 0.068);
            array[13] = item;
            item = new UkrСharacterFrequency("о", 0.086);
            array[14] = item;
            item = new UkrСharacterFrequency("п", 0.036);
            array[15] = item;
            item = new UkrСharacterFrequency("р", 0.055);
            array[16] = item;
            item = new UkrСharacterFrequency("с", 0.043);
            array[17] = item;
            item = new UkrСharacterFrequency("т", 0.045);
            array[18] = item;
            item = new UkrСharacterFrequency("у", 0.027);
            array[19] = item;
            item = new UkrСharacterFrequency("ф", 0.003);
            array[20] = item;
            item = new UkrСharacterFrequency("х", 0.011);
            array[21] = item;
            item = new UkrСharacterFrequency("ц", 0.010);
            array[22] = item;
            item = new UkrСharacterFrequency("ч", 0.011);
            array[23] = item;
            item = new UkrСharacterFrequency("ш", 0.005);
            array[24] = item;
            item = new UkrСharacterFrequency("щ", 0.004);
            array[25] = item;
            item = new UkrСharacterFrequency("і", 0.044);
            array[26] = item;
            item = new UkrСharacterFrequency("ї", 0.009);
            array[27] = item;
            item = new UkrСharacterFrequency("ь", 0.016);
            array[28] = item;
            item = new UkrСharacterFrequency("є", 0.005);
            array[29] = item;
            item = new UkrСharacterFrequency("ю", 0.008);
            array[30] = item;
            item = new UkrСharacterFrequency("я", 0.019);
            array[31] = item;
            item = new UkrСharacterFrequency("ґ", 0.001);
            array[32] = item;
            return array;
        }




        public static EncodingCharacterFrequency[] CountOfCharactersInNormalText(byte[] byteOfAlphabet, byte[] byteOfText)
        {
            int p = 0;
            EncodingCharacterFrequency[] array = new EncodingCharacterFrequency[byteOfAlphabet.Length];
            int count2 = 0;
            foreach (byte c in byteOfAlphabet)
            {
                foreach (byte s in byteOfText)
                {
                    if (s == c)
                    {
                        count2++;
                    }
                }
            }

            int g = 0;
            foreach (byte c in byteOfAlphabet)
            {
                int count1 = 0;
                foreach (byte s in byteOfText)
                {
                    if (s == c)
                    {
                        count1++;
                    }
                }
                double Freq = ((double)count1 / (double)count2);
                Freq = (Math.Round(Freq, 3, MidpointRounding.AwayFromZero));
                array[g] = new EncodingCharacterFrequency(c, Freq);
                g++;
            }
            return array;
        }

        public static string GenereteTextResult(byte[] byteOfText, EncodingCharacterFrequency[] encodingArray, UkrСharacterFrequency[] ukrArray)
        {

            string text = "";
            byte prob = 32;
            byte koma = 44;
            byte tochka = 46;
            byte tire = 45;
            byte enter = 13;

            foreach (byte b in byteOfText)
            {
                for (int i = 0; i < encodingArray.Length; i++)
                {

                    if (encodingArray[i].character == b)
                    {
                        if (encodingArray[i].character == prob)
                        {
                            text = text + " ";
                            break;
                        }
                        if (encodingArray[i].character == koma)
                        {
                            text = text + ",";
                            break;
                        }
                        if (encodingArray[i].character == tochka)
                        {
                            text = text + ".";
                            break;
                        }
                        if (encodingArray[i].character == tire)
                        {
                            text = text + "-";
                            break;
                        }
                        double[] raznica = new double[33];
                        for (int g = 0; g < ukrArray.Length; g++)
                        {
                            raznica[g] = Math.Abs((ukrArray[g].appearance) - (encodingArray[i].appearance));
                        }
                        int h = 0;
                        double min = raznica[0];
                        for (int p = 0; p < raznica.Length; p++)
                        {
                            if (raznica[p] <= min)
                            {
                                min = raznica[p];
                                h = p;
                            }
                        }
                        text = text + ukrArray[h].character;
                    }
                }
            }
            return text;
        }



    }
    struct EncodingCharacterFrequency
    {
        public byte character;
        public double appearance;

        public EncodingCharacterFrequency(byte character, double appearance)
        {
            this.character = character;
            this.appearance = appearance;
        }

        public override string ToString()
        {
            return String.Format("{0}-{1}", this.character, this.appearance);
        }
    }
    struct UkrСharacterFrequency
    {
        public string character;
        public double appearance;
        public UkrСharacterFrequency(string character, double appearance)
        {
            this.character = character;
            this.appearance = appearance;
        }

        public override string ToString()
        {
            return String.Format("{0}-{1}", this.character, this.appearance);
        }
    }



    // static public EncodingCharacterFrequency[] CalAndFreq(byte[] readByteOfText, byte[] byteOfAlphabetCp1251)
    //  {
    //     EncodingCharacterFrequency[] array = new EncodingCharacterFrequency[0X100];
    //     byte[] charecter = new byte[0x100];
    //    double[] num = new double[0x100];
    //     int count2 = 0;
    //      double[] freq = new double[num.Length];

    //    foreach (byte c in byteOfAlphabetCp1251)
    //    {
    //       foreach (byte s in readByteOfText)
    //        {
    //            if (s == c)
    //            {
    //                 count2++;
    //             }
    //         }
    ///      }
    //     byte g = 0;
    //     foreach (byte b in charecter)
    //     {
    //         g++;
    //        charecter[g] = g;
    //     }

    //    foreach (byte b in readByteOfText)
    //    {
    //        num[b]++;
    //    }

    //    for (int i = 0; i < charecter.Length; i++)
    //    {
    //        array[i].character = charecter[i];
    //     }

    //      for (int i = 0; i < freq.Length; i++)
    //     {
    //         freq[i] = num[i] / count2;
    //        freq[i] = (Math.Round(freq[i], 3, MidpointRounding.AwayFromZero));
    //          array[i].appearance = freq[i];
    ///      }
    //    return array;
    // }
}
