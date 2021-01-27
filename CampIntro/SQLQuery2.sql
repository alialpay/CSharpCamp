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
