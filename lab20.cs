using System;
using System.Collections.Generic;
using System.Linq;

namespace kpiyap
{
    
    
    public enum Genre
    {
        Drama, Military, Horror, Melodrama, Comedy
    }
    public class Film
    {
        private int year;
        private string name;
        private List<Genre> genres;
        private string director;
        private int sales;

        public int Year
        {
            get => year;
            private set
            {
                if(value < 1920 && value > 2019)
                    throw new Exception("Invalid year");
                year = value;
            }
        }

        public string Name
        {
            get => name;
            private set => name = value;
        }
        
        public string Diretor
        {
            get => director;
            private set => director = value;
        }
        
        public int Sales
        {
            get => sales;
            private set
            {
                if(value < 1000)
                    throw new Exception("Invalid sales");
                sales = value;
            }
        }
        
        public List<Genre> Genres
        {
            get => genres;
            private set
            {
                if(value.Count != 3)
                    throw new Exception("Invalid genres count");
            }
        }
        
        public Film()
        {
            genres = new List<Genre>(3);
        }

        public Film(string name, int year, List<Genre> genres, string director, int sales)
        {
            
            Name = name;
            Year = year;
            Genres = genres;
            Diretor = director;
            Sales = sales;
        }

        public string getSales()
        {
            return $"{sales}$";
        }
        public override string ToString()
        {
            return $"{Name}({year})\nSales: {getSales()}\nDirector: {director}\n";
        }
    }
    
    public class Lab20
    {
        private List<Film> list;
        
        public Lab20()
        {
            list = new List<Film>(10);
        }

        public void addFilm(string name, int year, List<Genre> genres, string director, int sales)
        {
            list.Add(new Film(name, year, genres, director, sales));
        }

        public void sortFilmsByNameDirector()
        {
            var sortedList = from film in list
                orderby film.Name, film.Diretor
                select film;

            foreach (Film film in sortedList)
            {
                Console.WriteLine(film.ToString());
            }
        }

        public void getName()
        {
            var selectedFilms = from film in list
                select film;
                
            foreach (var film in selectedFilms)
            {
                Console.WriteLine(film);
            }
        }

        public void getAverageSum()
        {
            var sum = from film in list
                where film.Year >= 2010
                select list.Average(o => o.Sales);
            foreach (var VARIABLE in sum)
            {
                Console.WriteLine(VARIABLE);
            }
        }
        
        public void getMinYear()
        {
            var min = from film in list
                where film.Year >= 2019
                select list.Min(e => e.Year);
            foreach (var VARIABLE in min)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}