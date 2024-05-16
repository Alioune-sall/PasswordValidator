using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    internal class SpecialCharacterControll : Approver
    {
        public override bool ProcessNew(string password)
        {
            int a = 0;
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {

                if (password.Contains(item))
                {
                    a++;
                }
            }
            if (a != 0)
                base.ProcessNew(password);
            else
            {
                string messaggio = "The password must contain at least one special character";
               // Console.WriteLine("The password must contain at least one special character");
                Raccolta.Add(messaggio);
                base.ProcessNew(password);
            }

            Console.WriteLine(base.Raccolta); //base.Raccolta.ToList();

            return base.IsValid;
        }
    }
}
