using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT323_Project02
{
    class CheckPositionValidation
    {
        static public bool checkPositionValidation(int wordIndex, string path, int IX, int IY)
        {

            if (path == "H")
            {
                bool touchLoop = false;
                //looping each word.
                for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length + 2; i++)
                {

                    // define data
                    // defin x
                    int PX = IX;
                    int PXtop = IX - 1;
                    int PXbottom = IX + 1;
                    //defin y
                    int PY = IY + i - 1;
                    int PYleft = IY - 1;
                    int PYright = IY + CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length;

                    // check each touch space
                    // check top each space of touch
                    if (CreateCrozzle.HWP.GroupBy(x => x.X == PXtop && x.Y == PY).Count() > 1)
                    { touchLoop = true;/*LogFile.WriteErrorFile("Horizontal word have touch horizational : " + T.WholeWord.ToString());*/ }
                    // check bottom each space of touch
                    if (CreateCrozzle.HWP.GroupBy(x => x.X == PXbottom && x.Y == PY).Count() > 1)
                    { touchLoop = true;/*LogFile.WriteErrorFile("Horizontal word have touch horizational : " + T.WholeWord.ToString());*/ }
                    // check single left space of touch
                    if (CreateCrozzle.HWP.GroupBy(x => x.X == PX && x.Y == PYleft).Count() > 1)
                    { touchLoop = true; /*LogFile.WriteErrorFile("Horizontal word have touch horizational : " + T.WholeWord.ToString());*/ }
                    // check single right space of touch
                    if (CreateCrozzle.HWP.GroupBy(x => x.X == PX && x.Y == PYright).Count() > 1)
                    { touchLoop = true; /*LogFile.WriteErrorFile("Horizontal word have touch horizational : " + T.WholeWord.ToString()); */}

                    // check single left space of touch
                    if (CreateCrozzle.VWP.GroupBy(x => x.X == PX && x.Y == PYleft).Count() > 1)
                    { touchLoop = true; /*LogFile.WriteErrorFile("Horizontal word have touch horizational : " + T.WholeWord.ToString());*/ }
                    // check single right space of touch
                    if (CreateCrozzle.VWP.GroupBy(x => x.X == PX && x.Y == PYright).Count() > 1)
                    { touchLoop = true; /*LogFile.WriteErrorFile("Horizontal word have touch horizational : " + T.WholeWord.ToString()); */}

                }

                if (touchLoop == true)
                {
                    //LogFile.WriteErrorFile("Crozzle word around touch check -----Error----" + "Horizontal word have touch horizational : " + DataLoad.TCSLNRSBWL[wordIndex].wordlist.ToString());
                    return false;
                }

            }
            else if (path == "V")
            {
                bool touchLoop = false;
                //looping each word.
                for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length + 2; i++)
                {
                    // define data
                    // defin x
                    int PX = IX + i - 1;
                    int PXtop = IX - 1;
                    int PXbottom = IX + CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length;
                    //defin y
                    int PY = IY;
                    int PYleft = IY - 1;
                    int PYright = IY + 1;

                    // check each touch space
                    // check single top each space of touch
                    if (CreateCrozzle.VWP.GroupBy(x => x.X == PXtop && x.Y == PY).Count() > 1)
                    { touchLoop = true;/*LogFile.WriteErrorFile("VERTICAL word have touch VERTICAL : " + T.WholeWord.ToString()); */}
                    // check single bottom each space of touch
                    if (CreateCrozzle.VWP.GroupBy(x => x.X == PXbottom && x.Y == PY).Count() > 1)
                    { touchLoop = true;/*LogFile.WriteErrorFile("VERTICAL word have touch VERTICAL : " + T.WholeWord.ToString());*/ }
                    // check left space of touch
                    if (CreateCrozzle.VWP.GroupBy(x => x.X == PX && x.Y == PYleft).Count() > 1)
                    { touchLoop = true;/*LogFile.WriteErrorFile("VERTICAL word have touch VERTICAL : " + T.WholeWord.ToString());*/ }
                    // check right space of touch
                    if (CreateCrozzle.VWP.GroupBy(x => x.X == PX && x.Y == PYright).Count() > 1)
                    { touchLoop = true;/*LogFile.WriteErrorFile("VERTICAL word have touch VERTICAL : " + T.WholeWord.ToString());*/ }

                    if (CreateCrozzle.HWP.GroupBy(x => x.X == PXtop && x.Y == PY).Count() > 1)
                    { touchLoop = true;/*LogFile.WriteErrorFile("VERTICAL word have touch VERTICAL : " + T.WholeWord.ToString()); */}
                    // check single bottom each space of touch
                    if (CreateCrozzle.HWP.GroupBy(x => x.X == PXbottom && x.Y == PY).Count() > 1)
                    { touchLoop = true;/*LogFile.WriteErrorFile("VERTICAL word have touch VERTICAL : " + T.WholeWord.ToString());*/ }


                }
                if (touchLoop == true)
                {
                    //LogFile.WriteErrorFile("Crozzle word around touch check -----Error----" + "Horizontal word have touch horizational : " + DataLoad.TCSLNRSBWL[wordIndex].wordlist.ToString());
                    return false;
                }

            }

            return true;
        }

        static public bool checkPositionExist(int wordIndex, string path, int IX, int IY)
        {
            if (path == "H")
            {
                if (IY + CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length - 1 > DataLoad.TCFL.Column || IX > DataLoad.TCFL.Row || IY <= 0)
                {
                    return false;
                }

                for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length; i++)
                {
                    if (CreateCrozzle.HWP.GroupBy(x => x.X == IX && x.Y == (IY + i)).Count() > 1)
                        return false;
                }
            }

            if (path == "V")
            {
                if (IX + CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length - 1 > DataLoad.TCFL.Row || IY > DataLoad.TCFL.Column || IX <= 0)
                {
                    return false;
                }

                for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length; i++)
                {
                    if (CreateCrozzle.VWP.GroupBy(x => x.X == (IX + i) && x.Y == IY).Count() > 1)
                        return false;
                }
            }
            return true;
        }

        static public bool checkcheckPositionCanBePlace(int wordIndex, string path, int IX, int IY)
        {
            if (path == "H")
            {
                foreach (VerticalWordPosition vwp in CreateCrozzle.VWP)
                {
                    for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length; i++)
                    {
                        //if (CreateCrozzle.VWP.Where(x => x.X == IX && x.Y == (IY + i)).GroupBy(x => x.letter == DataLoad.TCSLNRSBWL[wordIndex].letter[i]).Count() > 1)

                        if (vwp.X.Equals(IX) && vwp.Y.Equals(IY + i))
                        {
                            if (!vwp.letter.Equals(CreateCrozzle.TCSLNRSBWLforloop[wordIndex].letter[i]))
                            {
                                return false;

                            }
                        }
                    }
                }

                int leftspeaceX = IX - 1;
                int rightspaceX = CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length + 1;
                int Y = IY;
                if (CreateCrozzle.VWP.GroupBy(x => x.X == leftspeaceX && x.Y == Y).Count() > 1)
                {
                    return false;
                }
                if (CreateCrozzle.VWP.GroupBy(x => x.X == rightspaceX && x.Y == Y).Count() > 1)
                {
                    return false;
                }


            }

            if (path == "V")
            {
                foreach (HorizontalWordPosition hwp in CreateCrozzle.HWP)
                {
                    for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length; i++)
                    {
                        //if (CreateCrozzle.HWP.Where(x => x.X == (IX + i) && x.Y == IY).GroupBy(x => x.letter == DataLoad.TCSLNRSBWL[wordIndex].letter[i]).Count() > 1)
                        if (hwp.X.Equals(IX + i) && hwp.Y.Equals(IY))
                        {
                            if (!hwp.letter.Equals(CreateCrozzle.TCSLNRSBWLforloop[wordIndex].letter[i]))
                            {
                                return false;
                            }
                        }
                    }
                }
                int X = IX;
                int topspaceY = IY + 1;
                int bottomspaceY = CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length + 1;
                if (CreateCrozzle.HWP.GroupBy(x => x.X == X && x.Y == topspaceY).Count() > 1)
                {
                    return false;
                }
                if (CreateCrozzle.HWP.GroupBy(x => x.X == X && x.Y == bottomspaceY).Count() > 1)
                {
                    return false;
                }
            }
            return true;
        }

        static public bool checkPositionIntersected(int wordIndex, string path, int IX, int IY)
        {

            if (path == "H")
            {
                foreach (VerticalWordPosition vwp in CreateCrozzle.VWP)
                {
                    for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length; i++)
                    {
                        if (vwp.X.Equals(IX) && vwp.Y.Equals(IY + i))
                        {
                            if (DataLoad.TCFL.Level == "EASY")
                            {
                                if (CreateCrozzle.WIT.FindAll((x) => { return x == vwp.wholeword; }).Count() >= 2)
                                {
                                    return false;
                                }
                            }
                            else if (DataLoad.TCFL.Level == "MEDIUM")
                            {
                                if (CreateCrozzle.WIT.FindAll((x) => { return x == vwp.wholeword; }).Count() >= 3)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            if (path == "V")
            {
                foreach (HorizontalWordPosition hwp in CreateCrozzle.HWP)
                {
                    for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length; i++)
                    {
                        //if (CreateCrozzle.HWP.Where(x => x.X == (IX + i) && x.Y == IY).GroupBy(x => x.letter == DataLoad.TCSLNRSBWL[wordIndex].letter[i]).Count() > 1)
                        if (hwp.X.Equals(IX + i) && hwp.Y.Equals(IY))
                        {
                            if (DataLoad.TCFL.Level == "EASY")
                            {
                                if (CreateCrozzle.WIT.FindAll((x) => { return x == hwp.wholeword; }).Count() >= 2)
                                {
                                    return false;
                                }
                            }
                            else if (DataLoad.TCFL.Level == "MEDIUM")
                            {
                                if (CreateCrozzle.WIT.FindAll((x) => { return x == hwp.wholeword; }).Count() >= 3)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            ////if (CreateCrozzle.WIT.GroupBy(x => x == words).Count() >= 2)
            //if (CreateCrozzle.WIT.FindAll((x) => { return x == words; }).Count() >= 2)
            //{
            //    return false;
            //}

            //if (DataLoad.TCFL.Level == "MEDIUM")
            //{
            //    //if (CreateCrozzle.WIT.GroupBy(x => x == words).Count() >= 3)
            //    if (CreateCrozzle.WIT.FindAll((x) => { return x == words; }).Count() == 3)
            //    {
            //        return false;
            //    }
            //}
            return true;
        }

        static public void checkWordIntersectedTimes(string path, int PX, int PY, string PW)
        {
            if (CreateCrozzle.HWP.Count != 0 && CreateCrozzle.VWP.Count != 0)
            {
                if (path == "H")
                {
                    foreach (VerticalWordPosition vwp in CreateCrozzle.VWP)
                    {
                        if (vwp.X.Equals(PX) && vwp.Y.Equals(PY))
                        {
                            //CreateCrozzle.wordIntersectedTimes.Add(new WordIntersectedTimes(hwp.wholeword, wordintersectTimes));
                            //CreateCrozzle.wordIntersectedTimes.Add(new WordIntersectedTimes(vwp.wholeword, wordintersectTimes));
                            CreateCrozzle.WIT.Add(vwp.wholeword);
                            CreateCrozzle.WIT.Add(PW);
                        }
                    }

                }
                if (path == "V")
                {
                    foreach (HorizontalWordPosition hwp in CreateCrozzle.HWP)
                    {
                        if (hwp.X.Equals(PX) && hwp.Y.Equals(PY))
                        {
                            //CreateCrozzle.wordIntersectedTimes.Add(new WordIntersectedTimes(hwp.wholeword, wordintersectTimes));
                            //CreateCrozzle.wordIntersectedTimes.Add(new WordIntersectedTimes(vwp.wholeword, wordintersectTimes));
                            CreateCrozzle.WIT.Add(hwp.wholeword);
                            CreateCrozzle.WIT.Add(PW);
                        }
                    }
                }
            }
        }

        static public bool checkWordNotIntersected(int wordIndex, string path, int IX, int IY)
        {
            for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length; i++)
            {
                if (CreateCrozzle.position.GroupBy(x => x.X == IX && x.Y == (IY + i)).Count() > 1)
                    return false;
            }
            return true;
        }

        static public int checkCrozzleEdge()
        {


            // define crozzle edge words number
            int crozzleEdgewordLeft = 0;
            int crozzleEdgewordRight = 0;
            int crozzleEdgewordTop = 0;
            int crozzleEdgewordBottom = 0;

            // check left and right crozzle edge!
            for (int i = 1; i < DataLoad.TCFL.Row; i++)
            {
                int PX = i;
                int PYLeft = 1;
                int PYRight = DataLoad.TCFL.Column;

                if (CreateCrozzle.position.GroupBy(x => x.X == PX && x.Y == PYLeft).Count() > 1)
                { crozzleEdgewordLeft++; }
                //else
                //{ crozzleEdge = true; }

                if (CreateCrozzle.position.GroupBy(x => x.X == PX && x.Y == PYRight).Count() > 1)
                { crozzleEdgewordRight++; }
                //else
                //{ crozzleEdge = true; }
            }

            // check top and bottom crozzle edge!
            for (int j = 1; j < DataLoad.TCFL.Column; j++)
            {
                int PXTop = 1;
                int PXBottom = DataLoad.TCFL.Row;
                int PY = j;

                if (CreateCrozzle.position.GroupBy(x => x.X == PXTop && x.Y == PY).Count() > 1)
                { crozzleEdgewordTop++; }
                //else
                //{ crozzleEdge = true; }

                if (CreateCrozzle.position.GroupBy(x => x.X == PXBottom && x.Y == PY).Count() > 1)
                { crozzleEdgewordBottom++; }
                //else
                //{ crozzleEdge = true; }
            }

            // print log file and show error list
            if (crozzleEdgewordLeft == 0 || crozzleEdgewordTop == 0)
            {
                //return 1;
                return 0;
            }

            if (crozzleEdgewordRight == 0 || crozzleEdgewordBottom == 0)
            {
                //return 2;
                return 0;
            }

            return 0;

        }

        static public bool checkEachWordSpaceNotTouch(int wordIndex, string path, int IX, int IY)
        {
            if (path == "H")
            {
                //foreach (PositionCanNotBePlace pcnbp in CreateCrozzle.positionCanNotBePlace)
                //{
                for (int i = 0; i < CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length; i++)
                {
                    int px = IX;
                    int py = IY + i;
                    if (CreateCrozzle.positionCanNotBePlace.GroupBy(x => x.X == px && x.Y == py).Count() > 1)
                    //if (pcnbp.X.Equals(IX) && pcnbp.Y.Equals(IY + i))
                    {
                        return false;
                    }
                }
                //}
            }
            if (path == "V")
            {
                //foreach (PositionCanNotBePlace pcnbp in CreateCrozzle.positionCanNotBePlace)
                //{
                for (int i = 0; i <CreateCrozzle.TCSLNRSBWLforloop[wordIndex].wordlist.Length; i++)
                {
                    int px = IX + i;
                    int py = IY;
                    if (CreateCrozzle.positionCanNotBePlace.GroupBy(x => x.X == px && x.Y == py).Count() > 1)
                    //if (pcnbp.X.Equals(IX) && pcnbp.Y.Equals(IY + i))
                    {
                        return false;
                    }
                }
                //}
            }
            return true;
        }

        static public bool checkEmptyPlace3X3(int x, int y)
        {
            
            int topx = x - 1;
            int bottomx = x + 1;
            int lefty = y - 1;
            int righty = y + 1;
            //top
            if (CreateCrozzle.positionNoRepeat.GroupBy(a => a.X == topx && a.Y == y).Count() > 1)
                return false;

            //top left
            if (CreateCrozzle.positionNoRepeat.GroupBy(a => a.X == topx && a.Y == lefty).Count() > 1)
                return false;

            //top right
            if (CreateCrozzle.positionNoRepeat.GroupBy(a => a.X == topx && a.Y == righty).Count() > 1)
                return false;


            // left
            if (CreateCrozzle.positionNoRepeat.GroupBy(a => a.X == x && a.Y == righty).Count() > 1)
                return false;

            //right
            if (CreateCrozzle.positionNoRepeat.GroupBy(a => a.X == x && a.Y == lefty).Count() > 1)
                return false;

            //bottom
            if (CreateCrozzle.positionNoRepeat.GroupBy(a => a.X == bottomx && a.Y == y).Count() > 1)
                return false;

            //bottom left
            if (CreateCrozzle.positionNoRepeat.GroupBy(a => a.X == bottomx && a.Y == lefty).Count() > 1)
                return false;

            //bottom right
            if (CreateCrozzle.positionNoRepeat.GroupBy(a => a.X == bottomx && a.Y == righty).Count() > 1)
                return false;


            return true;
        }
    }
}
