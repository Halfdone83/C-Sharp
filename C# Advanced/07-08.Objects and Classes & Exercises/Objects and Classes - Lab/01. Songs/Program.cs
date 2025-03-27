int songNumbers = int.Parse(Console.ReadLine());

List<Song>songList = new List<Song>();

for (int i = 0; i < songNumbers; i++)
{

    string[] songInfo = Console.ReadLine().Split("_");

    string typeList = songInfo[0];

    string name = songInfo[1];

    string duration = songInfo[2];

    Song song = new Song(typeList, name, duration);
    songList.Add(song);
}

string lastCommand = Console.ReadLine();

if (lastCommand == "all")
{

    foreach (Song song in songList)
    {
        Console.WriteLine(song.Name);
    }

}
else
{
    foreach (Song song in songList.Where(s => s.TypeList == lastCommand))
    Console.WriteLine(song.Name);
}

class Song
{

    public Song(string typeList, string name, string duration)
    {
        TypeList = typeList;

        Name = name;

        Duration = duration;
    }

    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Duration {  get; set; } 

}