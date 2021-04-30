using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Pastry
    { 
      
      public int PricePerPastry { get; private set; }
      public int PastryPrice { get;set; }
      public Pastry(int pricePerPastry)
      {
        PricePerPastry = pricePerPastry;
        PastryPrice = 0;
      }
       public void CalcPastry(int numOfPastry) {
          if(numOfPastry % 3 == 0) 
          {
            PastryPrice = (numOfPastry * PricePerPastry) - ((numOfPastry/3) * PricePerPastry);     
          } else if(numOfPastry % 3 == 1) 
          {
            PastryPrice = (numOfPastry * PricePerPastry) - ((numOfPastry-1)/3 * PricePerPastry);
          } else if (numOfPastry % 3 == 2) 
          {
            PastryPrice = (numOfPastry * PricePerPastry) - ((numOfPastry-2)/3 *PricePerPastry);
          } else PastryPrice = numOfPastry * PricePerPastry;
     }
         
    }
}
