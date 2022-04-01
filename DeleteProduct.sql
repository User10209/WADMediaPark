USE [dbMP]
GO
create proc [dbo].[Delete_ProductByMasterId]

@ProductId int
as

begin

delete from  tblProdcut   where ProductId=@ProductId
end


