//Task1
//for (int row = 1; row <= 6; ++row)
//{
//    for (int col = 1; col <= row; ++col)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine();
//}

//Task2
//for (int i = 0; i <= 4; i++)
//{
//    for (int j = 0; j <= 4; j++)
//    {
//        if (i == 0 || i == 4 || j == 0 || j == 4)
//        {
//            Console.Write("*");
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine();
//}

//Task3
//for (int i = 1; i < 5; i++)
//{
//	for (int j = 1; j < 5; j++)
//	{
//		Console.Write("* ");
//	}
//	Console.WriteLine();
//}

//Task4
for (int j = 1; j <= 10; j++)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.Write($"{0}*{1}={2}\t", i, j, (i * j));
    }
    Console.WriteLine();
}