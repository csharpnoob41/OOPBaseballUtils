
/*
 * (=IF(A1 <= 76, 399/75 * (A1 - 1) + 1, 150/114 * (A1 - 76) + 400)) to columns T through AK, AU through AW, AZ through BC, BE through BH, BJ through BW.

(=(A1-1)*2) to columns AO through AT, AY, BD, BI, BW, BX, and CA through CK.

 * 
 * 
 * */



using Card_Morpher;
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
                else
                {
                    if (update <= 76)
                    {
                        update = (update - 1) * 2;
                    }
                    else
                    {

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