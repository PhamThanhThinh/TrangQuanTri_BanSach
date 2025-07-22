using System.Collections.Generic;
using TrangQuanTri_BanSach.Models.Domain;

namespace TrangQuanTri_BanSach.Repo.Abstract
{
  public interface IBookService
  {
    bool Add(Book model);
    bool Update(Book model);
    bool Delete(int id);
    Book FindById(int id);
    IEnumerable<Book> GetAll();
  }
}
