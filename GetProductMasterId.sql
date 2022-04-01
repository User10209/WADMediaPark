create proc [dbo].[Get_ProductMasterDataById]
@MasterId int
as
begin
select * from tblProdcut where ProductId=@MasterId
end