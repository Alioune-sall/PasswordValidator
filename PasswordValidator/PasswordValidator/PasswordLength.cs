using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    internal class PasswordLength : Approver
    {
        public override bool ProcessNew(string password)
        {
            if (password.Length < 8)
            {
                string messaggio = "The password must be at least 8 characters long";
                Raccolta.Add(messaggio);
                base.ProcessNew(password);
            }
            else
                base.ProcessNew(password);
            return base.IsValid;
        }
    }
}
