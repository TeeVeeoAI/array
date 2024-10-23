//Uppgift 4

char[,] gameboard = new char[,]{
    {'-', '-', '-'},
    {'-', '-', '-'},
    {'-', '-', '-'}
};
while (true) {
    Main();   
}

void Main() {
    Player1();
    Player2();
}

void Player1() {
    Gameboard_load(gameboard);
    Console.WriteLine("player1 enter a cordinet on the board. x,y");
    string Input = Console.ReadLine();
    string[] input = Input.Split(',');
    char input_x = Convert.ToChar(input[0]);
    char input_y = Convert.ToChar(input[1]);
    gameboard[input_x, input_y] = 'x';
}

void Player2() {
    Gameboard_load(gameboard);
    Console.WriteLine("player2 enter a cordinet on the board. x,y");
    string Input = Console.ReadLine();
    string[] input = Input.Split(',');
    char input_x = Convert.ToChar(input[0]);
    char input_y = Convert.ToChar(input[1]);
    gameboard[input_x, input_y] = 'o';
}

void Gameboard_load(char[,] gb) {
    for (int i = 0; i < gb.GetLength(0); i++) {
        for (int j = 0; j < gb.GetLength(1); j++) {
            if (i == 0) {
                if (j == 2) {
                    Console.WriteLine(gb[i, j] + " ");
                } else {
                    Console.Write(gb[i, j] + " ");
                }
            } else if (i == 1) {
                if (j == 2) {
                    Console.WriteLine(gb[i, j] + " ");
                } else {
                    Console.Write(gb[i, j] + " ");
                }
            } else if (i == 2) {
                if (j == 2) {
                    Console.WriteLine(gb[i, j] + " ");
                } else {
                    Console.Write(gb[i, j] + " ");
                }
            }
        }
    }
}