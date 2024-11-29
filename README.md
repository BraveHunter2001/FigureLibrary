Ответ на вторую задачу.  
```
SELECT  
	Products.Name as ProductName, 
	Categories.Name  as CategoriesName
from Products 
left join ProductsCategories 
	on  Products.Id = ProductsCategories.ProductsId 
left join Categories
	on Categories.Id = ProductsCategories.CategoriesId 
```
