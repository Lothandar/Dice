using System;
using System.Collections.Generic;

namespace Dice
{
    class Cup:Die
    {
        
        List<Die> Dice = new List<Die>();
        public Cup()
        {
            
        }
        public void Add(Die die)
        {
            Dice.Add(die);

        }
        public void Remove(Die die)
        {
            if (Dice.Count <= 0)
            {
                Console.WriteLine("Your cup is already Empty");
            }
            else{
                Console.WriteLine("Which dice do you want to remove?");
            foreach(Die di in Dice)
                {
                    Console.WriteLine(di);
                }
            
            }
        }
        public void Show()
        {
            Console.WriteLine("The cup currently contains {0} dice", Dice.Count);
        }
        public void Empty()
        {
            Dice.Clear();
        }
        public override int Roll()
        {
            if (Dice.Count <= 0)
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
                Console.WriteLine("You Rolled {0} dice and have a total value of {1}",Dice.Count ,totalRollValue);
                return totalRollValue;
            }
        }
    }
}