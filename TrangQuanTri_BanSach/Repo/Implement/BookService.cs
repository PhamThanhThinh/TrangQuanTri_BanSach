using System.Collections.Generic;
using System.Linq;
using TrangQuanTri_BanSach.Models.Domain;
using TrangQuanTri_BanSach.Repo.Abstract;

namespace TrangQuanTri_BanSach.Repo.Implement
{
  public class BookService : IBookService
  {
    private readonly DatabaseContext _dbContext;

    public BookService(DatabaseContext dbContext)
    {
      _dbContext = dbContext;
    }

    // generate code theo thứ tự alphabet
    // theo bảng chữ cái alphabet

    public bool Add(Book model)
    {
      try
      {
        _dbContext.Book.Add(model);
        _dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception)
      {
        return false;
      }
    }

    public bool Delete(int id)
    {
      try
      {
        var data = FindById(id);
        if (data == null)
        {
          return false;
        }

        _dbContext.Book.Remove(data);
        _dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception)
      {
        return false;
      }
    }

    public Book FindById(int id)
    {
      return _dbContext.Book.Find(id);
    }

    public IEnumerable<Book> GetAll()
    {
      return _dbContext.Book.ToList();
    }

    public bool Update(Book model)
    {
      try
      {
        _dbContext.Book.Update(model);
        _dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception)
      {
        return false;
      }
    }
  }
}
