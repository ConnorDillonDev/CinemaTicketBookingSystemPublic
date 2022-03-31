using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UWS.CinemaTicketBookingSystem;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using UWS.CinemaTicketBookingSystem;
using System.Text.RegularExpressions;
using System.Security.Claims;
using System.Web;
using Microsoft.AspNetCore.Authentication;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;




namespace WebApp.Pages
{
    [Authorize(Policy ="MustBelongToCustomer")]
    public class IndexModel : PageModel
    {
        
        private Cinema db;

        public IList<Showing> Showings {get;set;}
        public IList<Movie> Movies {get;set;}
        public IList<AgeRating> Ratings {get;set;}
        public IList<Genre> Genres {get;set;}

        public string ApiImgPosters {get;set;}
        public string[] imagesources {get;set;}
        public int IMAGESOURCECOUNT {get;set;}


         public IndexModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }  


        public void OnGet(string sort){
            Movies = db.Movies.ToList();
            if(sort=="sort")
            {
                Sort();
            }


            //create list types of database tables
            Showings = db.Showings.ToList();
            Ratings = db.AgeRatings.ToList();
            Genres = db.Genres.ToList();

            api();
            //split to array on ","
            imagesources = ApiImgPosters.Split(",");

            IMAGESOURCECOUNT = imagesources.Count() -1 ;

        }

        public void Sort()
        {
            Movies = Movies.ToList();
            //order the movies based on their rating ID
            Movies = Movies.OrderBy(m => m.RatingID).ToList();
        }



        public void api(){
            //priv key "1b32a5b3"
            foreach (Movie movie in Movies)
            {
                //Access the API and get the image for the movie 
                string apikey = "&apikey=1b32a5b3";
                string url = "http://www.omdbapi.com/?t=" + movie.MovieName + apikey;
                WebRequest wrGETURL = WebRequest.Create(url);
                Stream objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = "";
                int i = 0;

                while (sLine != null)
                {
                    i++;
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                    {
                        try
                        {
                            Array data = sLine.Split(",");
                            foreach (string x in data){
                                if (x.Contains("Poster"))
                                {
                                    string saveRef = x.Remove(0,9);
                                    saveRef = saveRef.Replace("\"", "");
                                    ApiImgPosters = ApiImgPosters +","+ saveRef;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Unexpected Error, Consider purchashing a commerical API key"); //most likely being limited
                        }
                    } 
                }
            }
        }


        [BindProperty]
        public string ShowingID { get; set; }
        
        [BindProperty]
        public string route { get; set; }



        [HttpPost]  
        public IActionResult OnPost(){
            if (route=="sort")
            {
                //for sort selected
                return RedirectToPage("Index", new {sort = "sort"});
            }
            else
            {
                //for movie selected
                return RedirectToPage("Booking/Create", new {ID = ShowingID});

            }
        }
    }
}