using System.Collections.Generic;

namespace AuthorBook.Models
{
  public class Book
  {
    public Book()
    {
      this.JoinEntities = new HashSet<AuthorBook>();
    }

    public int BookId { get; set; }
    public string Title { get; set; }
    public string Synopsis { get; set; }
    public virtual ICollection<AuthorBook> JoinEntities { get; set; }
  }
}