namespace BookReader.Models.Response;

public class BookDetails
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int Pages { get; set; }
    public string Author { get; set; }
    public byte[] Picture { get; set; }
}
