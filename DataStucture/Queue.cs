using System;
using System.Collections.Generic;
using System.Text;

namespace DataStucture
{
    internal class Queue
    {
        static int front = -1, rear = -1;
        const int size = 10;
        static int[] a = new int[size];


        public static void enque(int e)
        {
            if (front == -1)
            {
                front = 0;
                rear = 0;
                a[front] = e;
            }
            // To Do

        }
        public static int deque()
        {
            if (rear != -1)
            {

                int r = a[rear];
                rear -= 1;
                return r;

            }
            else return -1;
        }
        public static int pek()
        {
            if (rear != -1)
            {

                int r = a[rear];
                return r;

            }
            else return -1;
        }
        public static object Main()
        {
            for (int i = 0; i < 10; i++)
            {

            }
            return null;
        }

    }
}
