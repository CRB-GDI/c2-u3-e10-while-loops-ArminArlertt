namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enemies = 18;
            int playerHP = 10;
            //check for emails
            while (enemies > 0 && playerHP > 5)
                {
                //attack enemies
                enemies--;
                Console.WriteLine("Enemies left: " + enemies);
                //random damage to player may reduce HP 
                    
                }// end of while loop on line 11
           if (enemies < 0 )
            {
                Console.WriteLine("Congratulations, you win!! :3");
            }
            else
            {
                Console.WriteLine("You lose game over");
            }//end of else 
        }
    }
}