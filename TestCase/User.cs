using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLLModel = BussinessLayer.Model;
using BLLService = BussinessLayer.Services;

namespace TestCase
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class User
    {
        public User()
        {
            BootScrapper.ConfigureStructureMap();
        }

        [TestMethod]
        public void Save()
        {
            List<BLLModel.User> users = new List<BLLModel.User>();
            users.Add(new BLLModel.User
            {
                UserName = "Marina",
                ContactInfo = new BLLModel.ContactInfo { FirstName = "Marry" }
            });
            users.Add(new BLLModel.User
            {
                UserName = "Soniaa",
                ContactInfo = new BLLModel.ContactInfo { FirstName = "Sany" }
            });
            users.Add(new BLLModel.User
            {
                UserName = "Andy",
                ContactInfo = new BLLModel.ContactInfo { FirstName = "Andiii" }
            });
            users.Add(new BLLModel.User
            {
                UserName = "Ranu",
                ContactInfo = new BLLModel.ContactInfo { FirstName = "Rani" }
            });

            foreach (BLLModel.User oUser in users)
            {
                BLLService.UserService.Save(oUser);
            }

            System.Console.Write("Record has been saved");
        }

        [TestMethod]
        public void Remove()
        {
            var users = BLLService.UserService.FindAll();

            if (users != null && users.Count > 0)
            {
                BLLService.UserService.Remove(users.FirstOrDefault().UserId);
                System.Console.Write("Record has been removed");
            }
        }

        [TestMethod]
        public void GetAll()
        {
            List<BLLModel.User> users = BLLService.UserService.FindAll();
            if (users != null)
                System.Console.Write(string.Format("{0} record has been fetched", users.Count));
            else
                System.Console.Write("object is null");
        }

        [TestMethod]
        public void GetById()
        {
            BootScrapper.ConfigureStructureMap();

            var users = BLLService.UserService.FindAll();

            if (users != null && users.Count > 0)
            {
                BLLModel.User user = BLLService.UserService.GetById(users.FirstOrDefault().UserId);

                if (user != null)
                    System.Console.Write("object has been return successully");
                else
                    System.Console.Write("object is null");
            }
        }
    }
}