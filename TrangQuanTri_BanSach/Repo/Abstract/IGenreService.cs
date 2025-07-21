using System.Collections;
using System.Collections.Generic;
using TrangQuanTri_BanSach.Models.Domain;

namespace TrangQuanTri_BanSach.Repo.Abstract
{
  public interface IGenreService
  {
    bool Add(Genre model);
    bool Update(Genre model);
    bool Delete(int id);
    Genre FindById(int id);
    IEnumerable<Genre> GetAll();
  }
}
