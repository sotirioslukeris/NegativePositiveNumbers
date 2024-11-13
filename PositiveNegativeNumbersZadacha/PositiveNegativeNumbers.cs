using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeNumbersZadacha
{
    public class PositiveNegativeNumbers
    {
        public bool IsPositive(int number)
        {

            //if (number > 0)
            //{
            //    return true;
            //}
            //return false;    
            bool result = false;
            if (number > 0) 
            {
                result = true;
            }
            if (number < 0) 
            { 
                return false;
            }
            if (number == 0) 
            {
                throw new ArgumentException("Ne moje da e 0!!!");
            }
            return result;
            
        }
    }
}
