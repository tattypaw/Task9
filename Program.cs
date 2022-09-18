// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
/*
// Ввод данных
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()??"");
    return num;
}

//Вывод данных
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

//формирование строки чисел от M до N (рекурсия)
string RecursMToN(int M, int N)
{
    //остановка рекурсии
    if(N<=M)
    {
        return N.ToString();
    }
    //рекурсия
    else{
        string outline = M + " " + RecursMToN(M+1, N);
        return outline;
    }
}

int inputM = ReadData("Введите число M: ");
int inputN = ReadData("Введите число N: ");
//проверка какое из чисел больше и вызов рекурсии
string outLine = (inputM < inputN) ? RecursMToN (inputM, inputN) : RecursMToN (inputN, inputM) ;
PrintData("Числа от M до N: ", outLine);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
//Ввод данных
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()??"");
    return num;
}
//Вывод данных
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}
//Вычисление суммы от M до N
int SumMN(int M, int N)
{
    //Точка остановки
    if(N <= M) return N;
    //Рекурсия
    else{
    return M + SumMN(M+1, N);
    }
}

int inputM = ReadData("Введите число: ");
int inputN = ReadData("Введите число: ");
int sumMN = 0;
//определение порядка чисел
if (inputM < inputN) sumMN = SumMN(inputM, inputN);
else sumMN = SumMN(inputN, inputM);
PrintData("Сумма чисел от M до N: ", sumMN.ToString());
*/
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

//Ввод данных
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()??"");
    return num;
}

//Вывод данных
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

// функция Аккермана
long AkkermanFunc(long numM, long numN)
{
    if(numM == 0) return numN + 1;
    if(numM >0 & numN == 0)
    {
        return AkkermanFunc (numM - 1, 1);
    }
    else{
        return AkkermanFunc (numM - 1, AkkermanFunc(numM, numN - 1));
    }
}


long inputNumM = ReadData("Введите число M: ");
long inputNumN = ReadData("Введите число N: ");
long resAkk = AkkermanFunc(inputNumM, inputNumN);
PrintData("Значение функции Аккермана: ", resAkk.ToString());
