using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public class ShowCards
    {
        public string Check(int humanScore, int computerScore)
        {
            string result="",result1="\nHuman Won!", result2= "\nIt's a draw!", result3= "\nHuman lost!";

           //schenario
            if (humanScore == 21 && !(computerScore == 21))
            {
                result = result1;
            }
            else if (humanScore <= 21 && computerScore > 21)
            {
               
                result = result1;
            }
            else if (humanScore > computerScore)
            {
                result = result1;
            }
           
            else if (humanScore == 21 && computerScore == 21)
            {
                result = result2;
            }
            else if (humanScore == computerScore)
            {
                result = result2;
            }
            else if (humanScore > 21 && computerScore <= 21)
            {
                result = result3;
            }
            else if (humanScore < computerScore && computerScore <= 21)
            {
                result = result3;
            }
            return result;
        }
    }
}
