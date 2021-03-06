USE [dbMP]
GO
/****** Object:  StoredProcedure [dbo].[sp_Insert_Product]    Script Date: 3/29/2022 11:23:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_Insert_Product]
	-- Add the parameters for the stored procedure here
	 @ProductName nvarchar(500)=null,
	 @ProductDescription nvarchar(500)=null,
	 @ProductPrice nvarchar(500)=null,
	 @ProductStock nvarchar(500)=null,  
	 @ProductCategory nvarchar(500)=null, 
	 @ProductWeight nvarchar(500)=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	INSERT INTO [dbo].[tblProdcut]
           (ProductName, ProductDescription, ProductPrice, ProductStock, ProductCategory, ProductWeight)
     VALUES
            (@ProductName,@ProductDescription, @ProductPrice, @ProductStock, @ProductCategory, @ProductWeight)
END