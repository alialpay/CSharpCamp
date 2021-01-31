--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--büyük küçük harfe duyarlı değil
seLeCt * from Products where CategoryID = 1 or CategoryID = 3

seLeCt * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products where CategoryID=1 order by UnitPrice desc    --ascending artan asc  --descending azalan desc --aşandik-düşendik

select count(*) Adet from Products where CategoryID=2


-- select ProductID, count(*) from Products group by CategoryID -- bu neden çalışmaz????????
--        ---------                                  ----------
-- group by kullanıldığında select edilen "kategori" sadece group by "kategori" olabilir

select CategoryID, count(*) from Products group by CategoryID
--     ----------                                  ----------


select CategoryID, count(*) from Products group by CategoryID having count(*)<10


select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10
-- fiyatı 20den büyük olan sayısı 10dan küçük olan tabloları sıraladı.


--join
-- satece ürünlerden değil ürünlerle kategorileri bir araya getirmek istiyoruz
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID -- bu koşula göre bir araya getir
where Products.UnitPrice>10					   -- bu satır fiyatı büyük olanları kategori ismine göre getirecek

--c# içinde bunlar karşımıza "DTO" "Data Transformation Object" olarak çıkıyor

-- inner join sadece iki tabloda da eşleşen verileri bir araya getirir
-- inner join sadece eşleşen kayıtları getirir.

select * from Products p left join [Order Details] od		-- left solda olup sağda olmayanları da getir. yani ürünler tablosunda var ama hiç satışı yok
on p.ProductID = od.ProductID								-- bütün ürünlerin sipariş kaydı olduğu ortaya çıktı. 2155 kayı geldi yine
inner join Orders o
on o.OrderID = od.OrderID


Select * from Customers c left join Orders o				-- joini left yapınca 830dan 832ye çıktı
on c.CustomerID = o.CustomerID


-- sisteme kayıtlı ama ürün almamış kişileri getirmek istedik diyelim--- Sana Özel kampanyaları

Select * from Customers c left join Orders o				
on c.CustomerID = o.CustomerID
where o.CustomerID is null				  -- Üye oldun ama ürün almadın. Sana Özel kampanya bu şekilde bu sorgularla geliyor. bu sorgularla mail geliyor


-- bir de right join var. left join in tam tersi. yine aynı mantıkla. sağda olup solda olmayanları getiriyor

SELECT Products.ProductName AS [Ürün Adı], 
Sum(OrderDetails.UnitPrice * OrderDetails.Quantity) AS [Kazanılan Toplam Miktar]
from Products
join [Order Details] OrderDetails ON OrderDetails.ProductID = Products.ProductID
jOiN Orders ON OrderDetails.OrderID = Orders.OrderID
Group BY Products.ProductName
Order BY Products.ProductName
