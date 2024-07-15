namespace FileDBImport.Worker.Data
{
    public static class DBConnectionExtensions
    {
        public static void AddData(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
        }
    }
}
