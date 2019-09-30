using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)


            // Делаем игру цикличной
            for (; ; )
            {
                // здесь нам не требуется большие числа длины int32, хватит и int16
                short userTry;
                short limitPlayer; // количество игроков

                #region переменные игроков       

                // присваем пустое значение для последущей операции сравнения
                string user1 = ""; // можно поиграть и с самим с собой, почему бы и нет
                string user2 = "";
                string user3 = "";
                string user4 = "";
                string user5 = "";
                string user6 = "";
                string user7 = "";
                string user8 = ""; // игра будет поддерживать до 8 игроков

                Console.WriteLine("Введите количество игроков от 1 до 8");
                while (true)
                {
                    limitPlayer = Convert.ToInt16(Console.ReadLine()); //считываем строку и преобразуем его в int16
                    if (limitPlayer >8 || limitPlayer < 1)
                    {
                        Console.WriteLine("неверное число");
                    }
                    else
                    {
                        break;
                    }
                }

                #region Считывание имён до 8 игроков

                // это неочень красивая конструкция, но мы же ещё не дошли до массивов
                while (user1 == "") //имя не может быть пустым, запрашиваем пока не будет введён правильный вариант
                {
                    Console.WriteLine("Игрок1 введи свой никнейм");
                    user1 = Console.ReadLine();
                }
                if (limitPlayer >1)
                while (user2 == "")
                {
                    Console.WriteLine("Игрок2 введи свой никнейм");
                    user2 = Console.ReadLine();
                }

                if (limitPlayer > 2)
                {
                    while (user3 == "")
                    {
                        Console.WriteLine("Игрок3 введи свой никнейм");
                        user3 = Console.ReadLine();
                    }
                }
                if (limitPlayer > 3)
                {
                    while (user4 == "")
                    {
                        Console.WriteLine("Игрок4 введи свой никнейм");
                        user4 = Console.ReadLine();
                    }
                }
                if (limitPlayer > 4)
                {
                    while (user5 == "")
                    {
                        Console.WriteLine("Игрок5 введи свой никнейм");
                        user5 = Console.ReadLine();
                    }
                }
                if (limitPlayer > 5)
                {
                    while (user6 == "")
                    {
                        Console.WriteLine("Игрок6 введи свой никнейм");
                        user6 = Console.ReadLine();
                    }
                }
                if (limitPlayer > 6)
                {
                    while (user7 == "")
                    {
                        Console.WriteLine("Игрок7 введи свой никнейм");
                        user7 = Console.ReadLine();
                    }
                }
                if (limitPlayer > 7)
                {
                    while (user8 == "")
                    {
                        Console.WriteLine("Игрок8 введи свой никнейм");
                        user8 = Console.ReadLine();
                    }
                }
#endregion

                #endregion

                string currentUser = user1; //первый ходит игрок 1

                // Генерация случайного числа
                Random rand = new Random();
                Console.WriteLine("Настроим сложность.\nВведите нижнюю границу случайного числа");
                int r1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите верхнюю границу случайного числа");
                int r2 = Int32.Parse(Console.ReadLine());
                int gamenumber = rand.Next(r1, r2);

                // Указываем конечное число для победы в игре
                int targetnumber;
                // Считываем пока не будет указано правильное число
                while (true)
                {
                    Console.WriteLine($"Введите число для победы в диапазоне от {r1} до {r2}");
                    targetnumber = Int32.Parse(Console.ReadLine());
                    if (targetnumber < r1 || targetnumber > r2)
                    {
                        Console.WriteLine("Неверное число");
                    }
                    else
                    {
                        break;
                    }
                    
                }
                
                #region Процесс геймплея
                // Начало геймплея, задаём i для подсчета хода игроков
                for (int i = 1; ; i++)
                {
                    Console.WriteLine($"Число: {gamenumber}");
                    // Если игроки получили число меньше целевого числа то игра прекращается
                    if (gamenumber < targetnumber) { Console.WriteLine("Вы проиграли"); break; }

                    // Выбор хода игрока
                    #region Такой способ не подойдёт для количества игроков >2
                    //// Если раунд чётный значит ходит игрок2
                    //if (i % 2 == 0)
                    //{
                    //    currentUser = user2;
                    //}
                    //// Иначе ходит игрок1
                    //else
                    //{
                    //    currentUser = user1;
                    //}
                    #endregion

                    // Выбираем игрока в зависимости от хода раунда
                    switch (i)
                    {
                        case 1:
                            currentUser = user1;
                            break;
                        case 2:
                            currentUser = user2;
                            break;
                        case 3:
                            currentUser = user3;
                            break;
                        case 4:
                            currentUser = user4;
                            break;
                        case 5:
                            currentUser = user5;
                            break;
                        case 6:
                            currentUser = user6;
                            break;
                        case 7:
                            currentUser = user7;
                            break;
                        case 8:
                            currentUser = user8;
                            break;
                    }


                    Console.WriteLine($"Ход {currentUser}: ");
                    userTry = Int16.Parse(Console.ReadLine());

                    // По тз нужно разрешить только числа 1,2,3,4
                    if (userTry > 0 && userTry < 5)
                    {

                        if (currentUser.Contains("омпьютер"))
                        {
                            Random rand2 = new Random();
                            int compNumber = rand2.Next(1, 3);
                            gamenumber -= compNumber;
                        }
                        else
                        {
                            gamenumber -= userTry;
                        }

                        // Если число равно целевому числу, то объявляем победителя и прерываем цикл
                        if (gamenumber == targetnumber)
                        {
                            Console.WriteLine($"{currentUser} победил");
                            break;
                        }
                        //currentUser++;
                    }
                    else
                    {
                        Console.WriteLine("Неверное число");
                        i--; // откатываем раунд чтобы текущий игрок повторил ход
                    }
                    if (i == 8) { i = 1; } // начинаем новый раунд
                }
                #endregion


                Console.WriteLine("Хотите реванш? (да/нет)");
                string revenge; // Заранее объявляем переменную чтобы прочитать её вне цикла              
                while (true) // Считываем ответ пока не получим правильный вариант
                {
                    revenge = Console.ReadLine();
                    if (revenge == "да" || revenge == "нет") break;  //прерываем цикл только когда получим правильный ответ
                }
                Console.Clear();
                if (revenge == "нет") break; // выходим из игры
            }
        }
    }
}
