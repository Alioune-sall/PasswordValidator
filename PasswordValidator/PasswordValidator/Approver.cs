using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    public abstract class Approver
    {
        protected Approver? Next;

        public List<string> Raccolta = new List<string>();

        public bool IsValid; 

        public Approver SetSuccessor(Approver next)
        {
            Next = next;
            return Next;
        }

        public virtual bool ProcessNew(string password)
        {
            Next?.ProcessNew(password);
            foreach (var item in Raccolta)
            { Console.WriteLine(item); }

            if (Raccolta.Count > 0)
            {
                IsValid = false;
                Console.WriteLine(IsValid);
                return IsValid;
                
            }
            else
            {
                IsValid = true;
                Console.WriteLine(IsValid);
                return IsValid;
            }
        }
    }
}
