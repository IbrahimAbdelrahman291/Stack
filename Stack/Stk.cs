using System;


namespace Stack
{
    public class Stk
    {
        int Top;
        int Size;
        int[] s;
        public Stk()
        {
            Top = 0;
            Size = 10;
            s = new int[Size];
        }
        public bool IsFull()
        {
            return (Top + 1 <= Size) ? false : true;
        }
        public bool IsEmpty()
        {
            return (Top == 0) ? true : false;
        }
        public void push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack overFlow");
            }
            else
            {
                s[Top] = value;
                Console.WriteLine("Pushed successfully");
                Top++;
            }
        }
        public void pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Already Empty");
            }
            else
            {
                s[Top - 1] = 0;
                Console.WriteLine("poped successfully");
                Top--;
            }
        }
        
        public void search(int value) 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Already Empty");
            }
            else
            {
                int test = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i]==value)
                    {
                        Console.WriteLine("Founded");
                        return;
                    }
                }
                if (test==0)
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
        public void Display() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Already Empty");                
            }
            else
            {
                for (int i = 0; i < Top; i++)
                {
                    Console.WriteLine(s[i]);
                }
            }
        }
    }
}
