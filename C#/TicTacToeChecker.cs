using System;



// the sketch
class TicTacToe {
  static void Main() {
    int count_1 = 0;
    int count_2 = 0;
    int row = 0;
    int column = 0;
    bool WinnerFound = false;
    int[,] board = {
        {1, 2, 1},
        {0, 1, 1},
        {2, 2, 1}
    };
    
    while(!WinnerFound) {
        
        // check rows
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
    
        // check columns
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
        
        // check diagonal (top left -> bottom right)
        if(!WinnerFound) {
            for(int i = 0; i < board.GetLength(0); i++) {
                Console.Write("Diagonal 1: " + board[i, i] + " ");
                
                if(board[i, i] == 1) {
                    count_1++;
                } else {
                    count_1 = 0;
                }
            
                if(board[i, i] == 2) {
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
        
        // check diagonal (top right -> bottom left)
        if(!WinnerFound) {
            int d_rows = board.GetLength(0);
            int d_columns = board.GetLength(1);
            
            for(int j = 0; j < d_rows; j++) {
                Console.WriteLine("Diagonal 2: " + board[j, d_columns - 1 - j] + " ");
                
                if(board[j, d_columns-1-j] == 1) {
                    count_1++;
                } else {
                    count_1 = 0;
                }
            
                if(board[j, d_columns-1-j] == 2) {
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
            Console.Write("Draw\n");
            break;
        }
    }
    
    Console.Write("count_1: " + count_1 + "\n");
    Console.Write("count_2: " + count_2);
  }
}
