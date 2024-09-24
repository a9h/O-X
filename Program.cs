namespace random;





class Game
{
    public static string Board(string[] rowOne, string[] rowTwo, string[] rowThree)
    {

        string board = @$"
╔═══╗ ╔═══╗ ╔═══╗
║ {rowOne[0]} ║ ║ {rowOne[1]} ║ ║ {rowOne[2]} ║
╚═══╝ ╚═══╝ ╚═══╝         
╔═══╗ ╔═══╗ ╔═══╗    
║ {rowTwo[0]} ║ ║ {rowTwo[1]} ║ ║ {rowTwo[2]} ║     
╚═══╝ ╚═══╝ ╚═══╝    
╔═══╗ ╔═══╗ ╔═══╗
║ {rowThree[0]} ║ ║ {rowThree[1]} ║ ║  {rowThree[2]}║
╚═══╝ ╚═══╝ ╚═══╝
";
        return board;

         

    }






    public static bool CorrectInput(int positon, string[] row)
    {
        if (row[positon] != " ")
        {
            return false;
        }
        else
        {
            return true;
        }


    }








    public void newGame()
    {


        int position;
        int counter = 2;
        int player;
        string symbol;


        string[] rowOne = { " ", " ", " " };
        string[] rowTwo = { " ", " ", " " };
        string[] rowThree = { " ", " ", " " };

        

        while (true){

            if (counter % 2 == 0)
            {
                player = 1;
                symbol = "x";
            }
            else
            {
                player = 2;
                symbol = "O";
            }




            Console.WriteLine(Board(rowOne, rowTwo, rowThree));

            Console.WriteLine($"Player {player}: Enter tile (1-9, left to right): ");

            position = Convert.ToInt32(Console.ReadLine());

            if (position <= 3)
            {
                position = position - 1;
                if (CorrectInput(position, rowOne) == true)
                {
                    rowOne[position] = symbol;
                }
                else
                {
                    counter--;
                    Console.Write("Incorrect move!");
                }


            }
            else if (position > 3 && position < 7)
            {
                position = position - 4;
                if (CorrectInput(position, rowTwo) == true)
                {
                    rowTwo[position] = symbol;
                }
                else
                {
                    counter--;
                    Console.Write("Incorrect move!");
                }
            }
            else
            {
                position = position - 7;
                if (CorrectInput(position, rowThree) == true)
                {
                    rowThree[position] = symbol;
                }
                else
                {
                    counter--;
                    Console.Write("Incorrect move!");
                }
            }
            counter++;
            Console.Clear();









        } 
    }


















    class Program
    {







        static void Main(string[] args)
        {



            Game game = new Game();

            game.newGame();














        }
    } }

