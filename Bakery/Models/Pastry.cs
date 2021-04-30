using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Pastry
    { 
      
      public int PricePerPastry { get; private set; }
      public int PastryPrice { get;set; }
      public Pastry()
      {
        PricePerPastry = 2;
        PastryPrice = 2;
      }
       public void CalcPastry(int numOfPastry) {
          if(numOfPastry % 3 == 0) 
          {
            PastryPrice =  (numOfPastry * 2) - (numOfPastry/3 * 1);    
          } else if(numOfPastry % 3 == 1) 
          {
            PastryPrice =  (numOfPastry * 2) -((numOfPastry-1)/3 *1);
          } else if (numOfPastry % 3 == 2) 
          {
            PastryPrice = (numOfPastry * 2) - (numOfPastry - 2)/3 *1;
          } else PastryPrice = numOfPastry * PricePerPastry;
     }
         
    }
}
