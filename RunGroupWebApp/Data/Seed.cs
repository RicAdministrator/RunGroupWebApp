using Microsoft.AspNetCore.Identity;
using RunGroupWebApp.Data.Enum;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                // Get SuperUser's Id
                var superUser = context.Users.FirstOrDefault(u => u.UserName == "SuperUser1");
                var superUserId = superUser?.Id;

                // Get User's Id
                var user = context.Users.FirstOrDefault(u => u.UserName == "User1");
                var userId = user?.Id;

                if (!context.Clubs.Any())
                {
                    context.Clubs.AddRange(new List<Club>()
                    {
                        new Club()
                        {
                            Title = "Running Club 1",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Running Club 1.",
                            ClubCategory = ClubCategory.RoadRunner,
                            Address = new Address()
                            {
                                Street = "Running Club 1 St",
                                City = "Calamba",
                                State = "Calabarzon"
                            },
                            AppUserId = superUserId
                        },
                        new Club()
                        {
                            Title = "Running Club 2",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Running Club 2.",
                            ClubCategory = ClubCategory.Womens,
                            Address = new Address()
                            {
                                Street = "Running Club 2 St",
                                City = "Makati",
                                State = "National Capital Region (NCR)"
                            },
                            AppUserId = superUserId
                        },
                        new Club()
                        {
                            Title = "Running Club 3",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Running Club 3.",
                            ClubCategory = ClubCategory.City,
                            Address = new Address()
                            {
                                Street = "Running Club 3 St",
                                City = "Calamba",
                                State = "Calabarzon"
                            },
                            AppUserId = userId
                        },
                        new Club()
                        {
                            Title = "Running Club 4",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Running Club 4.",
                            ClubCategory = ClubCategory.Trail,
                            Address = new Address()
                            {
                                Street = "Running Club 4 St",
                                City = "Makati",
                                State = "National Capital Region (NCR)"
                            },
                            AppUserId = userId
                        }
                    });
                    context.SaveChanges();
                }
                //Races
                if (!context.Races.Any())
                {
                    context.Races.AddRange(new List<Race>()
                    {
                        new Race()
                        {
                            Title = "Running Race 1",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Running Race 1.",
                            RaceCategory = RaceCategory.Marathon,
                            Address = new Address()
                            {
                                Street = "Running Race 1 St",
                                City = "Calamba",
                                State = "Calabarzon"
                            },
                            AppUserId = superUserId
                        },
                        new Race()
                        {
                            Title = "Running Race 2",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Running Race 2.",
                            RaceCategory = RaceCategory.Ultra,
                            Address = new Address()
                            {
                                Street = "Running Race 2 St",
                                City = "Makati",
                                State = "National Capital Region (NCR)"
                            },
                            AppUserId = superUserId
                        },
                        new Race()
                        {
                            Title = "Running Race 3",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Running Race 3.",
                            RaceCategory = RaceCategory.FiveK,
                            Address = new Address()
                            {
                                Street = "Running Race 3 St",
                                City = "Calamba",
                                State = "Calabarzon"
                            },
                            AppUserId = userId
                        },
                        new Race()
                        {
                            Title = "Running Race 4",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of Running Race 4.",
                            RaceCategory = RaceCategory.TenK,
                            Address = new Address()
                            {
                                Street = "Running Race 4 St",
                                City = "Makati",
                                State = "National Capital Region (NCR)"
                            },
                            AppUserId = userId
                        },
                    });
                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                string adminUserEmail = "super_user_1@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new AppUser()
                    {
                        UserName = "SuperUser1",
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "Super User 1 St",
                            City = "Calamba",
                            State = "Calabarzon"
                        }
                    };
                    await userManager.CreateAsync(newAdminUser, "P@ssword1");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user_1@gmail.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new AppUser()
                    {
                        UserName = "User1",
                        Email = appUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "User 1 St",
                            City = "Makati",
                            State = "National Capital Region (NCR)"
                        }
                    };
                    await userManager.CreateAsync(newAppUser, "P@ssword1");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
