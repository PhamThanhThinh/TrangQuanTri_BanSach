using System.Collections.Generic;
using TrangQuanTri_BanSach.Models.Domain;
using TrangQuanTri_BanSach.Repo.Abstract;

namespace TrangQuanTri_BanSach.Repo.Implement
{
  public class PublisherService : IPublisherService
  {
    private readonly DatabaseContext _dbContext;

    public PublisherService(DatabaseContext dbContext)
    {
      _dbContext = dbContext;
    }

    public bool Add(Publisher model)
    {
      try
      {
        _dbContext.Publisher.Add(model);
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
      throw new System.NotImplementedException();
    }

    public Publisher FindById(int id)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Publisher> GetAll()
    {
      throw new System.NotImplementedException();
    }

    public bool Update(Publisher model)
    {
      throw new System.NotImplementedException();
    }
  }
}
