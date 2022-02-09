
-- Select 

-- ANSII
select ContactName adi, CompanyName SirketAdı, City Sehri from Customers

Select * from Customers where City = 'London'

select * from Products where categoryId=1 or CategoryID =3

select * from Products where categoryId=1 and UnitPrice >=10

select * from Products order by ProductName, CategoryID, UnitPrice asc
-- desc  => azalan ascending artan
--descendinge en üstte en pahalı olan ki düşen oluyor
--asc de en düşük olur artan 


select * from Products where categoryId=1 order by ProductName 

select count(*) adet from Products where CategoryID=2


select categoryID, count(*) from products 
group by CategoryID having count(*)<10
-- içinde 10 taneden az olan kategorileri ver !

select Products.ProductID, Products.ProductName, Categories.CategoryName 
from Product inner join Categories
on Products.CategoryID = Categories.CategoryID

--DTO Date transformation object
select * from Products p left join
[Order Details] od on p.ProductID = od.ProductID

--left join solda olup sağda olmayanlar demek !!!
-- eğer sıfırsa bütün ürünleri satmışım demektir.


select * from Customers left join Orders o on
c.customerId = o.CustomerId
where o.customerId is null

--alışveriş yapmayanları getiren bir sorgudur
































