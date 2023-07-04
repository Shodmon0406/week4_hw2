namespace Task1;

public class PhotoBookTest
{
    PhotoBook book1 = new PhotoBook();
    PhotoBook book2 = new PhotoBook(24);
    BigPhotoBook book3 = new BigPhotoBook();
    public PhotoBookTest()
    {
        System.Console.WriteLine($"{book1.GetNumberPages()}");
        System.Console.WriteLine($"{book2.GetNumberPages()}");
        System.Console.WriteLine($"{book3.GetNumberPages()}");
    }
}
