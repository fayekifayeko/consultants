namespace consultants.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<consultants.Data_Access_Layer.ConsoltantsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(consultants.Data_Access_Layer.ConsoltantsContext context)
        {
            var consultants = new List<Consultant>
            {
            new Consultant {Consultant_ID=1,Name="Fayek"},
                        new Consultant {Consultant_ID=2,Name="Nour"},
            new Consultant {Consultant_ID=3,Name="Sally"},
            new Consultant {Consultant_ID=4,Name="Dina"}


            };

            consultants.ForEach(s => context.Consultants.Add(s));
            context.SaveChanges();
            var assignments = new List<Assignment>
            {
            new Assignment{Assignment_ID=1,Assignment_Name="TM",Client_Name="EON",Percentage="30%",Start_Date=DateTime.Parse("2016-09-01"),End_Date=DateTime.Parse("2016-12-31"),Comment="Project for Eon",Consultant_ID=1},
            new Assignment{Assignment_ID=2,Assignment_Name="Website",Client_Name="Telia",Percentage="80%",Start_Date=DateTime.Parse("2016-07-21"),End_Date=DateTime.Parse("2017-03-31"),Comment="Website for Telia",Consultant_ID=1},
            new Assignment{Assignment_ID=3,Assignment_Name="Web Services",Client_Name="Jayway",Percentage="60%",Start_Date=DateTime.Parse("2016-09-01"),End_Date=DateTime.Parse("2016-12-31"),Comment="Webservices for Jayway",Consultant_ID=2},
            new Assignment{Assignment_ID=1,Assignment_Name="back-end",Client_Name="H&M",Percentage="90%",Start_Date=DateTime.Parse("2016-07-23"),End_Date=DateTime.Parse("2016-12-02"),Comment="back-end for H&M",Consultant_ID=3},
            new Assignment{Assignment_ID=1,Assignment_Name="front-end",Client_Name="Mackdonalds",Percentage="50%",Start_Date=DateTime.Parse("2016-11-11"),End_Date=DateTime.Parse("2017-08-21"),Comment="front-end for Mackdonalds",Consultant_ID=4}

            };
            assignments.ForEach(s => context.Assignments.Add(s));
            context.SaveChanges();

        }
    }
}
