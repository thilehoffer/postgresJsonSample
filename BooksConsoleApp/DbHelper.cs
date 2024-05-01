using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksConsoleApp
{
	public static class DbHelper
	{
		public static void SeedData()
		{
			using (var context = new BooksDbContext())
			{

				if (context.Books.Any()) return;

				context.Books.AddRange(
				[
				new Book
			{
				BookId = 1,
				Title = "Book1",
				BookDetails = new()
				{
					Authors = new () {{"Author1"}, "Author2"},
					PublishedYear = 2000,
					Rating = 3
				}
			},
				new Book
			{
				BookId = 2,
				Title = "Book2",
				BookDetails = new()
				{
					Authors = new () {{"Author2"}, "Author3"},
					PublishedYear = 2010,
					Rating = 5
				}
			}
				]);
				context.SaveChanges();
			}
		}
	}
}
