using System.ComponentModel.DataAnnotations;

namespace TrangQuanTri_BanSach.Models.Domain
{
  public class Book
  {
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Isbn { get; set; }
    [Required]
    public int TotalPages { get; set; }

    // mã định danh tác giả
    [Required]
    public int AuthorId { get; set; }

    // mã định danh nhà xuất bản
    [Required]
    public int PublisherId { get; set; }

    [Required]
    public int GenreId { get; set; }
  }
}
