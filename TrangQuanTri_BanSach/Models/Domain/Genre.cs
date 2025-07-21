using System.ComponentModel.DataAnnotations;

namespace TrangQuanTri_BanSach.Models.Domain
{
  public class Genre
  {
    //[Key]
    // mã định danh (khóa chính), MaTheLoai
    public int Id { get;set; }

    // tên thể loại
    [Required]
    public string Name { get;set; }

  }
}
