namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
              Console.CursorTop = 2;
             Console.CursorLeft = 50;

           
            bool Input = true;
            List<int> numbers = new List<int>();
            do
            {
                Console.WriteLine("     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.WriteLine("          hello here ");
                Console.WriteLine("  A - For add ");
                Console.WriteLine("  D - For delete item ");
                Console.WriteLine("  F - For find ");
                Console.WriteLine("  S - For display ");
                Console.WriteLine("  Q - Quit ");
                Console.WriteLine("  M - Min number");
                Console.WriteLine("  L - Max number");
                Console.WriteLine("  V - List average");
                Console.WriteLine("  C - Clear all list");
                char choice = char.ToUpper(char.Parse(Console.ReadLine()));
                if (choice == 'A' || choice == 'D' || choice == 'F' || choice == 'S' || choice == 'Q' || choice == 'M' || choice == 'L' || choice == 'V' || choice == 'C' )
                {
                    switch (choice)
                    {

                        case 'A':
                            int Chek = 0;
                            bool hed = true;
                            while (hed = true)
                            {

                                Console.WriteLine("   Please entre number to add");
                                int num1 = int.Parse(Console.ReadLine());
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] == num1)
                                        Chek = 1;
                                }
                                if (Chek == 1)
                                {
                                    Console.WriteLine("  This number is here");
                                    Console.WriteLine("  Entre anthor number");
                                    break;
                                }
                                else
                                {
                                    numbers.Add(num1);
                                    Console.WriteLine("  {0} : is added in list", num1);
                                    break;
                                }
                            }
                            break;
                        case 'S':
                            if (numbers.Count > 0)
                            {
                                Console.Write(" [ ");
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    Console.Write(" {0} ", numbers[i]);

                                }
                                Console.Write(" ] ");
                                Console.WriteLine("\n");
                            }
                            else
                                Console.WriteLine("   sorry the list is empty ");
                            break;
                        case 'Q':
                            Input = false;
                            break;
                        case 'D':
                            bool Check = false;
                            Console.WriteLine("      Please entre number to delete it ");
                            int num2 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (num2 == numbers[i])
                                    Check = true;
                            }
                            if (Check == true)
                            {
                                numbers.Remove(num2);
                                Console.WriteLine("   {0} : is removed", num2);
                            }
                            else
                                Console.WriteLine("   This number isn't here");

                            break;
                        case 'F':
                            int test2 = 0;
                            int index = 0;
                            int num3 = int.Parse(Console.ReadLine());
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == num3)
                                    test2 = 1;
                                index = i;
                            }
                            if (test2 == 1)
                                Console.WriteLine("   This number is here at index:{0}", index);
                            else
                                Console.WriteLine("   This number isn't here");
                            break;
                        case 'M':
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[0] > numbers[i])
                                    numbers[0] = numbers[i];

                            }
                            Console.WriteLine("   small number is: {0}", numbers[0]);
                            break;
                        case 'L':
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[0] < numbers[i])
                                    numbers[0] = numbers[i];

                            }
                            Console.WriteLine("    Max number is: {0}", numbers[0]);
                            break;
                        case 'V':
                            double sum = 0, average = 0;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }
                            average = sum / numbers.Count;
                            Console.WriteLine("    Average is: {0}", average);
                            break;
                        case 'C':
                            numbers.Clear();
                            Console.WriteLine("  now list is empty");
                            break;
                    }
                }
                else
                    Console.WriteLine("   Entre number from list Please \n");
            } while (Input) ;
            
            
            Console.ReadLine();
        }
    }
}
