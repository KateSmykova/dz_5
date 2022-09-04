Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine()); 

int RandomNum(int num, int min, int max)
  {
  int[] randomNum = new int[num];
  int sumEl = 0;
  Console.Write("Массив: ");

    for (int i = 0; i <randomNum.Length; i++ )
    {
      randomNum[i] = new Random().Next(min, max);

      Console.Write(randomNum[i] + " ");

      if (i % 2 != 1)
      {
        sumEl+=randomNum[i];
      }
    }
  return sumEl;
  }
int randomNum =  RandomNum(num, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNum}");