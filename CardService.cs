using CsvHelper;
using CsvHelper.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace Card_Morpher
{
    public class CardService
    {
        public string readLocation { get; set; }
        public string writeLocation { get; set; }



        public void ReadCardsFromFile()
        {
            var cards = new List<CsvConfig>();

        }

        public List<Card> ReadCardFile(string? readLocation)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = ",",
            };

            using (var reader = new StreamReader(readLocation ?? "C:\\CardList\\cards.csv")) 
            { 
                using (var csv = new CsvReader(reader, config))
                {
                    var cards = csv.GetRecords<Card>().ToList();
                    return cards;
                }

            }

        }

        public void WriteCardFile(string? writeLocation, List<Card> cardList)
        {

            using (var writer = new StreamWriter(writeLocation ?? $"C:\\CardList\\cardListMorphed{""}.csv"))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<CsvConfig>();

                    csv.WriteHeader<Card>();
                    csv.NextRecord();
                    csv.WriteRecords(cardList);

                }
            }

        }


    }
}
