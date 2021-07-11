using System;
using System.Text;

namespace KnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input(args[0]);
            StringBuilder outputVector = new StringBuilder();

            int[] lastVector = new int[input.itemCount];
            double bestValue = 0.0;
            double mass = 0.0;

            for (long i = 0; i < Math.Pow(2, input.itemCount); i++)
            {
                int[] currentVector = new int[input.itemCount];

                for (int j = 0; j < Convert.ToString(i, 2).Length; j++)
                {
                    currentVector[currentVector.Length - j - 1] = int.Parse(Convert.ToString(i, 2)[index: Convert.ToString(i, 2).Length - j - 1].ToString());
                }
                for (int j = 0; j < currentVector.Length; j++)
                {
                    if (AuxMethods.checkMassBelowLimit(currentVector, input))
                    {
                        if (AuxMethods.calcVectorValue(currentVector, input) > bestValue)
                        {
                            bestValue = AuxMethods.calcVectorValue(currentVector, input);
                            mass = AuxMethods.calcVectorMass(currentVector, input);
                            lastVector = currentVector;
                            Console.WriteLine("Got hit, current best value: {0} with mass {1} at iteration {2}", bestValue, mass, i);
                        }
                    }
                }
            }
            foreach (int e in lastVector)
            {
                outputVector.Append(e).Append(" ");
            }
            Console.WriteLine("Best value: {0}", bestValue);
            Console.WriteLine("Mass : {0}", mass);
            Console.WriteLine("Vector : {0}", outputVector);
        }
    }
}
