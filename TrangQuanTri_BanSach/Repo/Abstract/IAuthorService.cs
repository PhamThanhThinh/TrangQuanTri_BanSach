using System.Collections.Generic;
using TrangQuanTri_BanSach.Models.Domain;

namespace TrangQuanTri_BanSach.Repo.Abstract
{
  public interface IAuthorService
  {
    bool Add(Author model);
    bool Update(Author model);
    bool Delete(int id);
    Author FindById(int id);
    IEnumerable<Author> GetAll();
  }
}
