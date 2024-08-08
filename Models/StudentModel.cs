using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Call_API_Web.Models
{
	public class StudentModel
	{
		[StringLength(30)]
		public string hoten { get; set; }

		[StringLength(30)]
		public string diachi { get; set; }

		[StringLength(12)]
		public string dienthoai { get; set; }

		public int? malop { get; set; }

		[StringLength(255)]
		public string anh { get; set; }
	}
}