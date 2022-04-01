//link to index page - serverside code - runs when requested by client
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

namespace WebApp.Pages
{
    public class LogoutModel : PageModel
    {

        public IActionResult OnGet()  //when the page is called (logout button requests this method)
        {
            
            foreach(var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie); //Logout the user out by  removing the cookies 
            }
            return RedirectToPage("/Login/Login");

        }
    }
}