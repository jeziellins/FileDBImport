using Dapper;
using FileDBImport.Worker.Data.Repositories.Interfaces;
using Npgsql;

namespace FileDBImport.Worker.Data.Repositories
{
    public class InstrumentsRepository : IInstrumentsRepository
    {
        private readonly ILogger<InstrumentsRepository> _logger;
        private readonly DapperContext _context;

        public InstrumentsRepository(ILogger<InstrumentsRepository> logger, DapperContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<bool> BulkInsertAsync(List<Instrument> instruments)
        {
            using var connection = new NpgsqlConnection(_context.GetConnectionString());
            await connection.OpenAsync();

            using var cmdCreateTempTable = new NpgsqlCommand("CREATE TEMP TABLE instruments_temp AS SELECT * FROM instruments WHERE false;", connection);
            cmdCreateTempTable.ExecuteNonQuery();

            var sqlCopy = @"COPY instruments_temp (""RptDt"", ""TckrSymb"", ""Asst"", ""AsstDesc"", ""SgmtNm"", ""MktNm"", ""SctyCtgyNm"", ""XprtnDt"", ""XprtnCd"", ""TradgStartDt"", ""TradgEndDt"", ""BaseCd"", ""ConvsCritNm"", ""MtrtyDtTrgtPt"", ""ReqrdConvsInd"", ""ISIN"", ""CFICd"", ""DlvryNtceStartDt"", ""DlvryNtceEndDt"", ""OptnTp"", ""CtrctMltplr"", ""AsstQtnQty"", ""AllcnRndLot"", ""TradgCcy"", ""DlvryTpNm"", ""WdrwlDays"", ""WrkgDays"", ""ClnrDays"", ""RlvrBasePricNm"", ""OpngFutrPosDay"", ""SdTpCd1"", ""UndrlygTckrSymb1"", ""SdTpCd2"", ""UndrlygTckrSymb2"", ""PureGoldWght"", ""ExrcPric"", ""OptnStyle"", ""ValTpNm"", ""PrmUpfrntInd"", ""OpngPosLmtDt"", ""DstrbtnId"", ""PricFctr"", ""DaysToSttlm"", ""SrsTpNm"", ""PrtcnFlg"", ""AutomtcExrcInd"", ""SpcfctnCd"", ""CrpnNm"", ""CorpActnStartDt"", ""CtdyTrtmntTpNm"", ""MktCptlstn"", ""CorpGovnLvlNm"") FROM STDIN (FORMAT BINARY)";
            using var writer = await connection.BeginBinaryImportAsync(sqlCopy);
            foreach (var instrument in instruments)
            {
                await writer.StartRowAsync();
                await writer.WriteAsync(instrument.RptDt, NpgsqlTypes.NpgsqlDbType.Timestamp);
                await writer.WriteAsync(instrument.TckrSymb, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.Asst, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.AsstDesc, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.SgmtNm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.MktNm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.SctyCtgyNm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.XprtnDt, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.XprtnCd, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.TradgStartDt, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.TradgEndDt, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.BaseCd, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.ConvsCritNm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.MtrtyDtTrgtPt, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.ReqrdConvsInd, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.ISIN, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.CFICd, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.DlvryNtceStartDt, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.DlvryNtceEndDt, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.OptnTp, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.CtrctMltplr, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.AsstQtnQty, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.AllcnRndLot, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.TradgCcy, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.DlvryTpNm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.WdrwlDays, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.WrkgDays, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.ClnrDays, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.RlvrBasePricNm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.OpngFutrPosDay, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.SdTpCd1, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.UndrlygTckrSymb1, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.SdTpCd2, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.UndrlygTckrSymb2, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.PureGoldWght, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.ExrcPric, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.OptnStyle, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.ValTpNm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.PrmUpfrntInd, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.OpngPosLmtDt, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.DstrbtnId, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.PricFctr, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.DaysToSttlm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.SrsTpNm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.PrtcnFlg, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.AutomtcExrcInd, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.SpcfctnCd, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.CrpnNm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.CorpActnStartDt, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.CtdyTrtmntTpNm, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.MktCptlstn, NpgsqlTypes.NpgsqlDbType.Text);
                await writer.WriteAsync(instrument.CorpGovnLvlNm, NpgsqlTypes.NpgsqlDbType.Text);
            }
            await writer.CompleteAsync();
            await writer.CloseAsync();

            var sqlInsert = @"
                INSERT INTO instruments (""RptDt"", ""TckrSymb"", ""Asst"", ""AsstDesc"", ""SgmtNm"", ""MktNm"", ""SctyCtgyNm"", ""XprtnDt"", ""XprtnCd"", ""TradgStartDt"", ""TradgEndDt"", ""BaseCd"", ""ConvsCritNm"", ""MtrtyDtTrgtPt"", ""ReqrdConvsInd"", ""ISIN"", ""CFICd"", ""DlvryNtceStartDt"", ""DlvryNtceEndDt"", ""OptnTp"", ""CtrctMltplr"", ""AsstQtnQty"", ""AllcnRndLot"", ""TradgCcy"", ""DlvryTpNm"", ""WdrwlDays"", ""WrkgDays"", ""ClnrDays"", ""RlvrBasePricNm"", ""OpngFutrPosDay"", ""SdTpCd1"", ""UndrlygTckrSymb1"", ""SdTpCd2"", ""UndrlygTckrSymb2"", ""PureGoldWght"", ""ExrcPric"", ""OptnStyle"", ""ValTpNm"", ""PrmUpfrntInd"", ""OpngPosLmtDt"", ""DstrbtnId"", ""PricFctr"", ""DaysToSttlm"", ""SrsTpNm"", ""PrtcnFlg"", ""AutomtcExrcInd"", ""SpcfctnCd"", ""CrpnNm"", ""CorpActnStartDt"", ""CtdyTrtmntTpNm"", ""MktCptlstn"", ""CorpGovnLvlNm"")
                SELECT ""RptDt"", ""TckrSymb"", ""Asst"", ""AsstDesc"", ""SgmtNm"", ""MktNm"", ""SctyCtgyNm"", ""XprtnDt"", ""XprtnCd"", ""TradgStartDt"", ""TradgEndDt"", ""BaseCd"", ""ConvsCritNm"", ""MtrtyDtTrgtPt"", ""ReqrdConvsInd"", ""ISIN"", ""CFICd"", ""DlvryNtceStartDt"", ""DlvryNtceEndDt"", ""OptnTp"", ""CtrctMltplr"", ""AsstQtnQty"", ""AllcnRndLot"", ""TradgCcy"", ""DlvryTpNm"", ""WdrwlDays"", ""WrkgDays"", ""ClnrDays"", ""RlvrBasePricNm"", ""OpngFutrPosDay"", ""SdTpCd1"", ""UndrlygTckrSymb1"", ""SdTpCd2"", ""UndrlygTckrSymb2"", ""PureGoldWght"", ""ExrcPric"", ""OptnStyle"", ""ValTpNm"", ""PrmUpfrntInd"", ""OpngPosLmtDt"", ""DstrbtnId"", ""PricFctr"", ""DaysToSttlm"", ""SrsTpNm"", ""PrtcnFlg"", ""AutomtcExrcInd"", ""SpcfctnCd"", ""CrpnNm"", ""CorpActnStartDt"", ""CtdyTrtmntTpNm"", ""MktCptlstn"", ""CorpGovnLvlNm""
                FROM instruments_temp
                ON CONFLICT (""RptDt"", ""TckrSymb"") DO UPDATE
                SET ""Asst"" = EXCLUDED.""Asst"", ""AsstDesc"" = EXCLUDED.""AsstDesc"", ""SgmtNm"" = EXCLUDED.""SgmtNm"", ""MktNm"" = EXCLUDED.""MktNm"", ""SctyCtgyNm"" = EXCLUDED.""SctyCtgyNm"", 
                     ""XprtnDt"" = EXCLUDED.""XprtnDt"", ""XprtnCd"" = EXCLUDED.""XprtnCd"", ""TradgStartDt"" = EXCLUDED.""TradgStartDt"", ""TradgEndDt"" = EXCLUDED.""TradgEndDt"", ""BaseCd"" = EXCLUDED.""BaseCd"", 
                     ""ConvsCritNm"" = EXCLUDED.""ConvsCritNm"", ""MtrtyDtTrgtPt"" = EXCLUDED.""MtrtyDtTrgtPt"", ""ReqrdConvsInd"" = EXCLUDED.""ReqrdConvsInd"", ""ISIN"" = EXCLUDED.""ISIN"", ""CFICd"" = EXCLUDED.""CFICd"", 
                     ""DlvryNtceStartDt"" = EXCLUDED.""DlvryNtceStartDt"", ""DlvryNtceEndDt"" = EXCLUDED.""DlvryNtceEndDt"", ""OptnTp"" = EXCLUDED.""OptnTp"", ""CtrctMltplr"" = EXCLUDED.""CtrctMltplr"", ""AsstQtnQty"" = EXCLUDED.""AsstQtnQty"", 
                     ""AllcnRndLot"" = EXCLUDED.""AllcnRndLot"", ""TradgCcy"" = EXCLUDED.""TradgCcy"", ""DlvryTpNm"" = EXCLUDED.""DlvryTpNm"", ""WdrwlDays"" = EXCLUDED.""WdrwlDays"", ""WrkgDays"" = EXCLUDED.""WrkgDays"", 
                     ""ClnrDays"" = EXCLUDED.""ClnrDays"", ""RlvrBasePricNm"" = EXCLUDED.""RlvrBasePricNm"", ""OpngFutrPosDay"" = EXCLUDED.""OpngFutrPosDay"", ""SdTpCd1"" = EXCLUDED.""SdTpCd1"", 
                     ""UndrlygTckrSymb1"" = EXCLUDED.""UndrlygTckrSymb1"", ""SdTpCd2"" = EXCLUDED.""SdTpCd2"", ""UndrlygTckrSymb2"" = EXCLUDED.""UndrlygTckrSymb2"", ""PureGoldWght"" = EXCLUDED.""PureGoldWght"", 
                     ""ExrcPric"" = EXCLUDED.""ExrcPric"", ""OptnStyle"" = EXCLUDED.""OptnStyle"", ""ValTpNm"" = EXCLUDED.""ValTpNm"", ""PrmUpfrntInd"" = EXCLUDED.""PrmUpfrntInd"", ""OpngPosLmtDt"" = EXCLUDED.""OpngPosLmtDt"", 
                     ""DstrbtnId"" = EXCLUDED.""DstrbtnId"", ""PricFctr"" = EXCLUDED.""PricFctr"", ""DaysToSttlm"" = EXCLUDED.""DaysToSttlm"", ""SrsTpNm"" = EXCLUDED.""SrsTpNm"", ""PrtcnFlg"" = EXCLUDED.""PrtcnFlg"", 
                     ""AutomtcExrcInd"" = EXCLUDED.""AutomtcExrcInd"", ""SpcfctnCd"" = EXCLUDED.""SpcfctnCd"", ""CrpnNm"" = EXCLUDED.""CrpnNm"", ""CorpActnStartDt"" = EXCLUDED.""CorpActnStartDt"", ""CtdyTrtmntTpNm"" = EXCLUDED.""CtdyTrtmntTpNm"", 
                     ""MktCptlstn"" = EXCLUDED.""MktCptlstn"", ""CorpGovnLvlNm"" = EXCLUDED.""CorpGovnLvlNm"";";
            using var cmdInsert = new NpgsqlCommand(sqlInsert, connection);
            await cmdInsert.ExecuteNonQueryAsync();
            connection.Close();
            return true;
        }

        public async Task ClearTableAsync(string tableName)
        {
            using var connection = new NpgsqlConnection(_context.GetConnectionString());
            await connection.OpenAsync();
            using var cmd = new NpgsqlCommand($@"TRUNCATE TABLE {tableName}", connection);
            await cmd.ExecuteNonQueryAsync();
            connection.Close();
        }

        public async Task<bool> InsertAsync(Instrument instrument)
        {
            try
            {
                var query = @"INSERT INTO public.instruments(
	                                ""RptDt"", ""TckrSymb"", ""Asst"", ""AsstDesc"", ""SgmtNm"", ""MktNm"", ""SctyCtgyNm"", 
                                    ""XprtnDt"", ""XprtnCd"", ""TradgStartDt"", ""TradgEndDt"", ""BaseCd"", ""ConvsCritNm"", 
                                    ""MtrtyDtTrgtPt"", ""ReqrdConvsInd"", ""ISIN"", ""CFICd"", ""DlvryNtceStartDt"", 
                                    ""DlvryNtceEndDt"", ""OptnTp"", ""CtrctMltplr"", ""AsstQtnQty"", ""AllcnRndLot"", 
                                    ""TradgCcy"", ""DlvryTpNm"", ""WdrwlDays"", ""WrkgDays"", ""ClnrDays"", ""RlvrBasePricNm"", 
                                    ""OpngFutrPosDay"", ""SdTpCd1"", ""UndrlygTckrSymb1"", ""SdTpCd2"", ""UndrlygTckrSymb2"", 
                                    ""PureGoldWght"", ""ExrcPric"", ""OptnStyle"", ""ValTpNm"", ""PrmUpfrntInd"", 
                                    ""OpngPosLmtDt"", ""DstrbtnId"", ""PricFctr"", ""DaysToSttlm"", ""SrsTpNm"", ""PrtcnFlg"", 
                                    ""AutomtcExrcInd"", ""SpcfctnCd"", ""CrpnNm"", ""CorpActnStartDt"", ""CtdyTrtmntTpNm"", 
                                    ""MktCptlstn"", ""CorpGovnLvlNm"")
	                          VALUES (@RptDt, @TckrSymb, @Asst, @AsstDesc, @SgmtNm, @MktNm, @SctyCtgyNm, @XprtnDt, @XprtnCd, 
                                      @TradgStartDt, @TradgEndDt, @BaseCd, @ConvsCritNm, @MtrtyDtTrgtPt, @ReqrdConvsInd, 
                                      @ISIN, @CFICd, @DlvryNtceStartDt, @DlvryNtceEndDt, @OptnTp, @CtrctMltplr, @AsstQtnQty, 
                                      @AllcnRndLot, @TradgCcy, @DlvryTpNm, @WdrwlDays, @WrkgDays, @ClnrDays, @RlvrBasePricNm, 
                                      @OpngFutrPosDay, @SdTpCd1, @UndrlygTckrSymb1, @SdTpCd2, @UndrlygTckrSymb2, @PureGoldWght, 
                                      @ExrcPric, @OptnStyle, @ValTpNm, @PrmUpfrntInd, @OpngPosLmtDt, @DstrbtnId, @PricFctr, 
                                      @DaysToSttlm, @SrsTpNm, @PrtcnFlg, @AutomtcExrcInd, @SpcfctnCd, @CrpnNm, @CorpActnStartDt, 
                                      @CtdyTrtmntTpNm, @MktCptlstn, @CorpGovnLvlNm);";

                using var connection = _context.CreateConnection();
                await connection.ExecuteAsync(query, instrument);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("[InstrumentsRepository/InsertAsync] - {message}", ex.Message);
                return false;
            }
        }
    }
}
