using Xunit;
using System.Collections.Generic;


namespace CoinCombinationsProgram.Objects
{
  public class Tests
  {
    [Fact]
    public void Test1_1cent1pennie_true()
    {
    CoinCombinations newCoinCombinations = new CoinCombinations(1);
    Assert.Equal(1, newCoinCombinations.CountPennies() );
    }

    [Fact]
    public void Test2_2cents2pennies_true()
    {
    CoinCombinations newCoinCombinations = new CoinCombinations(2);
    Assert.Equal(2, newCoinCombinations.CountPennies() );
    }


  }
}
