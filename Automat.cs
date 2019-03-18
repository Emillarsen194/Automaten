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
        //making our stacks holding the diffrent objects
        static Stack<Soda> cola = new Stack<Soda>();
        static Stack<Soda> fanta = new Stack<Soda>();
        static Stack<Soda> bluekled = new Stack<Soda>();
        static Stack<Soda> mountaindew = new Stack<Soda>();
        Gui LogicGui = new Gui();
        

        private int addedmoney;
        private int moneyroom;
        private bool power;
      

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
        public void AddSoda() //adds soda to the stacks and creating objects 
        {
            
            for (int i = 0; i < 11; i++) // creating 11 objects in the cocacola stack
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

        public int Addmoney(int Howmuch) //add money in the machine logic
        {
            return Addedmoney = Addedmoney + Howmuch;
        }

        public void BuySoda(int whsoda) //a method that does so we can buy soda and earn money for it and so on
        {
            if (whsoda == 1 && Addedmoney >= 25)
            {
                Console.WriteLine("U bhought a " + ReturnColas().Pop().Taste);
                Thread.Sleep(1500);
                addedmoney = addedmoney - 25;
                moneyroom = moneyroom + 25;
                
            }

            else if (whsoda == 2 && addedmoney >= 20)
            {
                Console.WriteLine("U bhought a " + ReturnFantas().Pop().Taste);
                Thread.Sleep(1500);
                addedmoney = addedmoney - 20;
                Console.Clear();
                moneyroom = moneyroom + 20;
            }

            else if (whsoda == 3 && addedmoney >= 10)
            {
                Console.WriteLine("U bhought a " + ReturnBlueKled().Pop().Brand);
                Thread.Sleep(1500);
                addedmoney = addedmoney - 10;
                moneyroom = moneyroom + 10;
            }

            else if (whsoda == 4 && addedmoney >= 30)
            {
                Console.WriteLine("U bhought a " + ReturnMountain().Pop().Taste);
                Thread.Sleep(1500); 
                addedmoney = addedmoney - 30;
                moneyroom = moneyroom + 30;

            }

            else
            {
                Thread.Sleep(1500);
                Console.WriteLine("Wrong input or insuficent money!");
            
            }

        }

        public void RefillSoda(byte whichsoda)  //being able to refill soda with new objects 
        {

            switch (whichsoda)
            {
                case 1:
                    while (ReturnColas().Count < 11) // runs while sodas quanity is less than 11
                    {

                        Soda colacola = new Soda("Coca-Cola", "Cola", 25); //making new objects in the stack
                        cola.Push(colacola);

                    }
                    break;



                case 2:
                    while (ReturnFantas().Count < 11)
                    {

                        Soda fantaE = new Soda("Fanta", "Exotic", 20);
                        fanta.Push(fantaE);

                    }
                    break;


                case 3:
                    while (ReturnFantas().Count < 11)
                    {

                        Soda bluekledS = new Soda("Bluekled", "Strawberry", 10);
                        bluekled.Push(bluekledS);

                    }
                    break;


                case 4:
                    while (ReturnFantas().Count < 11)
                    {

                        Soda mountaindewC = new Soda("Mountaindew", "Citrus", 30);
                        mountaindew.Push(mountaindewC);

                    }
                    break;


            }



        }


        public void TakeMoneyFromMoneyRoom(int howmuch) //take our earnings out of the money room
        {
            if (howmuch <= moneyroom)
            {
         moneyroom = moneyroom - howmuch;
            }

            else
            {
                Console.WriteLine("U dont have that much in moneyroom u currently have: " + moneyroom);
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
      
