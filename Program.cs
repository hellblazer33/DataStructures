            int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };
            int len = numbers.Length;
            Console.WriteLine("Before Merge Sort:");
            foreach(int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("After Merge Sort");
            SortMethod(numbers, 0, len - 1);
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.Read();
