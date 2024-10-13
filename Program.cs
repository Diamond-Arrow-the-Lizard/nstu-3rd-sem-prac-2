using System;


namespace Prac_3 {

    public enum Operator
    {
        PLUS = 0,
        MINUS = 1,
        MULTIPLY = 2,
        DIVIDE = 3,
        TO_POWER = 4,
        SQUARE = 5
    }


    public class TaskClass{

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
            int[,] Matrix = new int[M, N];

            int Number = 1;
            int top = 0;
            int bottom = M - 1;
            int left = 0;
            int right = N - 1;

            while (top <= bottom && left <= right) {
                for (int j = left; j <= right; j++) {
                    Matrix[top, j] = Number++;
                }
                top++;

                for (int i = top; i <= bottom; i++) {
                    Matrix[i, right] = Number++;
                }
                right--;

                if (top <= bottom) {
                    for (int j = right; j >= left; j--) {
                        Matrix[bottom, j] = Number++;
                    }
                    bottom--;
                }

                if (left <= right) {
                    for (int i = bottom; i >= top; i--) {
                        Matrix[i, left] = Number++;
                    }
                    left++;
                }
            }

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write($"[{Matrix[i, j]}] ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        public int DoOperation(Operator op, double left, double right)  => op switch 
        {
            Operator.PLUS => Convert.ToInt32(left + right),
                Operator.MINUS => Convert.ToInt32(left - right),
                Operator.MULTIPLY => Convert.ToInt32(left * right),
                Operator.DIVIDE => Convert.ToInt32(left / right),
                Operator.TO_POWER => Convert.ToInt32(Math.Pow(left, right)),
                Operator.SQUARE => Convert.ToInt32(Math.Sqrt(left)),
                _ => 0
        };

    }

    public class Program {

        public static void Main(string[] args) {

            TaskClass Tasks = new TaskClass();
            Tasks.Task1(10);
            Tasks.Task2(5);

            Tasks.Task3(5, 5);
            Tasks.Task3(7, 6);
            Tasks.Task3(6, 9);


            Console.WriteLine(Tasks.DoOperation(Operator.PLUS, 1, 2));
            Console.WriteLine(Tasks.DoOperation(Operator.MINUS, 1, 2));
            Console.WriteLine(Tasks.DoOperation(Operator.MULTIPLY, 1, 2));
            Console.WriteLine(Tasks.DoOperation(Operator.DIVIDE, 1, 2));
            Console.WriteLine(Tasks.DoOperation(Operator.TO_POWER, 1, 2));
            Console.WriteLine(Tasks.DoOperation(Operator.SQUARE, 1, 2));
        }

    }

}
