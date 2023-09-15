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

                        if (stringSplits.Length != 6)
                        {
                            Console.WriteLine($"L'indirizzo non è leggibile");
                        }
                        else
                        {
                            int counter = 0;

                            for (int i = 0; i < stringSplits.Length; i++)
                            {
                                stringSplits[i] = stringSplits[i].Trim();
                                if (stringSplits[i].Length > 0)
                                {
                                    counter++;
                                }
                            }

                            if (counter == 6)
                            {
                                string name = stringSplits[0];
                                string surname = stringSplits[1];
                                string street = stringSplits[2];
                                string city = stringSplits[3];
                                string province = stringSplits[4];
                                string zip = stringSplits[5];

                                Console.WriteLine($"Questo è l'indirizzo di {name},{surname}: Via {street} Città {city} Provincia {province} Cap{zip}");

                                Address newAddress = new Address(name, surname, street, city, province, zip);

                                listAddress.Add(newAddress);
                            } else
                            {
                                Console.WriteLine("L'indirizzo non è leggibile");
                            }
                           
                        }
                    }
                }

                fileListAddresss.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            // LEGGO E STAMPO LA LISTA DI INDIRIZZI e la scrivo in un file:
            try
            {

                StreamWriter fileToWrite = File.CreateText("C:\\Users\\giada\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\new-list-address.csv");

                for (int i = 0; i < listAddress.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listAddress[i]}");
                    fileToWrite.WriteLine($"{i + 1}. {listAddress[i]}");
                }

                fileToWrite.Close();
            }
            catch
            {
                Console.WriteLine("C'è stata un'eccezione");
            }
        }
    }
}