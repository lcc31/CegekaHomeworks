CREATE TABLE [dbo].[BRANDS] (
    [BRAND_ID]   INT           IDENTITY (1, 1) NOT NULL,
    [BRAND_NAME] VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED ([BRAND_ID] ASC)
);

