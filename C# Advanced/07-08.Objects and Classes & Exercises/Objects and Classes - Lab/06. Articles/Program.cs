using System.Runtime.InteropServices;

string[] input = Console.ReadLine().Split(",");

string title = input[0];
string content = input[1];
string author = input[2];

Article currentArticle = new Article(title, content, author);

int commands = int.Parse(Console.ReadLine());

for (int i = 0; i < commands; i++)
{
    string[] command = Console.ReadLine().Split(": ");

    string toDo = command[0];
    string toReplace = command[1];

    if (toDo == "Edit")
    {
        currentArticle.EditContent(toReplace);

    }

    if (toDo == "ChangeAuthor")

    {
        currentArticle.ChangeAuthor(toReplace);

    }
    if (toDo == "Rename")
    {
        currentArticle.RenameTitle(toReplace);
    }

}

Console.WriteLine($"{currentArticle.Title} - {currentArticle.Content}: {currentArticle.Author}");

class Article
{

    public Article(string title, string content, string author)
    {
         Title = title;
        Content = content;
        Author = author;
    }
    public string Title { get; set; }

    public string Content { get; set; }

    public string Author { get; set; }


    public void EditContent(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)

    {
        Author = newAuthor;
    }

    public void RenameTitle(string newTitle)
    {
        Title = newTitle;
    }

}