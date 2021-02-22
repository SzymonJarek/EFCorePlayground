using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Logging;
using Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Domain.Entity;

namespace EFCorePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddLogging()
                .BuildServiceProvider();

            //configure console logging
            serviceProvider
                .GetService<ILoggerFactory>();

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            logger.LogDebug("Starting application");

            var db = serviceProvider.GetService<Persistence.AppDbContext>();
            try
            {
                var book = new Book();
                book.Id = 1;
                book.Rating = 7;
                book.Title = "ppp";
                db.Books.Add(book);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                
            }
            

            Console.ReadKey();
            //do the actual work here
            //var bar = serviceProvider.GetService<IBarService>();
            //bar.DoSomeRealWork();

            //logger.LogDebug("All done!");

        }
    }
}
