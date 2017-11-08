using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            State state = new State(4);
            state.Move(state.Direction);
            state.Print();
        }
    }

    public class State
    {
        public int[,] Current { get; private set; }
        public int Direction { get; private set; }

        public State(int n)
        {
            Current = new int[n, n];
            ReadState(n);
            ReadDirection();
        }

        private void ReadState(int n)
        {
            string[] str;

            for (int i = 0; i < n; i++) {
                str = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    Current[i, j] = int.Parse(str[j]);
            }
        }

        private void ReadDirection()
        {
            Direction = int.Parse(Console.ReadLine());
        }

        public void Move(int n)
        {
            switch(n) {
                case 0:
                    MoveLeft();
                    break;
                case 1:
                    MoveUp();
                    break;
                case 2:
                    MoveRight();
                    break;
                case 3:
                    MoveDown();
                    break;
            }


        }

        private void MoveLeft()
        {
            for(int i=0; i<Current.GetLength(0); i++) {
                int location = -1, count = 0; ; //location is -1 as default instead of 0 due to for loops begining at 0.

                for (int j=0; j<Current.GetLength(1); j++) { // Change all 0s furthest to the right.
                    if(Current[i, j] == 0) { //Check place for 0.
                        count++;
                        if (count == 1) //If it's the first 0, this is the location to be swapped.
                            location = j;
                    }
                    else if(Current[i, j] != 0 && location != -1) { //If location is changed, a 0 exists.
                        Current[i, location] = Current[i, j]; //Swap current value to where 0 was located.
                        Current[i, j] = 0; 
                        location = j; // 0s current location.
                        count = 0; 
                    }
                }

                for(int j=0; j<Current.GetLength(1)-1; j++) { //Check if neighbours are equal, double the left right to 0.
                    if(Current[i, j] != 0 && Current[i, j] == Current[i, j+1]) {
                        Current[i, j] *= 2;
                        for (int k = j + 1; k < Current.GetLength(1) - 1; k++) // Shift all remaining values left one step.
                            Current[i, k] = Current[i, k + 1];
                        Current[i, Current.GetLength(1) - 1] = 0; //Move 0 furthest to the right.
                    }
                }
            }
        }

        private void MoveUp()
        {
            for (int j = 0; j < Current.GetLength(0); j++) {
                int location = -1, count = 0; ; //location is -1 as default instead of 0 due to for loops begining at 0.

                for (int i = 0; i < Current.GetLength(1); i++) { // Change all 0s furthest to the right.
                    if (Current[i, j] == 0) { //Check place for 0.
                        count++;
                        if (count == 1) //If it's the first 0, this is the location to be swapped.
                            location = i;
                    }
                    else if (Current[i, j] != 0 && location != -1) { //If location is changed, a 0 exists.
                        Current[location, j] = Current[i, j]; //Swap current value to where 0 was located.
                        Current[i, j] = 0;
                        location = i; // 0s current location.
                        count = 0;
                    }
                }

                for (int i = 0; i < Current.GetLength(1) - 1; i++) { //Check if neighbours are equal, double the top under to 0.
                    if (Current[i, j] != 0 && Current[i, j] == Current[i + 1, j]) {
                        Current[i, j] *= 2;
                        for (int k = i + 1; k < Current.GetLength(1) - 1; k++) // Shift all remaining values top one step.
                            Current[k, j] = Current[k + 1, j];
                        Current[Current.GetLength(1) - 1, j] = 0; //Move 0 furthest to the bottom.
                    }
                }
            }
        }

        private void MoveRight()
        {
            for (int i = 0; i < Current.GetLength(0); i++)
            {
                int location = -1, count = 0; ; //location is -1 as default instead of 0 due to for loops begining at 0.

                for (int j = Current.GetLength(1)-1; j > -1; j--) { // Change all 0s furthest to the right.
                    if (Current[i, j] == 0) { //Check place for 0.
                        count++;
                        if (count == 1) //If it's the first 0, this is the location to be swapped.
                            location = j;
                    }
                    else if (Current[i, j] != 0 && location != -1) { //If location is changed, a 0 exists.
                        Current[i, location] = Current[i, j]; //Swap current value to where 0 was located.
                        Current[i, j] = 0;
                        location = j; // 0s current location.
                        count = 0;
                    }
                }

                for (int j = Current.GetLength(1)-1; j > 0; j--)
                { //Check if neighbours are equal, double the right left to 0.
                    if (Current[i, j] != 0 && Current[i, j] == Current[i, j-1]) {
                        Current[i, j] *= 2;
                        for (int k = j - 1; k > 0; k--) // Shift all remaining values right one step.
                            Current[i, k] = Current[i, k - 1];
                        Current[i, 0] = 0; //Move 0 furthest to the left.
                    }
                }
            }
        }

        private void MoveDown()
        {
            for (int j = 0; j < Current.GetLength(0); j++) {
                int location = -1, count = 0; ; //location is -1 as default instead of 0 due to for loops begining at 0.

                for (int i = Current.GetLength(1) - 1; i > -1; i--) { // Change all 0s furthest to the right.
                    if (Current[i, j] == 0) { //Check place for 0.
                        count++;
                        if (count == 1) //If it's the first 0, this is the location to be swapped.
                            location = i;
                    }
                    else if (Current[i, j] != 0 && location != -1) { //If location is changed, a 0 exists.
                        Current[location, j] = Current[i, j]; //Swap current value to where 0 was located.
                        Current[i, j] = 0;
                        location = i; // 0s current location.
                        count = 0;
                    }
                }

                for (int i = Current.GetLength(1) - 1; i > 0; i--) { //Check if neighbours are equal, double the bottom top to 0.
                    if (Current[i, j] != 0 && Current[i, j] == Current[i - 1, j]) {
                        Current[i, j] *= 2;
                        for (int k = i - 1; k > 0; k--) // Shift all remaining values down one step.
                            Current[k, j] = Current[k - 1, j];
                        Current[0, j] = 0; //Move 0 furthest to the top.
                    }
                }
            }
        }

        public void Print()
        {
            for(int i=0; i<Current.GetLength(0); i++) {
                for (int j = 0; j < Current.GetLength(1); j++)
                    Console.Write($"{Current[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}
