using System;
using System.Collections.Generic;

namespace Dice
{
    class Cup:Die
    {
        int diceContain;
        List<Die> Dice = new List<Die>();
        public Cup()
        {
            diceContain = 0;
        }
        public void Add(Die die)
        {
            diceContain += 1;
            Dice.Add(die);

        }
        public void Remove(Die die)
        {
            if (diceContain <= 0)
            {
                Console.WriteLine("Your cup is already Empty");
            }
            else{
            diceContain -=1;
            }
        }
        public void Show()
        {
            Console.WriteLine("The cup currently contains {0} dice", diceContain);
        }
        public void Empty()
        {
            diceContain = 0;
            Dice.Clear();
        }
        public override int Roll()
        {
            if (diceContain <= 0)
            {
                Console.WriteLine("You can't roll an empty cup");
                return 0;
            }
            else
            {

                int totalRollValue = 0;
                foreach(Die die in Dice)
                {
                    totalRollValue += die.Roll();
                }
                Console.WriteLine("You Rolled {0} dice and have a total value of {1}",diceContain ,totalRollValue);
                return totalRollValue;
            }
        }
    }
}