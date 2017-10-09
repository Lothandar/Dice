using System;

namespace Dice
{
    class Die
    {
        int face;

        public Die()
        {
            face = 4;
        }
        public Die(int face)
        {
            this.face = face;
        }
        public virtual int Roll()
        {
            Random rnd = new Random();
            int result = rnd.Next(face+1);
            Console.WriteLine("You rolled a {0} face die and obtained a {1}",face,result);
            return result;
        }

    }
}