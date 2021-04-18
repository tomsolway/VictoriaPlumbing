USE [Victoria]
GO

/****** Object:  Table [dbo].[CustomerOrder]    Script Date: 18/04/2021 21:45:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerOrder](
	[CreatedDate] [datetime] NOT NULL,
	[OrderNumber] [varchar](30) NOT NULL,
	[BasketCode] [varchar](30) NOT NULL,
	[CustomerEmail] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CustomerOrder]  WITH CHECK ADD FOREIGN KEY([CustomerEmail])
REFERENCES [dbo].[Customer] ([CustomerEmail])
GO


