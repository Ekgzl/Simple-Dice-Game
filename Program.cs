namespace Simple_Dice_Game;

class Program
{
    static void Main(string[] args)
    {
        int playerNum,aiNum;
        Random random = new Random();
        int[] score = new int[2];
        char switchKey;
        bool flag = true;
        do
        {
            score[0] = 0;
            score[1] = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Press any key to roll the " +
                                  "dice...");
                Console.ReadKey();
                Console.WriteLine("--------");
                playerNum = random.Next(1, 7);
                aiNum = random.Next(1, 7);
                Console.WriteLine("You rolled " + playerNum);
                Console.WriteLine("AI Rolled " + aiNum);
                if (aiNum > playerNum)
                {
                    score[0]++;
                }
                else if (playerNum > aiNum)
                {
                    score[1]++;
                }
                else
                {
                    score[0]++;
                    score[1]++;
                }
                Console.WriteLine("\t\t | | PLAYER: " + score[1] + " | | AI: "+score[0]+ "\n");
                if (score[0] == 3 || score[1] == 3)
                {
                    break;
                }
            }
            if (score[0] > score[1])
            {
                Console.WriteLine("\t\t--------AI WINS-------");
            }
            else if (score[0] == score[1])
            {
                Console.WriteLine("\t\t--------NO WINNER NO DINNER-------");
            }
            else
            {
                Console.WriteLine("\t\t--------PLAYER WINS-------");
            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            
            
            
            
            do
            {
                Console.WriteLine("Do you want to play again?[Y]/[N]: ");
                switchKey = Console.ReadLine()[0];
            } while (switchKey != 'y' && switchKey !='Y' && switchKey != 'N' && switchKey != 'n');

            if (switchKey == 'n' || switchKey == 'N')
            {
                flag = false;
            }
        } while (flag);


        Console.WriteLine("Please press any key to exit..");
        Console.ReadLine();

    }
}