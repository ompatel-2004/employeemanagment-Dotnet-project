using EmployeeMgmtSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMgmtSystem.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			List<UserModel> user = new List<UserModel>();
			user.Add(new UserModel
			{
				Id = 1,
				Name = "Test",
				Email = "Test@gmail.com",
				Password = "password",
				Phone = "1234567890",
			});
			user.Add(new UserModel { 
				Id = 2,
				Name = "Test1",
				Email="abc@123",
				Password= "password",
				Phone = "1234567890",
			});

			return View(user);
		}
	}
}
