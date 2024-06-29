// yea ik bloody hell

using System;
class HelloWorld {
  static void Main() {
    int count_1 = 0;
    int count_2 = 0;
    int row = 0;
    int column = 0;
    bool WinnerFound = false;
    int[,] board = {
        {1, 2, 1},
        {0, 1, 0},
        {2, 2, 0}
    };
    
    while(!WinnerFound) {
        count_1 = 0;
        count_2 = 0;
        for(row = 0; row < board.GetLength(0); row++) {

            for(column = 0; column < board.GetLength(1); column++) {
                Console.Write("Row " + row + ", Col " + column + " -> " + board[row, column] + "\n");
            
            
                if(board[row, column] == 1) {
                    count_1++;
                } else {
                    count_1 = 0;
                }
            
                if(board[row, column] == 2) {
                    count_2++;
                } else {
                    count_2 = 0;
                }
            
                if(count_1 == 3) {
                    Console.Write("Player 1 won\n");
                    WinnerFound = true;
                    break;
                } else if (count_2 == 3) {
                    Console.Write("Player 2 won\n");
                    WinnerFound = true;
                    break;
                }
                
                if(WinnerFound) break;
            }
        }
    
        
        if(!WinnerFound) {
            for(column = 0; column < board.GetLength(1); column++) {
                count_1 = 0;
                count_2 = 0;

                for(row = 0; row < board.GetLength(0); row++) {
                    Console.Write("Row " + row + ", Col " + column + " -> " + board[row, column] + "\n");
                    
                    if(board[row, column] == 1) {
                        count_1++;
                    } else {
                        count_1 = 0;
                    }
            
                    if(board[row, column] == 2) {
                        count_2++;
                    } else {
                        count_2 = 0;
                    }
            
                    if(count_1 == 3) {
                        Console.Write("Player 1 won\n");
                        WinnerFound = true;
                        break;
                    } else if (count_2 == 3) {
                        Console.Write("Player 2 won\n");
                        WinnerFound = true;
                        break;
                    }
                
                }
                
                if(WinnerFound) break;
            }
        }
        
        if(!WinnerFound) {
            for(int i = 0; i < board.GetLength(0); i++) {
                Console.WriteLine(board[i, i]);
            }
        }
        
        if(!WinnerFound) {
            Console.Write("Draw\n");
            break;
        }
    }
    
    Console.Write("count_1: " + count_1 + "\n");
    Console.Write("count_2: " + count_2);
  }
}
