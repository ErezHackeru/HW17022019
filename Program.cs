using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17022019
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash niceGuy1 = new Flash(3, "Arrow", 30);
            SpiderMan niceGuy2 = new SpiderMan(250, "Google", 26);
            SuperMan niceGuy3 = new SuperMan(45, "LetMyPeopleGo", 300);

            ISuperHero[] HeroArr = new ISuperHero[3];
            HeroArr[0] = niceGuy1;
            HeroArr[1] = niceGuy2;
            HeroArr[2] = niceGuy3;
            Console.WriteLine("=============================================");
            foreach (object HeroPerson in HeroArr)
            {
                IdentifyHero((ISuperHero)HeroPerson);

                ActivateHero((ISuperHero)HeroPerson);

                GetMoreHeroData((ISuperHero)HeroPerson);

                Console.WriteLine("------------------------------------------------");
            }
            HeroArr[0] = CreateHero("Flash");
            HeroArr[1] = CreateHero("SpiderMan");
            HeroArr[2] = CreateHero("SuperMan");
            Console.WriteLine("=============================================");
            foreach (object HeroPerson in HeroArr)
            {
                IdentifyHero((ISuperHero)HeroPerson);

                ActivateHero((ISuperHero)HeroPerson);

                GetMoreHeroData((ISuperHero)HeroPerson);

                Console.WriteLine("------------------------------------------------");
            }
            Console.ReadKey();
        }

        static void ActivateHero(ISuperHero Ani)
        {
            Ani.ActivateSuperPowers();
        }

        static void IdentifyHero(ISuperHero Ani)
        {
            if (Ani is Flash)
                Console.WriteLine("Flash detected");
            else if (Ani is SpiderMan)
                Console.WriteLine("Spiderman detected");
            else if (Ani is SuperMan)
                Console.WriteLine("Superman detected");
            else
                Console.WriteLine("no known Hero was detected");
        }

        static void GetMoreHeroData(ISuperHero Ani)
        {
            if (Ani is Flash)
            {
                Console.WriteLine("Flash detected");
                Console.WriteLine((Ani as Flash).Voltage);
            }

            else if (Ani is SpiderMan)
            {
                Console.WriteLine("Spiderman detected");
                Console.WriteLine((Ani as SpiderMan).Speed);
            }
            else if (Ani is SuperMan)
            {
                Console.WriteLine("Superman detected");
                Console.WriteLine((Ani as SuperMan).WebLeft);
            }
            else
                Console.WriteLine("no known Hero was detected");
        }

        static ISuperHero CreateHero(string HeroName)
        {
            SpiderMan option1 = new SpiderMan(500, HeroName, 30);
            Flash option2 = new Flash(5, HeroName, 40);
            SuperMan option3 = new SuperMan(60, HeroName, 50);
            switch (HeroName)
            {
                case ("SpiderMan"): return option1; //break;
                case ("Flash"): return option2; //break;
                case ("SuperMan"): return option3; //break;
                default: return null; //break;
            }
        }
    }
}
