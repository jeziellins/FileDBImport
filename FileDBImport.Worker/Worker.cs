using FileDBImport.Worker.Data.Repositories.Interfaces;
using System.Diagnostics;

namespace FileDBImport.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IInstrumentsRepository _instrumentsRepository;
        private readonly string _filePath;

        public Worker(ILogger<Worker> logger, IInstrumentsRepository instrumentsRepository, IConfiguration configuration)
        {
            _logger = logger;
            _instrumentsRepository = instrumentsRepository;
            _filePath = configuration.GetSection("FilePath").Value ?? throw new Exception("File not found");
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Delay(3000, stoppingToken);
            Console.Clear();
           
            Console.WriteLine($"Clear Table...");
            await _instrumentsRepository.ClearTableAsync("instruments");

            await InsertAsync(_filePath);
            await BulkInsertAsync(_filePath);

            await Task.Delay(3000, stoppingToken);
        }

        private async Task InsertAsync(string filePath)
        {
            Console.WriteLine($"Starting InsertAsync...");

            string? line;
            using var fs = File.OpenRead(filePath);
            using var reader = new StreamReader(fs);
            int readLine = 1;
            Stopwatch stopwatch = Stopwatch.StartNew();
            while ((line = reader.ReadLine()) != null)
            {
                var instrument = new Instrument(line);
                await _instrumentsRepository.InsertAsync(instrument);
                readLine++;
            }
            stopwatch.Stop();
            Console.WriteLine($"{readLine} / {stopwatch.ElapsedMilliseconds / 1000.0}s");

            Console.WriteLine($"End InsertAsync");
            Console.WriteLine($"----------------------------------");
        }

        private async Task BulkInsertAsync(string filePath)
        {
            Console.WriteLine($"Starting BulkInsertAsync...");

            string? line;
            using var fs = File.OpenRead(filePath);
            using var reader = new StreamReader(fs);
            int readLine = 1;
            Stopwatch stopwatch = Stopwatch.StartNew();
            var list = new List<Instrument>();
            while ((line = reader.ReadLine()) != null)
            {
                var instrument = new Instrument(line);
                list.Add(instrument);
                if (readLine % 10000 == 0)
                {
                    await _instrumentsRepository.BulkInsertAsync(list);
                    list = new List<Instrument>();
                    Console.WriteLine($"{readLine}");
                }
                readLine++;
            }
            await _instrumentsRepository.BulkInsertAsync(list);
            stopwatch.Stop();
            Console.WriteLine($"{readLine} / {stopwatch.ElapsedMilliseconds / 1000.0}s");

            Console.WriteLine($"End BulkInsertAsync");
            Console.WriteLine($"----------------------------------");
        }
                
    }
}
