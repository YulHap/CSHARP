int n = 5;
int[] array = { 2, 4, 7, 3, 9 };
int i = 0;
int max = array[0];
while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.Writeline(max);
//error CS0117: "Console" не содержит определение для "Writeline". 
//Ошибка сборки. Устраните ошибки сборки и повторите попытку.