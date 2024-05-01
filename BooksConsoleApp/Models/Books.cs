public class Book
{
    public int BookId { get; set; }
    public string? Title { get; set; }
    public BookDetails BookDetails { get; set; }

    public Book()
    {
        BookDetails = new BookDetails();
    }
}