USE [Victoria]
GO

/****** Object:  Table [dbo].[CustomerItems]    Script Date: 18/04/2021 21:45:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerItems](
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[OrderNumber] [varchar](30) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CustomerItems]  WITH CHECK ADD FOREIGN KEY([OrderNumber])
REFERENCES [dbo].[CustomerOrder] ([OrderNumber])
GO

ALTER TABLE [dbo].[CustomerItems]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Items] ([ProductId])
GO


