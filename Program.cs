using System;

namespace Prac_3 {

    public class Matrix {

        public void Task1(int N) {

            int[] Array = new int[N];

            for(int i = 0; i < N; i++)
                Array[i] = i+1;
            for(int i = N-1; i >=0; i--)
                Console.Write($"[{Array[i]}] ");
            Console.WriteLine("\n");
        }

        public void Task2(int N) {

            int[] Size = new int[N];
            int[,] Matrix = new int[Size.Length, Size.Length];

            for(int i = 0; i < N; i++)
                Matrix[i, i] = 1;

            for(int i = 0; i < N-1; i++)
                Matrix[i+1, i] = 1;

            for(int i = 0; i < N; i++)
                for(int j = i+1; j < N; j++)
                    Matrix[i, j] = 1;


            for(int i = 0; i < N; i++) {
                for(int j = 0; j < N; j++)
                    Console.Write($"[{Matrix[i, j]}] ");
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
        }


        public void Task3(int M, int N) {

            int[] Width = new int[M];
            int[] Length = new int[N];

            int[,] Matrix = new int[Width.Length, Length.Length];

            int Number = 1;
            int Offset = 0;

            while(Offset != N/2) {

                for(int j = 0+Offset; j < N-Offset; j++) {
                    Matrix[0+Offset, j] = Number;
                    ++Number;
                }

                for(int i = 1+Offset; i < M-Offset; i++) {
                    Matrix[i, N-1-Offset] = Number;
                    ++Number;
                }

                for(int j = N-2-Offset; j >= 0+Offset; j--) {
                    Matrix[M-1-Offset, j] = Number;
                    ++Number;
                }


                for(int i = M-2-Offset; i > 0+Offset; i--) {
                    Matrix[i, 0+Offset] = Number;
                    ++Number;
                }

                ++Offset;
            }
            

            for(int i = 0; i < M; i++) {
                for(int j = 0; j < N; j++)
                    Console.Write($"[{Matrix[i, j]}] ");
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
        }

    }


    public class Program {

        public static void Main(string[] args) {

            Matrix Tasks = new Matrix();
            Tasks.Task1(10);
            Tasks.Task2(5);

            Tasks.Task3(5, 5);
            Tasks.Task3(7, 6);
            Tasks.Task3(6, 9);
        }

    }

}
