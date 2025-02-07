using Linq_Join;

List<Authors> authors = new List<Authors>
{
    new Authors { AuthorsId = 1, Name="Orhan Pamuk"},
    new Authors { AuthorsId = 2, Name="Elif Şafak"},
    new Authors { AuthorsId = 3, Name="Ahmet Ümit"}
};

List<Books> books = new List<Books>
{
    new Books { BookId= 1, Title="Kar", AuthorsId=1},
    new Books { BookId= 2, Title="İstanbul", AuthorsId=2},
    new Books { BookId= 3, Title="10 Minutes 38 Second in This Strange World", AuthorsId=2},
    new Books { BookId= 4, Title="Beyoğlu Rapsodisi", AuthorsId=3},
};

var query = from book in books
            join @author in authors
            on book.AuthorsId equals author.AuthorsId
            select new
            {
                BookTitle = book.Title,
                AuthorName = author.Name
            };

foreach (var item in query)
{
    Console.WriteLine($"Kitap Adı: {item.BookTitle} Yazarın Adı: {item.AuthorName}");
}