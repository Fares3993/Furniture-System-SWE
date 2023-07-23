create or replace procedure getproduct (Produt_ID in NUMBER,ptitle out VARCHAR2)
as
BEGIN
select p.producttitle
into ptitle
FROM products p
WHERE p.productid = Produt_ID;
end;

create or replace PROCEDURE GetProductID
(CID out sys_refcursor)
as
BEGIN
OPEN CID for
SELECT Productid 
FROM products;
end ;