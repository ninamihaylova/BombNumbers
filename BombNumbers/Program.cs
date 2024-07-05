class BombNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int[] bombParams = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int bombNumber = bombParams[0];
        int bombPower = bombParams[1];

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombNumber)
            {
                int start = Math.Max(0, i - bombPower);
                int end = Math.Min(numbers.Count - 1, i + bombPower);

                numbers.RemoveRange(start, end - start + 1);
                i = 0;
            }
        }

        int sum = numbers.Sum();
        Console.WriteLine(sum);
    }
}