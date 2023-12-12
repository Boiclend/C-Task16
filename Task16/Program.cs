// Результаты соревнований по прыжкам в длину представлены в виде матрицы 5х3 
// (5 спортсменов по 3 попытки у каждого). Указать, какой спортсмен и в какой попытке показал наилучший результат.


double[,] sportResults = new double[5,3];
fillArray(sportResults);
findMinRes(sportResults);


double[,] fillArray(double[,] arr) {
    Console.WriteLine("Введите результаты совернований: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    { 
        Console.Write($"Для {i+1} спортсмена: ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = double.Parse(Console.ReadLine());
        }
    }
    return arr;
}

void findMinRes(double[,] arr) {
    double max = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    { 
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(max < arr[i,j]) {
                max = arr[i,j];
            }
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    { 
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(max == arr[i,j]) {
                Console.WriteLine($"Лучший результат у спортсменов: \n № спортсмена {i+1} \n № попытки {j+1}");
            }
        }
    }

}