
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    private int _pages;
    public int Pages
    {
        get { return _pages; }
        set
        {
            if (value > 0)
            {
                _pages = value;
            }
            else
            {
                throw new ArgumentException("Pages must be greater than 0.");
            }
        }
    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public string Info()
    {
        return $"{Title} by {Author}, {Pages} pages";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[]
        {
            new Book("Suç ve Ceza", "Dostoyevski", 687),
            new Book("1984", "George Orwell", 328),
            new Book("Les Miserables", "Victor Hugo", 1463)
        };

        foreach (Book book in books)
        {
            Console.WriteLine(book.Info());
        }

        Book longestBook = books[0];
        foreach (Book book in books)
        {
            if (book.Pages > longestBook.Pages)
            {
                longestBook = book;
            }
        }

        Console.WriteLine("\nBook with the most pages:");
        Console.WriteLine(longestBook.Info());
    }
}