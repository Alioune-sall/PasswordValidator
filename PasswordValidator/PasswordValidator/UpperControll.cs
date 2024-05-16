using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    internal class UpperControll : Approver
    {
        public override bool ProcessNew(string password)
        {
            int a = 0;
            foreach (char c in  password)
            {
               
                if(char.IsUpper(c))
                { 
                    a++;
                }
            }
            if (a != 0)
                base.ProcessNew(password);
            else
            {
                string messaggio = "The password must contain at least one capital letter";
                Raccolta.Add(messaggio);
                //Console.WriteLine("The password must contain at least one capital letter");
                base.ProcessNew(password);
            }
            return base.IsValid;
        }

    }
}
