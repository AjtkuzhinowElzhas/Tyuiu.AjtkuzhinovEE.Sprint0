namespace Tyuiu.AjtkuzhinovEE.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        //Пример циклической  структуры (цикл с параметрами) for

        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            return total;




        }

        //Пример циклической структуры (цикл с предусловием) while
        public static object SubtractionArray(int[] numbers)
        {
            var tota1 = 0;
            int index = 0;

            while (index < numbers.Length)
            {
                tota1 = tota1 - numbers[index];
                index++;
            }
            return tota1;
        }

        //Пример циклической структуры (цикл с постусловием) do while
        public static object MultiplicationArray(int[] numbers)
        {
            var tota1 = 1;
            int index = 0;
            do
            {
                tota1 = tota1 * numbers[index];
                index++;
            }
            while (index < numbers.Length);

            return tota1;
        }


    }
}
