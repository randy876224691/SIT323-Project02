using System.Text.RegularExpressions;

namespace SIT323_Project02
{
    class RegexDetail
    {
        static public Regex checkalphabet = new Regex(@"[A-Za-z]");
        static public Regex checkalphabetLevel = new Regex(@"^\b(EASY|MEDIUM|HARD)\b$");
        static public Regex checkalphabetPath = new Regex(@"^\b(HORIZONTAL|VERTICAL)\b$");
        static public Regex checkalphabetStatus = new Regex(@"^\b(INTERSECTING|NONINTERSECTING)\b$");
        static public Regex checkalphabetGROUPSPERCROZZLELIMIT = new Regex(@"^\b(GROUPSPERCROZZLELIMIT)\b$");
        static public Regex checkalphabetPOINTSPERWORD = new Regex(@"^\b(POINTSPERWORD)\b$");
        static public Regex checkdigital = new Regex(@"[0-9]");
        //static public Regex checkdigitalNonnegative = new Regex(@"^[0-9]\d*$");
        static public Regex checkdigitalNonnegative = new Regex(@"^\d+$");
        static public Regex checkdigitalAmount = new Regex(@"[1-9]\d|[1-9]\d\d|(1000)");
        static public Regex checkdigitalRow = new Regex(@"[4-9]|[1-9]\d|[1-3]\d\d|(400)");
        static public Regex checkdigitalColumn = new Regex(@"[8-9]|[1-9]\d|[1-7]\d\d|(800)");
    }
}
