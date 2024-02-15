namespace PZ_16
{
    internal class Program
    {
        //Объявление глобальных переменных
        static int mapSize = 26;
        static char[,] map = new char[mapSize, mapSize];
        static int playerY = mapSize / 2;
        static int playerX = mapSize / 2;
        static byte enemies = 10;//враги
        static byte buffs = 5;//баффы
        static byte health = 5;//аптечки
        static int PlayerHp = 50;//хп игрока
        static int EnemiesHp = 30;//хп врага
        static int PlayerPower = 10;//удар игрока
        static int EnemiesPower = 5;//удар врага
        static int Steps = 0;//общее кол-во шагов
        static int StepsCount = 0;
        static int buffcount = 0;
        static bool bringbuff = false;//поднятие баффа
        static int playerOldY;
        static int playerOldX;
        static int buffcounthelp = 0;
        static int enemycount = 0;
        static string lastAction = " ";

        enum Direction { Left, Right, Up, Down }

        static void Main(string[] args)//Основной метод
        {
            StartGame();
            Move();
            SaveProgress();
            LoadGame();

        }

        static void GenerationMap()//Метод генерации карты
        {
            Random random = new Random();

            for (int i = 0; i < mapSize; i++)//Создание карты
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    map[i, j] = '_';

                }
            }

            map[playerX, playerY] = 'P';//Присвоение начальных координат
            int x;
            int y;

            while (enemies > 0)//Цикл создания врагов
            {
                x = random.Next(mapSize);
                y = random.Next(mapSize);
                if (map[x, y] == '_')
                {
                    map[x, y] = 'E';
                    enemies--;


                }
            }

            while (buffs > 0)//Цикл создания баффов
            {
                x = random.Next(mapSize);
                y = random.Next(mapSize);
                if (map[x, y] == '_')
                {
                    map[x, y] = 'B';
                    buffs--;
                }
            }


            while (health > 0)//Цикл создания аптечек
            {
                x = random.Next(mapSize);
                y = random.Next(mapSize);
                if (map[x, y] == '_')
                {
                    map[x, y] = 'H';
                    health--;
                }
            }

            UpdateMap();//обновление карты
        }

            static void UpdateMap() // Отображение заполненной карты на консоли
            {
                Console.Clear();
                for (int i = 0; i < mapSize; i++) //Запись карты в консоль
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        switch (map[i, j]) // Окраска элементов
                        {
                            case 'E':
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case 'B':
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;
                            case 'H':
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }

                        Console.Write(map[i, j]);
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
            }
        

        static void Move()//метод передвижения
        {
            while (true)
            {
                if (PlayerHp > 0 && enemycount != 10)
                {
                    Console.SetCursorPosition(1, 27);
                    Console.Write($"Здоровье игрока: {PlayerHp.ToString("D2")}");//вывод здоровья игрока
                    Console.SetCursorPosition(1, 28);
                    Console.Write($"Сила игрока: {PlayerPower}");//вывод силы удара игрока
                    Console.SetCursorPosition(1, 29);
                    Console.Write($"Количество шагов: {Steps}");//вывод общего количества шагов
                    Console.SetCursorPosition(1, 30);
                    Console.Write($"Бафф активирован: {lastAction}");//вывод общего количества шагов
                }
                playerOldX = playerX;//Присвоение значения старым координатам
                playerOldY = playerY;
                switch (Console.ReadKey().Key)//Свитч на изменение координат
                {
                    case ConsoleKey.UpArrow:
                        if (playerY == 0)
                            playerY = playerY;
                        else
                            playerY--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (playerY == 25)
                            playerY = playerY;
                        else
                            playerY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (playerX == 0)
                            playerX = playerX;
                        else
                            playerX--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (playerX == 24)
                            playerX = playerX;
                        else
                            playerX++;
                        break;
                    case ConsoleKey.Escape:
                        Escape(); //метод выхода из игры
                        break;
                }

                Health();//метод лечения
                Fight();//метод боевки
                Buff();//метод баффа
                buffcount++;//Подсчет длительности баффа
                if (buffcount == buffcounthelp + 21)//Проверка на завершении баффа
                {
                    PlayerPower = 10;
                }
                Console.CursorVisible = false;
                map[playerOldY, playerOldX] = '_';//Затирание старого положения игрока
                Console.SetCursorPosition(playerOldX, playerOldY);//Установка курсора на место старых координат
                Console.Write('_');//Затирка старых координат
                map[playerY, playerX] = 'P';//Установка нового положения игрока
                Console.SetCursorPosition(playerX, playerY);//Перенос курсора на координаты нового положения
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write('P');
                Console.ResetColor();//Замена текущего символа в данном месте на игрока

                if (playerX == playerOldX && playerY == playerOldY)
                    Steps = Steps;
                else
                    Steps++;//Счет шагов

                if (PlayerHp <= 0)
                    Fail(); //вывод экрана поражения

                if (enemycount == 10)
                    Win();

            }
        }



        static void Fight()//метод боя
        {
            if (map[playerY, playerX] == 'E')
            {
                PlayerHp -= EnemiesPower;
                EnemiesHp -= PlayerPower;
                if (EnemiesHp > 0)
                {
                    Console.SetCursorPosition(playerOldX, playerOldY);
                    map[playerOldY, playerOldX] = 'E';
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write('E');
                    Console.ResetColor();
                    playerOldX = playerX;
                    playerOldY = playerY;
                }
                else
                {
                    EnemiesHp = 30;
                    enemycount++;
                }
            }
        }

        static void Health()//Метод лечения
        {
            if (map[playerY, playerX] == 'H')
            {
                PlayerHp = 50;
            }
        }
        static void Buff() //Метод баффа
        {
            if (map[playerY, playerX] == 'B')
            {
                bringbuff = true;
                StepsCount = Steps;//сохранение шага на котором взят бафф
                PlayerPower = PlayerPower * 2;
                lastAction="да     ";
            }
            if (StepsCount==Steps-20)//бафф расчитан на 20 шагов
            {
                bringbuff=false;
                PlayerPower = 10;
                lastAction="нет   ";
            }
        }
        static void StartGame()// метод вывода начального экрана
        {
            Console.SetCursorPosition(37, 14);
            Console.WriteLine("N - начать новую игру");
            Console.SetCursorPosition(37, 15);
            Console.WriteLine("L - загрузить последнее сохранение");
            switch (Console.ReadKey().Key)
            {

                case ConsoleKey.N:
                    GenerationMap();
                    break;
                case ConsoleKey.L:
                    LoadGame();
                    break;

            }
        }

        private static void Centertext(string v, object centerY)
        {
            throw new NotImplementedException();
        }

        static void Fail()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 14);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы проиграли");
            Console.ReadLine();
        }

        static void Win()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 14);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы выиграли");
            Console.ReadLine();
        }

        static void Escape()//метод выхода из игры
        {

            Console.Clear();
            Console.SetCursorPosition(40, 14);
            Console.WriteLine("bZ - вернуться в игру ");
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("E - сохранить и выйти");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("S - выйти без сохранения");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.R:
                    UpdateMap();
                    break;
                case ConsoleKey.E:
                    {
                        Environment.Exit(0);
                    }
                    break;
                case ConsoleKey.S:
                    Environment.Exit(0);
                    break;

            }
        }


        static void SaveProgress()//сохранение
        {

            using (FileStream file = new FileStream("save.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file)) // Запись в него параметров
                {
                    writer.WriteLine($"playerX={playerX}");
                    writer.WriteLine($"playerY={playerY}");
                    writer.WriteLine($"playerHP={PlayerHp}");
                    writer.WriteLine($"playerStrong={PlayerPower}");
                    writer.WriteLine($"playerStepCount={Steps}");
                    writer.WriteLine($"enemyHP={EnemiesHp}");
                    writer.WriteLine($"buffStep={buffcount}");

                    
                }
            }
        }

        static void LoadGame()//загрузка
        {
            string path = "save.txt"; // Путь

            if (File.Exists(path)) // Если существует
            {
                string[] lines = File.ReadAllLines(path); // Передача файлов с документа в игру

                if (lines.Length >= mapSize)
                {
                    if (int.TryParse(lines[0].Split('=')[1], out int loadedPlayerX) &&
                    int.TryParse(lines[1].Split('=')[1], out int loadedPlayerY) &&
                    int.TryParse(lines[2].Split('=')[1], out int loadedPlayerHP) &&
                    int.TryParse(lines[3].Split('=')[1], out int loadedPlayerStrong) &&
                    int.TryParse(lines[4].Split('=')[1], out int loadedPlayerStepCount) &&
                    int.TryParse(lines[5].Split('=')[1], out int loadedEnemyHP) &&
                    bool.TryParse(lines[6].Split('=')[1], out bool loadedHasBuff) &&
                    int.TryParse(lines[7].Split('=')[1], out int loadedBuffStep))
                    {
                        playerX = loadedPlayerX;
                        playerY = loadedPlayerY;
                        PlayerHp = loadedPlayerHP; //хп игрока
                        PlayerPower = loadedPlayerStrong; //урон
                        Steps = loadedPlayerStepCount;//общее кол-во шагов
                        buffcount = loadedBuffStep;//после бафа
                        EnemiesHp = loadedEnemyHP; //хр врага

                        map[playerX, playerY] = 'P';

                        Console.Clear();
                        UpdateMap(); //Вывод на консоль
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка чтения файла сохранения.");
                }
            }
            else
            {
                Console.WriteLine("Файл сохранения не найден.");
            }
        }

       
    }
}