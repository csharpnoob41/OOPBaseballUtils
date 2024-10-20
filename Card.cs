using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CsvHelper.Configuration.Attributes;
using CsvHelper;
using System.Runtime.CompilerServices;

namespace Card_Morpher
{
    public class Card
    {



        public Card() { }

       

        [Name("Card Title")]
        public string CardTitle { get; set; }

        [Name("Card ID")]
        public string cardID                 {get; set;}

        [Name("Card Value")]
        public int CardValue { get; set; }

        [Name("Card Type")]
        public int CardType                      {get; set; }

        [Name("Card Sub Type")]
        public int cardSubType               {get; set; }

        [Name("Year")]
        public int Year                      {get; set; }

        [Name("Peak")]
        public string Peak                       {get; set; }

        [Name("Team")]
        public string Team                       {get; set; }

        [Name("LastName")]
        public string LastName                       {get; set; }

        [Name("FirstName")]
        public string FirstName                      {get; set; }

        [Name("NickName")]
        public string NickName                       {get; set; }

        [Name("UniformNumber")]
        public int UniformNumber                  {get; set; }

        [Name("DayOB")]
        public int DayOB                          {get; set; }

        [Name("MonthOB")]
        public int MonthOB                        {get; set; }


        [Name("YearOB")]
        public int YearOB                         {get; set; }


        [Name("Bats")]
        public int Bats                           {get; set; }

        [Name("Throws")]
        public int Throws                         {get; set; }

        [Name("Position")]
        public int Position                       {get; set; }


        [Name("Pitcher Role")]
        public int PitcherRole                   {get; set; }

        [Name("Contact")]
        public int Contact                        {get; set; }

        [Name("Gap")]
        public int Gap                            {get; set; }

        [Name("Power")]
        public int Power                          {get; set; }

        [Name("Eye")]
        public int Eye                            {get; set; }

        [Name("Avoid Ks")]
        public int AvoidKs                       {get; set; }

        [Name("BABIP")]
        public int BABIP                          {get; set; }

        [Name("Contact vL")]
        public int ContactvL                     {get; set; }

        [Name("Gap vL")]
        public int GapvL                         {get; set; }

        [Name("Power vL")]
        public int PowervL                       {get; set; }

        [Name("Eye vL")]
        public int EyevL                         {get; set; }

        [Name("Avoid K vL")]
        public int AvoidKvL                     {get; set; }

        [Name("BABIP vL")]
        public int BABIPvL                       {get; set; }

        [Name("Contact vR")]
        public int ContactvR                     {get; set; }

        [Name("Gap vR")]
        public int GapvR                         {get; set; }

        [Name("Power vR")]
        public int PowervR                       {get; set; }

        [Name("Eye vR")]
        public int EyevR                         {get; set; }

        [Name("Avoid K vR")]
        public int AvoidKvR                     {get; set; }

        [Name("BABIP vR")]
        public int BABIPvR                       {get; set; }

        [Name("GB Hitter Type")]
        public int GBHitterType                 {get; set; }

        [Name("FB Hitter Type")]
        public int FBHitterType                 {get; set; }

        [Name("BattedBallType")]
        public int BattedBallType                 {get; set; }

        [Name("Speed")]
        public int Speed                          {get; set; }

        [Name("Steal Rate")]
        public int StealRate                     {get; set; }

        [Name("Stealing")]
        public int Stealing                       {get; set; }

        [Name("Baserunning")]
        public int Baserunning                    {get; set; }

        [Name("Sac bunt")]
        public int Sacbunt                       {get; set; }

        [Name("Bunt for hit")]
        public int Buntforhit                   {get; set; }

        [Name("Stuff")]
        public int Stuff                          {get; set; }

        [Name("Movement")]
        public int Movement                       {get; set; }

        [Name("Control")]
        public int Control                        {get; set; }

        [Name("pHR")]
        public int pHR                            {get; set; }

        [Name("pBABIP")]
        public int pBABIP                         {get; set; }

        [Name("Stuff vL")]
        public int StuffvL                       {get; set; }

        [Name("Movement vL")]
        public int MovementvL                    {get; set; }

        [Name("Control vL")]
        public int ControlvL                     {get; set; }

        [Name("pHR vL")]
        public int pHRvL                         {get; set; }

        [Name("pBABIP vL")]
        public int pBABIPvL                      {get; set; }

        [Name("Stuff vR")]
        public int StuffvR                       {get; set; }

        [Name("Movement vR")]
        public int MovementvR                    {get; set; }

        [Name("Control vR")]
        public int ControlvR                     {get; set; }

        [Name("pHR vR")]
        public int pHRvR                         {get; set; }

        [Name("pBABIP vR")]
        public int pBABIPvR                      {get; set; }

        [Name("Fastball")]
        public int Fastball                       {get; set; }

        [Name("Slider")]
        public int Slider                         {get; set; }

        [Name("Curveball")]
        public int Curveball                      {get; set; }

        [Name("Changeup")]
        public int Changeup                       {get; set; }

        [Name("Cutter")]
        public int Cutter                         {get; set; }

        [Name("Sinker")]
        public int Sinker                         {get; set; }

        [Name("Splitter")]
        public int Splitter                       {get; set; }

        [Name("Forkball")]
        public int Forkball                       {get; set; }

        [Name("Screwball")]
        public int Screwball                      {get; set; }

        [Name("Circlechange")]
        public int Circlechange                   {get; set; }

        [Name("Knucklecurve")]
        public int Knucklecurve                   {get; set; }

        [Name("Knuckleball")]
        public int Knuckleball                    {get; set; }

        [Name("Stamina")]
        public int Stamina                        {get; set; }

        [Name("Hold")]
        public int Hold                           {get; set; }

        [Name("GB")]
        public int GB                             {get; set; }

        [Name("Velocity")]
        public string Velocity                       {get; set; }

        [Name("Arm Slot")]
        public int ArmSlot                       {get; set; }

        [Name("Height")]
        public int Height                         {get; set; }

        [Name("Infield Range")]
        public int InfieldRange                  {get; set; }

        [Name("Infield Error")]
        public int InfieldError                  {get; set; }

        [Name("Infield Arm")]
        public int InfieldArm                    {get; set; }

        [Name("DP")]
        public int DP                             {get; set; }

        [Name("CatcherAbil")]
        public int CatcherAbil                    {get; set; }

        [Name("CatcherFrame")]
        public int CatcherFrame                   {get; set; }

        [Name("Catcher Arm")]
        public int CatcherArm                    {get; set; }

        [Name("OF Range")]
        public int OFRange                       {get; set; }

        [Name("OF Error")]
        public int OFError                       {get; set; }

        [Name("OF Arm")]
        public int OFArm                         {get; set; }

        [Name("Pos Rating P")]
        public int PosRatingP                   {get; set; }

        [Name("Pos Rating C")]
        public int PosRatingC                   {get; set; }

        [Name("Pos Rating 1B")]
        public int PosRating1B                  {get; set; }

        [Name("Pos Rating 2B")]
        public int PosRating2B                  {get; set; }

        [Name("Pos Rating 3B")]
        public int PosRating3B                  {get; set; }

        [Name("Pos Rating SS")]
        public int PosRatingSS                  {get; set; }

        [Name("Pos Rating LF")]
        public int PosRatingLF                  {get; set; }

        [Name("Pos Rating CF")]
        public int PosRatingCF                  {get; set; }

        [Name("Pos Rating RF")]
        public int PosRatingRF                  {get; set; }

        [Name("LearnC")]
        public int LearnC                         {get; set; }

        [Name("Learn1B")]
        public int Learn1B                        {get; set; }

        [Name("Learn2B")]
        public int Learn2B                        {get; set; }

        [Name("Learn3B")]
        public int Learn3B                        {get; set; }

        [Name("LearnSS")]
        public int LearnSS                        {get; set; }

        [Name("LearnLF")]
        public int LearnLF                        {get; set; }

        [Name("LearnCF")]
        public int LearnCF                        {get; set; }

        [Name("LearnRF")]
        public int LearnRF                        {get; set; }

        [Name("era")]
        public int era                            {get; set; }

        [Name("tier")]
        public int tier                           {get; set; }

        [Name("MissionValue")]
        public int MissionValue                   {get; set; }

        [Name("limit")]
        public int limit                          {get; set; }

        [Name("owned")]
        public int owned                          {get; set; }

        [Name("brefid")]
        public string brefid                         {get; set; }

        [Name("Buy Order High")]
        public int BuyOrderHigh                 {get; set; }

        [Name("Sell Order Low")]
        public int SellOrderLow                 {get; set; }

        [Name("Last 10 Price")]
        public int Last10Price                  {get; set;}

        [Name("Buy Order High(CC)")]
        public int BuyOrderHighCC            {get; set;}

        [Name("Sell Order Low(CC)")]
        public int SellOrderLowCC           {get; set;}

        [Name("Last 10 Price(CC)")]
        public int Last10PriceCC            {get; set;}

        [Name("date")]
        public string date       { get; set; }


        //public void Morph()
        //{

        //    if (this.Contact <= 76)
        //    {
        //        this.Contact = (399 / 75) * (this.Contact - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Contact = (150 / 114) * (this.Contact - 76) + 400;
        //    }
        //    if (this.Power <= 76)
        //    {
        //        this.Power = (399 / 75) * (this.Power - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Power = (150 / 114) * (this.Power - 76) + 400;
        //    }
        //    if (this.Eye <= 76)
        //    {
        //        this.Eye = (399 / 75) * (this.Eye - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Eye = (150 / 114) * (this.Eye - 76) + 400;
        //    }
        //    if (this.Gap <= 76)
        //    {
        //        this.Gap = (399 / 75) * (this.Gap - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Gap = (150 / 114) * (this.Gap - 76) + 400;
        //    }
        //    if (this.GapvL <= 76)
        //    {
        //        this.GapvL = (399 / 75) * (this.GapvL - 1) + 1;
        //    }
        //    else
        //    {
        //        this.GapvL = (150 / 114) * (this.GapvL - 76) + 400;
        //    }
        //    if (this.GapvR <= 76)
        //    {
        //        this.GapvR = (399 / 75) * (this.GapvR - 1) + 1;
        //    }
        //    else
        //    {
        //        this.GapvR = (150 / 114) * (this.GapvR - 76) + 400;
        //    }
        //    if (this.Stuff <= 76)
        //    {
        //        this.Stuff = (399 / 75) * (this.Stuff - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Stuff = (150 / 114) * (this.Stuff - 76) + 400;
        //    }
        //    if (this.StuffvL <= 76)
        //    {
        //        this.StuffvL = (399 / 75) * (this.StuffvL - 1) + 1;
        //    }
        //    else
        //    {
        //        this.StuffvL = (150 / 114) * (this.StuffvL - 76) + 400;
        //    }
        //    if (this.StuffvR <= 76)
        //    {
        //        this.StuffvR = (399 / 75) * (this.StuffvR - 1) + 1;
        //    }
        //    else
        //    {
        //        this.StuffvR = (150 / 114) * (this.StuffvR - 76) + 400;
        //    }
        //    if (this.Control <= 76)
        //    {
        //        this.Control = (399 / 75) * (this.Control - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Control = (150 / 114) * (this.Control - 76) + 400;
        //    }
        //    if (this.ControlvL <= 76)
        //    {
        //        this.ControlvL = (399 / 75) * (this.ControlvL - 1) + 1;
        //    }
        //    else
        //    {
        //        this.ControlvL = (150 / 114) * (this.ControlvL - 76) + 400;
        //    }
        //    if (this.ControlvR <= 76)
        //    {
        //        this.ControlvR = (399 / 75) * (this.ControlvR - 1) + 1;
        //    }
        //    else
        //    {
        //        this.ControlvR = (150 / 114) * (this.ControlvR - 76) + 400;
        //    }
        //    if (this.pHR <= 76)
        //    {
        //        this.pHR = (399 / 75) * (this.pHR - 1) + 1;
        //    }
        //    else
        //    {
        //        this.pHR = (150 / 114) * (this.pHR - 76) + 400;
        //    }
        //    if (this.pHRvL <= 76)
        //    {
        //        this.pHRvL = (399 / 75) * (this.pHRvL - 1) + 1;
        //    }
        //    else
        //    {
        //        this.pHRvL = (150 / 114) * (this.pHRvL - 76) + 400;
        //    }
        //    if (this.pHRvR <= 76)
        //    {
        //        this.pHRvR = (399 / 75) * (this.pHRvR - 1) + 1;
        //    }
        //    else
        //    {
        //        this.pHRvR = (150 / 114) * (this.pHRvR - 76) + 400;
        //    }

        //    if (this.Speed <= 76)
        //    {
        //        this.Speed = (399 / 75) * (this.Speed - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Speed = (150 / 114) * (this.Speed - 76) + 400;
        //    }
        //    if (this.StealRate <= 76)
        //    {
        //        this.StealRate = (399 / 75) * (this.StealRate - 1) + 1;
        //    }
        //    else
        //    {
        //        this.StealRate = (150 / 114) * (this.StealRate - 76) + 400;
        //    }
        //    if (this.Stealing <= 76)
        //    {
        //        this.Stealing = (399 / 75) * (this.Stealing - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Stealing = (150 / 114) * (this.Stealing - 76) + 400;
        //    }
        //    if (this.Baserunning <= 76)
        //    {
        //        this.Baserunning = (399 / 75) * (this.Baserunning - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Baserunning = (150 / 114) * (this.Baserunning - 76) + 400;
        //    }
        //    if (this.Baserunning <= 76)
        //    {
        //        this.Baserunning = (399 / 75) * (this.Baserunning - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Baserunning = (150 / 114) * (this.Baserunning - 76) + 400;
        //    }
        //    if (this.Baserunning <= 76)
        //    {
        //        this.Baserunning = (399 / 75) * (this.Baserunning - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Baserunning = (150 / 114) * (this.Baserunning - 76) + 400;
        //    }
        //    if (this.Hold <= 76)
        //    {
        //        this.Hold = (399 / 75) * (this.Hold - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Hold = (150 / 114) * (this.Hold - 76) + 400;
        //    }                                 

        //    if (this.Sinker <= 76)
        //    {
        //        this.Sinker = (399 / 75) * (this.Sinker - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Sinker = (150 / 114) * (this.Sinker - 76) + 400;
        //    }
        //    if (this.Splitter <= 76)
        //    {
        //        this.Splitter = (399 / 75) * (this.Splitter - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Splitter = (150 / 114) * (this.Splitter - 76) + 400;
        //    }
        //    if (this.Forkball <= 76)
        //    {
        //        this.Forkball = (399 / 75) * (this.Forkball - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Forkball = (150 / 114) * (this.Forkball - 76) + 400;
        //    }
        //    if (this.Screwball <= 76)
        //    {
        //        this.Screwball = (399 / 75) * (this.Screwball - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Screwball = (150 / 114) * (this.Screwball - 76) + 400;
        //    }
        //    if (this.Circlechange <= 76)
        //    {
        //        this.Circlechange = (399 / 75) * (this.Circlechange - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Circlechange = (150 / 114) * (this.Circlechange - 76) + 400;
        //    }
        //    if (this.Knucklecurve <= 76)
        //    {
        //        this.Knucklecurve = (399 / 75) * (this.Knucklecurve - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Knucklecurve = (150 / 114) * (this.Knucklecurve - 76) + 400;
        //    }
        //    if (this.Knuckleball <= 76)
        //    {
        //        this.Knuckleball = (399 / 75) * (this.Knuckleball - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Knuckleball = (150 / 114) * (this.Knuckleball - 76) + 400;
        //    }
        //    if (this.Stamina <= 76)
        //    {
        //        this.Stamina = (399 / 75) * (this.Stamina - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Stamina = (150 / 114) * (this.Stamina - 76) + 400;
        //    }
        //    if (this.Curveball <= 76)
        //    {
        //        this.Curveball = (399 / 75) * (this.Curveball - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Curveball = (150 / 114) * (this.Curveball - 76) + 400;
        //    }
        //    if (this.Slider <= 76)
        //    {
        //        this.Slider = (399 / 75) * (this.Slider - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Slider = (150 / 114) * (this.Slider - 76) + 400;
        //    }
        //    if (this.Fastball <= 76)
        //    {
        //        this.Fastball = (399 / 75) * (this.Fastball - 1) + 1;
        //    }
        //    else
        //    {
        //        this.Fastball = (150 / 114) * (this.Fastball - 76) + 400;
        //    }




            

        }





    }





