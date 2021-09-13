/// Lab-Week2(Graded Assignment)    
/// File Name: HomeWork2
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Aokola
///
///The video game machine at the local arcade output coupons
/// according to how well the game is played.For ten redeemed coupons you get a candy bar
/// for 3 coupons you get one gumball. Preferably the choice is to go for candybars over gumballs (taste better than gum!!).
/// A program is written with defined variable inititailly assigned to the number of coupons one.
/// The program should output how many candy bars and gumballs one can get if all of the coupons are spent on candy bars first and 
/// remaining coupons on gumballs



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_coupons = 108;
            int num_coupons_after_candybars, num_coupons_after_gumballs, num_candy_bar, num_gumballs;
            //integer division below discards any remaninder
            num_candy_bar = num_coupons / 10;
            num_coupons_after_candybars = num_coupons % 10;

            //calculate gumballs

            num_gumballs = num_coupons_after_candybars / 3;

            //calculate any leftover num_coupons_after_candybars

            num_coupons_after_gumballs = num_coupons_after_candybars % 3;

            Console.WriteLine("Your {0} coupons can be redeemed for {1} candy bars and {2} gumballs with {3} coupons leftover", num_coupons,
            num_candy_bar, num_gumballs, num_coupons_after_gumballs);
            Console.ReadLine();
        }
    }
}
