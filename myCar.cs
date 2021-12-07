using System;

namespace ClassesExercise
{
    internal class myCar
    {
        public static implicit operator myCar(string v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator myCar(int v)
        {
            throw new NotImplementedException();
        }
    }
}