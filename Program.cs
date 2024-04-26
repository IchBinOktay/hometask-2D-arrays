
//int[,] array =
//{
//    {10,30,50},
//    {20,40,60},
//    {70,80,90}

//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i,j] + " ");
//    }
//    Console.WriteLine();
//}



//int sum = 0;
//int[,] array =
//{
//    {30,60,10},
//    {20,40,80},
//    {70, 50,90}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum += array[i, j];
//    }
//}
//Console.WriteLine(sum);


//int sum = 0;
//int[,] array =
//{
//    {30,60,10},
//    {20,40,80},
//    {70, 50,90}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int j = 0;
//    sum += array[i,j];

//}
//Console.WriteLine(sum);



//int[,] array =
//{
//    {30,-60,10},
//    {-20,40,-80},
//    {70, 50,-90}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i,j]<0)
//        { Console.WriteLine(array[i,j]); }
//    }
//}




//int[,] array =
//{
//    {30,-60,10},
//    {-20,40,-80},
//    {70, 50,-90}
//};
//int max = 0;
//int min = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] > max)
//        { max = array[i, j]; }
//        if (array[i, j] < min) 
//        { min = array[i, j]; }
//    }
//}
//Console.WriteLine(max);
//Console.WriteLine(min);

//????????????????????????????????????????????????????????????????????????????????????????
//int[,] array =
//{
//    {30,60,10},
//    {20,40,80},
//    {70, 50,90}
//};
//int tek = 1;
//int cut = 2;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] %2 == 0)
//        { cut = array[i, j]; }

//         if (array[i, j] %2==1)
//        { tek = array[i, j]; }


//    Console.WriteLine(tek + " ");
//    Console.Write(cut + " ");
//        }
//}
//?????????????????????????????????????????????????????????????????????????????????

//int[,] array =
//{
//    {30,60,10,44},
//    {20,40,80,93},
//    {70,50,90,76},
//    {25,65,97,12 }
//};

//for (int j = 0; j < array.GetLength(1); j++)
//{
//    array[1, j] = 0;
//}
//    for (int i = 0; i < array.GetLength(0); i++)
//    { 
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//        Console.Write(array[i, j] + " ");
//        }
//    Console.WriteLine();
//    }




//int[,] array =
//{
//    {30,60,10},
//    {20,40,80},
//    {70,50,90},
//};
//for (int i = 0; i < array.GetLength(0); i++)

//{
//    array[2,i] = 0;
//}
//for (int j = 0; j < array.GetLength(1); j++)
//{
//    for (int i = 0; i < array.GetLength(1); i++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}



//int sum = 0;
//int[,] array =
//{
//    {30,60,10},
//    {20,40,80},
//    {70,50,90},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            sum += array[i, j];
//        }
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine(sum);




//int[,] array = {
//{30,60,10,44},
//{20,40,80,93},
//{70,50,90,76},
//{25,65,97,12 }
//               };

//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)

//        if (i + j == 3)
//        {  sum += array[i,j]; }

//}

//Console.WriteLine(sum);




//int[,] array =
//{
//    {30,60,10,44,53},
//    {20,40,80,93,71},
//    {70,50,90,76,91},
//    {25,72,21,57,21},
//    {25,65,97,12,27 }
//};
//for (int i = 0; i < array.GetLength(0); i++)

//{
//    for (int j = 0; j <i; j++)
//    array[j, i] = 0;
//}
//for (int j = 0; j < array.GetLength(1); j++)
//{
//    for (int i = 0; i < array.GetLength(1); i++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}





//int[,] array =
//{
//    {30,60,10,44,53},
//    {20,40,80,93,71},
//    {70,50,90,76,91},
//    {25,72,21,57,21},
//    {25,65,97,12,27 }
//};
//for (int i = 0; i < array.GetLength(0); i++)

//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (j > i)
//        {
//            array[i, j] = 0;
//        }
//    }
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}



//int[,] array1 = {
//   {30,60,10},
//   {20,40,80},
//   {70,50,90}
//    };

//int[,] array2 = {
//            {90, 85, 97},
//            {26, 45, 54},
//            {83, 25, 21}
//        };

//int n = array1.GetLength(0);
//int[,] sumArray = new int[n, n];

//Console.WriteLine("Sum Array:");
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        sumArray[i, j] = array1[i, j] + array2[i, j];
//        Console.Write(sumArray[i, j] + " ");
//    }
//    Console.WriteLine();
//}



//int[,] array = {
//    { 30, 60,10 },
//    { 20, 40, 80 },
//    { 70, 50, 90 }
//};

//Console.WriteLine("her bir row-un cemi");
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int rowSum = 0;
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        rowSum += array[i, j];
//    }
//    Console.WriteLine($"Row {i + 1}: {rowSum}");
//}



//int[,] array = {
//    { 30, 60,10 },
//    { 20, 40, 80 },
//    { 70, 50, 90 }
//};

//Console.WriteLine("her bir column-in cemi:");
//for (int j = 0; j < array.GetLength(1); j++)
//{
//    int columnSum = 0;
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        columnSum += array[i, j];
//    }
//    Console.WriteLine($"Column {j + 1}: {columnSum}");
//}




//int[,] arr = {
//   {1, 1, 0, 0, 1, 1},
//   {1, 1, 0, 0, 1, 1},
//   {1, 1, 0, 0, 1, 1},
//   {1, 1, 0, 0, 1, 1}
//};

//int shift = 3;
//for (int i = 0; i<arr.GetLength(0); i++)
//{
//    for (int j = arr.GetLength(1)-1; j>= 0; j--)
//    {
//        if (j - shift >= 0)
//        {
//            arr[i, j] = arr[i, j - shift];
//        }
//        else
//            arr[i, j] = 0;
//    }
//}

//for (int i = 0;i<arr.GetLength(0); i++)
//{
//    for(int j=0; j<arr.GetLength(1); j++)
//    {
//        Console.Write($"{arr[i,j]}");
//    }
//    Console.WriteLine();
//}




//int[,] array1 = { 
//    { 3, 6 },
//    { 2, 4 }
//};
//int[,] array2 = { 
//    { 8, 5 },
//    { 7, 9 }
//};
//int[,] ArrayHasili = new int[array1.GetLength(0), array1.GetLength(1)];

//for (int i = 0; i < array1.GetLength(0); i++)
//{
//    for (int j = 0; j < array1.GetLength(1); j++)
//    {
//        ArrayHasili[i, j] = array1[i, j] * array2[i, j];
//        Console.Write(ArrayHasili[i, j] + " ");
//    }
//    Console.WriteLine();
//}
