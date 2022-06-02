using api.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api
{
    public class Program
    {       
        static void CreateDatabase()
        {
           using var dbcontext = new MyDbcontext();
            string name = dbcontext.Database.GetDbConnection().Database;
           var kq =  dbcontext.Database.EnsureCreated();
            
        }
        static void DropDatabase()
        {
            using var dbcontext = new MyDbcontext();
            string name = dbcontext.Database.GetDbConnection().Database;
            var kq = dbcontext.Database.EnsureDeleted();

        }
        static void Insert()
        {
            using var dbcontext = new MyDbcontext();
            var p1 = new HangHoa();
            p1.ID = 1;
            dbcontext.Add(p1);
            dbcontext.SaveChanges();

        }
        // test
        static void Read()
        {
            using var dbcontext = new MyDbcontext();
            var HangHoas = dbcontext.HangHoas.ToList();
            HangHoas.ForEach(HangHoa => HangHoa.PrintInfo()); 
        }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
