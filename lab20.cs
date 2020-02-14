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
                if(value < 1900 && value > 2021)
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
                if(value.Capacity != 3)
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
    }
    
    public class Lab20<Film>
    {
        private List<Film> list;
        
        private Lab20()
        {
            list = new List<Film>();
        }
        
    }
}