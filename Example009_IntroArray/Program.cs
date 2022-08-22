int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result)
    {
        result = arg2;
    }
    if (arg3 > result)
    {
        result = arg3;
    }
    return result;
}

int[] array = { 18, 63, 48, 53, 68, 78, 18, 98, 73, 56 };
array[7] = 120;


int result = Max(
    Max(array[0], array[1], array[3]), 
    Max(array[4], array[5], array[6]), 
    Max(array[7], array[8], array[9]));


System.Console.WriteLine(result);