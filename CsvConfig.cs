using CsvHelper.Configuration;

namespace Card_Morpher
{
    internal class CsvConfig : ClassMap<Card>
    {

        public CsvConfig() 
        {
            Map(c => c.ArmSlot).Index(77).Name("Arm Slot");
            Map(c => c.AvoidKs).Index(23).Name("Avoid Ks");
            Map(c => c.AvoidKvL).Index(29).Name("Avoid K vL");
            Map(c => c.AvoidKvR).Index(35).Name("Avoid K vR");
            Map(c => c.BABIP).Index(24).Name("BABIP");
            Map(c => c.BABIPvL).Index(30).Name("BABIP vL");
            Map(c => c.BABIPvR).Index(36).Name("BABIP vR");
            Map(c => c.Baserunning).Index(43).Name("Baserunning");
            Map(c => c.Bats).Index(15).Name("Bats");
            Map(c => c.BattedBallType).Index(39).Name("BattedBallType");
            Map(c => c.brefid).Index(111).Name("brefid");
            Map(c => c.Buntforhit).Index(45).Name("Bunt for hit");
            Map(c => c.BuyOrderHigh).Index(112).Name("Buy Order High");
            Map(c => c.BuyOrderHighCC).Index(115).Name("Buy Order High(CC)");
            Map(c => c.cardID).Index(1).Name("Card ID");
            Map(c => c.cardSubType).Index(4).Name("Card Sub Type");
            Map(c => c.CardTitle).Index(0).Name("Card Title");
            Map(c => c.CatcherAbil).Index(83).Name("CatcherAbil");
            Map(c => c.CatcherArm).Index(85).Name("Catcher Arm");
            Map(c => c.CatcherFrame).Index(84).Name("CatcherFrame");
            Map(c => c.Changeup).Index(64).Name("Changeup");
            Map(c => c.Circlechange).Index(70).Name("Circlechange");
            Map(c => c.Contact).Index(19).Name("Contact");
            Map(c => c.ContactvL).Index(25).Name("Contact vL");
            Map(c => c.ContactvR).Index(31).Name("Contact vR");
            Map(c => c.Control).Index(48).Name("Control");
            Map(c => c.ControlvL).Index(53).Name("Control vL");
            Map(c => c.ControlvR).Index(58).Name("Control vR");
            Map(c => c.Curveball).Index(63).Name("Curveball");
            Map(c => c.Cutter).Index(65).Name("Cutter");
            Map(c => c.date).Index(118).Name("date");
            Map(c => c.DayOB).Index(12).Name("DayOB");
            Map(c => c.DP).Index(82).Name("DP");
            Map(c => c.era).Index(106).Name("era");
            Map(c => c.Eye).Index(22).Name("Eye");
            Map(c => c.EyevL).Index(28).Name("Eye vL");
            Map(c => c.EyevR).Index(34).Name("Eye vR");
            Map(c => c.Fastball).Index(61).Name("Fastball");
            Map(c => c.FBHitterType).Index(38).Name("FB Hitter Type");
            Map(c => c.FirstName).Index(9).Name("FirstName");
            Map(c => c.Forkball).Index(68).Name("Forkball");
            Map(c => c.Gap).Index(20).Name("Gap");
            Map(c => c.GapvL).Index(26).Name("Gap vL");
            Map(c => c.GapvR).Index(32).Name("Gap vR");
            Map(c => c.GB).Index(75).Name("GB");
            Map(c => c.GBHitterType).Index(37).Name("GB Hitter Type");
            Map(c => c.Height).Index(78).Name("Height");
            Map(c => c.Hold).Index(74).Name("Hold");
            Map(c => c.InfieldArm).Index(81).Name("Infield Arm");
            Map(c => c.InfieldError).Index(80).Name("Infield Error");
            Map(c => c.InfieldRange).Index(79).Name("Infield Range");
            Map(c => c.Knuckleball).Index(72).Name("Knuckleball");
            Map(c => c.Knucklecurve).Index(71).Name("Knucklecurve");
            Map(c => c.Last10Price).Index(114).Name("Last 10 Price");
            Map(c => c.Last10PriceCC).Index(117).Name("Last 10 Price(CC)");
            Map(c => c.LastName).Index(8).Name("LastName");
            Map(c => c.Learn1B).Index(99).Name("Learn1B");
            Map(c => c.Learn2B).Index(100).Name("Learn2B");
            Map(c => c.Learn3B).Index(101).Name("Learn3B");
            Map(c => c.LearnC).Index(98).Name("LearnC");
            Map(c => c.LearnCF).Index(104).Name("LearnCF");
            Map(c => c.LearnLF).Index(103).Name("LearnLF");
            Map(c => c.LearnRF).Index(105).Name("LearnRF");
            Map(c => c.LearnSS).Index(102).Name("LearnSS");
            Map(c => c.limit).Index(109).Name("limit");
            Map(c => c.MissionValue).Index(108).Name("MissionValue");
            Map(c => c.MonthOB).Index(13).Name("MonthOB");
            Map(c => c.Movement).Index(47).Name("Movement");
            Map(c => c.MovementvL).Index(52).Name("Movement vL");
            Map(c => c.MovementvR).Index(57).Name("Movement vR");
            Map(c => c.NickName).Index(10).Name("NickName");
            Map(c => c.OFArm).Index(88).Name("OF Arm");
            Map(c => c.OFError).Index(87).Name("OF Error");
            Map(c => c.OFRange).Index(86).Name("OF Range");
            Map(c => c.owned).Index(110).Name("owned");
            Map(c => c.pBABIP).Index(50).Name("pBABIP");
            Map(c => c.pBABIPvL).Index(55).Name("pBABIP vL");
            Map(c => c.pBABIPvR).Index(60).Name("pBABIP vR");
            Map(c => c.Peak).Index(6).Name("Peak");
            Map(c => c.pHR).Index(49).Name("pHR");
            Map(c => c.pHRvL).Index(54).Name("pHR vL");
            Map(c => c.pHRvR).Index(59).Name("pHR vR");
            Map(c => c.PitcherRole).Index(18).Name("Pitcher Role");
            Map(c => c.Position).Index(17).Name("Position");
            Map(c => c.PosRating1B).Index(91).Name("Pos Rating 1B");
            Map(c => c.PosRating2B).Index(92).Name("Pos Rating 2B");
            Map(c => c.PosRating3B).Index(93).Name("Pos Rating 3B");
            Map(c => c.PosRatingC).Index(90).Name("Pos Rating C");
            Map(c => c.PosRatingCF).Index(96).Name("Pos Rating CF");
            Map(c => c.PosRatingLF).Index(95).Name("Pos Rating LF");
            Map(c => c.PosRatingP).Index(89).Name("Pos Rating P");
            Map(c => c.PosRatingRF).Index(97).Name("Pos Rating RF");
            Map(c => c.PosRatingSS).Index(94).Name("Pos Rating SS");
            Map(c => c.Power).Index(21).Name("Power");
            Map(c => c.PowervL).Index(27).Name("Power vL");
            Map(c => c.PowervR).Index(33).Name("Power vR");
            Map(c => c.Sacbunt).Index(44).Name("Sac bunt");
            Map(c => c.Screwball).Index(69).Name("Screwball");
            Map(c => c.SellOrderLow).Index(113).Name("Sell Order Low");
            Map(c => c.SellOrderLowCC).Index(116).Name("Sell Order Low(CC)");
            Map(c => c.Sinker).Index(66).Name("Sinker");
            Map(c => c.Slider).Index(62).Name("Slider");
            Map(c => c.Speed).Index(40).Name("Speed");
            Map(c => c.Splitter).Index(67).Name("Splitter");
            Map(c => c.Stamina).Index(73).Name("Stamina");
            Map(c => c.Stealing).Index(42).Name("Stealing");
            Map(c => c.StealRate).Index(41).Name("Steal Rate");
            Map(c => c.Stuff).Index(46).Name("Stuff");
            Map(c => c.StuffvL).Index(51).Name("Stuff vL");
            Map(c => c.StuffvR).Index(56).Name("Stuff vR");
            Map(c => c.Team).Index(7).Name("Team");
            Map(c => c.Throws).Index(16).Name("Throws");
            Map(c => c.tier).Index(107).Name("tier");
            Map(c => c.CardType).Index(3).Name("Card Type");
            Map(c => c.UniformNumber).Index(11).Name("UniformNumber");
            Map(c => c.CardValue).Index(2).Name("Card Value");
            Map(c => c.Velocity).Index(76).Name("Velocity");
            Map(c => c.Year).Index(5).Name("Year");
            Map(c => c.YearOB).Index(14).Name("YearOB");


        }

    }
}
