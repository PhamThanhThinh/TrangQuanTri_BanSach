using System.ComponentModel.DataAnnotations;

namespace TrangQuanTri_BanSach.Models.Domain
{
  public class Genre
  {
    //[Key]
    public int Id { get;set; }

    // tên thể loại
    [Required]
    public string Name { get;set; }

  }
}
