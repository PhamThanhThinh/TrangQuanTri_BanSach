using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

    // mã định danh thể loại
    [Required]
    public int GenreId { get; set; }

    public Author Author { get; set; } = null;
    public Publisher Publisher { get; set; } = null;
    public Genre Genre { get; set; } = null;

    [NotMapped]
    public string? AuthorName { get; set; }
    [NotMapped]
    public string? PublisherName { get; set; }
    [NotMapped]
    public string? GenreName { get; set; }

    [NotMapped]
    public List<SelectListItem>? AuthorList { get; set; }
    [NotMapped]
    public List<SelectListItem>? PublisherList { get; set; }
    [NotMapped]
    public List<SelectListItem>? GenreList { get; set; }
  }
}
