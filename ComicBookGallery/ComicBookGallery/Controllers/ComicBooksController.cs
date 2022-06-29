using ComicBookGallery.Data;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers;

public class ComicBooksController : Controller
{
    private ComicBookRepository _comicBookRepository = null;
    
    
    // constructor - instantiating a comicBookRepository
    public ComicBooksController()
    {
        _comicBookRepository = new ComicBookRepository();
    }

    
    public IActionResult Index()
    {
        var comicBooks = _comicBookRepository.GetComicBooks();
        return View(comicBooks);
    }
    
    
    public IActionResult Detail(int id)
    {
        var comicBook = _comicBookRepository.GetComicBook(id);
        return View(comicBook);
    }
}