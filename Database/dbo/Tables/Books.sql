﻿CREATE TABLE [dbo].[Books]
(
  [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  [Title] NVARCHAR(100) NOT NULL,
  [Author] NVARCHAR(100) NOT NULL,
  [Pages] INT NOT NULL
)