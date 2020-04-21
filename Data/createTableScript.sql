/*WARNING!!! RUNNING THIS SCRIPT WILL DELETE ALL YOUR EXISTING DATA!*/
DROP TABLE [dbo].[CheckOutList];
DROP TABLE [dbo].[CheckOut];
DROP TABLE [dbo].[Return];
DROP TABLE [dbo].[RoomBooking];
DROP TABLE [dbo].[Copies];
DROP TABLE [dbo].[Book];
DROP TABLE [dbo].[Room];
DROP TABLE [dbo].[Patron];
DROP TABLE [dbo].[AdminLib];

/*Creating Tables*/
CREATE TABLE [dbo].[AdminLib] (
    [Admin_ID] INT          IDENTITY (1000, 1) NOT NULL,
    [Name]     VARCHAR (50) NULL,
    [Password] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Admin_ID] ASC)
);

CREATE TABLE [dbo].[Patron] (
    [Patron_ID] INT           IDENTITY (1000, 1) NOT NULL,
    [Name]      VARCHAR (50)  NULL,
    [Course]    VARCHAR (MAX) NULL,
    [PhoneNo]   VARCHAR (50)  NULL,
    [Address]   VARCHAR (MAX) NULL,
    [Email]     VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Patron_ID] ASC)
);

CREATE TABLE [dbo].[Book] (
    [Book_Id]      INT           IDENTITY (1000, 1) NOT NULL,
    [Book_title]   VARCHAR (MAX) NULL,
    [Author]       VARCHAR (MAX) NULL,
    [Category]     VARCHAR (MAX) NULL,
    [Publication]  VARCHAR (MAX) NULL,
    [Year_Publish] INT           NULL,
    [Copies]       INT           NULL,
    [Call_no]      VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Book_Id] ASC)
);

/*Barcode is Copy_ID*/
CREATE TABLE [dbo].[Copies] (
    [Copy_ID] INT          IDENTITY (1000, 1) NOT NULL,
    [Book_ID] INT          NOT NULL,
    [Status]  VARCHAR (50) NULL,
    [CheckOut_ID] INT NULL, 
    PRIMARY KEY CLUSTERED ([Copy_ID] ASC),
    CONSTRAINT [FK_Copies_Book] FOREIGN KEY ([Book_ID]) REFERENCES [dbo].[Book] ([Book_Id]),
	CONSTRAINT [FK_Copies_CheckOut] FOREIGN KEY ([CheckOut_ID]) REFERENCES [dbo].[CheckOut] ([Chk_ID])
);

CREATE TABLE [dbo].[Room] (
    [Room_Id] INT IDENTITY (1000, 1) NOT NULL,
    [Size]    INT NULL,
    PRIMARY KEY CLUSTERED ([Room_Id] ASC)
);

CREATE TABLE [dbo].[RoomBooking] (
    [Patron_ID]     INT      NOT NULL,
    [Room_ID]       INT      NOT NULL,
    [Date_Time]     DATE NOT NULL,
    [CheckIn_Date]  VARCHAR(50) NULL,
    [CheckOut_Date] VARCHAR(50) NULL,
    CONSTRAINT [RoomBooking_ID] PRIMARY KEY CLUSTERED ([Patron_ID] ASC, [Room_ID] ASC, [Date_Time] ASC),
    CONSTRAINT [FK_RoomBooking_Patron] FOREIGN KEY ([Patron_ID]) REFERENCES [dbo].[Patron] ([Patron_ID]),
    CONSTRAINT [FK_RoomBooking_Room] FOREIGN KEY ([Room_ID]) REFERENCES [dbo].[Room] ([Room_Id])
);

CREATE TABLE [dbo].[Return] (
    [Rtn_ID]      INT        IDENTITY (1000, 1) NOT NULL,
    [Rtn_Date]    DATE       NULL,
    [Fine_Amount] SMALLMONEY NULL,
    CONSTRAINT [PK_Return] PRIMARY KEY CLUSTERED ([Rtn_ID] ASC),
);

CREATE TABLE [dbo].[CheckOut] (
    [Chk_ID]     INT  IDENTITY (1000, 1) NOT NULL,
    [Patron_ID]  INT  NOT NULL,
    [Issue_Date] DATE NOT NULL,
    [Due_Date]   DATE NOT NULL,
	[Rtn_ID]  INT	  NULL,
	CONSTRAINT [FK_CheckOut_Return] FOREIGN KEY ([Rtn_ID]) REFERENCES [dbo].[Return] ([Rtn_ID]),
    CONSTRAINT [FK_CheckOut_Patron] FOREIGN KEY ([Patron_ID]) REFERENCES [dbo].[Patron] ([Patron_ID]),
    CONSTRAINT [PK_CheckOut] PRIMARY KEY CLUSTERED ([Chk_ID] ASC)
);

CREATE TABLE [dbo].[CheckOutList] (
    [Chk_ID]  INT NOT NULL,
    [Copy_ID] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Chk_ID] ASC, [Copy_ID] ASC),
    CONSTRAINT [FK_Chk_ID] FOREIGN KEY ([Chk_ID]) REFERENCES [dbo].[CheckOut] ([Chk_ID]),
    CONSTRAINT [FK_Copy_ID] FOREIGN KEY ([Copy_ID]) REFERENCES [dbo].[Copies] ([Copy_ID])
);



