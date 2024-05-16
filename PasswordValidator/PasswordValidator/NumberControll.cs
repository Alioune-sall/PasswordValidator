using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    internal class NumberControll : Approver
    {
        
        public override bool ProcessNew(string password)
        {
            int a = 0;
            foreach (char c in password) 
            {
                if (char.IsNumber(c))
                {
                    a++;
                    //if (a >= 2)
                    //{ base.ProcessNew(password); }
                }
            }
            if (a >= 2)
            { 
                base.ProcessNew(password);
            }
            else
            {
                string messaggio = "The password must contain at least 2 numbers";
                Raccolta.Add(messaggio);
                //Console.WriteLine("The password must contain at least 2 numbers");
                base.ProcessNew(password);
            }
            return base.IsValid;
        }
    }
}
