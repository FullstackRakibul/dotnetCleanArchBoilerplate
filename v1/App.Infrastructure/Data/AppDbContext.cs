using Microsoft.EntityFrameworkCore;
using App.Core.Models;

namespace App.Infrastructure.Data
{
	internal class AppDbContext: DbContext
	{
		//public AppDbContext(DbContextOptions<AppDbContext> options)
		//	: base(options)
		//{

		//}
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		
	}
}
