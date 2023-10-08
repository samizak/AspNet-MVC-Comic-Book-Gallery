using ComicBookGallery.Models;

namespace ComicBookGallery.Data;

public class ComicBookRepository
{
    private static ComicBook[] _comicBooks = new ComicBook[]
    {
    new ComicBook()
        {
            SeriesTitle = "The Amazing Spider-Man",
            IssueNumber = 700,
            DescriptionHtml = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>",
            Artists = new Artists[]
            {
                new Artists() { Name = "Dan Slott", Role = "Script"},
                new Artists() { Name = "Humberto Ramos", Role = "Pencils"},
                new Artists() { Name = "Victor Olazaba", Role = "Inks"},
                new Artists() { Name = "Edgar Delgado", Role = "Colors"},
                new Artists() { Name = "Chris Eliopoulos", Role = "Letters"},
            },
            Favorite = false,
            Id = 1,
        },
    new ComicBook()
    {
        SeriesTitle = "The Amazing Spider-Man",
        IssueNumber = 657,
        DescriptionHtml = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>",
        Artists = new Artists[]
        {
            new Artists() { Name = "Dan Slott", Role = "Script" },
            new Artists() { Name = "Marcos Martin", Role = "Pencils" },
            new Artists() { Name = "Marcos Martin", Role = "Inks" },
            new Artists() { Name = "Muntsa Vicente", Role = "Colors" },
            new Artists() { Name = "Joe Caramagna", Role = "Letters" }
        },
        Favorite = false,
        Id = 2,
    },
    new ComicBook()
    {
        SeriesTitle = "Bone",
        IssueNumber = 50,
        DescriptionHtml = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>",
        Artists = new Artists[]
        {
            new Artists() { Name = "Jeff Smith", Role = "Script" },
            new Artists() { Name = "Jeff Smith", Role = "Pencils" },
            new Artists() { Name = "Jeff Smith", Role = "Inks" },
            new Artists() { Name = "Jeff Smith", Role = "Letters" }
        },
        Favorite = false,
        Id = 3,
    },

    new ComicBook()
    {
        SeriesTitle = "The Walking Dead: Days Gone Bye",
        IssueNumber = 1,
        DescriptionHtml = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>",
        Artists = new Artists[]
        {
            new Artists() { Name = "Lorem ipsum", Role = "Script" },
            new Artists() { Name = "Tony Moore", Role = "Pencils" },
            new Artists() { Name = "Lorem ipsum", Role = "Inks" },
            new Artists() { Name = "Tony Moore", Role = "Colors" },
            new Artists() { Name = "Rus Wooton", Role = "Letters" },
        },
        Favorite = false,
        Id = 4,
    },


    };
    public ComicBook[] GetComicBooks()
    {
        return _comicBooks;
    }

    public ComicBook GetComicBook(int id)
    {
        ComicBook comicBookToReturn = null;

        foreach (var comicBook in _comicBooks)
        {
            if (comicBook.Id == id)
            {
                comicBookToReturn = comicBook;
                break;
            }
        }

        return comicBookToReturn;
    }
}