using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_Structure_Algorithms
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
                this.data = data;
        }
    }
    public class LinkedList
    {
        public Node head;
        public int Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            return data;
        }

        public void SortedLinkedList(int data)
        {
            Node temp = head, index = null;

            if (head == null)
            {
                return;
            }
            else
            {
                while (temp != null)
                {
                    index = temp.next;

                    while (index != null)
                    {
                        if (temp.data < index.data)
                        {
                            data = temp.data;
                            temp.data = index.data;
                            index.data = data;
                        }
                        index = index.next;
                    }
                    temp = temp.next;
                }
            }
        }
        public class Queue
        {
            Node front;
            Node rear;
            public void Enquque(int data)
            {
                Node newNode = new Node(data);
                if (this.rear == null)
                {
                    this.front = this.rear = newNode;
                }
                else
                {
                    this.rear.next = newNode;
                    this.rear = newNode;
                }
            }

        }
        public void Display()
        {
            Node temp = head;

            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
    public class PrimeNumber
    {
        public int[,] Primes = new int[10, 100];
        int[,] anagram = new int[10, 100];
        public int[,] notAnagramNumbers = new int[10, 100];
        public void RangePrime()
        {
            int num = 2;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    if (IsPrime(num))
                    {
                        Primes[i, j] = num;
                    }
                    num++;
                }
            }
        }
        public void print()
        {
            int startRange = 1;
            int endRange = 100;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (Primes[i, j] != 0)
                    {
                        Console.WriteLine(Primes[i, j]);
                    }
                }
                startRange = 0;
                startRange = startRange + endRange;
                endRange = endRange + 100;
            }
        }
        public void printAnagramNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (Primes[i, j] != 0 && Primes[i, j] > 10)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            for (int q = j + 1; q < 100; q++)
                            {
                                if (CheckAnagram(Primes[i, j], Primes[k, q]))
                                {
                                    anagram[k, q] = Primes[i, j];
                                    anagram[i, j] = Primes[k, q];
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    if (anagram[k, l] != 0)
                    {
                        Console.WriteLine(anagram[k, l]);
                    }

                }
            }
        }
        public void PrintNotAnagramNumbers()
        {
            int check = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (Primes[i, j] != 0)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            for (int q = j + 1; q < 100; q++)
                            {
                                if (Primes[i, j] == anagram[k, q])
                                {
                                    check = 1;
                                    break;
                                }
                            }
                            if (check == 1)
                            {
                                break;
                            }
                        }
                        if (check == 0)
                        {
                            notAnagramNumbers[i, j] = Primes[i, j];
                            Console.WriteLine(notAnagramNumbers[i, j]);
                        }
                    }
                }
            }
        }
        public bool IsPrime(int i)
        {
            int j, flag;
            bool findPrime = false;

            if (i == 1 || i == 0)
                findPrime = false;

            flag = 1;

            for (j = 2; j <= i / 2; ++j)
            {
                if (i % j == 0)
                {
                    flag = 0;
                    break;
                }
            }
            if (flag == 1)
            {
                findPrime = true;
            }
            return findPrime;
        }
        public bool CheckAnagram(int num1, int num2)
        {
            char[] char1 = Convert.ToString(num1).ToCharArray();
            char[] char2 = Convert.ToString(num2).ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            string s1 = new string(char1);
            string s2 = new string(char2);
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Equals(s2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool CheckAnagramOrNot(int num1,int num2)
        {
            char[] char1 = Convert.ToString(num1).ToCharArray();
            char[] char2 = Convert.ToString(num2).ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            string s1 = new string(char1);
            string s2 = new string(char2);
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Equals(s2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
