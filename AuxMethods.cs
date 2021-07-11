namespace KnapsackProblem
{
    class AuxMethods
    {
        public static bool checkMassBelowLimit(int[] vectorArr, Input input)
        {
            double temp = 0.0;
            for (int i = 0; i < vectorArr.Length; i++)
            {
                if (vectorArr[i] == 1)
                {
                    temp += input.itemMassList[i];
                }
                if (temp > input.backpackSize)
                {
                    return false;
                }
            }
            return true;
        }

        public static double calcVectorMass(int[] vectorArr, Input input)
        {
            double output = 0.0;
            for (int i = 0; i < vectorArr.Length; i++)
            {
                if (vectorArr[i] == 1)
                {
                    output += input.itemMassList[i];
                }
            }
            return output;
        }
        public static double calcVectorValue(int[] vectorArr, Input input)
        {
            double output = 0.0;
            for (int i = 0; i < vectorArr.Length; i++)
            {
                if (vectorArr[i] == 1)
                {
                    output += input.itemValueList[i];
                }
            }
            return output;
        }
    }
}
