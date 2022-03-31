using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace UWS.CinemaTicketBookingSystem
{
    public class Cinema : DbContext
    {
        //these properties map to tables in the database
        public DbSet<Account> Accounts {set;get;}
        public DbSet<Actor> Actors {set;get;}
        public DbSet<ActorsMovieJunction> ActorsMovieJunctions {set;get;}
        public DbSet<AgeRating> AgeRatings {set;get;}
        public DbSet<Booking> Bookings {set;get;}
        public DbSet<Building> Buildings {set;get;}
        public DbSet<Director> Directors {set;get;}
        public DbSet<DirectorsMovieJunction> DirectorsMovieJunctions {set;get;}
        public DbSet<Genre> Genres {set;get;}
        public DbSet<Movie> Movies {set;get;}
        public DbSet<PossibleDiscount> PossibleDiscounts {set;get;}
        public DbSet<PossibleDiscountShowingJunction> PossibleDiscountShowingJunctions {set;get;}
        public DbSet<Showing> Showings {set;get;}
        public DbSet<Theatre> Theatres {set;get;}


        public Cinema(DbContextOptions<Cinema> options)
          : base(options) { }

        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //all following realtions are modeled fron the enhanced entity realtionship model 

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Building>()
            .HasMany(t =>t.Theatres)
            .WithOne(b => b.Building);

            
            modelBuilder.Entity<Booking>()
            .HasOne(c => c.Account)
            .WithMany(p => p.Bookings)
            .HasForeignKey(t => t.Email);

            modelBuilder.Entity<Account>()
            .HasMany(c => c.Bookings)
            .WithOne(p => p.Account);
            

            // // define a one-to-many relationship
            // modelBuilder.Entity<Building>()
            // .HasMany(c => c.Theatres)
            // .WithOne(p => p.Building);
            

            // define a one-to-many relationship
            modelBuilder.Entity<Theatre>()
            .HasMany(c => c.Showings)
            .WithOne(p => p.Theatre);
            // .HasForeignKey(t => t.ComplexName);

             modelBuilder.Entity<Theatre>()
            .HasOne(c => c.Building)
            .WithMany(p => p.Theatres)
            .HasForeignKey(t => t.ComplexName);

            // define a one-to-many relationship
            modelBuilder.Entity<Showing>()
            .HasOne(o => o.Movie)
            .WithMany(s => s.Showings)
            .HasForeignKey(t => t.MovieName);

            modelBuilder.Entity<Showing>()
            .HasMany(o => o.Bookings)
            .WithOne(s => s.Showing);

            modelBuilder.Entity<Showing>()
            .HasOne(o => o.Theatre)
            .WithMany(s => s.Showings)
            .HasForeignKey(t => t.ScreenNum);

            modelBuilder.Entity<Movie>()
            .HasOne(c => c.Genre)
            .WithMany(p => p.Movies)
            .HasForeignKey(t => t.GenreID);

            modelBuilder.Entity<Movie>()
            .HasOne(c => c.AgeRating)
            .WithMany(p => p.Movies)
            .HasForeignKey(t => t.RatingID);

            modelBuilder.Entity<Movie>()
            .HasMany(p => p.DirectorsMovieJunctions)
            .WithOne(c => c.Movie);

            modelBuilder.Entity<Booking>()
            .HasOne(c => c.Showing)
            .WithMany(p => p.Bookings)
            .HasForeignKey(t => t.ShowingID);
            
            
            modelBuilder.Entity<Booking>()
            .HasOne(c => c.Account)
            .WithMany(p => p.Bookings)
            .HasForeignKey(t => t.Email);


            //comp key for showing
            modelBuilder.Entity<PossibleDiscountShowingJunction>()
            .HasKey(o => new { o.DiscountID, o.ShowingID});


            modelBuilder.Entity<DirectorsMovieJunction>().HasKey(o => new {o.DirectorID, o.MovieName});

            modelBuilder.Entity<DirectorsMovieJunction>()
                .HasOne<Director>(sc => sc.Director)
                .WithMany(s => s.DirectorsMovieJunctions)
                .HasForeignKey(sc => sc.DirectorID);


            modelBuilder.Entity<DirectorsMovieJunction>()
                .HasOne<Movie>(sc => sc.Movie)
                .WithMany(s => s.DirectorsMovieJunctions)
                .HasForeignKey(sc => sc.MovieName);


            //comp key for movie
            modelBuilder.Entity<ActorsMovieJunction>().HasKey(o => new { o.ActorID, o.MovieName });

            modelBuilder.Entity<ActorsMovieJunction>()
                .HasOne<Actor>(sc => sc.Actor)
                .WithMany(s => s.ActorsMovieJunctions)
                .HasForeignKey(sc => sc.ActorID);


            modelBuilder.Entity<ActorsMovieJunction>()
                .HasOne<Movie>(sc => sc.Movie)
                .WithMany(s => s.ActorsMovieJunctions)
                .HasForeignKey(sc => sc.MovieName);            
        }
    }
}