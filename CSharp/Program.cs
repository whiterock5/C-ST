using System;

namespace CSharp
{
    class Program
    {

        enum ClassType
        {
            None = 0 ,
            Knight = 1 ,
            Archer = 2 ,
            Mage = 3
        }

        //구조체
        struct Player
        {
            public int hp;
            public int attack;

        }

        enum Monster
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }

        struct Monster
        {
            public int hp;
            public int attack;

        }

        static ClassType ChooseClass()
        {
            ClassType choice = ClassType.None;
            Console.WriteLine("직업을 선택하세요.");
            Console.WriteLine("[1] 1");
            Console.WriteLine("[2] 2");
            Console.WriteLine("[3] 3");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;

                case "3":
                    choice = ClassType.Mage;
                    break;
            }
            return choice;
        }


        // 캐릭터생성 , 스텟 값 넣기
        static void CreatePlayer (ClassType choice, out Player player)
        {
           
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }

        static void EnterField()
        {
            Console.WriteLine("필드이동완료.");

            Monster monster;


            CreateRendomMonster(out monster);



        }

        static void EnterGame()
        {
            while (true)
            {
                Console.WriteLine("접속 완료");
                Console.WriteLine("[1] 필드가기");
                Console.WriteLine("[2] 로비가기");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        EnterField();
                        break;

                    case "2":
                        return;

                }
            }
        }

        static void Main(string[] args)
        {

            
            while (true)
            {

                ClassType choice = ChooseClass();

                if(choice != ClassType.None)
                {
                    // 생성
                    // 1 ( 100/10 ) 2 ( 75/12 )  3 ( 50 /15 )
                    Player player;


                    CreatePlayer(choice , out player);

                    //Console.WriteLine($"HP{player.hp} Attack{player.attack}");

                    //fight 
                    EnterGame();

                }


            }
            
        }
    }
}
