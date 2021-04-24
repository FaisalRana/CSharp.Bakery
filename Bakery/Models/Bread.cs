using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        public int CalcBread(int numOfBread) {
          int totalnumBread = numOfBread;
          if(numOfBread % 3 == 0) {
            return (numOfBread * 5) - ((numOfBread/3) * 5);     
          } else if(numOfBread % 3 == 1) {
            return (numOfBread * 5) - ((numOfBread-1)/3 * 5);
          } else if (numOfBread % 3 == 2) {
            return (numOfBread * 5) - ((numOfBread-2)/3 *5);
          } else return numOfBread * 5;
        }
         
    }
};
