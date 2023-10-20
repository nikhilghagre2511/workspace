using Entity;
namespace DataLayer;
public class DataAccess
{
    public static List<Movie> movies = new List<Movie>()
    {
        new Movie{Id=1,Name= "Toofan" ,Ryear=2021,Ratings=3},
        new Movie{Id=2,Name= "Ludo" ,Ryear=2020,Ratings=1},
        new Movie{Id=3,Name= "Gunjan" ,Ryear=2023,Ratings=4},
        new Movie{Id=4,Name= "Jawan" ,Ryear=2022,Ratings=2},
        new Movie{Id=5,Name= "Shaktiman" ,Ryear=2018,Ratings=3},
    };

    public List<Movie> GetMovies()
    {
        return movies;
    }
}
