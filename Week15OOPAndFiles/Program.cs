List<Movie> myMovies = [];
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split([';'], StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was relased in {movie.Year}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\data\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie(string _title, string _year)
{
    private readonly string title = _title;
    private readonly string year = _year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }
}
