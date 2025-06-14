using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Xml.XPath;

namespace Bee;

class Program
{
    static void Main(string[] args)
    {
        Bee_2552();
    }

    // 1095 - Sequence I
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1095
    static void Bee_1095()
    {
        int i = 1;
        for (int j = 60; j >= 0; j -= 5)
        {
            Console.WriteLine($"I={i} J={j}");
            i += 3;
        }
    }

    // 1096 - Sequence II
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1096
    static void Bee_1096()
    {
        for (int i = 1; i <= 9; i += 2)
        {
            for (int j = 7; j >= 5; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }

    // 1097 - Sequence III
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1097
    static void Bee_1097()
    {
        int controller = 7;
        int controllerF = 5;
        for (int i = 1; i <= 9; i += 2)
        {
            for (int j = controller; j >= controllerF; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
            controller += 2;
            controllerF += 2;
        }
    }

    // 1097 - Sequence III (Alternative Version)
    // This version uses a different approach to calculate the values of J dynamically
    /*static void Bee_1097_Alternative()
    {
        for (int i = 1; i <= 9; i += 2)
        {
            for (int j = i + 6; j >= i + 4; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }*/


    // 1098 - Sequence IV
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1098
    static void Bee_1098()
    {
        for (double i = 0.0; i <= 2.0; i += 0.2)
        {
            for (double j = 1.0; j <= 3.0; j++)
            {
                if ((Math.Abs(i - Math.Round(i)) < 0.0001) && (Math.Abs(j - Math.Round(j)) < 0.0001))
                {
                    Console.WriteLine($"I={i:F0} J={j + i:F0}");
                }
                else
                {
                    Console.WriteLine($"I={i:F1} J={j + i:F1}");
                }
            }
        }
    }

    // Bee 1099 - Sequence V
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1099
    static void Bee_1099()
    {
        try
        {
            string input = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            int n = int.Parse(input);
            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine() ?? string.Empty;
                if (string.IsNullOrEmpty(numbers))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                string[] nums = numbers.Split(' ');
                int sum = 0;

                if (nums.Length != 2)
                {
                    Console.WriteLine(sum);
                    continue;
                }

                int x = int.Parse(nums[0]);
                int y = int.Parse(nums[1]);

                if (x < 0 || y < 0)
                {
                    Console.WriteLine(sum);
                }

                if (x > y)
                {
                    for (int j = y + 1; j < x; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sum += j;
                        }
                    }
                }
                else
                {
                    for (int j = x + 1; j < y; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sum += j;
                        }
                    }
                }
                Console.WriteLine(sum);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    // Bee 1150 - Exponential Growth
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1150
    static void Bee_1150()
    {
        int x = int.Parse(Console.ReadLine() ?? string.Empty);

        int z = 0;
        do
        {
            z = int.Parse(Console.ReadLine() ?? string.Empty);
        } while (z <= x);

        int sum = 0;
        int count = 0;

        for (int i = x; sum <= z; i++)
        {
            sum += i;
            count++;
        }

        Console.WriteLine(count);
    }

    // Bee 1156 - Fibonacci Array
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1156
    static void Bee_1156()
    {
        int y = 1;
        double sum = 0.0;
        for (int x = 1; x <= 39; x += 2)
        {
            sum += (double)x / y;
            y *= 2;
        }
        Console.WriteLine($"{sum:F2}");
    }


    // Bee 1160
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1160
    static void Bee_1160()
    {
        try
        {
            string first = Console.ReadLine() ?? string.Empty;
            int cases = int.Parse(first);
            for (int i = 0; i < cases; i++)
            {
                string[] case2 = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
                int firstValue = int.Parse(case2[0]);
                int secondValue = int.Parse(case2[1]);
                double thristValue = double.Parse(case2[2], CultureInfo.InvariantCulture);
                double fourthValue = double.Parse(case2[3], CultureInfo.InvariantCulture);

                int years = 0;

                while (firstValue <= secondValue && years <= 100)
                {
                    firstValue += (int)(firstValue * (thristValue / 100));
                    secondValue += (int)(secondValue * (fourthValue / 100));
                    years++;
                }

                if (years > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine($"{years} anos.");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    // Bee 1180 - Array Manipulation
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1180
    static void Bee_1180()
    {
        int quantity = int.Parse(Console.ReadLine() ?? string.Empty);
        string[] numbers = Console.ReadLine()?.Split(' ') ?? Array.Empty<string>();
        int[] numbersInt = new int[quantity];
        for (int i = 0; i < quantity; i++)
        {
            numbersInt[i] = int.Parse(numbers[i]);
        }

        Console.WriteLine($"Menor valor: {numbersInt.Min()}");
        Console.WriteLine($"Posicao: {Array.IndexOf(numbersInt, numbersInt.Min())}");
    }

    // Bee 1181 - Row of a Matrix
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1181
    // Example using Linq Sum() for calculating the sum of a row in a matrix
    static void Bee_1181()
    {
        int row = int.Parse(Console.ReadLine() ?? string.Empty);
        char operation = char.Parse(Console.ReadLine() ?? string.Empty);
        double[][] matrix = new double[12][];
        double sum = 0.0;
        for (int i = 0; i < 12; i++)
        {
            matrix[i] = new double[12]; // initialize matrix row

            for (int j = 0; j < 12; j++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                matrix[i][j] = double.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        sum = matrix[row].Sum();
        if (operation == 'S')
        {
            Console.WriteLine($"{sum:F1}");
        }
        else if (operation == 'M')
        {
            Console.WriteLine($"{sum / 12:F1}");
        }
    }


    // Example using For to calculate the sum of a row in a matrix
    /*
        static void Bee_1181_Alternative()
        {
            int row = int.Parse(Console.ReadLine() ?? string.Empty);
            char operation = char.Parse(Console.ReadLine() ?? string.Empty);
            double[,] matrix = new double[12, 12];
            double sum = 0.0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    string input = Console.ReadLine() ?? string.Empty;
                    matrix[i, j] = double.Parse(input, CultureInfo.InvariantCulture);
                }
            }

            for (int x = 0; x < 12; x++)
            {
                sum += matrix[row, x];
            }

            
            if (operation == 'S')
            {
                Console.WriteLine($"{sum:F1}");
            }
            else if(operation == 'M')
            {
                double average = sum / 12;
                Console.WriteLine($"{average:F1}");
            }
        }
    */

    // Bee 1564 - Vai ter Copa ?
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1564
    static void Bee_1564()
    {
        string line;
        while ((line = Console.ReadLine() ?? string.Empty) != string.Empty)
        {
            int number = int.Parse(line);
            if (number == 0)
            {
                Console.WriteLine("vai ter copa!");
            }
            else if (number != 0)
            {
                Console.WriteLine("vai ter duas!");
            }
        }
    }

    // Bee 1182 - Column of a Matrix
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1182
    static void Bee_1182()
    {
        int col = int.Parse(Console.ReadLine() ?? string.Empty);
        char operation = char.Parse(Console.ReadLine() ?? string.Empty);
        double[,] matrix = new double[12, 12];
        double sum = 0.0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                matrix[i, j] = double.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        for (int x = 0; x < 12; x++)
        {
            sum += matrix[x, col];
        }


        if (operation == 'S')
        {
            Console.WriteLine($"{sum:F1}");
        }
        else if (operation == 'M')
        {
            double average = sum / 12;
            Console.WriteLine($"{average:F1}");
        }
    }

    // Bee 1183 - Above the Main Diagonal
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1183
    static void Bee_1183()
    {
        char operation = char.Parse(Console.ReadLine() ?? string.Empty);
        double[,] matrix = new double[12, 12];
        double sum = 0.0;
        int count = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                matrix[i, j] = double.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                if (j > i)
                {
                    sum += matrix[j, i];
                    count++;
                }
            }
        }

        if (operation == 'S')
        {
            Console.WriteLine($"{sum:F1}");
        }
        else if (operation == 'M')
        {
            double average = sum / count;
            Console.WriteLine($"{average:F1}");
        }
    }


    // Bee 1184 - Below the Main Diagonal
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1184
    static void Bee_1184()
    {
        char operation = char.Parse(Console.ReadLine() ?? string.Empty);
        double[,] matrix = new double[12, 12];
        double sum = 0.0;
        int count = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                matrix[i, j] = double.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                if (j > i)
                {
                    sum += matrix[j, i];
                    count++;
                }
            }
        }

        if (operation == 'S')
        {
            Console.WriteLine($"{sum:F1}");
        }
        else if (operation == 'M')
        {
            double average = sum / count;
            Console.WriteLine($"{average:F1}");
        }
    }

    // Bee 1185 - Below the Secondary Diagonal
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1185
    static void Bee_1185()
    {
        char operation = char.Parse(Console.ReadLine() ?? string.Empty);
        double[,] matrix = new double[12, 12];
        double sum = 0.0;
        int count = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                matrix[i, j] = double.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                if (i + j < 11)
                {
                    sum += matrix[i, j];
                    count++;
                }
            }
        }

        if (operation == 'S')
        {
            Console.WriteLine($"{sum:F1}", CultureInfo.InvariantCulture);
        }
        else if (operation == 'M')
        {
            double average = sum / count;
            Console.WriteLine($"{average:F1}", CultureInfo.InvariantCulture);
        }
    }

    // Bee 1186 - Above the Secondary Diagonal
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1186
    static void Bee_1186()
    {
        char operation = char.Parse(Console.ReadLine() ?? string.Empty);
        double[,] matrix = new double[12, 12];
        double sum = 0.0;
        int count = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                matrix[i, j] = double.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                if (i + j > 11)
                {
                    sum += matrix[i, j];
                    count++;
                }
            }
        }

        if (operation == 'S')
        {
            Console.WriteLine($"{sum:F1}", CultureInfo.InvariantCulture);
        }
        else if (operation == 'M')
        {
            double average = sum / count;
            Console.WriteLine($"{average:F1}", CultureInfo.InvariantCulture);
        }
    }

    // Bee 1187 - Above the Main Diagonal
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1187
    static void Bee_1187()
    {
        char operation = char.Parse(Console.ReadLine() ?? string.Empty);
        double[,] matrix = new double[12, 12];
        double sum = 0.0;
        int count = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                matrix[i, j] = double.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 11 - i; j++)
            {
                sum += matrix[i, j];
                count++;
            }
        }

        if (operation == 'S')
        {
            Console.WriteLine($"{sum:F1}", CultureInfo.InvariantCulture);
        }
        else if (operation == 'M')
        {
            double average = sum / count;
            Console.WriteLine($"{average:F1}", CultureInfo.InvariantCulture);
        }
    }


    // Bee 1188 - Below the Main Diagonal
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1188
    static void Bee_1188()
    {
        char operation = char.Parse(Console.ReadLine() ?? string.Empty);
        double[,] matrix = new double[12, 12];
        double sum = 0.0;
        int count = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                matrix[i, j] = double.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        for (int i = 7; i < 12; i++)
        {
            var initial = i - 6;
            var end = 12 - (i - 6);
            for (int j = initial; j < end; j++)
            {
                sum += matrix[i, j];
                count++;
            }
        }

        if (operation == 'S')
        {
            Console.WriteLine($"{sum:F1}", CultureInfo.InvariantCulture);
        }
        else if (operation == 'M')
        {
            double average = sum / count;
            Console.WriteLine($"{average:F1}", CultureInfo.InvariantCulture);
        }
    }

    // Bee 1189 - Below the Secondary Diagonal
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1189
    static void Bee_1189()
    {
        char operation = char.Parse(Console.ReadLine() ?? string.Empty);
        double[,] matrix = new double[12, 12];
        double sum = 0.0;
        int count = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                matrix[i, j] = double.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        for (int i = 1; i < 11; i++)
        {
            int end = (i <= 5) ? i : 11 - i;
            for (int j = 0; j < end; j++)
            {
                sum += matrix[i, j];
                count++;
            }
        }

        if (operation == 'S')
        {
            Console.WriteLine($"{sum:F1}", CultureInfo.InvariantCulture);
        }
        else if (operation == 'M')
        {
            double average = sum / count;
            Console.WriteLine($"{average:F1}", CultureInfo.InvariantCulture);
        }
    }

    // Bee 1190 - Above the Secondary Diagonal
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1190
    static void Bee_1190()
    {
        char operation = char.Parse(Console.ReadLine() ?? string.Empty);
        double[,] matrix = new double[12, 12];
        double sum = 0.0;
        int count = 0;
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                string input = Console.ReadLine() ?? string.Empty;
                matrix[i, j] = double.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        for (int i = 1; i < 11; i++)
        {
            int initial = (i <= 5) ? 12 - i : i + 1;
            for (int j = initial; j < 12; j++)
            {
                sum += matrix[i, j];
                count++;
            }
        }

        if (operation == 'S')
        {
            Console.WriteLine($"{sum:F1}", CultureInfo.InvariantCulture);
        }
        else if (operation == 'M')
        {
            double average = sum / count;
            Console.WriteLine($"{average:F1}", CultureInfo.InvariantCulture);
        }
    }

    // Bee 1534
    // https://judge.beecrowd.com/pt/problems/view/1534
    static void Bee_1534()
    {
        string? linha;
        while ((linha = Console.ReadLine()) != null)
        {
            int n = int.Parse(linha);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("2");
                    }
                    else if (i + j == n - 1)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("3");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    // Bee 1541
    // https://judge.beecrowd.com/pt/problems/view/1541
    static void Bee_1541()
    {
        while (true)
        {
            string numbers = Console.ReadLine() ?? string.Empty;
            string[] arrayNumbers = numbers.Split(' ');
            int number1 = int.Parse(arrayNumbers[0]);
            if (number1 == 0) break;
            int number2 = int.Parse(arrayNumbers[1]);
            int number3 = int.Parse(arrayNumbers[2]);

            int value = (int)Math.Sqrt((number1 * number2 * (100.0 / number3)) + 0.5);
            Console.WriteLine(value);
        }
    }

    // Bee 1589
    // https://judge.beecrowd.com/pt/problems/view/1589
    static void Bee_1589()
    {
        int cases = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < cases; i++)
        {
            string numbers = Console.ReadLine() ?? string.Empty;
            string[] arrayNumbers = numbers.Split(' ');
            int number1 = int.Parse(arrayNumbers[0]);
            int number2 = int.Parse(arrayNumbers[1]);
            int total = number1 + number2;
            Console.WriteLine(total);
        }
    }

    // Bee 1759
    // https://judge.beecrowd.com/pt/problems/view/1759
    static void Bee_1759()
    {
        int caso = int.Parse(Console.ReadLine() ?? string.Empty);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < caso; i++)
        {
            sb.Append("Ho");
            if (i < caso - 1) sb.Append(" ");
        }
        sb.Append("!");
        Console.Write(sb.ToString());
    }

    // Bee 1828 Bazinga
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1828
    static void Bee_1828()
    {
        int cases = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 1; i <= cases; i++)
        {
            string spock = Console.ReadLine() ?? string.Empty;
            string[] arraySpock = spock.Split(' ');
            string first = arraySpock[0].ToLower();
            string second = arraySpock[1].ToLower();
            if (first == second)
            {
                Console.WriteLine($"Caso #{i}: De novo!");
            }
            else if (
                (first == "tesoura" && (second == "papel" || second == "lagarto")) ||
                (first == "papel" && (second == "pedra" || second == "spock")) ||
                (first == "pedra" && (second == "lagarto" || second == "tesoura")) ||
                (first == "lagarto" && (second == "spock" || second == "papel")) ||
                (first == "spock" && (second == "tesoura" || second == "pedra"))
            )
            {
                Console.WriteLine($"Caso #{i}: Bazinga!");
            }
            else
            {
                Console.WriteLine($"Caso #{i}: Raj trapaceou!");
            }
        }
    }

    // Bee 1435 - Matrix
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1435
    static void Bee_1435()
    {
        do
        {
            int n = int.Parse(Console.ReadLine() ?? string.Empty);
            if (n == 0) break;
            int[,] matrix = new int[n, n];

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                int value = i + 1;
                for (int j = 1; j < n - i; j++)
                {
                    for (int c = 1; c < n - i; c++)
                    {
                        matrix[j, c] = value;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0) Console.Write($"{matrix[i, j],3}");
                    else Console.Write($" {matrix[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        } while (true);
    }

    // Bee 1478 - Square Matrix
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1478
    static void Bee_1478()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            if (n == 0) break;

            int[,] matriz = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int value = Math.Abs(i - j) + 1;
                    if (j == 0) Console.Write($"{value,3}");
                    else Console.Write($" {value,3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    // Bee 1557 - Matrix of Numbers
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1557
    static void Bee_1557()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            if (n == 0) break;

            int max = (int)Math.Pow(2, (n - 1) * 2);
            int T = max.ToString().Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int value = (int)Math.Pow(2, i + j);
                    if (j == 0) Console.Write(value.ToString().PadLeft(T));
                    else Console.Write(" " + value.ToString().PadLeft(T));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    // Bee 1789
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1789
    static void Bee_1789()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            string? v = Console.ReadLine();
            int[] velocidades = Array.Empty<int>();
            if (string.IsNullOrEmpty(v))
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                velocidades = Array.ConvertAll(v.Split(' '), int.Parse);
            }

            int maxNumber = velocidades.Max();
            if (maxNumber < 10)
            {
                Console.WriteLine("1");
            }
            else if (maxNumber >= 10 && maxNumber < 20)
            {
                Console.WriteLine("2");
            }
            else if (maxNumber > 20)
            {
                Console.WriteLine("3");
            }
        }
    }

    // Bee 1837
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1837
    static void Bee_1837()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] numbers = line.Split();
            int first = int.Parse(numbers[0]);
            int second = int.Parse(numbers[1]);

            int quocient = first / second;
            int remainder = first % second;

            if (remainder < 0)
            {
                quocient -= (second > 0) ? 1 : -1;
                remainder = first - second * quocient;
            }
            Console.WriteLine($"{quocient} {remainder}");
        }
    }

    // Bee 1847
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1847
    static void Bee_1847()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] numbers = line.Split();
            int first = int.Parse(numbers[0]);
            int second = int.Parse(numbers[1]);
            int third = int.Parse(numbers[2]);

            if (first > second && second <= third)
            {
                Console.WriteLine(":)");
            }
            else if (first < second && second >= third)
            {
                Console.WriteLine(":(");
            }
            else if (first < second && second < third && (third - second) < (second - first))
            {
                Console.WriteLine(":(");
            }
            else if (first < second && second < third && (third - second) >= (second - first))
            {
                Console.WriteLine(":)");
            }
            else if (first > second && second > third && (second - third) < (first - second))
            {
                Console.WriteLine(":)");
            }
            else if (first > second && second > third && (second - third) >= (first - second))
            {
                Console.WriteLine(":(");
            }
            else if (first == second && third > second)
            {
                Console.WriteLine(":)");
            }
            else
            {
                Console.WriteLine(":(");
            }
        }
    }

    // Bee 1848
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1848
    static void Bee_1848()
    {
        int total = 0;
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            if (line == "caw caw")
            {
                Console.WriteLine(total);
                total = 0;
            }
            else
            {
                int value = 0;
                switch (line)
                {
                    case "*--":
                        value = 4;
                        break;
                    case "-*-":
                        value = 2;
                        break;
                    case "--*":
                        value = 1;
                        break;
                    case "-**":
                        value = 3;
                        break;
                    case "*-*":
                        value = 5;
                        break;
                    case "**-":
                        value = 6;
                        break;
                    case "***":
                        value = 7;
                        break;
                }
                total += value;
            }
        }
    }

    // Bee 1858
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1858
    static void Bee_1858()
    {
        string? line = Console.ReadLine();
        string[] numbers = Console.ReadLine()!.Split();

        var arrayNumber = Array.ConvertAll(numbers, int.Parse);
        int minValue = arrayNumber.Min();
        int position = Array.IndexOf(arrayNumber, minValue);
        Console.WriteLine(position + 1);
    }

    // 1864
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1864
    static void Bee_1864()
    {
        string phrase = "LIFE IS NOT A PROBLEM TO BE SOLVED";
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine(phrase.Substring(0, n));
    }

    // Bee 1865
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1865
    static void Bee_1865()
    {
        int cases = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < cases; i++)
        {
            string[] input = Console.ReadLine()?.Split() ?? Array.Empty<string>();
            string name = input[0];

            if (name == "Thor")
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }

    // Bee 1866
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1866
    static void Bee_1866()
    {
        int cases = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < cases; i++)
        {
            int n = int.Parse(Console.ReadLine() ?? string.Empty);
            if (n % 2 == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }

    // Bee 1914
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1914
    static void Bee_1914()
    {
        int cases = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < cases; i++)
        {
            string[] input = Console.ReadLine()?.Split() ?? Array.Empty<string>();
            string[] numbers = Console.ReadLine()?.Split() ?? Array.Empty<string>();
            string first = input[0];
            string second = input[1];
            string third = input[2];
            string fourth = input[3];

            int firstNumber = int.Parse(numbers[0]);
            int secondNumber = int.Parse(numbers[1]);

            int sum = firstNumber + secondNumber;

            if (sum % 2 == 0)
            {
                if (second == "PAR")
                {
                    Console.WriteLine($"{first}");
                }
                else
                {
                    Console.WriteLine($"{third}");
                }
            }
            else
            {
                if (second == "IMPAR")
                {
                    Console.WriteLine($"{first}");
                }
                else
                {
                    Console.WriteLine($"{third}");
                }
            }
        }
    }

    // Bee 1924
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1924
    static void Bee_1924()
    {
        int cases = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < cases; i++)
        {
            string caseInput = Console.ReadLine() ?? string.Empty;
        }
        Console.WriteLine("Ciencia da Computacao");
    }


    // Bee 1929
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1929
    static void Bee_1929()
    {
        string[] numbers = Console.ReadLine()?.Split() ?? Array.Empty<string>();
        List<int> list = new List<int>();
        foreach (string number in numbers)
        {
            int value = int.Parse(number);
            list.Add(value);
        }

        bool isTriangle = false;
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                for (int k = j + 1; k < list.Count; k++)
                {
                    int a = list[i];
                    int b = list[j];
                    int c = list[k];

                    if (a + b > c && a + c > b && b + c > a)
                    {
                        isTriangle = true;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(isTriangle ? "S" : "N");
    }

    // Bee 1930
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1930
    static void Bee_1930()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
        int x = numbers[0];
        int y = numbers[1];
        int z = numbers[2];
        int k = numbers[3];
        int calc = (x + y + z + k) - 3;
        Console.WriteLine(calc);
    }

    // Bee 1933
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1933
    static void Bee_1933()
    {
        int[] casesInput = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
        int first = casesInput[0];
        int second = casesInput[1];

        if (first == second)
        {
            Console.WriteLine(first);
        }
        else if (first > second)
        {
            Console.WriteLine(first);
        }
        else
        {
            Console.WriteLine(second);
        }
    }

    // 1957
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1957
    static void Bee_1957()
    {
        int number = int.Parse(Console.ReadLine() ?? string.Empty);
        string hex = number.ToString("X");
        Console.WriteLine(hex);
    }

    // 1958
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1958
    static void Bee_1958()
    {
        string input = Console.ReadLine() ?? string.Empty;
        double number = double.Parse(input, CultureInfo.InvariantCulture);

        // verificando se o número é negativo e zero
        bool isNegativeZero = number == 0.0 && input.TrimStart().StartsWith("-");

        // se o numero for negativo ou zero, o sinal base será "-"
        string baseSign = number < 0 || isNegativeZero ? "-" : "+";

        // retornando o valor absoluto do numero
        double absNumber = Math.Abs(number);
        string scientific = absNumber.ToString("E4", CultureInfo.InvariantCulture);

        string[] parts = scientific.Split('E');
        string basePart = parts[0];
        string exponentPart = parts[1];

        int exponent = int.Parse(exponentPart, NumberStyles.AllowLeadingSign);
        string formattedExponent = exponent.ToString("+00;-00");

        Console.WriteLine($"{baseSign}{basePart}E{formattedExponent}");
    }

    // 1985
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1985
    static void Bee_1985()
    {
        int cases = int.Parse(Console.ReadLine() ?? string.Empty);
        double value = 0.0;
        for (int i = 0; i < cases; i++)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
            int caseMenu = numbers[0];
            int quantity = numbers[1];

            switch (caseMenu)
            {
                case 1001:
                    value += 1.50 * quantity;
                    break;
                case 1002:
                    value += 2.50 * quantity;
                    break;
                case 1003:
                    value += 3.50 * quantity;
                    break;
                case 1004:
                    value += 4.50 * quantity;
                    break;
                case 1005:
                    value += 5.50 * quantity;
                    break;
            }
        }
        Console.WriteLine(value.ToString("F2", CultureInfo.InvariantCulture));
    }

    // Bee 2029
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2029
    static void Bee_2029()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            double volume = double.Parse(line, CultureInfo.InvariantCulture);
            double diametro = double.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);

            double raio = diametro / 2.0;
            double area = 3.14 * raio * raio;
            double altura = volume / area;

            Console.WriteLine("ALTURA = {0:F2}", altura, CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = {0:F2}", area, CultureInfo.InvariantCulture);
        }
    }

    // Bee 2059
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2059
    static void Bee_2059()
    {
        int[] caseNumbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
        int p = caseNumbers[0];
        int j1 = caseNumbers[1];
        int j2 = caseNumbers[2];
        int r = caseNumbers[3];
        int a = caseNumbers[4];

        if (r == 1 && a == 1)
        {
            Console.WriteLine("Jogador 2 ganha!");
        }
        else if (r == 1 && a == 0)
        {
            Console.WriteLine("Jogador 1 ganha!");
        }
        else
        {
            int soma = j1 + j2;
            bool par = soma % 2 == 0;

            if ((par && p == 1) || (!par && p == 0))
            {
                Console.WriteLine("Jogador 1 ganha!");
            }
            else
            {
                Console.WriteLine("Jogador 2 ganha!");
            }
        }

    }

    // Bee 1973
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1973
    static void Bee_1973()
    {
        int case1 = int.Parse(Console.ReadLine() ?? string.Empty);
        long[] cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), long.Parse);
        bool[] visited = new bool[case1];

        int i = 0;
        while (i >= 0 && i < case1)
        {
            if (!visited[i])
            {
                visited[i] = true;
            }

            if (cases[i] == 0)
            {
                break;
            }

            long beforeAttack = cases[i];
            cases[i]--;

            if (beforeAttack % 2 == 0)
            {
                i--;
            }
            else
            {
                i++;
            }
        }

        int sumPos = visited.Count(v => v);
        long sum = cases.Sum();
        Console.WriteLine($"{sumPos} {sum}");
    }

    // Bee 1961
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1961
    static void Bee_1961()
    {
        int[] cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
        int n = cases[0];
        int n1 = cases[1];
        int[] cases1 = (Console.ReadLine() ?? "")
        .Split()
        .Where(s => !string.IsNullOrWhiteSpace(s))
        .Select(int.Parse)
        .ToArray();

        bool win = true;
        for (int i = 1; i < n1; i++)
        {
            if (Math.Abs(cases1[i] - cases1[i - 1]) > n)
            {
                win = false;
                break;
            }
        }

        Console.WriteLine(win ? "YOU WIN" : "GAME OVER");
    }

    // Bee 1960
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1960
    static void Bee_1960()
    {
        int number = int.Parse(Console.ReadLine() ?? string.Empty);
        string roman = Roman(number);
        Console.WriteLine(roman);
    }

    static string Roman(int number)
    {
        string[] thousand = { "", "M" };
        string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        return thousand[number / 1000] +
               hundreds[(number % 1000) / 100] +
               tens[(number % 100) / 10] +
               units[number % 10];

    }

    // Bee 1963
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1963
    static void Bee_1963()
    {
        float[] cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), float.Parse);
        float a = cases[0];
        float b = cases[1];
        float calc = ((b - a) / a) * 100.0f;
        Console.WriteLine($"{calc.ToString("F2", CultureInfo.InvariantCulture)}%");
    }

    // Bee 1959
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1959
    static void Bee_1959()
    {
        long[] cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), long.Parse);
        long n = cases[0];
        long l = cases[1];
        long p = n * l;
        Console.WriteLine(p);
    }

    // Bee 2028
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2028
    static void Bee_2028()
    {
        string? line;
        int count = 1;

        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            List<int> numbers = new List<int>();

            for (int i = 0; i <= n; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    numbers.Add(i);
                }
            }

            numbers.Insert(0, 0);
            int total = (n * (n + 1)) / 2 + 1;

            if (count > 1) Console.WriteLine();

            Console.WriteLine($"Caso {count}: {(total == 1 ? $"{total} numero" : $"{total} numeros")}");
            Console.WriteLine(string.Join(" ", numbers));

            count++;
        }
    }

    // Bee 2031
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2031
    static void Bee_2031()
    {
        int cases = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < cases; i++)
        {
            string? first = Console.ReadLine();
            string? second = Console.ReadLine();

            if (first == "ataque" && second == "ataque")
            {
                Console.WriteLine("Aniquilacao mutua");
            }

            if (first == "papel" && second == "papel")
            {
                Console.WriteLine("Ambos venceram");
            }

            if (first == "pedra" && second == "pedra")
            {
                Console.WriteLine("Sem ganhador");
            }
            else if (first == "ataque" && second == "pedra")
            {
                Console.WriteLine("Jogador 1 venceu");
            }
            else if (first == "papel" && second == "ataque")
            {
                Console.WriteLine("Jogador 2 venceu");
            }
            else if (first == "pedra" && second == "papel")
            {
                Console.WriteLine("Jogador 1 venceu");
            }
            else if (first == "papel" && second == "pedra")
            {
                Console.WriteLine("Jogador 2 venceu");
            }
            else if (first == "ataque" && second == "papel")
            {
                Console.WriteLine("Jogador 1 venceu");
            }
            else if (first == "pedra" && second == "ataque")
            {
                Console.WriteLine("Jogador 2 venceu");
            }
            else if (first == "papel" && second == "pedra")
            {
                Console.WriteLine("Jogador 1 venceu");
            }
            else if (first == "pedra" && second == "papel")
            {
                Console.WriteLine("Jogador 2 venceu");
            }

        }
    }

    // Bee 1962
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1962
    static void Bee_1962()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < n; i++)
        {
            int cases = int.Parse(Console.ReadLine() ?? string.Empty);
            long year = 2015 - cases;

            if (year < 0)
            {
                Console.WriteLine($"{Math.Abs(year - 1)} A.C.");
            }
            else if (year == 0)
            {
                Console.WriteLine("1 A.C.");
            }
            else
            {
                Console.WriteLine($"{year} D.C.");
            }
        }
    }

    // Bee 1983
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1983
    static void Bee_1983()
    {
        int cases = int.Parse(Console.ReadLine() ?? string.Empty);
        Dictionary<int, double> alunos = new Dictionary<int, double>();

        for (int i = 0; i < cases; i++)
        {
            string[] casesInput = Console.ReadLine()?.Split() ?? Array.Empty<string>();
            int aluno = int.Parse(casesInput[0]);
            double nota = double.Parse(casesInput[1]);
            alunos[aluno] = nota;
        }

        double maiorNota = alunos.Values.Max();

        if (maiorNota >= 8)
        {
            var key = alunos
            .Where(x => x.Value == maiorNota)
            .Select(x => x.Key)
            .FirstOrDefault();

            Console.WriteLine(key);
        }
        else
        {
            Console.WriteLine("Minimum note not reached");
        }
    }

    // Bee 1984
    // https://www.urionlinejudge.com.br/judge/en/problems/view/1984
    static void Bee_1984()
    {
        char[] array = Console.ReadLine()?.ToCharArray() ?? Array.Empty<char>();
        Array.Reverse(array);
        Console.WriteLine(new string(array));
    }

    // Bee 2003
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2003
    static void Bee_2003()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] numbers = line.Split(':');
            int h = int.Parse(numbers[0]);
            int m = int.Parse(numbers[1]);

            int acordou = h * 60 + m;
            int chegada = acordou + 60;
            int atraso = chegada - 480; // 480 = 8:00

            if (atraso < 0)
            {
                atraso = 0;
            }

            Console.WriteLine($"Atraso maximo: {atraso}");
        }
    }

    // Bee 2057
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2057
    static void Bee_2057()
    {
        int[] cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
        int s = cases[0];
        int t = cases[1];
        int f = cases[2];
        int total = s + t + f;

        if (total >= 24)
        {
            total -= 24;
        }
        else if (total < 0)
        {
            total += 24;
        }

        Console.WriteLine(total);
    }


    // Bee 2060
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2060
    static void Bee_2060()
    {
        int cases = int.Parse(Console.ReadLine() ?? string.Empty);
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int[] numbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);

        for (int i = 0; i < cases; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                count2++;
            }
            if (numbers[i] % 3 == 0)
            {
                count3++;
            }
            if (numbers[i] % 4 == 0)
            {
                count4++;
            }
            if (numbers[i] % 5 == 0)
            {
                count5++;
            }
        }
        Console.WriteLine($"{count2} Multiplo(s) de 2");
        Console.WriteLine($"{count3} Multiplo(s) de 3");
        Console.WriteLine($"{count4} Multiplo(s) de 4");
        Console.WriteLine($"{count5} Multiplo(s) de 5");
    }

    // Bee 2140
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2140
    static void Bee_2140()
    {

        while (true)
        {
            string[] numbers = Console.ReadLine()?.Split() ?? Array.Empty<string>();
            int n1 = int.Parse(numbers[0]);
            int n2 = int.Parse(numbers[1]);

            if (n1 == 0 && n2 == 0)
            {
                break;
            }

            List<int> notas = new List<int> { 2, 5, 10, 20, 50, 100 };

            int finalValue = n2 - n1;
            bool isPossible = false;

            for (int i = 0; i < notas.Count; i++)
            {
                for (int j = i + 1; j < notas.Count; j++)
                {
                    if (notas[i] + notas[j] == finalValue)
                    {
                        isPossible = true;
                    }
                }
                if (isPossible)
                {
                    break;
                }
            }

            Console.WriteLine(isPossible ? "possible" : "impossible");
        }
    }

    // Bee 2146
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2146
    static void Bee_2146()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            Console.WriteLine(n - 1);
        }

    }

    // Bee 2159
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2159
    static void Bee_2159()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        double logN = Math.Log(n);
        double P = n / logN;
        double M = 1.25506 * n / logN;
        Console.WriteLine(P.ToString("F1", CultureInfo.InvariantCulture) + " " + M.ToString("F1", CultureInfo.InvariantCulture));
    }

    // Bee 2152
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2152
    static void Bee_2152()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < n; i++)
        {
            string[] numbers = Console.ReadLine()?.Split() ?? Array.Empty<string>();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);

            if (c == 0)
            {
                Console.WriteLine($"{a.ToString("D2")}:{b.ToString("D2")} - A porta fechou!");
            }
            else
            {
                Console.WriteLine($"{a.ToString("D2")}:{b.ToString("D2")} - A porta abriu!");
            }
        }
    }

    // Bee 2139
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2139
    static void Bee_2139()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            int[] numbers = Array.ConvertAll(line.Split(), int.Parse);
            int m = numbers[0];
            int d = numbers[1];

            DateTime now = new DateTime(2016, m, d);
            DateTime natal = new DateTime(2016, 12, 25);

            int dias = (natal - now).Days;

            if (dias == 0)
            {
                Console.WriteLine("E natal!");
            }
            else if (dias == 1)
            {
                Console.WriteLine("E vespera de natal!");
            }
            else if (dias < 0)
            {
                Console.WriteLine("Ja passou!");
            }
            else
            {
                Console.WriteLine($"Faltam {dias} dias para o natal!");
            }
        }
    }

    // Bee 2161
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2161
    static void Bee_2161()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        if (n == 0)
        {
            Console.WriteLine("3.0000000000");
        }
        else
        {
            double value = 6.0;
            for (int i = 1; i < n; i++)
            {
                value = 6 + 1 / value;
            }
            double result = 3 + 1 / value;
            Console.WriteLine($"{result:F10}", CultureInfo.InvariantCulture);
        }
    }

    // Bee 2061
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2061
    static void Bee_2061()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
        int n = numbers[0];
        int m = numbers[1];
        int count = n;
        for (int i = 0; i < m; i++)
        {
            string line = Console.ReadLine() ?? string.Empty;
            if (line == "fechou")
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        Console.WriteLine(count);
    }

    // Bee 2143
    // https://www.urionlinejudge.com.br/judge/en/problems/view/2143
    static void Bee_2143()
    {
        while (true)
        {
            string? line = Console.ReadLine();
            if (line == null)
                break;

            int t = int.Parse(line);
            if (t == 0)
                break;

            for (int i = 0; i < t; i++)
            {
                int N = int.Parse(Console.ReadLine() ?? "0");

                int pedidos;
                if (N % 2 == 0)
                {
                    pedidos = (2 * N) - 2;
                }
                else
                {
                    pedidos = (2 * N) - 1;
                }

                Console.WriteLine(pedidos);
            }
        }

    }

    // Bee 2166
    // https://judge.beecrowd.com/pt/problems/view/2166
    static void Bee_2166()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);

        if (n == 0)
        {
            Console.WriteLine("1.0000000000");
        }
        else
        {
            double value = 0.0;
            for (int i = 0; i < n; i++)
            {
                value = 1.0 / (2.0 + value);
            }
            double result = 1 + value;
            Console.WriteLine($"{result:F10}", CultureInfo.InvariantCulture);
        }
    }

    // Bee 2167
    // https://judge.beecrowd.com/pt/problems/view/2167
    static void Bee_2167()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        int[] numbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
        int position = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                position = i + 2;
                break;
            }
        }
        Console.WriteLine(position);
    }

    // Bee 2172
    // https://judge.beecrowd.com/pt/problems/view/2172
    static void Bee_2172()
    {
        while (true)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<String>(), int.Parse);
            int x = numbers[0];
            int m = numbers[1];
            int final = 0;

            if (x == 0 && m == 0) break;

            final = x * m;
            Console.WriteLine(final);
        }
    }

    // Bee 2176
    // https://judge.beecrowd.com/pt/problems/view/2176
    static void Bee_2176()
    {
        char[] array = Console.ReadLine()?.ToCharArray() ?? Array.Empty<char>();
        int numbers1 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == '1')
            {
                numbers1 += 1;
            }
        }
        string result = "";
        if (numbers1 % 2 == 0)
        {
            result = new string(array) + "0";
        }
        else
        {
            result = new string(array) + "1";
        }
        Console.WriteLine(result);
    }

    // Bee 2147
    // https://judge.beecrowd.com/pt/problems/view/2147
    static void Bee_2147()
    {
        int value = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < value; i++)
        {
            string word = Console.ReadLine() ?? string.Empty;
            double v = word.Length / 100.0;
            Console.WriteLine(v.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    // Bee 2164
    // https://judge.beecrowd.com/pt/problems/view/2164
    static void Bee_2164()
    {
        int value = int.Parse(Console.ReadLine() ?? string.Empty);
        double sqrt_5 = Math.Sqrt(5);
        double phi = (1 + sqrt_5) / 2;
        double psi = (1 - sqrt_5) / 2;
        double fib_n = (Math.Pow(phi, value) - Math.Pow(psi, value)) / sqrt_5;
        Console.WriteLine(fib_n.ToString("F1", CultureInfo.InvariantCulture));
    }

    // Bee 2234
    // https://judge.beecrowd.com/pt/problems/view/2234
    static void Bee_2234()
    {
        int[] values = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
        int v1 = values[0];
        int v2 = values[1];
        double result = (double)v1 / v2;
        Console.WriteLine(result.ToString("F2", CultureInfo.InvariantCulture));
    }

    // Bee 2235
    // https://judge.beecrowd.com/pt/problems/view/2235
    static void Bee_2235()
    {
        int[] value = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<String>(), int.Parse);
        int a = value[0];
        int b = value[1];
        int c = value[2];

        int comb2_1 = a + b;
        int comb2_2 = a - b;
        int comb2_3 = -a + b;
        int comb2_4 = a + c;
        int comb2_5 = a - c;
        int comb2_6 = -a + c;
        int comb2_7 = b + c;
        int comb2_8 = b - c;
        int comb2_9 = -b + c;

        int comb3_1 = a + b + c;
        int comb3_2 = a + b - c;
        int comb3_3 = a - b + c;
        int comb3_4 = -a + b + c;
        int comb3_5 = -a - b + c;
        int comb3_6 = -a + b - c;
        int comb3_7 = a - b - c;
        int comb3_8 = -a - b - c;

        if (
            comb2_1 == 0 || comb2_2 == 0 || comb2_3 == 0 ||
            comb2_4 == 0 || comb2_5 == 0 || comb2_6 == 0 ||
            comb2_7 == 0 || comb2_8 == 0 || comb2_9 == 0 ||
            comb3_1 == 0 || comb3_2 == 0 || comb3_3 == 0 || comb3_4 == 0 ||
            comb3_5 == 0 || comb3_6 == 0 || comb3_7 == 0 || comb3_8 == 0
        )
        {
            Console.WriteLine("S");
        }
        else
        {
            Console.WriteLine("N");
        }
    }

    // Bee 2221
    // https://judge.beecrowd.com/pt/problems/view/2221
    static void Bee_2221()
    {
        int caseValue = int.Parse(Console.ReadLine() ?? String.Empty);
        for (int i = 0; i < caseValue; i++)
        {
            int bonus = int.Parse(Console.ReadLine() ?? String.Empty);
            int[] DNumbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<String>(), int.Parse);
            int[] GNumbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<String>(), int.Parse);

            int DResult = (DNumbers[0] + DNumbers[1]) / 2;
            int GResult = (GNumbers[0] + GNumbers[1]) / 2;

            if (GNumbers[2] % 2 == 0)
            {
                GResult += bonus;
            }

            if (DNumbers[2] % 2 == 0)
            {
                DResult += bonus;
            }

            if (GResult > DResult)
            {
                Console.WriteLine("Guarte");
            }
            else if (DResult > GResult)
            {
                Console.WriteLine("Dabriel");
            }
            else
            {
                Console.WriteLine("Empate");
            }
        }
    }

    // Bee 2126
    // https://judge.beecrowd.com/pt/problems/view/2126
    static void Bee_2126()
    {
        string? n;
        int cases = 1;
        bool first = true;

        while ((n = Console.ReadLine()) != null)
        {
            string nValue = n ?? string.Empty;
            string seq = Console.ReadLine() ?? string.Empty;

            int nLen = nValue.Length;
            int count = 0;
            int lastPosition = -1;

            for (int i = 0; i <= seq.Length - nLen; i++)
            {
                if (seq.Substring(i, nLen) == nValue)
                {
                    count++;
                    lastPosition = i + 1;
                }
            }

            if (!first)
                Console.WriteLine();

            Console.WriteLine($"Caso #{cases++}:");

            if (count == 0)
            {
                Console.WriteLine("Nao existe subsequencia\n");
            }
            else
            {
                Console.WriteLine($"Qtd.Subsequencias: {count}");
                Console.WriteLine($"Pos: {lastPosition}\n");
            }

            first = false;
        }
    }

    // Bee 2163
    // https://judge.beecrowd.com/pt/problems/view/2163
    static void Bee_2163()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<String>(), int.Parse);
        int first = numbers[0];
        int second = numbers[1];

        List<int[]> listNumbers = new List<int[]>();
        for (int i = 0; i < first; i++)
        {
            int[] seqNumbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<String>(), int.Parse);
            listNumbers.Add(seqNumbers);
        }

        for (int i = 1; i < first - 1; i++)
        {
            for (int j = 1; j < second - 1; j++)
            {
                if (listNumbers[i][j] == 42 &&
                    listNumbers[i - 1][j - 1] == 7 &&
                    listNumbers[i - 1][j] == 7 &&
                    listNumbers[i - 1][j + 1] == 7 &&
                    listNumbers[i][j - 1] == 7 &&
                    listNumbers[i][j + 1] == 7 &&
                    listNumbers[i + 1][j - 1] == 7 &&
                    listNumbers[i + 1][j] == 7 &&
                    listNumbers[i + 1][j + 1] == 7
                )
                {
                    Console.WriteLine($"{i + 1} {j + 1}");
                    return;
                }
            }
        }

        Console.WriteLine("0 0");
    }

    // Bee 2168
    // https://judge.beecrowd.com/pt/problems/view/2168
    static void Bee_2168()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        List<int[]> map = new List<int[]>();

        for (int i = 0; i < n + 1; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
            map.Add(line);
        }

        for (int i = 0; i < n; i++)
        {
            string result = "";
            for (int j = 0; j < n; j++)
            {
                int soma = map[i][j] + map[i][j + 1] + map[i + 1][j] + map[i + 1][j + 1];
                result += (soma >= 2) ? 'S' : 'U';
            }
            Console.WriteLine(result);
        }
    }

    // Bee 2160
    // https://judge.beecrowd.com/pt/problems/view/2160
    static void Bee_2160()
    {
        string text = Console.ReadLine() ?? string.Empty;
        Console.WriteLine(text.Length <= 80 ? "YES" : "NO");
    }

    // Bee 2344
    // https://www.beecrowd.com.br/judge/en/problems/view/2344
    static void Bee_2344()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);

        if (n == 0)
        {
            Console.WriteLine("E");
        }
        else if (n >= 1 && n <= 35)
        {
            Console.WriteLine("D");
        }
        else if (n >= 36 && n <= 60)
        {
            Console.WriteLine("C");
        }
        else if (n >= 61 && n <= 85)
        {
            Console.WriteLine("B");
        }
        else if (n >= 86 && n <= 100)
        {
            Console.WriteLine("A");
        }
    }

    // Bee 2483
    // https://www.beecrowd.com.br/judge/en/problems/view/2483
    static void Bee_2483()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append("a");
        }

        Console.WriteLine($"Feliz nat{sb.ToString().TrimEnd()}l!");
    }

    // Bee 2543
    // https://judge.beecrowd.com/pt/problems/view/2543
    static void Bee_2543()
    {
        string? linha;
        while ((linha = Console.ReadLine()) != null)
        {
            int[] numbers = Array.ConvertAll(linha.Split(), int.Parse);
            int count = 0;
            for (int i = 0; i < numbers[0]; i++)
            {
                int[] cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
                if (cases[0] == numbers[1] && cases[1] == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

    // Bee 2581
    // https://www.beecrowd.com.br/judge/en/problems/view/2581
    static void Bee_2581()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < n; i++)
        {
            string question = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("I am Toorg!");
        }
    }

    // Bee 2582
    // https://www.beecrowd.com.br/judge/en/problems/view/2582
    static void Bee_2582()
    {
        int n = int.Parse(Console.ReadLine() ?? "0");

        string[] musics = new string[]
        {
            "PROXYCITY",
            "P.Y.N.G.",
            "DNSUEY!",
            "SERVERS",
            "HOST!",
            "CRIPTONIZE",
            "OFFLINE DAY",
            "SALT",
            "ANSWER!",
            "RAR?",
            "WIFI ANTENNAS"
        };

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(line)) continue;

            int[] numbers = Array.ConvertAll<string, int>(
                line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            if (numbers.Length != 2) continue;

            int sum = numbers[0] + numbers[1];
            Console.WriteLine(musics[sum]);
        }
    }

    // Bee 2547
    // https://www.beecrowd.com.br/judge/en/problems/view/2547
    static void Bee_2547()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            int[] numbers = Array.ConvertAll(line.Split(), int.Parse);
            int min = numbers[1];
            int max = numbers[2];
            int count = 0;

            for (int i = 0; i < numbers[0]; i++)
            {
                int number = int.Parse(Console.ReadLine() ?? string.Empty);
                if (number >= min && number <= max)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

    // Bee 2534
    // https://www.beecrowd.com.br/judge/en/problems/view/2534
    static void Bee_2534()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            int[] numbers = Array.ConvertAll(line.Split(), int.Parse);
            int n1 = numbers[0];
            int n2 = numbers[1];
            int[] arrayNumbers = new int[n1];
            int[] sequenceNumbers = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                int n = int.Parse(Console.ReadLine() ?? string.Empty);
                arrayNumbers[i] = n;
            }

            Array.Sort(arrayNumbers);
            Array.Reverse(arrayNumbers);

            for (int i = 0; i < n2; i++)
            {
                int s = int.Parse(Console.ReadLine() ?? string.Empty);
                sequenceNumbers[i] = s;
            }

            for (int i = 0; i < n2; i++)
            {
                int position = sequenceNumbers[i];
                Console.WriteLine(arrayNumbers[position - 1]);
            }
        }
    }

    // Bee 2486
    // https://www.beecrowd.com.br/judge/en/problems/view/2486
    static void Bee_2486()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line ?? string.Empty);
            if (n == 0) break;

            Dictionary<string, int> alimentosVitaminaC = new Dictionary<string, int>
            {
                { "suco de laranja", 120 },
                { "morango fresco", 85 },
                { "mamao", 85 },
                { "goiaba vermelha", 70 },
                { "manga", 56 },
                { "laranja", 50 },
                { "brocolis", 34 }
            };
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string[] cases = Console.ReadLine()?.Split() ?? Array.Empty<string>();
                int quant = int.Parse(cases[0]);
                string alimento = string.Join(" ", cases.Skip(1));
                count += quant * alimentosVitaminaC[alimento];
            }

            if (count < 110)
            {
                Console.WriteLine("Mais " + (110 - count) + " mg");
            }
            else if (count > 130)
            {
                Console.WriteLine("Menos " + (count - 130) + " mg");
            }
            else
            {
                Console.WriteLine($"{count} mg");
            }
        }
    }

    // Bee 2717
    // https://www.beecrowd.com.br/judge/en/problems/view/2717
    static void Bee_2717()
    {
        int minutes = int.Parse(Console.ReadLine() ?? string.Empty);
        int[] cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
        int n1 = cases[0];
        int n2 = cases[1];
        int sum = n1 + n2;

        if (sum <= minutes)
        {
            Console.WriteLine("Farei hoje!");
        }
        else
        {
            Console.WriteLine("Deixa para amanha!");
        }
    }

    // Bee 2510
    // https://www.beecrowd.com.br/judge/en/problems/view/2510
    static void Bee_2510()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        string[] vilans = new string[n];

        for (int i = 0; i < n; i++)
        {
            string caseInput = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(caseInput)) continue;

            vilans[i] = caseInput.Trim();
        }

        foreach (string vilan in vilans)
        {
            Console.WriteLine("Y");
        }
    }

    // Bee 2523
    // https://www.beecrowd.com.br/judge/en/problems/view/2523
    static void Bee_2523()
    {
        string? line;
        StringBuilder sb = new StringBuilder();
        while ((line = Console.ReadLine()) != null)
        {
            char[] characters = line.ToCharArray();
            int n = int.Parse(Console.ReadLine() ?? string.Empty);
            int[] numbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
            for (int i = 0; i < numbers.Length; i++)
            {
                sb.Append(characters[numbers[i] - 1]);
            }
            Console.WriteLine(sb.ToString());
            sb.Clear();
        }
    }

    // Bee 2310
    // https://www.beecrowd.com.br/judge/en/problems/view/2310
    static void Bee_2310()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        int[] case1 = new int[3];
        int[] case2 = new int[3];
        int saque_tentativas = 0;
        int saque_acertos = 0;
        int bloqueio_tentativas = 0;
        int bloqueio_acertos = 0;
        int ataques_tentativas = 0;
        int ataques_acertos = 0;

        for (int i = 0; i < n; i++)
        {
            string player = Console.ReadLine() ?? string.Empty;
            int[] first_cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
            case1[0] = first_cases[0];
            case1[1] = first_cases[1];
            case1[2] = first_cases[2];
            int[] second_cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
            case2[0] = second_cases[0];
            case2[1] = second_cases[1];
            case2[2] = second_cases[2];

            saque_tentativas += case1[0];
            saque_acertos += case2[0];
            bloqueio_tentativas += case1[1];
            bloqueio_acertos += case2[1];
            ataques_tentativas += case1[2];
            ataques_acertos += case2[2];
        }
        decimal saques = ((decimal)saque_acertos / saque_tentativas) * 100;
        decimal bloqueios = ((decimal)bloqueio_acertos / bloqueio_tentativas) * 100;
        decimal ataques = ((decimal)ataques_acertos / ataques_tentativas) * 100;
        Console.WriteLine($"Pontos de Saque: {saques:F2} %.");
        Console.WriteLine($"Pontos de Bloqueio: {bloqueios:F2} %.");
        Console.WriteLine($"Pontos de Ataque: {ataques:F2} %.");
    }

    // Bee 2162
    // https://judge.beecrowd.com/pt/problems/view/2162
    static void Bee_2162()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        int[] cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);

        if (n < 2)
        {
            Console.WriteLine(1);
            return;
        }

        bool isValid = true;
        int ultimo_movimento = 0;

        for (int i = 1; i < n; i++)
        {
            if (cases[i] == cases[i - 1])
            {
                isValid = false;
                break;
            }

            int movimentoAtual = cases[i] > cases[i - 1] ? 1 : -1;

            if (ultimo_movimento != 0 && movimentoAtual == ultimo_movimento)
            {
                isValid = false;
                break;
            }

            ultimo_movimento = movimentoAtual;
        }
        Console.WriteLine(isValid ? 1 : 0);
    }

    // Bee 2165
    // https://judge.beecrowd.com/pt/problems/view/2165
    static void Bee_2165()
    {
        string tweet = Console.ReadLine() ?? string.Empty;
        if (tweet.Length <= 140)
        {
            Console.WriteLine("TWEET");
        }
        else
        {
            Console.WriteLine("MUTE");
        }
    }

    // Bee 2311
    // https://www.beecrowd.com.br/judge/en/problems/view/2311
    static void Bee_2311()
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine() ?? string.Empty;
            double dificulty = double.Parse(Console.ReadLine() ?? string.Empty);
            double[] cases = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), double.Parse);
            List<double> values = cases.OrderByDescending(x => x).ToList();
            values.RemoveAt(0);
            values.RemoveAt(values.Count - 1);
            double sum = values.Sum();
            double finalValue = sum * dificulty;
            Console.WriteLine($"{name} {finalValue:F2}");
        }
    }

    // Bee 2313
    // https://www.beecrowd.com.br/judge/en/problems/view/2313
    static void Bee_2313()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
        int n = numbers[0];
        int m = numbers[1];
        int c = numbers[2];
        string isRetangle;

        int max = numbers.Max();
        int min = numbers.Min();
        int middle = numbers.OrderBy(x => x).ElementAt(1);
        if (Math.Pow(max, 2) == Math.Pow(min, 2) + Math.Pow(middle, 2))
        {
            isRetangle = "Retangulo: S";
        }
        else
        {
            isRetangle = "Retangulo: N";
        }


        if (n + m > c && n + c > m && m + c > n)
        {
            if (n == m && n == c)
            {
                Console.WriteLine("Valido-Equilatero");
                Console.WriteLine(isRetangle);
            }
            else if (n != m && n != c && m != c)
            {
                Console.WriteLine("Valido-Escaleno");
                Console.WriteLine(isRetangle);
            }
            else
            {
                Console.WriteLine("Valido-Isoceles");
                Console.WriteLine(isRetangle);
            }

        }
        else
        {
            Console.WriteLine("Invalido");
        }
    }

    // DIO project
    // retornando nomes filtrados por letras especificas, ignore maiúsculas/minúsculas
    static void DIO()
    {
        string? linhaDeNomes = Console.ReadLine();

        if (string.IsNullOrEmpty(linhaDeNomes))
        {
            Console.WriteLine("Nenhum nome encontrado");
            return;
        }
        List<string> nomes = linhaDeNomes
            .Split(',')
            .Select(nome => nome.Trim())
            .ToList();

        char letraFiltro = char.Parse(Console.ReadLine() ?? string.Empty);

        if (char.IsWhiteSpace(letraFiltro) || !char.IsLetter(letraFiltro))
        {
            Console.WriteLine("Nenhum character encontrado");
            return;
        }

        // TODO: Filtre a lista de nomes que começam com a letra (ignore maiúsculas/minúsculas):
        List<string> filtrados = nomes
        .Where(nome => nome.StartsWith(letraFiltro.ToString(), StringComparison.OrdinalIgnoreCase))
        .ToList();
        // TODO: Retorne o resultado e implemente a condição if para retornar 'Nenhum nome encontrado' e exiba o resultado: 
        if (filtrados.Count == 0)
        {
            Console.WriteLine("Nenhum nome encontrado");
        }
        else
        {
            foreach (var nome in filtrados)
            {
                Console.WriteLine(nome);
            }
        }
    }

    // Bee 2334
    // https://www.beecrowd.com.br/judge/en/problems/view/2334
    static void Bee_2334()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            BigInteger n = BigInteger.Parse(line ?? string.Empty);
            if (n == -1) break;
            BigInteger result = n - 1;
            if (result <= 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }

    // Bee 2502
    // https://www.beecrowd.com.br/judge/en/problems/view/2502
    static void Bee_2502()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            int[] numbers = Array.ConvertAll(line.Split(), int.Parse);
            char[] first = Console.ReadLine()?.ToCharArray() ?? Array.Empty<char>();
            char[] second = Console.ReadLine()?.ToCharArray() ?? Array.Empty<char>();
            Dictionary<char, char> dictionary = new Dictionary<char, char>();
            List<string> phrases = new List<string>();

            for (int c = 0; c < first.Length; c++)
            {

                dictionary[first[c]] = second[c];
                dictionary[second[c]] = first[c];
            }

            for (int i = 0; i < numbers[1]; i++)
            {
                string phrase = Console.ReadLine() ?? string.Empty;
                phrases.Add(Cifer(phrase, dictionary));
            }

            foreach (string phrase in phrases)
            {
                Console.WriteLine(phrase);
            }
            Console.WriteLine();
            dictionary.Clear();
        }
    }

    static string Cifer(string frase, Dictionary<char, char> mapa)
    {
        StringBuilder resultado = new StringBuilder();

        foreach (char ch in frase)
        {
            char chMap = ch;
            if (mapa.ContainsKey(char.ToUpper(ch)))
            {
                char sub = mapa[char.ToUpper(ch)];
                if (char.IsLetter(sub))
                {
                    if (char.IsUpper(ch))
                        chMap = char.ToUpper(sub);
                    else
                        chMap = char.ToLower(sub);
                }
                else
                {
                    chMap = sub;
                }
            }
            resultado.Append(chMap);
        }

        return resultado.ToString();
    }

    // Bee 2552
    // https://www.beecrowd.com.br/judge/en/problems/view/2552
    static void Bee_2552()
    {
        string? line;
        while ((line = Console.ReadLine()) != null)
        {
            int[] quandrante = Array.ConvertAll(line.Split(), int.Parse);
            int[,] matriz = new int[quandrante[0], quandrante[1]];
            int[,] direcoes = new int[,]
            {
                {-1, 0}, // cima
                {1, 0},  // baixo
                {0, -1}, // esquerda
                {0, 1}   // direita
            };

            for (int i = 0; i < quandrante[0]; i++)
            {
                int[] numbers = Array.ConvertAll(Console.ReadLine()?.Split() ?? Array.Empty<string>(), int.Parse);
                for (int j = 0; j < quandrante[1]; j++)
                {
                    matriz[i, j] = numbers[j];
                }
            }

            for (int i = 0; i < quandrante[0]; i++)
            {
                for (int j = 0; j < quandrante[1]; j++)
                {
                    if (matriz[i, j] == 1)
                    {
                        Console.Write("9");
                    }
                    else
                    {
                        int count = 0;
                        // verificando as direções com base no tamanho do quadrante
                        // GetLength(0) acessa as posicoes de cima, baixo, esquerda e direita
                        for (int d = 0; d < direcoes.GetLength(0); d++)
                        {
                            int ni = i + direcoes[d, 0];
                            int nj = j + direcoes[d, 1];

                            if (ni >= 0 && ni < quandrante[0] && nj >= 0 && nj < quandrante[1] && matriz[ni, nj] == 1)
                            {
                                count++;
                            }
                        }
                        Console.Write(count);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}