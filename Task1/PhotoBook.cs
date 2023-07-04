namespace Task1;

public class PhotoBook
{
    int _numPages;
    public int GetNumberPages() => _numPages;
    public PhotoBook()
    {
        _numPages = 16;
    }
    public PhotoBook(int numPages)
    {
        _numPages = numPages;
    }
}
