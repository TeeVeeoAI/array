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
    while (true) {
        string Input = Console.ReadLine();
        string[] input = Input.Split(",");
        int input_x = Convert.ToInt32(input[0]);
        int input_y = Convert.ToInt32(input[1]);
        if (gameboard[input_y-1, input_x-1] == '-') {
            gameboard[input_y-1, input_x-1] = 'x';
            break;
        } else {
            Console.WriteLine("Invalid, retry");
        }
    }
}

void Player2() {
    Gameboard_load(gameboard);
        Console.WriteLine("player2 enter a cordinet on the board. x,y");
    while (true) {
        string Input = Console.ReadLine();
        string[] input = Input.Split(",");
        int input_x = Convert.ToInt32(input[0]);
        int input_y = Convert.ToInt32(input[1]);
        if (gameboard[input_y-1, input_x-1] == '-') {
            gameboard[input_y-1, input_x-1] = 'o';
            break;
        } else {
            Console.WriteLine("Invalid, retry");
        }
    }
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