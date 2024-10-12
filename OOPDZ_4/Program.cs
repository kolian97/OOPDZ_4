
//4 задача решение через hashset
//величайший недостаток в том что числа не могут повторяться из-за этого массив с одинаковыми числами подсчитает не корректно
class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { -2, 10, 2, 31, 4, 5, 16, 7, 8, 9 };
        int target = 29;
        HashSet<int> set = new HashSet<int>();
        for (int j = 0; j < arr.Length; j++)
        {
            foreach (int i in arr)
            {
                if (set.Contains(target - i - arr[j]) && i != arr[j] && target - i - arr[j] != i
                    && target - i - arr[j] != arr[j])//т.к. числа всеравно не могут быть одинаковыми исключаем повторения
                {
                    Console.WriteLine($"числа = {target - i - arr[j]},{i},{arr[j]}");
                    return;
                }
                else
                {
                    set.Add(i);
                }
            }
        }
        Console.WriteLine("Числа не найдены");
    }
}

//4 задача решение через for
//тут числа в массиве могут повторяться но for многовато
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arr = new int[] { -2, 10, 10, 2, 31, 4, 5, 16, 7, 8, 9 };
//        int target = 29;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            for (int j = 0; j < arr.Length; j++)
//            {
//                if (i == j)
//                    continue;
//                for (int k = 0; k < arr.Length; k++)
//                {
//                    if (i == k || j == k)
//                        continue;
//                    if (arr[i] + arr[j] + arr[k] == target)
//                    {
//                        Console.WriteLine($"Числа = {arr[i]},{arr[j]},{arr[k]}");
//                        return;
//                    }

//                }
//            }

//        }
//        Console.WriteLine("Числа не найдены");
//    }
//}