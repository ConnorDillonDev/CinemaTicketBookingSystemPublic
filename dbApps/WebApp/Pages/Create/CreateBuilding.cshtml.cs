using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using UWS.CinemaTicketBookingSystem;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace WebApp.Pages
{
    //must hold the staff cookie claim 
    [Authorize(Policy ="MustBelongToStaff")]
    public class CreateBuildingModel : PageModel
    {
        public IQueryable<Building> Buildings {get;set;}

        public string PostResult {get;set;}


        private Cinema db;

        public CreateBuildingModel(Cinema injectedContext)
        {   
            db = injectedContext;

        }   

        public void OnGet(string ID){
            PostResult = ID;
            Buildings = db.Buildings;
        }

 

        [BindProperty]
        public Building Building { get; set; }


        public IActionResult OnPost()
        {   
            if (ModelState.IsValid){ 
                try{
                    //add new building to the database
                    db.Buildings.Add(Building);
                    db.SaveChanges();
                    return RedirectToPage ("../Create/CreateBuilding", new {ID = "added"});
                }catch(Microsoft.EntityFrameworkCore.DbUpdateException e) //error if the primary key is attempted to be used twice
                {
                    return RedirectToPage ("../Create/CreateBuilding", new {ID = "error"});
                }
                
            }
            else
            {
                return RedirectToPage ("../Create/CreateBuilding", new {ID = "invalid"});
            }
            
        }

    }
}