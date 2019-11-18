Update [dbo].[POC_BFI_Product] set
ProductName = @ProductName,
Description = @Description,
Price = @Price,
ExpiredDate = @ExpiredDate
where ProductId = @ProductId

