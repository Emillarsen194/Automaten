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
        
        

        private int addedmoney;
        private int moneyroom;
        private bool access;
        
      

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

        public bool Access
        {
            get
            {
                return access;
            }

            set
            {
                access = value;
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

                Soda fantaE = new Soda("Fanta", "Exotic", 20);
                fanta.Push(fantaE);

                Soda bluekledS = new Soda("Bluekled", "Strawberry", 10);
                bluekled.Push(bluekledS);

                Soda mountaindewC = new Soda("Mountaindew", "Citrus", 30);
                mountaindew.Push(mountaindewC);
            }

        }


        public int Addmoney(int Howmuch) //add money in the machine logic
        {
            return Addedmoney = Addedmoney + Howmuch;
        }

        public String BuySoda(int whsoda) //a method that does so we can buy soda and earn money for it and so on
        {

   
            if (whsoda == 1 && Addedmoney >= ReturnColas().Peek().Price)
            {
               
                addedmoney = addedmoney - ReturnColas().Peek().Price;
                moneyroom = moneyroom + ReturnColas().Peek().Price;
                
                return "U bhought a " + ReturnColas().Pop().Taste;
            }


            else if (whsoda == 2 && addedmoney >= ReturnFantas().Peek().Price)
            {
                
                addedmoney = addedmoney - ReturnFantas().Peek().Price;
                Console.Clear();
                moneyroom = moneyroom + ReturnFantas().Peek().Price;

               return "U bhought a " + ReturnFantas().Pop().Taste;
            }

            else if (whsoda == 3 && addedmoney >= ReturnBlueKled().Peek().Price)
            {
                
                addedmoney = addedmoney - ReturnBlueKled().Peek().Price;
                moneyroom = moneyroom + ReturnBlueKled().Peek().Price;

                return "U bhought a " + ReturnBlueKled().Pop().Brand;
            }

            else if (whsoda == 4 && addedmoney >= ReturnMountain().Peek().Price)
            {

                addedmoney = addedmoney - ReturnMountain().Peek().Price;
                moneyroom = moneyroom + ReturnMountain().Peek().Price;

               return "U bhought a " + ReturnMountain().Pop().Brand;
                

            }

            else
            {
              
                return "insuficent money!";

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


        public bool AdminLogin(String username, String pass) //checks username and password on administrator menu
        {
            if (username == "admin" && pass == "soda")
            {

                return Access = true;

            }

            return Access;
        

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
      
