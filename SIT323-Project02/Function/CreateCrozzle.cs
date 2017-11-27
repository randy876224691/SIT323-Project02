using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT323_Project02
{
    class CreateCrozzle
    {
        static public List<Position> position;
        static public List<HorizontalWordPosition> HWP;
        static public List<VerticalWordPosition> VWP;
        static public DataTable dt;
        static public char[,] crozzleTable;
        static public List<PositionIntersect> positionIntersect;
        static public List<PositionNoIntersect> positionNoInresect;
        static public List<PositionNoRepeat> positionNoRepeat;
        static public List<Point> point;
        static public List<PositionStillCanBePlace> positionStillCanBePlace;
        static public List<PositionCanNotBePlace> positionCanNotBePlace;
        static public List<PositionSecondCanBePlace> positionSecondCanBePlace;
        static public List<TestCrozzleSecondLineNoRepeatSortedByWordLength> TCSLNRSBWLforloop;
        //static public List<TestCrozzleSecondLineNoRepeatSortedByMaxPoint> TCSLNRSBMPforloop;
        static public List<HorizontalWordForExport> HWFE;
        static public List<VerticalWordForExport> VWFE;
        //static public List<WordIntersectedTimes> wordIntersectedTimes;
        static public List<string> WIT;
        public static int totalValue = 0;

        public static void createCrozzle()
        {
            try
            {
                if (DataLoad.TCFL.Level == "EASY")
                {
                    #region for easy
                    LogFile.WriteLogFile("Start Create Crozzle for easy level");
                    do
                    {
                        TCSLNRSBWLforloop = new List<TestCrozzleSecondLineNoRepeatSortedByWordLength>();
                        foreach (TestCrozzleSecondLineNoRepeatSortedByWordLength t in DataLoad.TCSLNRSBWL)
                        {
                            TCSLNRSBWLforloop.Add(new TestCrozzleSecondLineNoRepeatSortedByWordLength(t.wordlist, t.wordlist));
                        }

                        dt = new DataTable();
                        crozzleTable = new char[DataLoad.TCFL.Row, DataLoad.TCFL.Column];

                        position = new List<Position>();
                        positionIntersect = new List<PositionIntersect>();
                        positionNoRepeat = new List<PositionNoRepeat>();
                        positionNoInresect = new List<PositionNoIntersect>();
                        positionStillCanBePlace = new List<PositionStillCanBePlace>();
                        positionCanNotBePlace = new List<PositionCanNotBePlace>();
                        positionSecondCanBePlace = new List<PositionSecondCanBePlace>();
                        //wordIntersectedTimes = new List<WordIntersectedTimes>();
                        HWP = new List<HorizontalWordPosition>();
                        VWP = new List<VerticalWordPosition>();
                        WIT = new List<string>();
                        HWFE = new List<HorizontalWordForExport>();
                        VWFE = new List<VerticalWordForExport>();

                        for (int i = 0; i < DataLoad.TCFL.Row; i++)
                        {
                            for (int j = 0; j < DataLoad.TCFL.Column; j++)
                            {
                                positionStillCanBePlace.Add(new PositionStillCanBePlace(i + 1, j + 1));
                            }
                        }

                        writeDataTable(1);


                        //first
                        createCrozzleInitPosition();

                        for (int i = CreateCrozzle.TCSLNRSBWLforloop.Count() - 1; i >= 0; i--)
                        {
                            otherCrozzlePosition(i);
                        }
                        positionPlace();

                        writeDataTable(2);
                        secondTimesCanBePlace();

                        foreach (string p in WIT)
                        {
                            Console.WriteLine(p);
                        }

                        Console.WriteLine();

                        int a = -2;
                        int times = 0;
                        do
                        {
                            Random rnw = new Random();
                            int aaa = rnw.Next(0, CreateCrozzle.TCSLNRSBWLforloop.Count() - 1);
                            Console.WriteLine(aaa);
                            a = otherCrozzlePositionSecondInitPosition(aaa);
                            times++;
                        } while (a != -1 && times < 300);


                        positionPlace();

                        writeDataTable(2);

                        foreach (string p in WIT)
                        {
                            Console.WriteLine(p);
                        }

                        Console.WriteLine();

                        for (int i = CreateCrozzle.TCSLNRSBWLforloop.Count() - 1; i >= 0; i--)
                        {
                            otherCrozzlePosition(i);
                        }

                        positionPlace();
                        secondTimesCanBePlace();

                        writeDataTable(2);

                        foreach (string p in WIT)
                        {
                            Console.WriteLine(p);
                        }

                        Console.WriteLine();

                        insertNoIntersect();
                        calculatePoint();

                        Console.WriteLine(totalValue);

                    }
                    while (totalValue < 50);

                    #endregion
                }
                if (DataLoad.TCFL.Level == "MEDIUM")
                {
                    #region for medium
                    LogFile.WriteLogFile("Start Create Crozzle for medium level");
                    do
                    {
                        TCSLNRSBWLforloop = new List<TestCrozzleSecondLineNoRepeatSortedByWordLength>();
                        foreach (TestCrozzleSecondLineNoRepeatSortedByWordLength t in DataLoad.TCSLNRSBWL)
                        {
                            TCSLNRSBWLforloop.Add(new TestCrozzleSecondLineNoRepeatSortedByWordLength(t.wordlist, t.wordlist));
                        }

                        dt = new DataTable();
                        crozzleTable = new char[DataLoad.TCFL.Row, DataLoad.TCFL.Column];

                        position = new List<Position>();
                        positionIntersect = new List<PositionIntersect>();
                        positionNoRepeat = new List<PositionNoRepeat>();
                        positionNoInresect = new List<PositionNoIntersect>();
                        positionStillCanBePlace = new List<PositionStillCanBePlace>();
                        positionCanNotBePlace = new List<PositionCanNotBePlace>();
                        positionSecondCanBePlace = new List<PositionSecondCanBePlace>();
                        //wordIntersectedTimes = new List<WordIntersectedTimes>();
                        HWP = new List<HorizontalWordPosition>();
                        VWP = new List<VerticalWordPosition>();
                        WIT = new List<string>();
                        HWFE = new List<HorizontalWordForExport>();
                        VWFE = new List<VerticalWordForExport>();

                        for (int i = 0; i < DataLoad.TCFL.Row; i++)
                        {
                            for (int j = 0; j < DataLoad.TCFL.Column; j++)
                            {
                                positionStillCanBePlace.Add(new PositionStillCanBePlace(i + 1, j + 1));
                            }
                        }

                        writeDataTable(1);


                        //first
                        createCrozzleInitPosition();

                        for (int i = CreateCrozzle.TCSLNRSBWLforloop.Count() - 1; i >= 0; i--)
                        {
                            otherCrozzlePosition(i);
                        }
                        positionPlace();

                        writeDataTable(2);
                        secondTimesCanBePlace();

                        foreach (string p in WIT)
                        {
                            Console.WriteLine(p);
                        }

                        Console.WriteLine();



                        //second
                        int a = -2;
                        int times = 0;
                        do
                        {
                            Random rnw = new Random();
                            int aaa = rnw.Next(0, CreateCrozzle.TCSLNRSBWLforloop.Count() - 1);
                            Console.WriteLine(aaa);
                            a = otherCrozzlePositionSecondInitPosition(aaa);
                            times++;
                        } while (a != -1 && times < 300);


                        positionPlace();

                        writeDataTable(2);

                        foreach (string p in WIT)
                        {
                            Console.WriteLine(p);
                        }

                        Console.WriteLine();

                        for (int i = CreateCrozzle.TCSLNRSBWLforloop.Count() - 1; i >= 0; i--)
                        {
                            otherCrozzlePosition(i);
                        }

                        positionPlace();
                        secondTimesCanBePlace();

                        writeDataTable(2);

                        foreach (string p in WIT)
                        {
                            Console.WriteLine(p);
                        }

                        Console.WriteLine();

                        insertNoIntersect();
                        calculatePoint();

                        Console.WriteLine(totalValue);

                    }
                    while (totalValue < 600);
                    #endregion
                }
                if (DataLoad.TCFL.Level == "HARD")
                {
                    #region for hard
                    LogFile.WriteLogFile("Start Create Crozzle for hard level");
                    do
                    {
                        TCSLNRSBWLforloop = new List<TestCrozzleSecondLineNoRepeatSortedByWordLength>();
                        foreach (TestCrozzleSecondLineNoRepeatSortedByMaxPoint t in DataLoad.TCSLNRSBMP)
                        {
                            TCSLNRSBWLforloop.Add(new TestCrozzleSecondLineNoRepeatSortedByWordLength(t.wordlist, t.wordlist));
                        }

                        dt = new DataTable();
                        crozzleTable = new char[DataLoad.TCFL.Row, DataLoad.TCFL.Column];

                        position = new List<Position>();
                        positionIntersect = new List<PositionIntersect>();
                        positionNoRepeat = new List<PositionNoRepeat>();
                        positionNoInresect = new List<PositionNoIntersect>();
                        positionStillCanBePlace = new List<PositionStillCanBePlace>();
                        positionCanNotBePlace = new List<PositionCanNotBePlace>();
                        positionSecondCanBePlace = new List<PositionSecondCanBePlace>();
                        //wordIntersectedTimes = new List<WordIntersectedTimes>();
                        HWP = new List<HorizontalWordPosition>();
                        VWP = new List<VerticalWordPosition>();
                        WIT = new List<string>();
                        HWFE = new List<HorizontalWordForExport>();
                        VWFE = new List<VerticalWordForExport>();

                        for (int i = 0; i < DataLoad.TCFL.Row; i++)
                        {
                            for (int j = 0; j < DataLoad.TCFL.Column; j++)
                            {
                                positionStillCanBePlace.Add(new PositionStillCanBePlace(i + 1, j + 1));
                            }
                        }

                        writeDataTable(1);


                        //first
                        createCrozzleInitPosition();

                        for (int i = CreateCrozzle.TCSLNRSBWLforloop.Count() - 1; i >= 0; i--)
                        {
                            otherCrozzlePosition(i);
                        }
                        positionPlace();

                        writeDataTable(2);
                        secondTimesCanBePlace();

                        foreach (string p in WIT)
                        {
                            Console.WriteLine(p);
                        }

                        Console.WriteLine();

                        insertNoIntersect();
                        calculatePoint();

                        Console.WriteLine(totalValue);

                    }
                    while (totalValue < 450);
                    #endregion
                }
            }
            catch (Exception ex)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + ex.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }

        }

        private static void addPosition(int wordIndex, int IX, int IY, string path)
        {
            if (path == "H")
            {
                HWFE.Add(new HorizontalWordForExport(IX, IY, TCSLNRSBWLforloop[wordIndex].wordlist));

                for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].letter.Length; i++)
                {
                    int PX = IX;
                    int PY = IY + i;
                    int PYleft = IY - 1;
                    int PYright = IY + CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length;
                    char PL = CreateCrozzle.TCSLNRSBWLforloop[wordIndex].letter[i];
                    string PW = CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist;
                    if (position.GroupBy(x => x.X == IX && x.Y == IY + i).Count() > 1)
                    {
                        position.Add(new Position(PX, PY, PL, PW));
                        HWP.Add(new HorizontalWordPosition(PX, PY, PL, PW));
                        positionIntersect.Add(new PositionIntersect(PX, PY, PL, PW));
                        CheckPositionValidation.checkWordIntersectedTimes(path, PX, PY, PW);
                    }
                    else
                    {
                        position.Add(new Position(PX, PY, PL, PW));
                        positionNoRepeat.Add(new PositionNoRepeat(PX, PY, PL, PW));
                        HWP.Add(new HorizontalWordPosition(PX, PY, PL, PW));
                    }
                    positionCanNotBePlace.Add(new PositionCanNotBePlace(PX, PYleft));
                    positionCanNotBePlace.Add(new PositionCanNotBePlace(PX, PYright));

                    //CheckPositionValidation.checkWordIntersectedTimes(path, PX, PY, PW);
                }
            }
            else if (path == "V")
            {
                VWFE.Add(new VerticalWordForExport(IX, IY, TCSLNRSBWLforloop[wordIndex].wordlist));

                for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].letter.Length; i++)
                {
                    int PX = IX + i;
                    int PY = IY;
                    char PL = CreateCrozzle.TCSLNRSBWLforloop[wordIndex].letter[i];
                    string PW = CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist;
                    int PXtop = IX - 1;
                    int PXbottom = IX + CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length;
                    if (position.GroupBy(x => x.X == IX + i && x.Y == IY).Count() > 1)
                    {
                        position.Add(new Position(PX, PY, PL, PW));
                        VWP.Add(new VerticalWordPosition(PX, PY, PL, PW));
                        positionIntersect.Add(new PositionIntersect(PX, PY, PL, PW));
                        CheckPositionValidation.checkWordIntersectedTimes(path, PX, PY, PW);
                    }
                    else
                    {
                        position.Add(new Position(PX, PY, PL, PW));
                        positionNoRepeat.Add(new PositionNoRepeat(PX, PY, PL, PW));
                        VWP.Add(new VerticalWordPosition(PX, PY, PL, PW));
                    }
                    positionCanNotBePlace.Add(new PositionCanNotBePlace(PXtop, PY));
                    positionCanNotBePlace.Add(new PositionCanNotBePlace(PXbottom, PY));

                    //CheckPositionValidation.checkWordIntersectedTimes(path, PX, PY, PW);
                }
            }
            //CheckPositionValidation.checkWordIntersectedTimes(path);
        }

        private static void writeDataTable(int way)
        {

            if (way == 1)
            {
                //LogFile.WriteLogFile("create whole data table, hve not put in data");
                for (int i = 0; i < crozzleTable.GetLength(0); i++)
                {
                    for (int j = 0; j < crozzleTable.GetLength(1); j++)
                    {
                        crozzleTable[i, j] = '*';
                    }
                }
            }

            if (way == 2)
            {
                foreach (Position p in position)
                {
                    crozzleTable[p.X - 1, p.Y - 1] = p.letter;
                }

                for (int variable1 = 0; variable1 <= crozzleTable.GetUpperBound(0); variable1++)
                {
                    for (int variable2 = 0; variable2 <= crozzleTable.GetUpperBound(1); variable2++)
                    {
                        var value = crozzleTable[variable1, variable2];
                        Console.Write(value);
                    }
                    Console.WriteLine();
                }
            }

        }

        private static void createCrozzleInitPosition()
        {
            Random rn = new Random();

            for (int i = CreateCrozzle.TCSLNRSBWLforloop.Count() - 1; i >= 0; i--)
            {
                if (HWP.Count == 0)
                {
                    int PX = rn.Next(1, 10);
                    int PY = rn.Next(1, (10 - CreateCrozzle.TCSLNRSBWLforloop[i].wordlist.Length));
                    //int PX = 2;
                    //int PY = 1;
                    addPosition(i, PX, PY, "H");
                    CreateCrozzle.TCSLNRSBWLforloop.RemoveAt(i);
                    continue;
                }

                if (VWP.Count == 0)
                {
                    bool write = false;
                    foreach (HorizontalWordPosition hwp in HWP)
                    {
                        if (write == false)
                        {
                            for (int k = 0; k < CreateCrozzle.TCSLNRSBWLforloop[i].wordlist.Length; k++)
                            {
                                if (CreateCrozzle.TCSLNRSBWLforloop[i].letter[k] == hwp.letter)
                                {
                                    int PX = hwp.X - k;
                                    int PY = hwp.Y;
                                    //if (CheckPositionValidation.checkPositionExist(i, k, "V", PX, PY) && CheckPositionValidation.checkPositionIntersected(hwp.wholeword))
                                    if (CheckPositionValidation.checkPositionExist(i, "V", PX, PY))
                                    {
                                        addPosition(i, PX, PY, "V");
                                        CreateCrozzle.TCSLNRSBWLforloop.RemoveAt(i);
                                        write = true;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    continue;
                }
                break;
            }
        }

        private static int otherCrozzlePosition(int index)
        {
            for (int k = CreateCrozzle.TCSLNRSBWLforloop[index].wordlist.Length - 1; k >= 0; k--)
            {
                foreach (VerticalWordPosition vwp in VWP)
                {
                    if (CreateCrozzle.TCSLNRSBWLforloop[index].letter[k] == vwp.letter)
                    {
                        int PX = vwp.X;
                        int PY = vwp.Y - k;
                        //if (CheckPositionValidation.checkPositionValidation(index, "H", PX, PY) && CheckPositionValidation.checkPositionExist(index, "H", PX, PY) && CheckPositionValidation.checkcheckPositionCanBePlace(index, "H", PX, PY) && CheckPositionValidation.checkPositionIntersected(index, "H", PX, PY) && CheckPositionValidation.checkEachWordSpaceNotTouch(index, "H", PX, PY))
                        if (CheckPositionValidation.checkPositionValidation(index, "H", PX, PY))
                            if (CheckPositionValidation.checkPositionExist(index, "H", PX, PY))
                                if (CheckPositionValidation.checkcheckPositionCanBePlace(index, "H", PX, PY))
                                    if (CheckPositionValidation.checkPositionIntersected(index, "H", PX, PY))
                                        if (CheckPositionValidation.checkEachWordSpaceNotTouch(index, "H", PX, PY))
                                        {

                                            addPosition(index, PX, PY, "H");
                                            CreateCrozzle.TCSLNRSBWLforloop.RemoveAt(index);
                                            return -1;
                                        }
                    }
                }
            }


            for (int k = CreateCrozzle.TCSLNRSBWLforloop[index].wordlist.Length - 1; k >= 0; k--)
            {
                foreach (HorizontalWordPosition hwp in HWP)
                {
                    if (hwp.letter == CreateCrozzle.TCSLNRSBWLforloop[index].letter[k])
                    {
                        int PX = hwp.X - k;
                        int PY = hwp.Y;
                        //if (CheckPositionValidation.checkPositionValidation(index, "V", PX, PY) && CheckPositionValidation.checkPositionExist(index, "V", PX, PY) && CheckPositionValidation.checkcheckPositionCanBePlace(index, "V", PX, PY) && CheckPositionValidation.checkPositionIntersected(index, "V", PX, PY) && CheckPositionValidation.checkEachWordSpaceNotTouch(index, "V", PX, PY))
                        if (CheckPositionValidation.checkPositionValidation(index, "V", PX, PY))
                            if (CheckPositionValidation.checkPositionExist(index, "V", PX, PY))
                                if (CheckPositionValidation.checkcheckPositionCanBePlace(index, "V", PX, PY))
                                    if (CheckPositionValidation.checkPositionIntersected(index, "V", PX, PY))
                                        if (CheckPositionValidation.checkEachWordSpaceNotTouch(index, "V", PX, PY))
                                        {
                                            addPosition(index, PX, PY, "V");
                                            CreateCrozzle.TCSLNRSBWLforloop.RemoveAt(index);
                                            return -1;
                                        }

                    }
                }
            }

            return index;
        }

        private static int otherCrozzlePositionSecondInitPosition(int index)
        {
            Random rn = new Random();

            int a = CheckPositionValidation.checkCrozzleEdge();
            switch (a)
            {
                case 0:
                    //for (int pi = 0; pi < positionStillCanBePlace.Count(); pi++)
                    //for (int i = DataLoad.TCSLNRSBWL.Count() - 1; i >= 0; i--)
                    //{
                    bool writteda = false;
                    while (writteda == false)
                    {
                        //for (int x = DataLoad.TCFL.Row; x >= 1; x--)
                        //{
                        //    for (int y = 1; y <= (DataLoad.TCFL.Column - DataLoad.TCSLNRSBWL[i].wordlist.Length); y++)
                        //    {
                        //for (int i = DataLoad.TCSLNRSBWL.Count() - 1; i >= 0; i--)
                        for (int pi = 0; pi < positionSecondCanBePlace.Count(); pi++)
                        {
                            //int x = rn.Next(1, 10);
                            //int y = rn.Next(1, (10 - DataLoad.TCSLNRSBWL[i].wordlist.Length));
                            ////int PX = 2;
                            ////int PY = 1;
                            int x = positionSecondCanBePlace[pi].X;
                            int y = positionSecondCanBePlace[pi].Y;
                            //if (CheckPositionValidation.checkPositionValidation(index, "H", x, y) && CheckPositionValidation.checkPositionExist(index, "H", x, y) && CheckPositionValidation.checkWordNotIntersected(index, "H", x, y) && CheckPositionValidation.checkEachWordSpaceNotTouch(index, "H", x, y))
                            if (CheckPositionValidation.checkPositionValidation(index, "H", x, y))
                                if (CheckPositionValidation.checkPositionExist(index, "H", x, y))
                                    if (CheckPositionValidation.checkWordNotIntersected(index, "H", x, y))
                                        if (CheckPositionValidation.checkEachWordSpaceNotTouch(index, "H", x, y))
                                        {
                                            addPosition(index, x, y, "H");
                                            CreateCrozzle.TCSLNRSBWLforloop.RemoveAt(index);
                                            writteda = true;
                                            return -1;
                                        }

                        }
                        return index;
                    }
                    //}
                    break;

                    //case 1:
                    //    //for (int i = DataLoad.TCSLNRSBWL.Count() - 1; i >= 0; i--)
                    //    //{

                    //    bool writtedb = false;
                    //    if (writtedb == false)
                    //    {
                    //        //int PX = rn.Next(1, 10);
                    //        //int PY = rn.Next(1, (10 - DataLoad.TCSLNRSBWL[i].wordlist.Length));
                    //        int x = 1;
                    //        int y = 1;
                    //        //if (CheckPositionValidation.checkPositionValidation(index, "H", x, y) && CheckPositionValidation.checkPositionExist(index, "H", x, y) && CheckPositionValidation.checkWordNotIntersected(index, "H", x, y) && CheckPositionValidation.checkEachWordSpaceNotTouch(index, "H", x, y))
                    //        if (CheckPositionValidation.checkPositionValidation(index, "H", x, y))
                    //            if (CheckPositionValidation.checkPositionExist(index, "H", x, y))
                    //                if (CheckPositionValidation.checkWordNotIntersected(index, "H", x, y))
                    //                    if (CheckPositionValidation.checkEachWordSpaceNotTouch(index, "H", x, y))
                    //                    {
                    //                        addPosition(index, x, y, "H");
                    //                        CreateCrozzle.TCSLNRSBWLforloop.RemoveAt(index);
                    //                        writtedb = true;
                    //                        return -1;
                    //                    }
                    //        //if (CheckPositionValidation.checkPositionValidation(index, "V", x, y) && CheckPositionValidation.checkPositionExist(index, "V", x, y) && CheckPositionValidation.checkWordNotIntersected(index, "V", x, y) && CheckPositionValidation.checkEachWordSpaceNotTouch(index, "V", x, y))
                    //        if (CheckPositionValidation.checkPositionValidation(index, "V", x, y))
                    //            if (CheckPositionValidation.checkPositionExist(index, "V", x, y))
                    //                if (CheckPositionValidation.checkWordNotIntersected(index, "V", x, y))
                    //                    if (CheckPositionValidation.checkEachWordSpaceNotTouch(index, "V", x, y))
                    //                    {
                    //                        addPosition(index, x, y, "V");
                    //                        CreateCrozzle.TCSLNRSBWLforloop.RemoveAt(index);
                    //                        writtedb = true;
                    //                        return -1;
                    //                    }
                    //    }
                    //    //}
                    //    break;

                    //case 2:
                    //    //for (int i = DataLoad.TCSLNRSBWL.Count() - 1; i >= 0; i--)
                    //    //{

                    //    bool writtedc = false;
                    //    if (writtedc == false)
                    //    {
                    //        //int PX = rn.Next(1, 10);
                    //        //int PY = rn.Next(1, (10 - DataLoad.TCSLNRSBWL[i].wordlist.Length));
                    //        int x = DataLoad.TCFL.Row;
                    //        int y = DataLoad.TCFL.Column - CreateCrozzle.TCSLNRSBWLforloop[index].wordlist.Length + 1;

                    //        //if (CheckPositionValidation.checkPositionValidation(index, "H", x, y) && CheckPositionValidation.checkPositionExist(index, "H", x, y) && CheckPositionValidation.checkWordNotIntersected(index, "H", x, y) && CheckPositionValidation.checkEachWordSpaceNotTouch(index, "H", x, y))
                    //        if (CheckPositionValidation.checkPositionValidation(index, "H", x, y))
                    //            if (CheckPositionValidation.checkPositionExist(index, "H", x, y))
                    //                if (CheckPositionValidation.checkWordNotIntersected(index, "H", x, y))
                    //                    if (CheckPositionValidation.checkEachWordSpaceNotTouch(index, "H", x, y))
                    //                    {
                    //                        addPosition(index, x, y, "H");
                    //                        CreateCrozzle.TCSLNRSBWLforloop.RemoveAt(index);
                    //                        writtedc = true;
                    //                        return -1;
                    //                    }
                    //        //if (CheckPositionValidation.checkPositionValidation(index, "V", x, y) && CheckPositionValidation.checkPositionExist(index, "V", x, y) && CheckPositionValidation.checkWordNotIntersected(index, "V", x, y) && CheckPositionValidation.checkEachWordSpaceNotTouch(index, "V", x, y))
                    //        if (CheckPositionValidation.checkPositionValidation(index, "V", x, y))
                    //            if (CheckPositionValidation.checkPositionExist(index, "V", x, y))
                    //                if (CheckPositionValidation.checkWordNotIntersected(index, "V", x, y))
                    //                    if (CheckPositionValidation.checkEachWordSpaceNotTouch(index, "V", x, y))
                    //                    {
                    //                        addPosition(index, x, y, "V");
                    //                        CreateCrozzle.TCSLNRSBWLforloop.RemoveAt(index);
                    //                        writtedc = true;
                    //                        return -1;
                    //                    }
                    //    }
                    //    //}
                    //    break;

            }
            return index;
        }

        private static void calculatePoint()
        {
            point = new List<Point>();

            foreach (PositionIntersect PI in positionIntersect)
            {
                foreach (TestConfigurationOther TCO in DataLoad.testConfigurationOther)
                {
                    if (TCO.Status == "INTERSECTING")
                    {
                        if (PI.letter == Convert.ToChar(TCO.Letter))
                        {
                            point.Add(new Point(PI.letter, TCO.EachPoint));
                        }
                    }
                }
            }

            foreach (PositionNoIntersect PNI in positionNoInresect)
            {
                foreach (TestConfigurationOther TCO in DataLoad.testConfigurationOther)
                {
                    if (TCO.Status == "NONINTERSECTING")
                    {
                        if (PNI.letter == Convert.ToChar(TCO.Letter))
                        {
                            point.Add(new Point(PNI.letter, TCO.EachPoint));
                        }
                    }
                }
            }

            totalValue = 0;
            int PointSPERWORD = 0;
            foreach (Point p in point)
            {
                totalValue = totalValue + p.Value;
            }
            //PointSPERWORD = (DataLoad.TCSLNR.Count - DataLoad.TCSLNRSBMP.Count) * Convert.ToInt32(DataLoad.ConfigurationSecordLine.POINTSPERWORD);
            PointSPERWORD = (DataLoad.TCSLNR.Count - CreateCrozzle.TCSLNRSBWLforloop.Count) * Convert.ToInt32(DataLoad.ConfigurationSecordLine.POINTSPERWORD);

            totalValue = totalValue + PointSPERWORD;

        }

        private static void insertNoIntersect()
        {
            int chechrepeat = 0;
            //foreach (PositionIntersect pi in positionIntersect)
            foreach (PositionNoRepeat pnr in positionNoRepeat)
            {
                try
                {
                    foreach (PositionIntersect pi in positionIntersect)
                    //foreach (PositionNoRepeat pnr in positionNoRepeat)
                    {
                        try
                        {
                            if (pnr.X.Equals(pi.X) && pnr.Y.Equals(pi.Y))
                            {
                                chechrepeat = 1;
                                break;
                            }
                            else
                            {
                                chechrepeat = 0;
                            }
                        }
                        catch (Exception e)
                        {
                            LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                            //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
                        }
                    }


                    if (chechrepeat == 0)
                    {
                        int X = pnr.X;
                        int Y = pnr.Y;
                        char PLN = pnr.letter;
                        string PWN = pnr.word;
                        positionNoInresect.Add(new PositionNoIntersect(X, Y, PLN, PWN));
                    }
                }
                catch (Exception e)
                {
                    LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                    //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
                }
            }
        }

        private static void positionPlace()
        {
            for (int i = positionStillCanBePlace.Count - 1; i >= 0; i--)
            {
                if (position.GroupBy(x => x.X == positionStillCanBePlace[i].X && x.Y == positionStillCanBePlace[i].Y).Count() > 1)
                {
                    positionStillCanBePlace.RemoveAt(i);
                }
            }
            for (int i = positionStillCanBePlace.Count - 1; i >= 0; i--)
            {
                if (positionCanNotBePlace.GroupBy(x => x.X == positionStillCanBePlace[i].X && x.Y == positionStillCanBePlace[i].Y).Count() > 1)
                {
                    positionStillCanBePlace.RemoveAt(i);
                }
            }
        }

        private static void secondTimesCanBePlace()
        {
            for (int pi = 0; pi < positionStillCanBePlace.Count(); pi++)
            {
                //int x = rn.Next(1, 10);
                //int y = rn.Next(1, (10 - DataLoad.TCSLNRSBWL[i].wordlist.Length));
                ////int PX = 2;
                ////int PY = 1;
                int x = positionStillCanBePlace[pi].X;
                int y = positionStillCanBePlace[pi].Y;
                if (CheckPositionValidation.checkEmptyPlace3X3(x, y))
                {
                    positionSecondCanBePlace.Add(new PositionSecondCanBePlace(x, y));
                }
            }
        }

        public static void addCrozzleTableToDT()
        {
            LogFile.WriteLogFile("create Table from memory");
            for (int i = 0; i < CreateCrozzle.crozzleTable.GetLength(1); i++)
            {
                DataColumn newColumn = new DataColumn(i.ToString(), CreateCrozzle.crozzleTable[0, 0].GetType());
                dt.Columns.Add(newColumn);
            }
            for (int i = 0; i < CreateCrozzle.crozzleTable.GetLength(0); i++)
            {
                DataRow newRow = dt.NewRow();
                for (int j = 0; j < CreateCrozzle.crozzleTable.GetLength(1); j++)
                {
                    newRow[j.ToString()] = CreateCrozzle.crozzleTable[i, j];
                }
                dt.Rows.Add(newRow);
            }
        }
    }
}

