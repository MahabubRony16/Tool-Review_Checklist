using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ReviewCheckList
{
    class InputValidity
    {
        public bool IsTaskIdValid(string input)
        {
            if (input.Length == 11 && input.Substring(0, 4).ToLower() == "task" && int.TryParse(input.Substring(4, 7), out _) || input.Length==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDocumentlinkValid(string input)
        {
            if (input.Contains("valmet.service-now.com") || input.Length == 0)
            { return true; }
            else { return false; }
        }
        public bool IsRedmineIdValid(string input)
        {
            if (input.Length == 6 && int.TryParse(input.Substring(0, 6), out _) || input.Length == 0)
            { return true; }
            else { return false; }
        }
       

    }
}
