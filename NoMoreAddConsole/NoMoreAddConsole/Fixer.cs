
namespace NoMoreAddConsole
{
    class Fixer
    {

        public string FixDDD(string DDD)
        {
            string ddd = DDD;
            if (DDD.StartsWith("0"))
            {
                ddd = DDD.Substring(1);
            }

            return ddd;
        }

        public string FixDDI(string DDI)
        {
            string ddi = DDI;
            if (DDI.StartsWith("+"))
            {
                ddi = ddi.Substring(1);
            }
            return ddi;
        }

        public string FixFirstNine(string NUM)
        {
            string number = NUM;
            if (NUM.Length == 8)
            {
                number = "9" + NUM;
            }
            return number;
        }
    }
}
