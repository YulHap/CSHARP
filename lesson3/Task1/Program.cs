double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator; // чтобы сохранить дробную часть, сменим тип данных одной из переменных на тип double (сменим у numenator)
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
System.Console.WriteLine(result);
