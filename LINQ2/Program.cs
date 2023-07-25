using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ2
{
    class Program
    {
        static void Main()
        {
            //     ● Исходная последовательность содержит сведения об абитуриентах. Каждый элемент
            // последовательности включает следующие поля:
            //     <Фамилия> <Год поступления> <Номер школы>

            //     Для каждой школы вывести общее число абитуриентов за все годы и фамилию первого из абитуриентов
            // этой школы, содержащихся в исходном наборе данных (вначале указывать номер школы, затем число
            //     абитуриентов, затем фамилию). Сведения о каждой школе выводить на новой строке и упорядочивать
            // по возрастанию номеров школ.*/


            List<UniversityEntrant> universityEntrantAll = new List<UniversityEntrant>
            {
                new UniversityEntrant("Макаров", 2020, 53),
                new UniversityEntrant("Антипов", 2019, 48),
                new UniversityEntrant("Лавочкина", 2021, 21),
                new UniversityEntrant("Мишина", 2020, 48),
                new UniversityEntrant("Лепешкин", 2019, 53),
                new UniversityEntrant("Зайцев", 2021, 48),
                new UniversityEntrant("Чубайс", 2020, 21),
                new UniversityEntrant("Навальная", 2021, 48)
            };

            var schoolStats = universityEntrantAll.GroupBy(x => x.NumberSchool)
                .OrderBy(x => x.Key)
                .Select(x => new
                {
                    numberSchool = x.Key,
                    TotalApplicants = x.Count(),
                    FirstApplicantSurName = x.First().Surname
                    // FirstApplicantSurName = x.OrderBy(x => x.YearAdmission).First().Surname - Первый по поступлению
                })
                .ToList();


            foreach (var stat in schoolStats)
            {
                Console.WriteLine($"Школа - {stat.numberSchool}");
                Console.WriteLine($"Количество абитуриентов - {stat.TotalApplicants}");
                Console.WriteLine($"Первый абитуриент - {stat.FirstApplicantSurName}");
                Console.WriteLine($"-------------------------------------------------");
            }

            return;
        }

        private static void GetDifferenceA()
        {
            // Дано целое число K (> 0) и целочисленная последовательность A. Найти теоретико-множественную
            // разность двух фрагментов A: первый содержит все четные числа, а второй — все числа с порядковыми
            //     номерами, большими K. В полученной последовательности (не содержащей одинаковых элементов)
            // поменять порядок элементов на обратный.

            int K = 5;
            Random random = new Random();
            var arrayA = Enumerable.Range(0, 10).Select(x => random.Next(1, 10))
                .ToArray();

            var aaa = arrayA.Where(x => x % 2 == 0)
                .Except(arrayA.Where(x => x > K))
                .Reverse()
                .ToArray();
        }

        private static void GetSequenceOfAandB()
        {
            // ● Даны целые числа K1 и K2 и целочисленные последовательности A и B. Получить последовательность,
            //     содержащую все числа из A, большие K1, и все числа из B, меньшие K2. Отсортировать полученную
            // последовательность по возрастанию.

            int K1 = 3;
            int K2 = 5;

            var arrayA = new[] { 1, 2, 7, 6, 3, 4, 85, 48, 473, 146 };
            var arrayB = new[] { 7, 6, 2, 45, 4654, 4, 1641, 21, };

            var sequenceOfAandB = arrayA.Select(x => x)
                .Where(x => x > K1)
                .Concat(arrayB.Select(x => x).Where(x => x < K2))
                .OrderBy(x => x)
                .ToList();
        }
    }
}