namespace IntroToProcedure;

internal class Program
{
    static void ReadInput(List<int> list/*, int specifiedIndex = 0*/)
    {
        Console.WriteLine("Enter an integer to add to the list: ");
        int number = Convert.ToInt32(Console.ReadLine());
        list.Add(number);
        // Bonus: Merge the previous two line in one line
        // Bonus: disallow duplication
        // Bonus: add multiple value in one shot (separated by space (2 point) / separated by line)
        Console.WriteLine($"number: {number} added.");
    }

    static void PrintList(List<int> list, int from, int to)
    {
        // TODO: validation - to less than count //

        Console.Write("[ ");
        for (int i = from; i < to; i++)
        {
            Console.Write($"{list[i]} ");
        }
        Console.WriteLine("]");
    }

    static void Main(string[] args)
    {
        List<int> list = [10, 20, 30];

        int selection;

        do
        {

            Console.WriteLine("\n1. Add an integer to the list");
            Console.WriteLine("2. Print the list");
            Console.WriteLine("3. Calc Sum");
            Console.WriteLine("4. Swap numbers");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your selection: ");
            selection = Convert.ToInt32(Console.ReadLine());

            switch(selection)
            {
                case 1:
                    {
                        int specifiedIndex = 1;

                        ReadInput(list/*, specifiedIndex*/); // [], 1
                        ReadInput(/*specifiedIndex: specifiedIndex,*/ list: list); // named argument 
                        ReadInput(list); // default parameter
                    }
                    break;
                case 2:
                    {
                        int from = 0;
                        int to = 3;

                        if(list.Count <= 0)
                            Console.WriteLine("The list is empty");
                        else
                            PrintList(list, from, to);
                    }
                    break;
                case 3:
                    {
                        // TODO
                        //CalcSum(); // 60
                    }
                    break;
                case 4:
                    {

                    }
                    break;
                case 5:
                    {

                    }
                    break;
            }

        } while (selection != 5);

    }

}

// Develop feature
