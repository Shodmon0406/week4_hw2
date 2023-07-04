namespace Task1;

public class PhotoBook
{
    int _numPages = 16;
    public int NumPages { get => _numPages; set => _numPages = value; }
    // public int GetNumberPages() => _numPages;
    public PhotoBook()
    {
        
    }
    public PhotoBook(int numPages)
    {
        _numPages = numPages;
    }
}
