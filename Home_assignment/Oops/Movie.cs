using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.Oops
{
    public class Movie
    {
        public string moviename;
        public string director;
        public string producer;
        public string male_actor;
        public string female_actor;
        public float rating;

        public void SetMoviename(string M_name)
        {
            moviename = M_name;
        }
        public string GetMoviename()
        {
            return moviename;
        }
        public void SetDirector(string M_director)
        {
            director = M_director;
        }
        public string GetDirector()
        {
        return director;
        }
        public void SetProducer(string M_producer)
        {
            producer = M_producer;
        }
       public string GetProducer()
       {
          return producer;
       }
        public void SetMale_actor(string M_actor)
        {
            male_actor = M_actor;
        }
        public string GetMale_actor()
        {
            return male_actor;
        }
        public void SetFemale_actor(string M_f_actor)
        {
            female_actor = M_f_actor;
        }
        public string GetFemale_actor()
        {
            return female_actor;
        }
        public void SetRating(float M_rating)
        {
            rating = M_rating;
        }
        public float GetRating()
        {
            return rating;
        }

        class MovieA
        {
            static void Main(string[] args)
            {
                Movie A = new Movie();
                A.SetMoviename("ray");
                A.SetProducer("s.d");
                A.SetDirector("b.p");
                A.SetMale_actor("r.t");
                A.SetFemale_actor("e.r");
                A.SetRating(4.5f);

                string Mname = A.GetMoviename();
                string Mproducer = A.GetProducer();
                string Mdirector = A.GetDirector();
                string Mmactor = A.GetMale_actor();
                string Mfactor = A.GetFemale_actor();
                float Mratting = A.GetRating();




            }

        }



    }
}
