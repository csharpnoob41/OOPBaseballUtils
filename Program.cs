using Card_Morpher;
using System.ComponentModel.Design;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

var cardList = new List<Card>();
var service = new CardService();
var template = new CardMorphTemplate();

try
{
    cardList = service.ReadCardFile(null);

    foreach(var card in cardList)
    {
        foreach(PropertyInfo property in card.GetType().GetProperties())
        {


            int morphType = template.GetMorphType(property.Name);


            if(property.PropertyType == typeof(int))
            {
                int update = (int)property.GetValue(card);
                if (morphType == 0)
                {
                    continue;
                }
                else if (morphType == 1)
                {
                    if (update <= 76)
                    {
                        update = (399 / 75) * (update - 1) + 1;

                    }
                    else
                    {
                        update = (150 / 114) * (update - 76) + 400;

                    }
                    property.SetValue(card, update, null);
    
                }
                else if(morphType == 2) 
                {
                
                    
                    update = (update - 1) * 2;

                   
                }

                else if(morphType == 3)
                {
                    update = (update - 1) * 2;

                    if (update <= 120)
                    {
                        update = 1 + (update - 1) * (70-1)/(120-1);
                    }
                    else if(update <= 270)
                    {
                        update = 70 + (update - 120) * (200 - 70)/(270-120);
                    }
                    else
                    {
                        update = 200 + (update - 270) * (250 - 200) / (318 - 270);
                    }
                }
                property.SetValue(card, update, null);


            }





        }
    }

    service.WriteCardFile(null, cardList);


}

catch(Exception ex) {

    Console.WriteLine(ex.ToString());
    Console.WriteLine(ex.Message);
}
