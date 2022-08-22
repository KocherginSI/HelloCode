int[] array = { 18, 63, 48, 53, 68, 78, 18, 98, 73, 56 };
array[7] = 120;

int n = array.Length;
int find = 18;

int index = 0;
while(index < n)
{
    
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
    
}
