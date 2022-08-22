// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) int rusult = arg2;
//     if (arg3 > result) int rusult = arg3;
//     return result;
// }


int a1 = 15;
int b1 = 175;
int c1 = -45;
int a2 = 874;
int b2 = 263;
int c2 = 17;
int a3 = 22;
int b3 = 5;
int c3 = 40;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;
 
if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

System.Console.WriteLine(max);