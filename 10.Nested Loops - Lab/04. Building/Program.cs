
int floors = int.Parse(Console.ReadLine());

int estates = int.Parse(Console.ReadLine());


for (int floor = floors; floor >= 1; floor--)
{

    for (int estate = 0; estate < estates; estate++)

    {
        if (floor == floors)

        {
            char room = 'L';

            Console.Write($"{room}{floor}{estate} " );
        }
        else if (floor % 2 == 0)

        {
            char room = 'O';
            Console.Write($"{room}{floor}{estate} " );
        }

        else
        {
            char room = 'A' ;
            Console.Write($"{room}{floor}{estate} " );
        }

      
    }
    Console.WriteLine();
}

