Console.Write($"Введи количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

int moreZero = 0;

for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    if(massiveNumbers[i] > 0)
    {
      moreZero = moreZero + 1; 
    }
  }
Console.Write("Количество чисел больше 0: " + moreZero);

