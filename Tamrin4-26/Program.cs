//Console.WriteLine("Enter The Column");
//int c = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter The Row");
//int r = Convert.ToInt32(Console.ReadLine());
//int[,] values = new int[c, r];
//int[,] expected = new int[r, c];
//Console.WriteLine("Enter The Matrix");
//for (int i = 0; i < c; i++)
//{
//    for (int j = 0; j < r; j++)
//    {
//        values[i, j] = Convert.ToInt32(Console.ReadLine());
//    }
//}
//for (int i = 0; i < r; i++)
//{
//    for (int j = 0; j < c; j++)
//    {
//        expected[i, j] = values[j, i];
//    }
//}
//for (int i = 0; i < r; i++)
//{
//    Console.WriteLine(" ");
//    for (int j = 0; j < c; j++)
//    {
//        Console.Write(expected[i, j] + " ");
//    }
//}

//-------------------Part2--------------------
Console.WriteLine("How Many Times Do u Want to Rotate? ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = { 1, 2, 3, 4, 5 };
int[] res = new int[arr.Length];
int temp = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i < arr.Length - 1)
        {
            temp = arr[i];
            res[i] = arr[i + 1];
            
        }
    }
    res[arr.Length - 1] = temp;
}

foreach (int i in res)
{
    Console.Write(i + " ");
}