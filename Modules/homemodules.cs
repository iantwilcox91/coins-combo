using System;
using System.Collections.Generic;
using Nancy;
using CoinCombinationsProgram.Objects;

namespace CoinCombinationsProgram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => { return View["index.cshtml"]; };

      Get["/result"] = _ => { return View["result.cshtml"]; };
    }
  }
}
