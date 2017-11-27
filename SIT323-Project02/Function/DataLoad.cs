using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace SIT323_Project02
{
    class DataLoad
    {

        #region Define Static public

        static public TestCrozzleFirstLine TCFL;
        static public List<TestCrozzleSecondLine> TCSL;
        static public List<TestCrozzleSecondLineNoRepeat> TCSLNR;
        static public List<TestCrozzleSecondLineNoRepeatSortedByWordLength> TCSLNRSBWL;
        static public List<TestCrozzleSecondLineNoRepeatSortedByMaxPoint> TCSLNRSBMP;

        static public TestConfigurationFirstLine ConfigurationFirstLine;
        static public TestConfigurationSecondLine ConfigurationSecordLine;
        static public List<TestConfigurationOther> testConfigurationOther;

        static public List<TestCrozzleSecondLineWithMaxPoint> MAXPoint;



        #endregion

        public static void crozzleDataLoad(string filepath, int v)
        {

            #region read test crozzle

            // read data and clean old error list

            LogFile.WriteLogFile("Start read crozzle.txt");
            string[] strLine = File.ReadAllLines(filepath);

            // FirstLine
            LogFile.WriteLogFile("Input First Line of crozzle.txt");
            string[] str = strLine[0].Split(',');
            foreach (string s in str)
            { if (string.IsNullOrEmpty(s)) { LogFile.WriteLogFile("TEST Crozzle First Line Input Check!!!---ERROR---" + " : Invalid!!! Nothing input, Its null or empty."); LogFile.WriteErrorFile("TEST Crozzle First Line Input Check!!!---ERROR---" + " : Invalid!!! Nothing input, Its null or empty."); } }

            str = str.Where(s => !string.IsNullOrEmpty(s)).ToArray();

            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    // violations detected and logged--------Regular expressions
                    #region LOG AND ERROR
                    switch (i)
                    {
                        case 0:
                            if (!RegexDetail.checkalphabetLevel.IsMatch(str[0]))
                            { LogFile.WriteLogFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[0].ToString() + " : Invalid!!! Level Word input not alphabet or Not correct Word"); LogFile.WriteErrorFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[0].ToString() + " : Invalid!!! Level Word input not alphabet or Not correct Word"); }
                            break;
                        case 1:
                            if (!RegexDetail.checkdigitalAmount.IsMatch(Convert.ToString(str[1])))
                            { LogFile.WriteLogFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[1].ToString() + " : Invalid!!! Word List Total Number input not digital or not 10 to 1000"); LogFile.WriteErrorFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[1].ToString() + " : Invalid!!! Word List Total Number input not digital or not 10 to 1000"); }
                            if (!RegexDetail.checkdigital.IsMatch(Convert.ToString(str[1])))
                            { str[1] = "0"; }
                            break;
                        case 2:
                            if (!RegexDetail.checkdigitalRow.IsMatch(Convert.ToString(str[2])))
                            { LogFile.WriteLogFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[2].ToString() + " : Invalid!!! Row input not digital or not 4 to 400"); LogFile.WriteErrorFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[2].ToString() + " : Invalid!!! Row input not digital or not 4 to 400"); }
                            if (!RegexDetail.checkdigital.IsMatch(Convert.ToString(str[2])))
                            { str[2] = "0"; }
                            break;
                        case 3:
                            if (!RegexDetail.checkdigitalColumn.IsMatch(Convert.ToString(str[3])))
                            { LogFile.WriteLogFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[3].ToString() + " : Invalid!!! Column input not digital or not 8 to 800"); LogFile.WriteErrorFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[3].ToString() + " : Invalid!!! Column input not digital or not 8 to 800"); }
                            if (!RegexDetail.checkdigital.IsMatch(Convert.ToString(str[3])))
                            { str[3] = "0"; }
                            break;
                        case 4:
                            if (!RegexDetail.checkdigitalNonnegative.IsMatch(Convert.ToString(str[4])))
                            { LogFile.WriteLogFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[4].ToString() + " : Invalid!!! Horizontally Oriented Word input not digital or not Non-Negative"); LogFile.WriteErrorFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[4].ToString() + " : Invalid!!! Horizontally Oriented Word input not digital or not Non-Negative"); }
                            if (!RegexDetail.checkdigital.IsMatch(Convert.ToString(str[4])))
                            { str[4] = "0"; }
                            break;
                        case 5:
                            if (!RegexDetail.checkdigitalNonnegative.IsMatch(Convert.ToString(str[5])))
                            { LogFile.WriteLogFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[5].ToString() + " : Invalid!!! Vertically Oriented Word input not digital or not Non-Negative"); LogFile.WriteErrorFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[5].ToString() + " : Invalid!!! Vertically Oriented Word input not digital or not Non-Negative"); }
                            if (!RegexDetail.checkdigital.IsMatch(Convert.ToString(str[5])))
                            { str[5] = "0"; }
                            break;
                        default:
                            { LogFile.WriteLogFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[i].ToString() + " : Invalid!!! Extra DATA"); LogFile.WriteErrorFile("TEST Crozzle First Line Input Check!!!---ERROR---" + str[6].ToString() + " : Invalid!!! Extra DATA"); }
                            break;
                    }
                    #endregion
                }
                // add in TestCrozzleFirstLine list
                TCFL = new TestCrozzleFirstLine(str[0], Int32.Parse(str[1]), Int32.Parse(str[2]), Int32.Parse(str[3]), Int32.Parse(str[4]), Int32.Parse(str[5]));
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

            //Console.WriteLine(TCFL.ToString());

            // SecondLine
            LogFile.WriteLogFile("Input Second Line of crozzle.txt");
            TCSL = new List<TestCrozzleSecondLine>();
            str = strLine[1].Split(',');

            foreach (string s in str)
            { if (string.IsNullOrEmpty(s)) { LogFile.WriteLogFile("TEST Crozzle First Line Input Check!!!---ERROR---" + " : Invalid!!! Nothing input, Its null or empty."); LogFile.WriteErrorFile("TEST Crozzle First Line Input Check!!!---ERROR---" + " : Invalid!!! Nothing input, Its null or empty."); } }

            str = str.Where(s => !string.IsNullOrEmpty(s)).ToArray();

            try
            {
                foreach (string s in str)
                {
                    // violations detected and logged--------Regular expressions
                    #region LOG AND ERROR
                    if (!RegexDetail.checkalphabet.IsMatch(s))
                    { LogFile.WriteLogFile("TEST Crozzle Second Line Input Check!!!---ERROR---" + s.ToString() + " : Invalid!!! input not alphabet"); LogFile.WriteErrorFile("TEST Crozzle Second Line Input Check!!!--------ERROR-----" + s.ToString() + " : Invalid!!! input not alphabet"); }
                    #endregion
                    // add in TestCrozzleSecondLine list
                    TCSL.Add(new TestCrozzleSecondLine(s));
                }
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

            //Console.WriteLine(TCSL.ToString());

            //check SecondLine duplicate!
            LogFile.WriteLogFile("Check Second Line duplicate!");
            TCSLNR = new List<TestCrozzleSecondLineNoRepeat>();
            try
            {
                foreach (TestCrozzleSecondLine tcsl in TCSL)
                {

                    if (TCSLNR.GroupBy(x => x.wordlist == tcsl.wordlist).Count() > 1)
                    {
                        LogFile.WriteLogFile("TEST Crozzle Second Line duplicate! Input Check!!!---ERROR---" + "duplicat word : " + tcsl.wordlist.ToString());
                        LogFile.WriteErrorFile("TEST Crozzle Second Line duplicate! Input Check!!!---ERROR---" + "duplicat word : " + tcsl.wordlist.ToString());
                    }
                    else
                    {
                        TCSLNR.Add(new TestCrozzleSecondLineNoRepeat(tcsl.wordlist, tcsl.wordlist));
                    }

                }
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

            #endregion

            #region sorted TCSLNR
            try
            {
                TCSLNRSBWL = new List<TestCrozzleSecondLineNoRepeatSortedByWordLength>();
                IEnumerable<TestCrozzleSecondLineNoRepeat> TCSLNRSorted = DataLoad.TCSLNR.OrderBy(a => a.wordlist.LongCount()).ToList();
                foreach (TestCrozzleSecondLineNoRepeat tcslnr in TCSLNRSorted)
                {
                    TCSLNRSBWL.Add(new TestCrozzleSecondLineNoRepeatSortedByWordLength(tcslnr.wordlist, tcslnr.wordlist));
                }
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }
            //Console.WriteLine();
            #endregion

        }

        public static void configurationDataLoad(string filepath, int v)
        {

            #region read test configuration

            // read data
            LogFile.WriteLogFile("Start read configuration.txt");
            string[] strLine = File.ReadAllLines(filepath);

            // FirstLine
            LogFile.WriteLogFile("Input First Line of configuration.txt");
            string[] str1 = strLine[0].Split('=');

            foreach (string s in str1)
            { if (string.IsNullOrEmpty(s)) { LogFile.WriteLogFile("TEST Configuration First Line Input Check!!!---ERROR---" + " : Invalid!!! Nothing input, Its null or empty."); LogFile.WriteErrorFile("TEST Configuration First Line Input Check!!!---ERROR---" + " : Invalid!!! Nothing input, Its null or empty."); } }

            str1 = str1.Where(s => !string.IsNullOrEmpty(s)).ToArray();

            try
            {
                // violations detected and logged--------Regular expressions
                #region LOG AND ERROR
                if (!RegexDetail.checkalphabetGROUPSPERCROZZLELIMIT.IsMatch(str1[0]))
                { LogFile.WriteLogFile("TEST Configuration First Line Input Check!!!---ERROR---" + str1[0].ToString() + " : Invalid!!! This word must GROUPSPERCROZZLELIMIT"); LogFile.WriteErrorFile("TEST Configuration First Line Input Check!!!---ERROR---" + str1[0].ToString() + " : Invalid!!! This word must GROUPSPERCROZZLELIMIT"); }

                if (!RegexDetail.checkdigital.IsMatch(str1[1]))
                { LogFile.WriteLogFile("TEST Configuration First Line Input Check!!!---ERROR---" + str1[1].ToString() + " : Invalid!!! Its must be a positive digital"); LogFile.WriteErrorFile("TEST Configuration First Line Input Check!!!---ERROR---" + str1[1].ToString() + " : Invalid!!! Its must be a positive digital"); }
                #endregion
                //add data in TestConfigurationFirstLine list
                ConfigurationFirstLine = new TestConfigurationFirstLine(str1[1]);
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

            // SecordLine
            LogFile.WriteLogFile("Input Second Line of configuration.txt");
            string[] str2 = strLine[1].Split('=');
            foreach (string s in str2)
            { if (string.IsNullOrEmpty(s)) { LogFile.WriteLogFile("TEST Configuration First Line Input Check!!!---ERROR---" + " : Invalid!!! Nothing input, Its null or empty."); LogFile.WriteErrorFile("TEST Configuration First Line Input Check!!!---ERROR---" + " : Invalid!!! Nothing input, Its null or empty."); } }

            str2 = str2.Where(s => !string.IsNullOrEmpty(s)).ToArray();

            try
            {
                // violations detected and logged--------Regular expressions
                #region LOG AND ERROR
                if (!RegexDetail.checkalphabetPOINTSPERWORD.IsMatch(str2[0]))
                { LogFile.WriteLogFile("TEST Configuration Second Line Input Check!!!---ERROR---" + str2[0].ToString() + " : Invalid!!! This word must POINTSPERWORD"); LogFile.WriteErrorFile("TEST Configuration Second Line Input Check!!!---ERROR---" + str2[0].ToString() + " : Invalid!!! This word must POINTSPERWORD"); }

                if (!RegexDetail.checkdigital.IsMatch(str2[1]))
                { LogFile.WriteLogFile("TEST Configuration Second Line Input Check!!!---ERROR---" + str2[1].ToString() + " : Invalid!!! input not digital"); LogFile.WriteErrorFile("TEST Configuration Second Line Input Check!!!---ERROR---" + str2[1].ToString() + " : Invalid!!! input not digital"); }
                #endregion
                //add data in TestConfigurationSecondLine list
                ConfigurationSecordLine = new TestConfigurationSecondLine(str2[1]);
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

            // OtherLine
            LogFile.WriteLogFile("Input Other Line of configuration.txt");
            testConfigurationOther = new List<TestConfigurationOther>();
            for (int i = 2; i < strLine.Count(); i++)
            {
                string[] str3 = strLine[i].Split(new char[2] { ':', '=' });
                try
                {
                    // violations detected and logged--------Regular expressions
                    #region LOG AND ERROR
                    if (!RegexDetail.checkalphabetStatus.IsMatch(str3[0]))
                    { LogFile.WriteLogFile("TEST Configuration Other Line Input Check!!!---ERROR---" + str3[0].ToString() + " : Invalid!!! This word must INTERSECTING or NONINTERSECTING"); LogFile.WriteErrorFile("TEST Configuration Other Line Input Check!!!---ERROR---" + str3[0].ToString() + " : Invalid!!! This word must INTERSECTING or NONINTERSECTING"); }

                    if (!RegexDetail.checkalphabet.IsMatch(str3[1]))
                    { LogFile.WriteLogFile("TEST Configuration Other Line Input Check!!!---ERROR---" + str3[1].ToString() + " : Invalid!!! input not alphabet, not A-Z letter, or Null"); LogFile.WriteErrorFile("TEST Configuration Other Line Input Check!!!---ERROR---" + str3[1].ToString() + " : Invalid!!! input not alphabet, not A-Z letter, or Null"); }

                    if (!RegexDetail.checkdigital.IsMatch(Convert.ToString(str3[2])))
                    { LogFile.WriteLogFile("TEST Configuration Other Line Input Check!!!---ERROR---" + str3[2].ToString() + " : Invalid!!! input not digital, or Null"); LogFile.WriteErrorFile("TEST Configuration Other Line Input Check!!!---ERROR---" + str3[2].ToString() + " : Invalid!!! input not digital , or Null"); }
                    #endregion
                    //add data in TestConfigurationOther list
                    testConfigurationOther.Add(new TestConfigurationOther(str3[0], str3[1], Int32.Parse(str3[2])));
                }
                catch (Exception e)
                {
                    LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                    //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
                }
            }



            #endregion

            #region Check value of 26 letter in the list

            try
            {
                LogFile.WriteLogFile("Check value of 26 letter in the list");

                string[] Al = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                List<string> ALI = new List<string>();
                List<string> ALNI = new List<string>();
                List<string> expectedList1 = new List<string>();
                List<string> expectedList2 = new List<string>();

                foreach (TestConfigurationOther tco in testConfigurationOther)
                {
                    if (tco.Status == "INTERSECTING")
                        ALI.Add(tco.Letter);
                    else if (tco.Status == "NONINTERSECTING")
                        ALNI.Add(tco.Letter);
                }

                expectedList1 = Al.Except(ALI).ToList();
                expectedList2 = Al.Except(ALNI).ToList();

                foreach (string a in expectedList1)
                { LogFile.WriteLogFile("TEST Configuration Other Line Input Check!!!---ERROR---" + a.ToString() + " not contains in INTERSECTING parts"); LogFile.WriteErrorFile("TEST Configuration Other Line Input Check!!!---ERROR---" + a.ToString() + " not contains in INTERSECTING parts"); }
                foreach (string a in expectedList2)
                { LogFile.WriteLogFile("TEST Configuration Other Line Input Check!!!---ERROR---" + a.ToString() + " not contains in NONINTERSECTING parts"); LogFile.WriteErrorFile("TEST Configuration Other Line Input Check!!!---ERROR---" + a.ToString() + " not contains in NONINTERSECTING parts"); }

            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }
            //Console.WriteLine();

            #endregion

            #region match value for Max point for each word

            try
            {
                LogFile.WriteLogFile("Match value and word putin Point");

                MAXPoint = new List<TestCrozzleSecondLineWithMaxPoint>();

                foreach (TestCrozzleSecondLineNoRepeat tcslnr in TCSLNR)
                {
                    int letterValue = 0;
                    int wordValue = 0;
                    for (int i = 0; i < tcslnr.letter.Count(); i++)
                    {
                        foreach (TestConfigurationOther tco in testConfigurationOther)
                        {
                            if (tco.Status == "INTERSECTING" && tcslnr.letter[i] == Convert.ToChar(tco.Letter))
                            {
                                letterValue = tco.EachPoint;
                            }

                        }
                        wordValue = wordValue + letterValue;
                    }
                    MAXPoint.Add(new TestCrozzleSecondLineWithMaxPoint(tcslnr.wordlist, tcslnr.wordlist, wordValue));
                }

                TCSLNRSBMP = new List<TestCrozzleSecondLineNoRepeatSortedByMaxPoint>();
                IEnumerable<TestCrozzleSecondLineWithMaxPoint> MAXPointSorted = DataLoad.MAXPoint.OrderBy(a => a.maxvalue).ToList();
                foreach (TestCrozzleSecondLineWithMaxPoint tcslwmp in MAXPointSorted)
                {
                    TCSLNRSBMP.Add(new TestCrozzleSecondLineNoRepeatSortedByMaxPoint(tcslwmp.wordlist, tcslwmp.wordlist));
                }
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

            //Console.WriteLine();


            #endregion


        }
    }
}
