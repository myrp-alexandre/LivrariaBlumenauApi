﻿using System.Web;
using System.Web.Mvc;

namespace LivrariaBlumenau.Presentation.MVC
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
