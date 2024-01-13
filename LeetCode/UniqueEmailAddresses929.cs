using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class UniqueEmailAddresses929
    {
        public string EmailString(string email)
        {
            int idxS = email.IndexOf('@');
            int idxP = email.IndexOf('+');
            string part1 = email.Remove(idxS);
            string part2 = email.Remove(0, idxS);
            string result1 = "";
            foreach(var item in part1)
            {
                if (item == '+') break;
                if (item != '.') result1 += item;
            }
            return result1 + part2;
        }
        public int NumUniqueEmails(string[] emails)
        {
            List<string> emailList = new List<string>();
            foreach (string email in emails)
            {
                emailList.Add(EmailString(email));
            }
            return emailList.Distinct().ToList().Count;
        }
    }
}
