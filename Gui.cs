using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Gui
    {
        public Gui()
        {

        }
        public void Menu(int addedmoney, int moneyroom)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1. Add Money          " + "Total Added Money: " + addedmoney  + "Kr");
            Console.WriteLine("2. Buy Soda");
            Console.WriteLine("3. Administrator Menu");
            Console.WriteLine("-----------------------------------------------");
        }


        public void AddMoney()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1 = 5Kr");
            Console.WriteLine("2 = 10kr");
            Console.WriteLine("3 = 20kr");
            Console.WriteLine("How much money do u wanna add to the machine: ");
            Console.WriteLine("----------------------------------------------");
            

        }

        public void BuySodaGui()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            #region Buysodasign
            Console.WriteLine(@"$$$$$$$\                             $$$$$$\                  $$\           
$$  __$$\                           $$  __$$\                 $$ |          
$$ |  $$ |$$\   $$\ $$\   $$\       $$ /  \__| $$$$$$\   $$$$$$$ | $$$$$$\  
$$$$$$$\ |$$ |  $$ |$$ |  $$ |      \$$$$$$\  $$  __$$\ $$  __$$ | \____$$\ 
$$  __$$\ $$ |  $$ |$$ |  $$ |       \____$$\ $$ /  $$ |$$ /  $$ | $$$$$$$ |
$$ |  $$ |$$ |  $$ |$$ |  $$ |      $$\   $$ |$$ |  $$ |$$ |  $$ |$$  __$$ |
$$$$$$$  |\$$$$$$  |\$$$$$$$ |      \$$$$$$  |\$$$$$$  |\$$$$$$$ |\$$$$$$$ |
\_______/  \______/  \____$$ |       \______/  \______/  \_______| \_______|
                    $$\   $$ |                                              
                    \$$$$$$  |                                              
                     \______/                               ");
            #endregion
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1. CocaCola                    25Kr");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("2. Fanta Exotic                20Kr");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("3. Bluekled(strawberry flavor) 10Kr");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("4. Mountaindew                 30Kr");
            Console.WriteLine("----------------------------------------------");

            Console.Write("\n\n Choose One: ");
        }

        public void AdministratorGui()
        {
            #region administator sign
            Console.WriteLine(@" $$$$$$\        $$\               $$\           $$\             $$\                         $$\                                                   $$\           
$$  __$$\       $$ |              \__|          \__|            $$ |                        $$ |                                                  $$ |          
$$ /  $$ | $$$$$$$ |$$$$$$\$$$$\  $$\ $$$$$$$\  $$\  $$$$$$$\ $$$$$$\    $$$$$$\  $$$$$$\ $$$$$$\    $$$$$$\   $$$$$$\         $$$$$$\  $$$$$$$\  $$ |$$\   $$\ 
$$$$$$$$ |$$  __$$ |$$  _$$  _$$\ $$ |$$  __$$\ $$ |$$  _____|\_$$  _|  $$  __$$\ \____$$\\_$$  _|  $$  __$$\ $$  __$$\       $$  __$$\ $$  __$$\ $$ |$$ |  $$ |
$$  __$$ |$$ /  $$ |$$ / $$ / $$ |$$ |$$ |  $$ |$$ |\$$$$$$\    $$ |    $$ |  \__|$$$$$$$ | $$ |    $$ /  $$ |$$ |  \__|      $$ /  $$ |$$ |  $$ |$$ |$$ |  $$ |
$$ |  $$ |$$ |  $$ |$$ | $$ | $$ |$$ |$$ |  $$ |$$ | \____$$\   $$ |$$\ $$ |     $$  __$$ | $$ |$$\ $$ |  $$ |$$ |            $$ |  $$ |$$ |  $$ |$$ |$$ |  $$ |
$$ |  $$ |\$$$$$$$ |$$ | $$ | $$ |$$ |$$ |  $$ |$$ |$$$$$$$  |  \$$$$  |$$ |     \$$$$$$$ | \$$$$  |\$$$$$$  |$$ |            \$$$$$$  |$$ |  $$ |$$ |\$$$$$$$ |
\__|  \__| \_______|\__| \__| \__|\__|\__|  \__|\__|\_______/    \____/ \__|      \_______|  \____/  \______/ \__|             \______/ \__|  \__|\__| \____$$ |
                                                                                                                                                      $$\   $$ |
                                                                                                                                                      \$$$$$$  |
                                                                                                                                                       \______/ ");
            #endregion

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" 1. Check how many Sodas back in each room    ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" 2. Refill the machine ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" 3. Check how many money in money room        ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" 4. Take money from money room                ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" 5. Stats from sales the last month           ");
            Console.WriteLine("----------------------------------------------");
        }

        public void RefillGui()
        {
            #region administator sign
            Console.WriteLine(@" $$$$$$\        $$\               $$\           $$\             $$\                         $$\                                                   $$\           
$$  __$$\       $$ |              \__|          \__|            $$ |                        $$ |                                                  $$ |          
$$ /  $$ | $$$$$$$ |$$$$$$\$$$$\  $$\ $$$$$$$\  $$\  $$$$$$$\ $$$$$$\    $$$$$$\  $$$$$$\ $$$$$$\    $$$$$$\   $$$$$$\         $$$$$$\  $$$$$$$\  $$ |$$\   $$\ 
$$$$$$$$ |$$  __$$ |$$  _$$  _$$\ $$ |$$  __$$\ $$ |$$  _____|\_$$  _|  $$  __$$\ \____$$\\_$$  _|  $$  __$$\ $$  __$$\       $$  __$$\ $$  __$$\ $$ |$$ |  $$ |
$$  __$$ |$$ /  $$ |$$ / $$ / $$ |$$ |$$ |  $$ |$$ |\$$$$$$\    $$ |    $$ |  \__|$$$$$$$ | $$ |    $$ /  $$ |$$ |  \__|      $$ /  $$ |$$ |  $$ |$$ |$$ |  $$ |
$$ |  $$ |$$ |  $$ |$$ | $$ | $$ |$$ |$$ |  $$ |$$ | \____$$\   $$ |$$\ $$ |     $$  __$$ | $$ |$$\ $$ |  $$ |$$ |            $$ |  $$ |$$ |  $$ |$$ |$$ |  $$ |
$$ |  $$ |\$$$$$$$ |$$ | $$ | $$ |$$ |$$ |  $$ |$$ |$$$$$$$  |  \$$$$  |$$ |     \$$$$$$$ | \$$$$  |\$$$$$$  |$$ |            \$$$$$$  |$$ |  $$ |$$ |\$$$$$$$ |
\__|  \__| \_______|\__| \__| \__|\__|\__|  \__|\__|\_______/    \____/ \__|      \_______|  \____/  \______/ \__|             \______/ \__|  \__|\__| \____$$ |
                                                                                                                                                      $$\   $$ |
                                                                                                                                                      \$$$$$$  |
                                                                                                                                                       \______/ ");
            #endregion

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" 1. Fill up on Cola    ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" 2. Fill up on Fanta ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" 3. Fill up on bluekled ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" 4. Fill up on Mountaindew");
            Console.WriteLine("----------------------------------------------");
        }


        public void CheckMoneyRoom(int moneyroom)
        {
            Console.WriteLine("Money in moneyroom: " + moneyroom + "Dkk\n\n");
        }

        public void TakemoneyGui()
        {
            Console.WriteLine("How much money do u wanna take from money room cant take more than u have though");
        }






    }
}
