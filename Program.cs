class Craps
{
    static void Main(string[] args)
    {

        int roll;

        Random random = new Random();

        PlayCraps();
        Console.ReadLine();

        void RollDice()
        {

            Console.WriteLine("Это игры Craps, чтобы начать играть нажми Enter!");
            Console.WriteLine(@"Правила игры такие. Игрок бросает две кости и подсчитывает сумму выпавших очков.
Он сразу же выигрывает, если эта сумма равна 7 или 11, и проигрывает, если она равна 2, 3 или 12
Всякая другая сумма – это его “пойнт”.
Если в первый раз выпадает “пойнт”, то игрок бросает кости еще до тех пор, пока он или не выиграет,
выбросив свой “пойнт”, или не проиграет, получив сумму очков,равную 7.");
            Console.ReadLine();

            int die1 = 0;
            int die2 = 0;

            die1 = random.Next(6) + 1;

            die2 = random.Next(6) + 1;

            roll = die1 + die2;
            Console.WriteLine("Выпало: {0}", roll);
        }

        void PlayCraps()
        {
            RollDice();
            int gameStatus = 0;
            int point = roll;
            Console.ReadLine();

            while (gameStatus < 1)
            {


                if (roll == 7 || roll == 11)
                {
                    Console.WriteLine("Повезло, ты победил!!");
                    break;
                }
                else if (roll == 2 || roll == 3 || roll == 12)
                {
                    Console.WriteLine("Не повезло, ты проиграл.");
                    break;
                }
                else
                {
                  
                    Console.WriteLine("Твой 'поинт': {0}", point);
                    Console.ReadLine();             

                    while (point != roll || roll != 7)
                    {
                        RollDice();
                        if (roll == point)
                        {
                            Console.WriteLine("Повезло, ты победил!!");
                            gameStatus++;
                            break;
                        }

                        if (roll == 7)
                        {
                            Console.WriteLine("Не повезло, ты проиграл.");
                            gameStatus++;
                            break;


                        }
                        Console.WriteLine("Кидай еще раз.");
                        Console.ReadLine();

                    }

                }
            }
        }
    }
}

