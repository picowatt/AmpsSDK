﻿namespace Mips.Commands
{
	public enum MipsCommand
	{
		GVER,
		GERR,
		GNAME,
		SNAME,
		ABOUT,
		SMREV,
		RESEST,
		SAVE,
		GCHAN,
		MUTE,
		ECHO,
		TRIGOUT,
		DELAY,
		GCMDS,
		GAENA,
		SAENA,
		THREADS,
		STHRDENA,
		SDEVADD,
		RDEV,
		RDEV2,
		TBLTSKENA,
		ADC,
		LEDOVRD,
		LED,
		DSPOFF,

		GWIDTH,
		SWIDTH,
		GFREQ,
		SFREQ,
		BURST,

		SDTRIGINP,
		SDTRIGDLY,
		GDTRIGDLY,
		SDTRIGPRD,
		GDTRIGPRD,
		SDTRIGRPT,
		GDTRIGRPT,
		SDTRIGMOD,
		SDTRIGENA,
		GDTRIGENA,

		SDCB,
		GDCB,
		GDCBV,
		SDCBOF,
		GDCBOF,
		GDCMIN,
		GDCMAX,
		SDCPWR,
		GDCPWR,
		SDCBALL,
		GDCBALL,
		GDCBALLV,
		SDCBDELTA,
		SDCBCHNS,
		SDCBONEOFF,
		DCBOFFRBENA,
		SDCBOFFENA,

		SDCBPRO,
		GDCBPRO,
		ADCBPRO,
		CDCBPRO,
		TDCBPRO,
		TDCBSTOP,

		SRFFRQ,
		SRFVLT,
		SRFDRV,
		GRFFRQ,
		GRFPPVP,
		GRFPPVN,
		GRFDRV,
		GRFVLT,
		GRFPWR,
		GRFALL,

		SDIO,
		GDIO,
		RPT,
		MIRROR,
		SHV,
		GHV,
		GHVV,
		GHVI,
		GHVMAX,

		STBLDAT,
		STBLCLK,
		STBLTRG,
		TBLABRT,
		SMOD,
		TBLSTRT,
		TBLSTOP,
		GTBLFRQ,
		STBLNUM,
		GTBLNUM,
		STBLADV,
		GTBLADV,
		STBLVLT,
		GTVLVLT,
		STBLCNT,
		STBLDLY,
		SOFTLDAC,
		STBLREPLY,
		GTBLREPLY,

		MRECORD,
		MSTOP,
		MPLAY,
		MLIST,
		MDELETE,

		GTWF,
		STWF,
		GTWPV,
		STWPV,
		GTWG1V,
		STWG1V,
		GTWG2V,
		STWG2V,
		GTWSEQ,
		STWSEQ,
		GTWDIR,
		STWDIR,
		STWCTBL,
		GTWCTBL,
		GTWCMODE,
		STWCMODE,
		GTWCORDER,
		STWCORDER,
		GTWCTD,
		STWCTD,
		GTWCTC,
		STWCTC,
		GTWCTN,
		STWCTN,
		GTWCTNC,
		STWCTNC,
		TWCTRG,
		GTWCSW,
		STWCSW,
		STWCCLK,
		STWCMP,

		STWSSTRT,
		GTWSSTRT,
		STWSSTP,
		GTWSSTP,
		STWSTM,
		GTWSTM,
		STWSGO,
		STWSHLT,
		GTWSTA,

		SRFHPCAL,
		SRFHNCAL,

		GFLENA,
		SFLENA,
		GFLI,
		GFLAI,
		SFLI,
		GFLSV,
		GFLASV,
		SFLSV,
		GFLV,
		GFLPWR,
		GFLRT,
		SFLRT,
		GFLP1,
		SFLP1,
		GFLP2,
		SFLP2,
		GFLCY,
		SFLCY,
		GFLENAR,
		SFLENAR,
		RFLPARMS,
		SFLSRES,
		GFLSRES,
		GFLECUR,

		GHOST,
		GSSID,
		GPSWD,
		SHOST,
		SSSID,
		SPSWD,
		SWIFIENA,

		GEIP,
		SEIP,
		GEPORT,
		SEPORT,
		GEGATE,
		SEGATE,

		SARBMODE,
		GARBMODE,
		SWFREQ,
		GWFREQ,
		SWFVRNG,
		GWFVRNG,
		SWFVOFF,
		GWFVOFF,
		SWFVAUX,
		GWFVAUX,
		SWFDIS,
		SWFENA,
		SWFDIR,
		GWFDIR,
		SWFARB,
		GWFARB,
		SWFTYP,
		GWFTYP,
		SARBBUF,
		GARBBUF,
		SARBNUM,
		GARBNUM,
		SARBCHS,
		SARBCH,
		SACHRNG,

		SARBCTBL,
		GARBCTBL,
		GARBCMODE,
		SARBCMODE,
		GARBCORDER,
		SARBCORDER,
		GARBCTD,
		SARBCTD,
		GARBCTC,
		SARBCTC,
		GARBCTN,
		SARBCTN,
		GARBCTNC,
		SARBCTNC,
		TARBTRG,
		GARBCSW,
		SARBCSW,

		SARBCCLK,
		SARBCMP

	}
}