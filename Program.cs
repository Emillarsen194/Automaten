using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Gui gui = new Gui();
            Automat Logic = new Automat();
            Logic.AddSoda();
            Logic.ReturnColas();
            Console.ForegroundColor = ConsoleColor.Green;
            string[] Textmsg = { @" $$$$$$\                  $$\                  $$$$$$\              $$\                                        $$\     
$$  __$$\                 $$ |                $$  __$$\             $$ |                                       $$ |    
$$ /  \__| $$$$$$\   $$$$$$$ | $$$$$$\        $$ /  $$ |$$\   $$\ $$$$$$\    $$$$$$\  $$$$$$\$$$$\   $$$$$$\ $$$$$$\   
\$$$$$$\  $$  __$$\ $$  __$$ | \____$$\       $$$$$$$$ |$$ |  $$ |\_$$  _|  $$  __$$\ $$  _$$  _$$\  \____$$\\_$$  _|  
 \____$$\ $$ /  $$ |$$ /  $$ | $$$$$$$ |      $$  __$$ |$$ |  $$ |  $$ |    $$ /  $$ |$$ / $$ / $$ | $$$$$$$ | $$ |    
$$\   $$ |$$ |  $$ |$$ |  $$ |$$  __$$ |      $$ |  $$ |$$ |  $$ |  $$ |$$\ $$ |  $$ |$$ | $$ | $$ |$$  __$$ | $$ |$$\ 
\$$$$$$  |\$$$$$$  |\$$$$$$$ |\$$$$$$$ |      $$ |  $$ |\$$$$$$  |  \$$$$  |\$$$$$$  |$$ | $$ | $$ |\$$$$$$$ | \$$$$  |
 \______/  \______/  \_______| \_______|      \__|  \__| \______/    \____/  \______/ \__| \__| \__| \_______|  \____/ 
                                                                                                                       " };


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Textmsg[0]);
                Console.ResetColor();

            gui.Menu(Logic.Addedmoney, Logic.Moneyroom);

        

            Console.Write("\n\n choose: ");
            int whichMenu = int.Parse(Console.ReadLine());


            switch (whichMenu)
            {
                    case 1:
                        gui.AddMoney();
                        int howmuch = int.Parse(Console.ReadLine());
                        switch (howmuch)
                        {
                            case 1:
                                Logic.Addmoney(5);
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
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        gui.BuySodaGui();
                       
                        int whichSoda = int.Parse(Console.ReadLine());
                        Logic.BuySoda(whichSoda);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();

                        gui.AdministratorGui();

                        int whichAdminMenu = int.Parse(Console.ReadLine());
                        

                switch (whichAdminMenu)
                {
                    case 1:
                        Console.Clear();
                        Logic.CheckSodasGui();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        gui.RefillGui();
                        byte whichSodas = byte.Parse(Console.ReadLine());
                        Logic.RefillSoda(whichSodas);
                        break;
                    case 3:
                                Console.Clear();
                                gui.CheckMoneyRoom(Logic.Moneyroom);
                        break;
                    case 4:
                                Console.Clear();
                                gui.TakemoneyGui();
                                int howmuchMoney = int.Parse(Console.ReadLine());
                                Logic.TakeMoneyFromMoneyRoom(howmuchMoney);
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
                        break;
                     
            }


              
         
                    
                    





                

               
            }

        }
    }
}
