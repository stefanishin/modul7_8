using System;
using System.Collections.Generic;
/*Программа «Статистика».
Подсчитать, сколько раз каждое слово встречается в заданном тексте. 
Результат записать в коллекцию Dictionary.
Пример текста для проверки: 
Вот дом, Который построил Джек. А это пшеница,
Которая в темном чулане хранится В доме, 
Который построил Джек. А это веселая птица-синица,
Которая часто ворует пшеницу, Которая в темном чулане хранится В доме,
Который построил Джек.
*/
namespace Statistics
{
    {
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    int x = 5;
                    int y = x / 0;
                    Console.WriteLine($"Результат: {y}");
                }
                catch
                {
                    Console.WriteLine("Возникло исключение!");
                }
                finally
                {
                    Console.WriteLine("Блок finally");
                }
                Console.WriteLine("Конец программы");
                Console.Read();
            }
        }
    }
