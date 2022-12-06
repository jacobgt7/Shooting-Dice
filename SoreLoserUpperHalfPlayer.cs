using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : SoreLoserPlayer
    {
        public override int Roll()
        {
            return new Random().Next(DiceSize / 2, DiceSize) + 1;
        }
    }
}