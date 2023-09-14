namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Address> listAddress = new List<Address>();

            try
            {

                StreamReader fileListAddresss = File.OpenText("C:\\Users\\giada\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv");

                int lineNumber = 0;
                while (!fileListAddresss.EndOfStream)
                {
                    string line = fileListAddresss.ReadLine();
                    lineNumber++;
                    if (lineNumber > 1)
                    {
                        string[] stringSplits = line.Split(',');

                        if (stringSplits.Length < 6)
                        {
                            Console.WriteLine($"L'indirizzo {line} non è leggibile");
                        }
                        else
                        {

                            string name = stringSplits[0];
                            string surname = stringSplits[1];
                            string street = stringSplits[2];
                            string city = stringSplits[3];
                            string province = stringSplits[4];
                            string zip = stringSplits[5];

                            Console.WriteLine($" {name} {surname} {street} {city} {province} {zip}");

                            Address newAddress = new Address(name, surname, street, city, province, zip);

                            listAddress.Add(newAddress);
                        }
                    }
                }

                //Console.WriteLine(listAddress);
                fileListAddresss.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                StreamWriter fileToWrite = File.CreateText("C:\\Users\\giada\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\mylistaddress.csv");

                for (int i = 0; i < listAddress.Count; i++)
                {
                    Console.WriteLine(listAddress[i]);
                    fileToWrite.WriteLine(listAddress[i]);
                }
                fileToWrite.Close();
            }catch
            {
                Console.WriteLine("Non è stato possibile stampare l'indirizzo");
            }

        }
    }
}