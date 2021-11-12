using System;

namespace Lib_6
{
    public class Calculate
    {
        public string GenerateRandomX(out string result)
        {
            Random random = new();
            int x = int.MaxValue, saveX;
            result = string.Empty;
            do
            {
                saveX = x;
                x = random.Next(-5, 5);
                if(x > 0)
                {
                    result += $"Сгенерировано: {x}  |  Результат: {Math.Round(Math.Sqrt(x),3)} \n";
                }
                else if (x < 0)
                {
                    result += $"Сгенерировано: {x}  | Результат: {Math.Pow(x, 2)} \n";
                }
            } while (saveX != x);
            return result;
        }
    }
}
