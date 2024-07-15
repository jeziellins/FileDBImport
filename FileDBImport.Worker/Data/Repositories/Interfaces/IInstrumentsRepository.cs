namespace FileDBImport.Worker.Data.Repositories.Interfaces
{
    public interface IInstrumentsRepository
    {
        Task<bool> InsertAsync(Instrument instrument);
        Task<bool> BulkInsertAsync(List<Instrument> instruments);
        Task ClearTableAsync(string tableName);
    }
}
