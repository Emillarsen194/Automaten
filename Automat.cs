using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automaten
{
    class Automat
    {
        static Stack<Soda> cola = new Stack<Soda>();
        static Stack<Soda> fanta = new Stack<Soda>();
        static Stack<Soda> bluekled = new Stack<Soda>();
        static Stack<Soda> mountaindew = new Stack<Soda>();

        

        private int addedmoney;
        private int moneyroom;
        private bool power;
        private int quantity;

        #region MakeItPublic
        public int Addedmoney
        {
            get
            {
                return addedmoney;
            }

            set
            {
                addedmoney = value;
            }
        }
        public int Moneyroom
        {
            get
            {
                return moneyroom;
            }

            set
            {
                moneyroom = value;
            }
        }

        public bool Power
        {
            get
            {
                return power;
            }

            set
            {
                power = value;
            }
        }
        #endregion

        #region returnstack
        public Stack<Soda> ReturnColas()
        {
            
            return cola;
        }
        public Stack<Soda> ReturnFantas()
        {
            return fanta;
        }
        public Stack<Soda> ReturnBlueKled()
        {
            return bluekled;
        }
        public Stack<Soda> ReturnMountain()
            {
                return mountaindew;

            }
        #endregion

       
        public Automat()
        {

        }
        public void AddSoda()
        {
            
            for (int i = 0; i < 11; i++)
            {
                Soda colacola = new Soda("Coca-Cola", "Cola", 25);
                cola.Push(colacola);
            }

            for (int i = 0; i < 11; i++)
            {
                Soda fantaE = new Soda("Fanta", "Exotic", 20);
                fanta.Push(fantaE);
            }

            for (int i = 0; i < 11; i++)
            {
                Soda bluekledS = new Soda("Bluekled", "Strawberry", 10);
                bluekled.Push(bluekledS);
            }


            for (int i = 0; i < 11; i++)
            {
                Soda mountaindewC = new Soda("Mountaindew", "Citrus", 30);
                mountaindew.Push(mountaindewC);
            }
        }

        public int Addmoney(int Howmuch)
        {
            return Addedmoney = Addedmoney + Howmuch;
        }

        public void BuySoda(int whsoda)
        {
            if (whsoda == 1 && Addedmoney >= 25)
            {
                Console.WriteLine("U bhought a " + ReturnColas().Pop().Taste);
                Thread.Sleep(1500);
                addedmoney = addedmoney - 25;
                
            }

            else if (whsoda == 2 && addedmoney >= 20)
            {
                Console.WriteLine("U bhought a " + ReturnFantas().Pop().Taste);
                Thread.Sleep(1500);
                addedmoney = addedmoney - 20;
                Console.Clear();
            }

            else if (whsoda == 3 && addedmoney >= 10)
            {
                Console.WriteLine("U bhought a " + ReturnBlueKled().Pop().Brand);
                Thread.Sleep(1500);
                addedmoney = addedmoney - 10;
            }

            else if (whsoda == 4 && addedmoney >= 30)
            {
                Console.WriteLine("U bhought a " + ReturnMountain().Pop().Taste);
                Thread.Sleep(1500); 
                addedmoney = addedmoney - 30;
            }

            else
            {
                Thread.Sleep(1500);
                Console.WriteLine("Wrong input or insuficent money!");

            }

        }

        public void RefillSoda(int howmanytoadd, int whichsoda)
        {
            if (whichsoda == 1 && howmanytoadd < 11)
            {

            }
        }


    public void AdministratorMenu(int WhichMenu)
        {

          
            switch (WhichMenu)
            {
                case 1:
                    Console.Clear();
                    CheckSodasGui();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;

            }
        }











        public void CheckSodasGui()
        {
            Console.WriteLine("Cola tilbage: " + ReturnColas().Count());
            Console.WriteLine("Fanta tilbage: " + ReturnFantas().Count());
            Console.WriteLine("Bluekled tilbage: " + ReturnBlueKled().Count());
            Console.WriteLine("Mountaindew tilbage: " + ReturnMountain().Count());
        }
    }
}
      
