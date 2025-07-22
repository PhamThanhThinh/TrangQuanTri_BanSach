
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrangQuanTri_BanSach.Models.Domain
{
  public class Publisher
  {
    // id
    public int Id { get; set; }
    // tên nhà xuất bản
    [Required]
    public string PublisherName { get; set; }

    public ICollection<Book> Books { get; set; } = [];
  }
}