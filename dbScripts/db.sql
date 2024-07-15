-- Database: Instruments

-- DROP DATABASE IF EXISTS "Instruments";

CREATE DATABASE "Instruments"
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Portuguese_Brazil.1252'
    LC_CTYPE = 'Portuguese_Brazil.1252'
    LOCALE_PROVIDER = 'libc'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;

-- Table: public.instruments

-- DROP TABLE IF EXISTS public.instruments;

CREATE TABLE IF NOT EXISTS public.instruments
(
    "RptDt" timestamp without time zone NOT NULL,
    "TckrSymb" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "Asst" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "AsstDesc" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "SgmtNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "MktNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "SctyCtgyNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "XprtnDt" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "XprtnCd" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "TradgStartDt" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "TradgEndDt" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "BaseCd" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "ConvsCritNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "MtrtyDtTrgtPt" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "ReqrdConvsInd" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "ISIN" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "CFICd" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "DlvryNtceStartDt" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "DlvryNtceEndDt" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "OptnTp" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "CtrctMltplr" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "AsstQtnQty" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "AllcnRndLot" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "TradgCcy" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "DlvryTpNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "WdrwlDays" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "WrkgDays" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "ClnrDays" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "RlvrBasePricNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "OpngFutrPosDay" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "SdTpCd1" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "UndrlygTckrSymb1" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "SdTpCd2" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "UndrlygTckrSymb2" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "PureGoldWght" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "ExrcPric" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "OptnStyle" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "ValTpNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "PrmUpfrntInd" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "OpngPosLmtDt" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "DstrbtnId" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "PricFctr" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "DaysToSttlm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "SrsTpNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "PrtcnFlg" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "AutomtcExrcInd" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "SpcfctnCd" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "CrpnNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "CorpActnStartDt" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "CtdyTrtmntTpNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "MktCptlstn" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "CorpGovnLvlNm" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT instruments_pkey PRIMARY KEY ("TckrSymb", "RptDt")
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.instruments
    OWNER to postgres;