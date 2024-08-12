using Microsoft.AspNetCore.Identity;


//TODO: Update these using statements to include your project name
using spr24_team4_finalproject.Utilities;
using spr24_team4_finalproject.DAL;
using spr24_team4_finalproject.Models;

//TODO: Upddate this namespace to match your project name
namespace spr24_team4_finalproject.Seeding
{
    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();

            //Employees

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "t.jacobs@longhornairlines.neet",
                    Email = "t.jacobs@longhornairlines.neet",
                    PhoneNumber = "(469) 465-3365",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    MiddleInitial = "L",
                    Street = "4564 Elm St.",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75032",
                    empStatus = EmpStatus.Active

                },
                Password = "society",
                RoleName = "Gate Agent"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "e.rice@longhornairlines.neet",
                    Email = "e.rice@longhornairlines.neet",
                    PhoneNumber = "4693876657",
                    FirstName = "Eryn",
                    LastName = "Rice",
                    MiddleInitial = "M",
                    Street = "3405 Rio Grande",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75043",
                    empStatus = EmpStatus.Active
                },
                Password = "ricearoni",
                RoleName = "Manager"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "a.taylor@longhornairlines.neet",
                    Email = "a.taylor@longhornairlines.neet",
                    PhoneNumber = "4694748452",
                    FirstName = "Allison",
                    LastName = "Taylor",
                    MiddleInitial = "R",
                    Street = "467 Nueces St.",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75206",
                    empStatus = EmpStatus.Active
                },
                Password = "nostalgic",
                RoleName = "Gate Agent"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "m.sheffield@longhornairlines.neet",
                    Email = "m.sheffield@longhornairlines.neet",
                    PhoneNumber = "4695479167",
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    MiddleInitial = "J",
                    Street = "3886 Avenue A",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75032",
                    empStatus = EmpStatus.Active
                },
                Password = "longhorns",
                RoleName = "Gate Agent"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "j.macleod@longhornairlines.neet",
                    Email = "j.macleod@longhornairlines.neet",
                    PhoneNumber = "2814748138",
                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    MiddleInitial = "D",
                    Street = "2504 Far West Blvd.",
                    City = "Houston",
                    State = "TX",
                    Zip = "77001",
                    empStatus = EmpStatus.Active
                },
                Password = "smitty",
                RoleName = "Gate Agent"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "j.tanner@longhornairlines.neet",
                    Email = "j.tanner@longhornairlines.neet",
                    PhoneNumber = "5124590929",
                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    MiddleInitial = "S",
                    Street = "4347 Almstead",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705",
                    empStatus = EmpStatus.Active
                },
                Password = "tanman",
                RoleName = "Gate Agent"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "e.stuart@longhornairlines.neet",
                    Email = "e.stuart@longhornairlines.neet",
                    PhoneNumber = "5128178335",
                    FirstName = "Eric",
                    LastName = "Stuart",
                    MiddleInitial = "F",
                    Street = "5576 Toro Ring",
                    City = "Austin",
                    State = "TX",
                    Zip = "78710",
                    empStatus = EmpStatus.Active
                },
                Password = "stewboy",
                RoleName = "Gate Agent"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "c.miller@longhornairlines.neet",
                    Email = "c.miller@longhornairlines.neet",
                    PhoneNumber = "9157458615",
                    FirstName = "Charles",
                    LastName = "Miller",
                    MiddleInitial = "R",
                    Street = "8962 Main St.",
                    City = "El Paso",
                    State = "TX",
                    Zip = "79901",
                    empStatus = EmpStatus.Active
                },
                Password = "squirrel",
                RoleName = "Gate Agent"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "r.taylor@longhornairlines.neet",
                    Email = "r.taylor@longhornairlines.neet",
                    PhoneNumber = "2814512631",
                    FirstName = "Rachel",
                    LastName = "Taylor",
                    MiddleInitial = "O",
                    Street = "345 Longview Dr.",
                    City = "Houston",
                    State = "TX",
                    Zip = "77002",
                    empStatus = EmpStatus.Active
                },
                Password = "swansong",
                RoleName = "Manager"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "v.lawrence@longhornairlines.neet",
                    Email = "v.lawrence@longhornairlines.neet",
                    PhoneNumber = "2819457399",
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    MiddleInitial = "Y",
                    Street = "6639 Butterfly Ln.",
                    City = "Houston",
                    State = "TX",
                    Zip = "77003",
                    empStatus = EmpStatus.Active
                },
                Password = "lottery",
                RoleName = "Gate Agent"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "a.rogers@longhornairlines.neet",
                    Email = "a.rogers@longhornairlines.neet",
                    PhoneNumber = "4698752943",
                    FirstName = "Allen",
                    LastName = "Rogers",
                    MiddleInitial = "H",
                    Street = "4965 Oak Hill",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75043",
                    empStatus = EmpStatus.Active
                },
                Password = "evanescent",
                RoleName = "Manager"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "e.markham@longhornairlines.neet",
                    Email = "e.markham@longhornairlines.neet",
                    PhoneNumber = "5124579845",
                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    MiddleInitial = "K",
                    Street = "7861 Chevy Chase",
                    City = "Austin",
                    State = "TX",
                    Zip = "78712",
                    empStatus = EmpStatus.Active
                },
                Password = "monty3",
                RoleName = "Gate Agent"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "s.saunders@longhornairlines.neet",
                    Email = "s.saunders@longhornairlines.neet",
                    PhoneNumber = "5123497810",
                    FirstName = "Sarah",
                    LastName = "Saunders",
                    MiddleInitial = "M",
                    Street = "332 Avenue C",
                    City = "Austin",
                    State = "TX",
                    Zip = "78613",
                    empStatus = EmpStatus.Active
                },
                Password = "rankmary",
                RoleName = "Gate Agent"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "w.sewell@longhornairlines.neet",
                    Email = "w.sewell@longhornairlines.neet",
                    PhoneNumber = "5124510084",
                    FirstName = "William",
                    LastName = "Sewell",
                    MiddleInitial = "G",
                    Street = "2365 51st St.",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705",
                    empStatus = EmpStatus.Active
                },
                Password = "walkamile",
                RoleName = "Manager"
            });

            //Customers

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "cbaker@freserve.co.uk",
                    Email = "cbaker@freserve.co.uk",
                    PhoneNumber = "(469) 557-1146",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Christopher",
                    LastName = "Baker",
                    MiddleInitial = "L",
                    Street = "1245 Lake Anchorage Blvd.",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75001",
                    DateOfBirth = DateTime.Parse("1949-11-23 00:00:00"),
                    AdvNumber = 5001

                },
                Password = "hello123",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "banker@longhorn.net",
                    Email = "banker@longhorn.net",
                    PhoneNumber = "4692678873",
                    FirstName = "Michelle",
                    LastName = "Banks",
                    MiddleInitial = "nan",
                    Street = "1300 Tall Pine Lane",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75002",
                    DateOfBirth = DateTime.Parse("1962-11-27 00:00:00"),
                    AdvNumber = 5002
                },
                Password = "potato",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "franco@aoll.com",
                    Email = "franco@aoll.com",
                    PhoneNumber = "2815659699",
                    FirstName = "Franco",
                    LastName = "Broccolo",
                    MiddleInitial = "V",
                    Street = "62 Browning Road",
                    City = "Houston",
                    State = "TX",
                    Zip = "77003",
                    DateOfBirth = DateTime.Parse("1992-10-11 00:00:00"),
                    AdvNumber = 5003
                },
                Password = "painting",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "wchang@gogle.com",
                    Email = "wchang@gogle.com",
                    PhoneNumber = "5125943222",
                    FirstName = "Wendy",
                    LastName = "Chang",
                    MiddleInitial = "L",
                    Street = "202 Bellmont Hall",
                    City = "Austin",
                    State = "TX",
                    Zip = "78719",
                    DateOfBirth = DateTime.Parse("1997-05-16 00:00:00"),
                    AdvNumber = 5004
                },
                Password = "texas2000",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "limchou@yoho.com",
                    Email = "limchou@yoho.com",
                    PhoneNumber = "8137724599",
                    FirstName = "Lim",
                    LastName = "Chou",
                    MiddleInitial = "nan",
                    Street = "1600 Teresa Lane",
                    City = "Fort Meyers",
                    State = "FL",
                    Zip = "33917",
                    DateOfBirth = DateTime.Parse("1970-04-06 00:00:00"),
                    AdvNumber = 5005
                },
                Password = "Anchorage",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "shdixon@utx.edu",
                    Email = "shdixon@utx.edu",
                    PhoneNumber = "2052643255",
                    FirstName = "Shan",
                    LastName = "Dixon",
                    MiddleInitial = "D",
                    Street = "234 Holston Circle",
                    City = "Sheffield",
                    State = "AL",
                    Zip = "35662",
                    DateOfBirth = DateTime.Parse("1984-01-12 00:00:00"),
                    AdvNumber = 5006
                },
                Password = "pepperoni",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "j.b.evans@aheca.org",
                    Email = "j.b.evans@aheca.org",
                    PhoneNumber = "5122565834",
                    FirstName = "Jim Bob",
                    LastName = "Evans",
                    MiddleInitial = "nan",
                    Street = "506 Farrell Circle",
                    City = "Austin",
                    State = "TX",
                    Zip = "78705",
                    DateOfBirth = DateTime.Parse("1959-09-09 00:00:00"),
                    AdvNumber = 5007
                },
                Password = "longhorns",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "feeley@longhorn.org",
                    Email = "feeley@longhorn.org",
                    PhoneNumber = "9152556749",
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    MiddleInitial = "K",
                    Street = "600 S 8th Street W",
                    City = "El Paso",
                    State = "TX",
                    Zip = "79901",
                    DateOfBirth = DateTime.Parse("2002-01-12 00:00:00"),
                    AdvNumber = 5008
                },
                Password = "aggies",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tfreeley@minnetonka.ci.us",
                    Email = "tfreeley@minnetonka.ci.us",
                    PhoneNumber = "6123255687",
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    MiddleInitial = "P",
                    Street = "4448 Fairview Ave.",
                    City = "Minnetonka",
                    State = "MN",
                    Zip = "55343",
                    DateOfBirth = DateTime.Parse("1991-02-04 00:00:00"),
                    AdvNumber = 5009
                },
                Password = "raiders",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mgarcia@gogle.com",
                    Email = "mgarcia@gogle.com",
                    PhoneNumber = "4696593544",
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    MiddleInitial = "L",
                    Street = "594 Longview",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75043",
                    DateOfBirth = DateTime.Parse("1991-10-02 00:00:00"),
                    AdvNumber = 5010
                },
                Password = "mustangs",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    PhoneNumber = "4698475583",
                    FirstName = "Charles",
                    LastName = "Haley",
                    MiddleInitial = "E",
                    Street = "One Cowboy Pkwy",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75032",
                    DateOfBirth = DateTime.Parse("1974-07-10 00:00:00"),
                    AdvNumber = 5011
                },
                Password = "onetime",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "jeffh@sonic.com",
                    Email = "jeffh@sonic.com",
                    PhoneNumber = "4696978613",
                    FirstName = "Jeffrey",
                    LastName = "Hampton",
                    MiddleInitial = "T.",
                    Street = "337 38th St.",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75209",
                    DateOfBirth = DateTime.Parse("2014-03-10 00:00:00"),
                    AdvNumber = 5012
                },
                Password = "hampton1",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "wjhearniii@umich.org",
                    Email = "wjhearniii@umich.org",
                    PhoneNumber = "2818965621",
                    FirstName = "John",
                    LastName = "Hearn",
                    MiddleInitial = "B",
                    Street = "4225 North First",
                    City = "Houston",
                    State = "TX",
                    Zip = "77010",
                    DateOfBirth = DateTime.Parse("1950-08-05 00:00:00"),
                    AdvNumber = 5013
                },
                Password = "jhearn22",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ahick@yaho.com",
                    Email = "ahick@yaho.com",
                    PhoneNumber = "2815788965",
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    MiddleInitial = "J",
                    Street = "32 NE Garden Ln., Ste 910",
                    City = "Houston",
                    State = "TX",
                    Zip = "77012",
                    DateOfBirth = DateTime.Parse("2005-12-08 00:00:00"),
                    AdvNumber = 5014
                },
                Password = "hickhickup",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ingram@jack.com",
                    Email = "ingram@jack.com",
                    PhoneNumber = "5124678821",
                    FirstName = "Brad",
                    LastName = "Ingram",
                    MiddleInitial = "S.",
                    Street = "6548 La Posada Ct.",
                    City = "Austin",
                    State = "TX",
                    Zip = "78613",
                    DateOfBirth = DateTime.Parse("2016-09-05 00:00:00"),
                    AdvNumber = 5015
                },
                Password = "ingram2015",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "toddj@yourmom.com",
                    Email = "toddj@yourmom.com",
                    PhoneNumber = "9154653365",
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    MiddleInitial = "L.",
                    Street = "4564 Elm St.",
                    City = "El Paso",
                    State = "TX",
                    Zip = "79991",
                    DateOfBirth = DateTime.Parse("1999-01-20 00:00:00"),
                    AdvNumber = 5016
                },
                Password = "toddy25",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "thequeen@aska.net",
                    Email = "thequeen@aska.net",
                    PhoneNumber = "9159457399",
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    MiddleInitial = "M.",
                    Street = "6639 Butterfly Ln.",
                    City = "El Paso",
                    State = "TX",
                    Zip = "79930",
                    DateOfBirth = DateTime.Parse("2000-04-14 00:00:00"),
                    AdvNumber = 5017
                },
                Password = "something",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "linebacker@gogle.com",
                    Email = "linebacker@gogle.com",
                    PhoneNumber = "5122449976",
                    FirstName = "Erik",
                    LastName = "Lineback",
                    MiddleInitial = "W",
                    Street = "1300 Netherland St",
                    City = "Austin",
                    State = "TX",
                    Zip = "78613",
                    DateOfBirth = DateTime.Parse("2013-12-02 00:00:00"),
                    AdvNumber = 5018
                },
                Password = "Password1",
                RoleName = "Customer"
            });


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "elowe@netscare.net",
                    Email = "elowe@netscare.net",
                    PhoneNumber = "4695344627",
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    MiddleInitial = "S",
                    Street = "3201 Pine Drive",
                    City = "Dallas",
                    State = "TX",
                    Zip = "75039",
                    DateOfBirth = DateTime.Parse("1977-12-07 00:00:00"),
                    AdvNumber = 5019
                },
                Password = "aclfest2017",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "cluce@gogle.com",
                    Email = "cluce@gogle.com",
                    PhoneNumber = "5126983548",
                    FirstName = "Chuck",
                    LastName = "Luce",
                    MiddleInitial = "B",
                    Street = "2345 Rolling Clouds",
                    City = "Austin",
                    State = "TX",
                    Zip = "78712",
                    DateOfBirth = DateTime.Parse("1949-03-16 00:00:00"),
                    AdvNumber = 5020
                },
                Password = "nothinggood",
                RoleName = "Customer"
            });
            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + errorFlag, ex);
            }

            return result;
        }
    }
}
