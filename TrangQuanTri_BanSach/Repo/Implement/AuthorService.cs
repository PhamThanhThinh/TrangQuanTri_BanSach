using System.Collections.Generic;
using System.Linq;
using TrangQuanTri_BanSach.Models.Domain;
using TrangQuanTri_BanSach.Repo.Abstract;

namespace TrangQuanTri_BanSach.Repo.Implement
{
  public class AuthorService : IAuthorService
  {
    private readonly DatabaseContext _dbContext;

    public AuthorService(DatabaseContext dbContext)
    {
      _dbContext = dbContext;
    }

    public bool Add(Author model)
    {
      try
      {
        _dbContext.Author.Add(model);
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

        _dbContext.Author.Remove(data);
        _dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception)
      {
        return false;
      }
    }

    public Author FindById(int id)
    {
      return _dbContext.Author.Find(id);
    }

    public IEnumerable<Author> GetAll()
    {
      return _dbContext.Author.ToList();
    }

    public bool Update(Author model)
    {
      try
      {
        _dbContext.Author.Update(model);
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
