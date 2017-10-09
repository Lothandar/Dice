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
            return rnd.Next(face);
        }

    }
}