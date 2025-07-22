using System.Collections.Generic;
using TrangQuanTri_BanSach.Models.Domain;

namespace TrangQuanTri_BanSach.Repo.Abstract
{
  public interface IPublisherService
  {
    bool Add(Publisher model);
    bool Update(Publisher model);
    bool Delete(int id);
    Publisher FindById(int id);
    IEnumerable<Publisher> GetAll();
  }
}
