using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Card_Morpher
{
    internal class CardMorphTemplate : Card
    {

        List<(string,int)> morphType = new() 
        {
            ("Contact",1),
            ("Gap", 1),
            ("Power", 1),
            ("Eye", 1),
            ("Avoid Ks", 1),
            ("BABIP", 1),
            ("Contact vL", 1),
            ("Gap vL", 1),
            ("Power vL", 1),
            ("Eye vL", 1),
            ("Avoid K vL", 1),
            ("BABIP vL", 1),
            ("Contact vR", 1),
            ("Gap vR", 1),
            ("Power vR", 1),
            ("Eye vR", 1),
            ("Avoid K vR", 1),
            ("BABIP vR",1),
            ("Stuff", 1),
            ("Movement", 1),
            ("Control",1),
            ("Stuff vL", 1),
            ("Movement vL", 1),
            ("Control vL", 1),
            ("pHR vL",1),
            ("Stuff vR", 1),
            ("Movement vR", 1),
            ("Control vR", 1),
            ("pHR vR",1),
            ("Fastball", 1),
            ("Slider", 1),
            ("Curveball", 1),
            ("Changeup", 1),
            ("Cutter", 1),
            ("Sinker", 1),
            ("Splitter", 1),
            ("Forkball", 1),
            ("Screwball", 1),
            ("Circlechange", 1),
            ("Knucklecurve", 1),
            ("Knuckleball", 1),
            ("Stamina", 1),
            ("Hold", 1),
            ("Speed",2),
            ("Steal Rate",2),
            ("Stealing",2),
            ("Baserunning",2),
            ("Sac bunt",2),
            ("Bunt for hit",2),
            ("pBABIP",2),
            ("pBABIP vL",2),
            ("pBABIP vR",2),
            ("Hold",2),
            ("GB",2),
            ("Height",2),
            ("Infield Range",2),
            ("Infield Error",2),
            ("Infield Arm",2),
            ("DP",2),
            ("CatcherAbil",2),
            ("CatcherFrame",2),
            ("Catcher Arm",2),
            ("OF Range",2),
            ("OF Error",2),
            ("OF Arm",2)
        };

       
        public int GetMorphType(string property)
        {
            string query = Regex.Replace(property, @"\s+", "");
           


            var response = this.morphType.Where(e => e.Item1.ToLower() == query.ToLower()).FirstOrDefault(("",0));


            return response.Item2;

        }







        








    }
}
