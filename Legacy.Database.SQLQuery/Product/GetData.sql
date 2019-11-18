declare @sql varchar(max) = '';
set @sql = 'select
	ProductId,
	ProductName,
	Description,
	Price,
	ExpiredDate
from  [dbo].[POC_BFI_Product]
	where @SearchByText like @SearchByValue
ORDER BY @OrderBy
OFFSET (@Page-1)*@Size ROWS
FETCH NEXT @Size ROWS ONLY'

if	isnull(@SearchByText,'') = '' or isnull(@SearchByValue,'')=''
	begin 
		set @sql = REPLACE(@sql,'where @SearchByText like @SearchByValue','') 
	end
	
set @sql = REPLACE(@sql,'@SearchByText',@SearchByText)
set @sql = REPLACE(@sql,'@SearchByValue','''%'+@SearchByValue+'%''')
set @sql = REPLACE(@sql,'@Page',@Page)
set @sql = REPLACE(@sql,'@Size',@Size)
	
if	lower(@OrderBy) = 'productid asc' 
	set @sql = REPLACE(@sql,'@OrderBy','''productid'' asc')
else if	lower(@OrderBy) = 'productid desc' 
	set @sql = REPLACE(@sql,'@OrderBy','''productid'' desc')
else
	set @sql = REPLACE(@sql,'@OrderBy','''productid'' asc') --for default order 
exec(@sql)

 