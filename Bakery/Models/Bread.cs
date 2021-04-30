using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    { 
      
      public int PricePerLoaf { get; private set; }
      public int BreadPrice { get;set; }
      public Bread()
      {
        PricePerLoaf = 5;
        BreadPrice = 0;
      }
       public void CalcBread(int numOfBread) {
          if(numOfBread % 3 == 0) 
          {
            BreadPrice = (numOfBread * PricePerLoaf) - ((numOfBread/3) * PricePerLoaf);     
          } else if(numOfBread % 3 == 1) 
          {
            BreadPrice = (numOfBread * PricePerLoaf) - ((numOfBread-1)/3 * PricePerLoaf);
          } else if (numOfBread % 3 == 2) 
          {
            BreadPrice = (numOfBread * PricePerLoaf) - ((numOfBread-2)/3 *PricePerLoaf);
          } else BreadPrice = numOfBread * PricePerLoaf;
     }
         
    }
}
