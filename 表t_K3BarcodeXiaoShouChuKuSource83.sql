CREATE TABLE [dbo].[t_K3BarcodeXiaoShouChuKuSource83](
	[FID] [bigint] IDENTITY(1,1) NOT NULL,
	[FXiaoShouChuKuNo] [varchar](80) NULL,
	[FBarCodeSN] [varchar](80) NULL,
	[FStockNo] [varchar](80) NULL,
	[FStockPlaceNo] [varchar](80) NULL,
	[FBatchNo] [varchar](200) NULL,
	[FQty] [decimal](28, 10) NULL,
	[FScanner] [varchar](80) NULL,
	[FScanDateTime] [datetime] NULL,
CONSTRAINT [PK_t_K3BarcodeXiaoShouChuKuSource83] PRIMARY KEY CLUSTERED 
(
	[FID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO