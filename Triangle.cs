using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemonstration
{
    public static class Triangle
    {
        //Prasanna Chinnu 8868349 Mutant test.
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                //Made some changes in the result
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }

            
            return result;
        }
    }
}
