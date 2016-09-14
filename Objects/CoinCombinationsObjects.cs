using System;
using System.Collections.Generic;
using System.Linq;




namespace CoinCombinationsProgram.Objects
{
  public class CoinCombinations
  {
    private int _change;

    public CoinCombinations(int change)
    {
      _change = change;
    }
    public int GetInputChange()
    {
      return _change;
    }
    public void SetInputChange(int change)
    {
      _change = change;
    }


    int D = 0;
    int Q = 0;
    int N = 0;
    int P = 0;

    // int inputChange = this.GetInputChange();
    // for(int i = inputChange ; i%25>1 ; i - 25 = i)
    // {
    //   int Q + 1 = Q;
    // }
    // for(int i = inputChange ; i%10>1 ; i - 10 = i)
    // {
    //   int D + 1 = D;
    // }

    // for(int i = inputChange ; i%5>1 ; i - 5 = i)
    // {
    //   int N + 1 = N;
    // }




    public int CountPennies()
    {
      for( int i = this.GetInputChange() ; i!=0 ; i=i-1 )
      {
          P = P + 1;
          Console.WriteLine(P);

      }
      return P;
    }





  }
}
