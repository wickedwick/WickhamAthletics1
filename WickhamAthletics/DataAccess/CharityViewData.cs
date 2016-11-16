using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WickhamAthletics.Models;

namespace WickhamAthletics.DataAccess
{
    public class CharityViewData
    {
        private static string[] DonationTitleNames = { "Household Supplies", "Toys for the Family Room" , "Pantry Items" };
        private static string[] HouseholdSupplies = { "First class postage stamps",
                                               "Keurig coffee pods",
                                               "Gift cards for Dillons/Walmart",
                                               "Wicker Waste Basket",
                                               "12-Cup Coffeemaker",
                                               "Paper towels",
                                               "Playtex Diaper Genie Disposal System Refills",
                                               "OXO Good Grips Bottle Brush/Dish Brush",
                                               "OXO Good Grips Hideaway Compact Toilet Brush",
                                               "Laundry Detergent",
                                               "Yankee Candles",
                                               "Electric Candle Warmer",
                                               "Fabric Softener Dryer Sheets",
                                               "Comet Cleanser with Bleach",
                                               "Windex Glass & Multi-Surface Cleaner",
                                               "Kaboom BowlBlaster Liquid Toilet Bowl Cleaner",
                                               "Kaboom with OxiClean Foam-Tastic",
                                               "Swiffer Sweeper Floor Mop Starter Kit",
                                               "Swiffer Dusters Starter Kit",
                                               "42 Gallon Garbage Bags",
                                               "Febreze air freshener",
                                               "Softsoap Antibacterial Liquid Hand Soap",
                                               "Dawn Dish Soap and Dishwashing Liquid",
                                               "Rubbermaid Storage Containers",
                                               "Clorox Disinfectant Wipes" };

        private static string[] FamilyRoomToys = { "Games for Xbox One & Kinect",
                                            "Accessories for Little Tykes Kitchen",
                                            "Fisher Price Little People Items",
                                            "Lego Duplo Items",
                                            "Fisher Price 3 in 1 Sit, Stride, & Ride Lion",
                                            "Fisher Price Shimmer & Shine Dolls",
                                            "Finding Dory puzzles, toys, dolls, games, etc…",
                                            "Matchbox Cars",
                                            "Puzzles",
                                            "Coloring Books & Crayons",
                                            "Play Doh",
                                            "Mega Block sets"};
        private static string[] PantryItems = { "Chicken broth",
                                         "Cream of mushroom soup",
                                         "Cream of chicken soup",
                                         "Canned fruit",
                                         "Sugar (granulated, powder, brown)",
                                         "Flour",
                                         "Cocoa",
                                         "Sweetened condensed milk",
                                         "Baking chips (chocolate, butterscotch, peanut butter)",
                                         "Crisco",
                                         "Olive and canola oil",
                                         "Heavy duty aluminum foil",
                                         "Parchment paper",
                                         "Frosted Pop Tarts",
                                         "Protein bars",
                                         "Fruit snacks",
                                         "Small bags of nuts",
                                         "Single serve pudding cups",
                                         "Single serve fruit cups",
                                         "Egg noodles",
                                         "Rice",
                                         "Salsa",
                                         "Bisquick"};

        public static CharityView GetCharityView()
        {
            CharityView viewData = null;

            viewData = new CharityView
            {
                Title = "“Hope for the Holidays”",
                Heading = "The Ronald McDonald House charity list"
            };

            List<DonationTypes> donationTypes = new List<DonationTypes>();

            foreach (var title in DonationTitleNames)
            {
                //viewData.DonationTypes.Add(GetDonationTypes(title));
                donationTypes.Add(GetDonationTypes(title));
            }

            viewData.DonationTypes = donationTypes;

            return viewData;
        }

        private static DonationTypes GetDonationTypes(string type)
        {
            switch (type)
            {
                case "Household Supplies":
                    return new DonationTypes
                    {
                        Title = "Household Supplies",
                        ListItems = HouseholdSupplies.ToList()
                    };
                case "Toys for the Family Room":
                    return new DonationTypes
                    {
                        Title = "Toys for the Family Room",
                        ListItems = FamilyRoomToys.ToList()
                    };
                case "Pantry Items":
                    return new DonationTypes
                    {
                        Title = "Pantry Items",
                        ListItems = PantryItems.ToList()
                    };
                default: throw new InvalidCastException("");
            }
        }
    }
}