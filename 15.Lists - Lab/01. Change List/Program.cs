List<int>  numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


List <string> input  = Console.ReadLine().Split().ToList(); 


while (input[0] != "end")
{

    string command = input[0];

    if (command == "Delete")
    {

        int elementToDelete = int.Parse(input[1]);

        for (int i = 0; i < numbers.Count; i++)
         numbers.Remove(elementToDelete);
           

    }
    else if (command =="Insert")
    {
        int elementToInsert = int.Parse(input[1]);
        int position = int.Parse(input[2]); 

        numbers.Insert(position, elementToInsert);
    }

    input = Console.ReadLine().Split().ToList();

}

Console.WriteLine(string.Join(" ", numbers));