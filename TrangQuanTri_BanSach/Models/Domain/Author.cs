//using System.Collections;
//using System.Collections.Generic;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrangQuanTri_BanSach.Models.Domain
{
  // tác giả
  public class Author
  {
    public int Id { get; set; }
    
    [Required]
    public string AuthorName { get; set; }

    public ICollection<Book> Books { get; set; } = [];

  }
}
