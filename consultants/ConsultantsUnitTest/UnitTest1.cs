//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using consultants.Models;
//using System.Collections.Generic;
//using consultants.Controllers;
//using System.Web;
//using consultants.Data_Access_Layer;
//using System.Web.Http.Results;

//namespace ConsultantsUnitTest
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void GetAssignments_ShouldReturnAllAssignments()
//        {
//            var context = new AppContext();


//            context.Assignments.Add(new Assignment { Assignment_ID = 2, Assignment_Name = "Website", Client_Name = "Telia", Percentage = "80%", Start_Date = DateTime.Parse("2016-07-21"), End_Date = DateTime.Parse("2017-03-31"), Comment = "Website for Telia", Consultant_ID = 1 });

//            context.Assignments.Add(new Assignment { Assignment_ID = 1, Assignment_Name = "TM", Client_Name = "EON", Percentage = "30%", Start_Date = DateTime.Parse("2016-09-01"), End_Date = DateTime.Parse("2016-12-31"), Comment = "Project for Eon", Consultant_ID = 1 });

//            context.Assignments.Add(new Assignment { Assignment_ID = 3, Assignment_Name = "Web Services", Client_Name = "Jayway", Percentage = "60%", Start_Date = DateTime.Parse("2016-09-01"), End_Date = DateTime.Parse("2016-12-31"), Comment = "Webservices for Jayway", Consultant_ID = 2 });


//            var controller = new AssignmentController(context);
//            var result = controller.Get() as TestAssignmentDbSet;

//            Assert.IsNotNull(result);
//            Assert.AreEqual(3, result.Local.Count);
//        }
//        [TestMethod]
//        public void GetProduct_ShouldReturnProductWithSameID()
//        {
//            var context = new AppContext();
//            context.Assignments.Add(GetDemoProduct());

//            var controller = new AssignmentController(context);
//            var result = controller.Get(3) as OkNegotiatedContentResult<Assignment>;

//            Assert.IsNotNull(result);
//            Assert.AreEqual(3, result.Content.Assignment_ID);
//        }
//        Assignment GetDemoProduct()
//        {
//            return new Assignment { Assignment_ID = 3, Assignment_Name = "Web Services", Client_Name = "Jayway", Percentage = "60%", Start_Date = DateTime.Parse("2016-09-01"), End_Date = DateTime.Parse("2016-12-31"), Comment = "Webservices for Jayway", Consultant_ID = 2 };

//        }



//    }
//}

////        public void TestMethod1()
////        {
////            var testAssignments = GetTestAssignments();
////            var controller = new AssignmentController();

////            var result = controller.Get() as List<Assignment>;
////            Assert.AreEqual(testProducts.Count, result.Count);

////        }
////        private List<Assignment> GetTestAssignments()
////        {
////            var testAssignments = new List<Assignment>();
////            testAssignments.Add(new Assignment { Assignment_ID = 1, Assignment_Name = "TM", Client_Name = "EON", Percentage = "30%", Start_Date = DateTime.Parse("2016-09-01"), End_Date = DateTime.Parse("2016-12-31"), Comment = "Project for Eon", Consultant_ID = 1 });
////            testAssignments.Add(new Assignment { Assignment_ID = 2, Assignment_Name = "Website", Client_Name = "Telia", Percentage = "80%", Start_Date = DateTime.Parse("2016-07-21"), End_Date = DateTime.Parse("2017-03-31"), Comment = "Website for Telia", Consultant_ID = 1 });
////            testAssignments.Add( new Assignment { Assignment_ID = 3, Assignment_Name = "Web Services", Client_Name = "Jayway", Percentage = "60%", Start_Date = DateTime.Parse("2016-09-01"), End_Date = DateTime.Parse("2016-12-31"), Comment = "Webservices for Jayway", Consultant_ID = 2 });
////            testAssignments.Add(  new Assignment { Assignment_ID = 1, Assignment_Name = "back-end", Client_Name = "H&M", Percentage = "90%", Start_Date = DateTime.Parse("2016-07-23"), End_Date = DateTime.Parse("2016-12-02"), Comment = "back-end for H&M", Consultant_ID = 3 });
////            testAssignments.Add(new Assignment { Assignment_ID = 1, Assignment_Name = "front-end", Client_Name = "Mackdonalds", Percentage = "50%", Start_Date = DateTime.Parse("2016-11-11"), End_Date = DateTime.Parse("2017-08-21"), Comment = "front-end for Mackdonalds", Consultant_ID = 4 });




////            return testAssignments;

////        }

////    }
////}
