namespace FileDBImport.Worker
{
    public class Instrument
    {
        public Instrument(string line)
        {
            var parts = line.Split(';');
            RptDt = DateTime.Parse(parts[0]);
            TckrSymb = parts[1];
            Asst = parts[2];
            AsstDesc = parts[3];
            SgmtNm = parts[4];
            MktNm = parts[5];
            SctyCtgyNm = parts[6];
            XprtnDt = parts[7];
            XprtnCd = parts[8];
            TradgStartDt = parts[9];
            TradgEndDt = parts[10];
            BaseCd = parts[11];
            ConvsCritNm = parts[12];
            MtrtyDtTrgtPt = parts[13];
            ReqrdConvsInd = parts[14];
            ISIN = parts[15];
            CFICd = parts[16];
            DlvryNtceStartDt = parts[17];
            DlvryNtceEndDt = parts[18];
            OptnTp = parts[19];
            CtrctMltplr = parts[20];
            AsstQtnQty = parts[21];
            AllcnRndLot = parts[22];
            TradgCcy = parts[23];
            DlvryTpNm = parts[24];
            WdrwlDays = parts[25];
            WrkgDays = parts[26];
            ClnrDays = parts[27];
            RlvrBasePricNm = parts[28];
            OpngFutrPosDay = parts[29];
            SdTpCd1 = parts[30];
            UndrlygTckrSymb1 = parts[31];
            SdTpCd2 = parts[32];
            UndrlygTckrSymb2 = parts[33];
            PureGoldWght = parts[34];
            ExrcPric = parts[35];
            OptnStyle = parts[36];
            ValTpNm = parts[37];
            PrmUpfrntInd = parts[38];
            OpngPosLmtDt = parts[39];
            DstrbtnId = parts[40];
            PricFctr = parts[41];
            DaysToSttlm = parts[42];
            SrsTpNm = parts[43];
            PrtcnFlg = parts[44];
            AutomtcExrcInd = parts[45];
            SpcfctnCd = parts[46];
            CrpnNm = parts[47];
            CorpActnStartDt = parts[48];
            CtdyTrtmntTpNm = parts[49];
            MktCptlstn = parts[50];
            CorpGovnLvlNm = parts[51];
        }

        public DateTime RptDt { get; private set; }
        public string? TckrSymb { get; private set; }
        public string? Asst { get; private set; }
        public string? AsstDesc { get; private set; }
        public string? SgmtNm { get; private set; }
        public string? MktNm { get; private set; }
        public string? SctyCtgyNm { get; private set; }
        public string? XprtnDt { get; private set; }
        public string? XprtnCd { get; private set; }
        public string? TradgStartDt { get; private set; }
        public string? TradgEndDt { get; private set; }
        public string? BaseCd { get; private set; }
        public string? ConvsCritNm { get; private set; }
        public string? MtrtyDtTrgtPt { get; private set; }
        public string? ReqrdConvsInd { get; private set; }
        public string? ISIN { get; private set; }
        public string? CFICd { get; private set; }
        public string? DlvryNtceStartDt { get; private set; }
        public string? DlvryNtceEndDt { get; private set; }
        public string? OptnTp { get; private set; }
        public string? CtrctMltplr { get; private set; }
        public string? AsstQtnQty { get; private set; }
        public string? AllcnRndLot { get; private set; }
        public string? TradgCcy { get; private set; }
        public string? DlvryTpNm { get; private set; }
        public string? WdrwlDays { get; private set; }
        public string? WrkgDays { get; private set; }
        public string? ClnrDays { get; private set; }
        public string? RlvrBasePricNm { get; private set; }
        public string? OpngFutrPosDay { get; private set; }
        public string? SdTpCd1 { get; private set; }
        public string? UndrlygTckrSymb1 { get; private set; }
        public string? SdTpCd2 { get; private set; }
        public string? UndrlygTckrSymb2 { get; private set; }
        public string? PureGoldWght { get; private set; }
        public string? ExrcPric { get; private set; }
        public string? OptnStyle { get; private set; }
        public string? ValTpNm { get; private set; }
        public string? PrmUpfrntInd { get; private set; }
        public string? OpngPosLmtDt { get; private set; }
        public string? DstrbtnId { get; private set; }
        public string? PricFctr { get; private set; }
        public string? DaysToSttlm { get; private set; }
        public string? SrsTpNm { get; private set; }
        public string? PrtcnFlg { get; private set; }
        public string? AutomtcExrcInd { get; private set; }
        public string? SpcfctnCd { get; private set; }
        public string? CrpnNm { get; private set; }
        public string? CorpActnStartDt { get; private set; }
        public string? CtdyTrtmntTpNm { get; private set; }
        public string? MktCptlstn { get; private set; }
        public string? CorpGovnLvlNm { get; private set; }
    }
}
