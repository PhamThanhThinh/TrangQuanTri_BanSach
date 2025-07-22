using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using TrangQuanTri_BanSach.Models.Domain;
using TrangQuanTri_BanSach.Repo.Abstract;
using TrangQuanTri_BanSach.Repo.Implement;

namespace TrangQuanTri_BanSach.Controllers
{
  public class BookController : Controller
  {
    private readonly IBookService _bookService;
    private readonly IAuthorService _authorService;
    private readonly IGenreService _genreService;
    private readonly IPublisherService _publisherService;

    public BookController(IBookService bookService, IAuthorService authorService, IGenreService genreService, IPublisherService publisherService)
    {
      _bookService = bookService;
      _authorService = authorService;
      _genreService = genreService;
      _publisherService = publisherService;
    }

    [HttpGet]
    public IActionResult Add()
    {
      var model = new Book();
      model.AuthorList = _authorService.GetAll().Select(a => new SelectListItem { Text = a.AuthorName, Value = a.Id.ToString() }).ToList();
      model.PublisherList = _publisherService.GetAll().Select(a => new SelectListItem { Text = a.PublisherName, Value = a.Id.ToString() }).ToList();
      model.GenreList = _genreService.GetAll().Select(a => new SelectListItem { Text = a.Name, Value = a.Id.ToString() }).ToList();

      return View(model);
    }

    [HttpPost]
    public IActionResult Add(Book model)
    {
      model.AuthorList = _authorService.GetAll().Select(a => new SelectListItem { Text = a.AuthorName, Value = a.Id.ToString(), Selected = a.Id == model.AuthorId }).ToList();
      model.PublisherList = _publisherService.GetAll().Select(a => new SelectListItem { Text = a.PublisherName, Value = a.Id.ToString(), Selected = a.Id == model.PublisherId }).ToList();
      model.GenreList = _genreService.GetAll().Select(a => new SelectListItem { Text = a.Name, Value = a.Id.ToString(), Selected = a.Id == model.GenreId }).ToList();
      
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      var result = _bookService.Add(model);
      if (result)
      {
        TempData["msg"] = "Thêm Thành Công";
        return RedirectToAction(nameof(Add));
      }
      TempData["msg"] = "Thêm Không Thành Công";

      return View(model);
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
      var record = _bookService.FindById(id);
      return View(record);
    }

    [HttpPost]
    public IActionResult Update(Book model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      var result = _bookService.Update(model);
      if (result)
      {
        TempData["msg"] = "Sửa Thành Công";
        return RedirectToAction(nameof(Update));
      }
      TempData["msg"] = "Sửa Không Thành Công";

      return View(model);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
      var result = _bookService.Delete(id);
      return RedirectToAction("GetAll");
    }

    [HttpGet]
    public IActionResult GetAll()
    {
      var ketqua = _bookService.GetAll();
      return View(ketqua);
    }

  }
}
