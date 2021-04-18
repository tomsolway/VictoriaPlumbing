USE [Victoria]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 18/04/2021 21:45:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[Name] [varchar](255) NOT NULL,
	[CustomerEmail] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


