using System;
using System.Collections.Generic;
using System.Linq;
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

    public bool Add(Genre model)
    {
      try
      {
        _dbContext.Genre.Add(model);
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

        _dbContext.Genre.Remove(data);
        _dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception)
      {
        return false;
      }
    }

    public Genre FindById(int id)
    {
      return _dbContext.Genre.Find(id);
    }

    public IEnumerable<Genre> GetAll()
    {
      return _dbContext.Genre.ToList();
    }

    public bool Update(Genre model)
    {
      try
      {
        _dbContext.Genre.Update(model);
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
