create proc [dbo].[Update_ProductByMasterId]
@ProductId int,
@ProductName  nvarchar(500),
@ProductDescription nvarchar(500),
@ProductPrice nvarchar(500),
@ProductStock nvarchar(500),
@ProductCategory nvarchar(500),
@ProductWeight nvarchar(500)

As
begin
update [dbo].[tblProdcut] set ProductName=@ProductName, ProductDescription = @ProductDescription,
							  ProductPrice = @ProductPrice, ProductStock = @ProductStock,
							  ProductCategory = @ProductCategory, ProductWeight = @ProductWeight
							  where ProductId=@ProductId
end
