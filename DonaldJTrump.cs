using System;
using System.Collections.Generic;

namespace RepublicanParty
{
  public class DonaldJTrump : DoucheBag
  {
    const int Racism = Int32.MaxValue;
    const int Misogyny = Int32.MaxValue;
    const int Xenophobia = Int32.MaxValue;
    const int Volatility = Int32.MaxValue;
    const int DictatorQualities = Int32.MaxValue;
    const int RealityDistortionField = Int32.MaxValue;
    const int Morality = Int32.MinValue;
    const int HandSize = Int32.MinValue;
    readonly List<string> Words = new List<string> { "Best", "Me", "Losers", "Great", "Crooked Hillary", "Pussy", "Tic Tacs", "Skittles", "Islamic Extremists", "Illegals", "Mexicans", "Deleted Emails", "Bengazi", "The Cyber", "Rapists", "Media", "Taxes", "Folks", "Obamacare", "Dishonest", "Rigged" };

    Random Rand = new Random();

    public void Speak()
    {
      SayMeanderingNonsensicalBullshit();
    }

    public void Listen()
    {
      Interrupt();

      Speak();

      throw new InvalidOperationException();
    }

    public void ApproachFemale()
    {
      JustGrabThemByThePussy();

      throw new SexualAssualtException();
    }

    public void Apologize()
    {
      HeyLookOverThere();

      throw new InvalidApologyException();
    }

    private void Interrupt()
    {
    }

    private void SayMeanderingNonsensicalBullshit()
    {
      var numWords = Rand.Next(10);
      var bullshit = new List<string>();

      for(var i = 0; i < numWords; ++i)
      {
        bullshit.Add(Words[Rand.Next(Words.Count)]);
      }

      Console.WriteLine(String.Join(" ", bullshit));
    }

    private void JustGrabThemByThePussy()
    {
    }

    private void HeyLookOverThere()
    {
      Console.WriteLine("Hey, look over there!");
    }
  }
}
