List<Movies> myMovies = new List<Movies>();

string[] data = GetDataFromMyFiles();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    Movies newMovie = new Movies(tempArray[0], tempArray[2]);
}

foreach (Movies movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}

static string[] GetDataFromMyFiles()
{
    string filePath = @"C:\Users\37253\Downloads\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{

    foreach(string line in someArray)   
    {
        Console.WriteLine(line);
    }
}

class  Movies
{
    string title;
    string year;

    public string Title
    {
        get { return title; } 
    }

    public string Year
    {
        get { return year; }
    }
    public Movies(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}