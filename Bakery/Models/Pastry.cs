using System;
using System.Collections.Generic;


namespace Bakery.Models
{
	public class Pastry
	{
    public int CalcPastry(int numOfPastry) {
      if (numOfPastry % 3 == 0) {
        return (numOfPastry * 2) - (numOfPastry/3 * 1);
      } else if (numOfPastry % 3 == 1) {
        return (numOfPastry * 2) -((numOfPastry-1)/3 *1);
      }
      return numOfPastry * 2;

     }
  }
};

// 1. Find length of string.
// 2. Use conditional to determine if length is > 7.
// 3. If length is greater then 7, return true. 

