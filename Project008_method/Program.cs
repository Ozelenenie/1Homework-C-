//метод поиска максимума из трёх чисел
int Max(int arg1, int arg2, int arg3); 
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}


int a = 23;
int a2 = 12;
int a3 = 10 ;
int b =24;
int b2 = 15;
int b3 = 17;
int c = 5;
int c2 =22;
int c3 =11;

int max1 = Max(a,b,c);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3,c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);