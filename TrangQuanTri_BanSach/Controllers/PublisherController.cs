using Microsoft.AspNetCore.Mvc;
using TrangQuanTri_BanSach.Models.Domain;
using TrangQuanTri_BanSach.Repo.Abstract;
using TrangQuanTri_BanSach.Repo.Implement;

namespace TrangQuanTri_BanSach.Controllers
{
  public class PublisherController : Controller
  {
    private readonly IPublisherService _publisherService;

    public PublisherController(IPublisherService publisherService)
    {
      _publisherService = publisherService;
    }

    [HttpGet]
    public IActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Add(Publisher model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      var result = _publisherService.Add(model);
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
      var record = _publisherService.FindById(id);
      return View(record);
    }

    [HttpPost]
    public IActionResult Update(Publisher model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      var result = _publisherService.Update(model);
      if (result)
      {
        TempData["msg"] = "Sửa Thành Công";
        return RedirectToAction(nameof(Update));
      }
      TempData["msg"] = "Sửa Không Thành Công";

      return View(model);
    }

    public IActionResult Delete(int id)
    {
      var result = _publisherService.Delete(id);
      return RedirectToAction("GetAll");
    }

    public IActionResult GetAll()
    {
      var ketqua = _publisherService.GetAll();
      return View(ketqua);
    }

  }
}
