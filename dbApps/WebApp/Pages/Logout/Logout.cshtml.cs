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
        //!! not working need to destory the cookie
        public async Task<IActionResult> OnPostAsync(){
            // await HttpContext.SignOutAsync();
            // HttpContext.Response.Cookies.Remove("MyCookieAuth");
            return RedirectToPage("../");
        }

    }
}