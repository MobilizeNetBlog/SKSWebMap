


namespace WebSite
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    public partial class Startup
    {  
        /// <summary>
        /// Entry point of windows form application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Start(string[] args)
        {
            UpgradeHelpers.DB.DbProviderFactories.RegisterFactory("System.Data.SQLite", typeof(System.Data.SQLite.SQLiteFactory));
            SKS.modMain.Main();
        }

        /// <summary>
        /// Entry Point of the web Application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            
            BuildWebHost(args).Run();
        }

        /// <summary>
        /// Returns a new WebHost
        /// </summary>
        /// <param name="args">run arguments</param>
        /// <returns>a new WebHost</returns>
        public static IWebHost BuildWebHost(string[] args){
            return WebHost.CreateDefaultBuilder(args)
                //// logging
                //.ConfigureLogging(builder => builder.AddFile(options =>
                //{
                //    options.FileName = "log-";
                //    options.LogDirectory = "LogFiles";
                //    options.FileSizeLimit = 20 * 1024 * 1024;
                //}))
                .UseStartup<Startup>()
                .Build();
        }
    }
}

