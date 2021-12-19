using System;
using System.Collections.Generic;
using System.Text;

namespace NoMoreAddConsole
{
    class Handler
    {
        Fixer fixer = new Fixer();
        Validation validation = new Validation();
        public string HandleQueue(string DDI, string DDD, string Number)
        {
            string number = $"{HandleDDI(DDI)}{HandleDDD(DDD)}{HandleNumber(Number)}";
            return number;
        }

        public string HandleDDI(string DDI)
        {
            bool permission;
            string answer;

            Response validation_ = this.validation.ValidateDDI(DDI);

            permission = validation_.GetPermission();
            answer = null;

            if (permission == true)
            {
                answer = DDI;
            }

            while (permission == false)
            {
                Console.WriteLine(validation_.GetError());
                answer = Console.ReadLine();
                validation_ = this.validation.ValidateDDI(answer);
                permission = validation_.GetPermission();
            }
           
            answer = this.fixer.FixDDI(answer);
            return answer;
        }

        public string HandleDDD(string DDD)
        {
            bool permission;
            string answer;

            Response validation_ = this.validation.ValidateDDD(DDD);

            permission = validation_.GetPermission();
            answer = null;

            if (permission == true)
            {
                answer = DDD;
            }

            while (permission == false)
            {
                Console.WriteLine(validation_.GetError());
                answer = Console.ReadLine();
                validation_ = this.validation.ValidateDDD(answer);
                permission = validation_.GetPermission();
            }

            answer = this.fixer.FixDDD(answer);
            return answer;
        }

        public string HandleNumber(string Num)
        {
            bool permission;
            string answer;

            Response validation_ = this.validation.ValidateNumber(Num);

            permission = validation_.GetPermission();
            answer = null;

            if (permission == true)
            {
                answer = Num;
            }

            while (permission == false)
            {
                Console.WriteLine(validation_.GetError());
                answer = Console.ReadLine();
                validation_ = this.validation.ValidateNumber(answer);
                permission = validation_.GetPermission();
            }

            answer = this.fixer.FixFirstNine(answer);
            return answer;
        }

    }
}
