using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Gui gui = new Gui();
            Automat Logic = new Automat(); //creating our automat object
            Logic.AddSoda(); //adding our sodas

            Console.ForegroundColor = ConsoleColor.Green; //changing colors
            string[] Textmsg = { @" $$$$$$\                  $$\                  $$$$$$\              $$\                                        $$\     
$$  __$$\                 $$ |                $$  __$$\             $$ |                                       $$ |    
$$ /  \__| $$$$$$\   $$$$$$$ | $$$$$$\        $$ /  $$ |$$\   $$\ $$$$$$\    $$$$$$\  $$$$$$\$$$$\   $$$$$$\ $$$$$$\   
\$$$$$$\  $$  __$$\ $$  __$$ | \____$$\       $$$$$$$$ |$$ |  $$ |\_$$  _|  $$  __$$\ $$  _$$  _$$\  \____$$\\_$$  _|  
 \____$$\ $$ /  $$ |$$ /  $$ | $$$$$$$ |      $$  __$$ |$$ |  $$ |  $$ |    $$ /  $$ |$$ / $$ / $$ | $$$$$$$ | $$ |    
$$\   $$ |$$ |  $$ |$$ |  $$ |$$  __$$ |      $$ |  $$ |$$ |  $$ |  $$ |$$\ $$ |  $$ |$$ | $$ | $$ |$$  __$$ | $$ |$$\ 
\$$$$$$  |\$$$$$$  |\$$$$$$$ |\$$$$$$$ |      $$ |  $$ |\$$$$$$  |  \$$$$  |\$$$$$$  |$$ | $$ | $$ |\$$$$$$$ | \$$$$  |
 \______/  \______/  \_______| \_______|      \__|  \__| \______/    \____/  \______/ \__| \__| \__| \_______|  \____/ 
                                                                                                                       " }; // one of our textmsg in a array for easier printing


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Textmsg[0]); //writing our big sign at index 0
                Console.ResetColor();

                gui.Menu(Logic.Addedmoney); // printing our menu + our current added money 



                Console.Write("\n\n choose: ");
                try //trying this code 
                {
                    int whichMenu = int.Parse(Console.ReadLine()); //readsline on which menu we use

                    switch (whichMenu)
                    {
                        case 1:
                            gui.AddMoney(); // this is our add money menu
                            int howmuch = int.Parse(Console.ReadLine());
                            AddMoney(howmuch);

                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            gui.BuySodaGui(Logic.ReturnColas().Peek().Price, Logic.ReturnFantas().Peek().Price, 
                                Logic.ReturnBlueKled().Peek().Price, Logic.ReturnMountain().Peek().Price); // prints our buy sodagui

                            int whichSoda = int.Parse(Console.ReadLine()); //which soda do u wanna buy
                            Console.WriteLine(Logic.BuySoda(whichSoda));   //calls our method that buy the soda
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;

                        case 3:
                            if (Logic.Access == false)
                            {

                                Console.Write("\n\n username: ");
                                String username = Console.ReadLine();
                                Console.Write("\n\n password: ");
                                String pass = Console.ReadLine();

                                Logic.AdminLogin(username, pass);
                            }
                            if (Logic.Access == true)
                            {

                                SwitchAdmin();
                               
                            }
                            else
                            {
                                Console.WriteLine("wrong password");
                            }
                            break;
                    }

                }

                catch (FormatException e) //if we write anything else than numbers 
                {
                    Console.Clear();
                    Console.WriteLine("fejl du kan kun skrive tal " + e.Message);
                }

                catch (Exception e) //if user does somthing really stupid
                {
                    Console.WriteLine("fejl1" + e.Message);
                }

            }















            // Down Below is our switch cases 


            void AddMoney(int howmuch)
            {
            switch (howmuch)
                        {
                            case 1:
                                Logic.Addmoney(5); //adds 5 to added money and so on
                                break;
                            case 2:
                                Logic.Addmoney(10);
                                break;
                            case 3:
                                Logic.Addmoney(20);
                                break;
                            default:
                                Console.WriteLine("u cant use anyother dk than 5, 10, 20");
                                break;
                        }

            }


            void SwitchAdmin()
            {
                Console.Clear();

                gui.AdministratorGui(); // calls our admin menu

                int whichAdminMenu = int.Parse(Console.ReadLine()); // and what do we wanna do in the admin menu



                switch (whichAdminMenu)
                {
                    case 1:

                        Console.Clear();
                        Logic.CheckSodasGui(); //checking how many sodas back in each stack
                        Console.ReadLine();
                        break;

                    case 2:

                        Console.Clear();
                        gui.RefillGui(); //refill gui
                        byte whichSodas = byte.Parse(Console.ReadLine());
                        Logic.RefillSoda(whichSodas); // refill the choosen soda to max again
                        break;

                    case 3:
                        Console.Clear();
                        gui.CheckMoneyRoom(Logic.Moneyroom); // checking our money room for how much money we have earned 
                        break;
                    case 4:
                        Console.Clear();
                        gui.TakemoneyGui(); // take money from the machine gui
                        int howmuchMoney = int.Parse(Console.ReadLine());
                        Logic.TakeMoneyFromMoneyRoom(howmuchMoney); //method that allow us to take money from the moneyroom
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            }
        
       

        }
    }
}
