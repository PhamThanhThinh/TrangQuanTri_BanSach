using System.Collections.Generic;
using TrangQuanTri_BanSach.Models.Domain;
using TrangQuanTri_BanSach.Repo.Abstract;

namespace TrangQuanTri_BanSach.Repo.Implement
{
  public class GenreService : IGenreService
  {
    private readonly DatabaseContext _dbContext;

    public GenreService(DatabaseContext dbContext)
    {
      _dbContext = dbContext;
    }

    public bool Add(Book model)
    {
      try
      {
        _dbContext.Add(model);
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
        if (data != null)
        {
          return false;
        }

        _dbContext.Remove(data);
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
      
    }

    public IEnumerable<Book> GetAll()
    {
      throw new System.NotImplementedException();
    }

    public bool Update(Book model)
    {
      try
      {
        _dbContext.Update(model);
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
