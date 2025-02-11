using System;

namespace MovieManagementSystem
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int YearOfRelease { get; set; }
        public double Rating { get; set; }
        public Movie Next { get; set; }
        public Movie Prev { get; set; }

        public Movie(string title, string director, int yearOfRelease, double rating)
        {
            Title = title;
            Director = director;
            YearOfRelease = yearOfRelease;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }

    public class MovieList
    {
        private Movie head;
        private Movie tail;

        public MovieList()
        {
            head = null;
            tail = null;
        }

        public void AddMovieAtBeginning(string title, string director, int yearOfRelease, double rating)
        {
            Movie newMovie = new Movie(title, director, yearOfRelease, rating);
            if (head == null)
            {
                head = newMovie;
                tail = newMovie;
            }
            else
            {
                newMovie.Next = head;
                head.Prev = newMovie;
                head = newMovie;
            }
        }

        public void AddMovieAtEnd(string title, string director, int yearOfRelease, double rating)
        {
            Movie newMovie = new Movie(title, director, yearOfRelease, rating);
            if (tail == null)
            {
                head = newMovie;
                tail = newMovie;
            }
            else
            {
                tail.Next = newMovie;
                newMovie.Prev = tail;
                tail = newMovie;
            }
        }

        public void AddMovieAtPosition(string title, string director, int yearOfRelease, double rating, int position)
        {
            if (position <= 0)
            {
                AddMovieAtBeginning(title, director, yearOfRelease, rating);
                return;
            }

            Movie newMovie = new Movie(title, director, yearOfRelease, rating);
            Movie current = head;
            int index = 0;

            while (current != null && index < position - 1)
            {
                current = current.Next;
                index++;
            }

            if (current == null)
            {
                AddMovieAtEnd(title, director, yearOfRelease, rating);
            }
            else
            {
                newMovie.Next = current.Next;
                newMovie.Prev = current;
                if (current.Next != null)
                {
                    current.Next.Prev = newMovie;
                }
                current.Next = newMovie;
                if (newMovie.Next == null)
                {
                    tail = newMovie;
                }
            }
        }

        public void RemoveMovieByTitle(string title)
        {
            Movie current = head;

            while (current != null)
            {
                if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    else
                    {
                        tail = current.Prev;
                    }

                    return;
                }
                current = current.Next;
            }
        }

        public void SearchMovieByDirector(string director)
        {
            Movie current = head;
            while (current != null)
            {
                if (current.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.YearOfRelease}, Rating: {current.Rating}");
                }
                current = current.Next;
            }
        }

        public void SearchMovieByRating(double rating)
        {
            Movie current = head;
            while (current != null)
            {
                if (current.Rating == rating)
                {
                    Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.YearOfRelease}, Rating: {current.Rating}");
                }
                current = current.Next;
            }
        }

        public void DisplayMoviesForward()
        {
            Movie current = head;
            while (current != null)
            {
                Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.YearOfRelease}, Rating: {current.Rating}");
                current = current.Next;
            }
        }

        public void DisplayMoviesReverse()
        {
            Movie current = tail;
            while (current != null)
            {
                Console.WriteLine($"Title: {current.Title}, Director: {current.Director}, Year: {current.YearOfRelease}, Rating: {current.Rating}");
                current = current.Prev;
            }
        }

        public void UpdateMovieRating(string title, double newRating)
        {
            Movie current = head;
            while (current != null)
            {
                if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    current.Rating = newRating;
                    return;
                }
                current = current.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MovieList movieList = new MovieList();

            movieList.AddMovieAtBeginning("Inception", "Christopher Nolan", 2010, 8.8);
            movieList.AddMovieAtEnd("The Matrix", "Lana Wachowski", 1999, 8.7);
            movieList.AddMovieAtPosition("Interstellar", "Christopher Nolan", 2014, 8.6, 1);

            Console.WriteLine("Movies in forward order:");
            movieList.DisplayMoviesForward();

            Console.WriteLine("\nMovies in reverse order:");
            movieList.DisplayMoviesReverse();

            Console.WriteLine("\nSearch movies by director 'Christopher Nolan':");
            movieList.SearchMovieByDirector("Christopher Nolan");

            Console.WriteLine("\nSearch movies by rating 8.7:");
            movieList.SearchMovieByRating(8.7);

            Console.WriteLine("\nUpdate rating of 'Inception' to 9.0:");
            movieList.UpdateMovieRating("Inception", 9.0);
            movieList.DisplayMoviesForward();

            Console.WriteLine("\nRemove movie 'The Matrix':");
            movieList.RemoveMovieByTitle("The Matrix");
            movieList.DisplayMoviesForward();
        }
    }
}