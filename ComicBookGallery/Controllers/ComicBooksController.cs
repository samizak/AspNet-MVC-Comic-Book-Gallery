using ComicBookGallery.Data;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers;

public class ComicBooksController : Controller
{
    private ComicBookRepository _comicBookRepository = null;

    public ComicBooksController()
    {
        _comicBookRepository = new ComicBookRepository();
    }

    public IActionResult Index()
    {
        var comicBooks = _comicBookRepository.GetComicBooks();
        return View(comicBooks);
    }

    public IActionResult Detail(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var comicBook = _comicBookRepository.GetComicBook(id.Value);

        return View(comicBook);
    }
}