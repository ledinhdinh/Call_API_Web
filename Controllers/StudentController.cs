using Call_API_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Call_API_Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

		public async Task<ActionResult> Index(StudentModel student)
		{
			ViewBag.Title = "Trang Chủ";
			var listStudent = await GetStudents();
			return View(listStudent);
		}

		private async Task<List<StudentModel>> GetStudents()
		{
			//string baseUrl = Request.Url.Scheme + "://" + Request.Url.Authority +
			//	Request.ApplicationPath.TrimEnd('/') + "/";   // Lấy base uri của website

			string link = "http://localhost/API/School/Danhsach";
			//HttpWebRequest request = HttpWebRequest.CreateHttp(link);
			using (var httpClient = new HttpClient())
			{
				//HttpResponseMessage res = await httpClient.GetAsync(baseUrl + "API/School/Danhsach");
				HttpResponseMessage res = await httpClient.GetAsync(link);
				if (res.StatusCode == System.Net.HttpStatusCode.OK)
				{
					List<StudentModel> list = new List<StudentModel>();
					list = res.Content.ReadAsAsync<List<StudentModel>>().Result;
					return list;
				}
				return null;
			}
		}
	}
}