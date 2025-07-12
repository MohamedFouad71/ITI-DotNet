


namespace refPractice.Utilities
{
    class SalaryManager
    {
        public static void AddBonus(ref double salary)
        {
            const float bonus = 1000f / 30;
            salary += bonus;
        }
    }
}