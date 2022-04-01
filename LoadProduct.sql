USE [dbMP]
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadAllData_Batch]    Script Date: 3/28/2022 10:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[sp_LoadAllData_Product]
as
begin
select ROW_NUMBER() over (order by  ProductId) as SL, * from tblProdcut

end
