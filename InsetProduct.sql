USE [dbMP]
GO
/****** Object:  StoredProcedure [dbo].[sp_Insert_Course]    Script Date: 3/28/2022 7:31:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_Insert_Product]
	-- Add the parameters for the stored procedure here
	 @ProductName nvarchar(500)=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	INSERT INTO [dbo].[tblProdcut]
           (ProductName)
     VALUES
            (@ProductName)
END

