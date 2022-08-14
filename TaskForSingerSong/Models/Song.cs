using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForSingerSong.Models
{
    class Song
    {
        private string _name;
        private string _genre;
        
        public string Name { get 
            {
                return _name;
            } 
            set
            {
                if (value.Length<=100)
                {
                    _name = value;
                }
            } }
        public string Genre {
            get 
            { 
                return _genre; 
            }
            set
            {
                if (value== "Pop" || value == "Rock" || value == "Jazz" || value== "Techno")
                {
                    _genre = value;
                }
                else 
                {
                    Console.WriteLine("wrong input");
                }
            }
                 }
        public Singer Singer { get; set; }
        private double _avrage = 0;

        public void AddRating(int addrate) 
        {
            
            
                if (_avrage != 0)
                {
                    _avrage = (_avrage + addrate) / 2;
                }
                else
                {
                    _avrage = addrate;
                }
            }
        public double GetAverageRating() 
        {

            return _avrage;
        
        }
           
        public void GetInfo() 
        {
            Console.WriteLine(_name + " " + _genre + " "+ _avrage);
        }    
            
           
            
            

        }
        


    }

