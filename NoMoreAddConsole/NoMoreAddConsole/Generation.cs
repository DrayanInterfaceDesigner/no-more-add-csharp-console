using System;

namespace NoMoreAddConsole
{
    class Generation
    {
        public string GenerateLink(string num)
        {
            string link = $"//api.whatsapp.com/send/?phone={num}&text&app_absent=0";
            return link;
        }

        public void PrintLink(string link)
        {
            Console.WriteLine("Here's your link:");
            Console.WriteLine($"\t{link}");
        }
    }
}
