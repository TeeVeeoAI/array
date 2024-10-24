//Uppgift 4

char[,] gameboard = new char[,] {
    {'-', '-', '-'},
    {'-', '-', '-'},
    {'-', '-', '-'}
};
int P1_wins = 0;
int P2_wins = 0;
int Count = 0;
while (true) {
    Main();
}

void Main() {
    Player1();
    Win();
    Player2();
    Win();
}

void Player1() {
    if (P1_wins > 0 || P2_wins > 0) {
        Console.WriteLine("\n" + "The score is: " + P1_wins + " : " + P2_wins + "\n");
        Count++;
    }
    Gameboard_load(gameboard);
    if (Count == 0) {
        Console.WriteLine("Player1 enter a cordinet on the board. x,y");
    }
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
    if (P1_wins > 0 || P2_wins > 0) {
        Console.WriteLine("\n" + "The score is: " + P1_wins + " : " + P2_wins + "\n");
        Count++;
    }
    Gameboard_load(gameboard);
    if (Count == 0) {
        Console.WriteLine("Player2 enter a cordinet on the board. x,y");
    }
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

void Win() {
    for (int i = 0; i < 3; i++) {
        if (gameboard[i, 0] == 'x' && gameboard[i, 1] == 'x' && gameboard[i, 2] == 'x' || 
            gameboard[0, i] == 'x' && gameboard[1, i] == 'x' && gameboard[2, i] == 'x' ||
            gameboard[0, 0] == 'x' && gameboard[1, 1] == 'x' && gameboard[2, 2] == 'x' ||
            gameboard[2, 0] == 'x' && gameboard[1, 1] == 'x' && gameboard[0, 2] == 'x') {
            Console.WriteLine("Player1 wins");
            Reset();
            P1_wins++;
        } else if  (gameboard[i, 0] == 'o' && gameboard[i, 1] == 'o' && gameboard[i, 2] == 'o' || 
                    gameboard[0, i] == 'o' && gameboard[1, i] == 'o' && gameboard[2, i] == 'o' ||
                    gameboard[0, 0] == 'o' && gameboard[1, 1] == 'o' && gameboard[2, 2] == 'o' ||
                    gameboard[2, 0] == 'o' && gameboard[1, 1] == 'o' && gameboard[0, 2] == 'o') {
                        Console.WriteLine("Player2 wins");
                        Reset();
                        P2_wins++;
                    }
    }
}

void Reset() {
    gameboard = new char[,] {
        {'-', '-', '-'},
        {'-', '-', '-'},
        {'-', '-', '-'}
    };
}