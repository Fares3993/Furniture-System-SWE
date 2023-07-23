Create Sequence USERID;

drop table USERS cascade constraints;
drop table PRODUCTS cascade constraints;
drop table FAVORITE cascade constraints;
drop table PAYMENT cascade constraints;
drop table CARTEDATA cascade constraints;
drop table ORDERDATA cascade constraints;
drop table transData cascade constraints;
drop table USER_CARTE cascade constraints;
drop table ORDERCART cascade constraints;
drop table USER_ORDER cascade constraints;


Create table USERS
(USERID number(10) primary key, USERNAME varchar2 (20),USEREMAIL varchar2 (20),USERPASSWORD varchar2 (20),PHONENUMBER varchar2 (20),ADDRESS varchar2 (20));
Create Table PRODUCTS
(PRODUCTID number(10) primary key, PRODUCTTitle varchar2(50), PRODDSCRIP  varchar2(50), PRICE 
number (20), IMAGEURL varchar2(10));
Create Table FAVORITE
(USERID number(10) References USERS (USERID) , PRODUCTID number(10) References PRODUCTS 
(PRODUCTID), CONSTRAINT US_PROD_PK PRIMARY KEY(USERID, PRODUCTID));
Create  Table  PAYMENT
(PAYMENTID number(10) primary key, INVOICENUMBER NUMBER(10), PAYMENTNAME  varchar2 (20));
Create table CARTEDATA
(CARTEID number(10)primary key,PRODUCTID number(10) References PRODUCTS (PRODUCTID), QUANTITY  NUMBER(10));
Create  Table ORDERDATA
(ORDERID number(10) primary key, AMOUNT NUMBER(10), DATETIME  DATE);
Create table transData
(transID number(10)primary key,ORDERID number(10) References ORDERDATA (ORDERID), PAYMENTID number(10) References PAYMENT (PAYMENTID));
Create  Table USER_CARTE
(USERID number(10) References USERS (USERID) , CARTEID number(10) References CARTEDATA 
(CARTEID), CONSTRAINT US_CART_PK PRIMARY KEY(USERID, CARTEID));
Create  Table ORDERCART
(ORDERID number(10) References ORDERDATA (ORDERID) , CARTEID number(10) References CARTEDATA 
(CARTEID), CONSTRAINT CR_ORD_PK PRIMARY KEY(ORDERID, CARTEID));
Create  Table USER_ORDER
(USERID number(10) References USERS (USERID) , ORDERID number(10) References ORDERDATA 
(ORDERID), CONSTRAINT US_ORD_PK PRIMARY KEY(USERID, ORDERID));


insert into USERS values
(1, 'AHMED','ahm41@gmail.com','12345','01055652','5 street 445');
insert into USERS values
(2, 'AHMED1','ah11d@gmail.com','12345','01055652','8 street 445');
insert into USERS values
(3, 'AHMED2','ah55d@gmail.com','12345','01055652','8 street 445');
insert into USERS values
(4, 'AHMED3','ah66ed@gmail.com','12345','01055652','7 street 445');
insert into USERS values
(5, 'AHMED4','ah4ed@gmail.com','12345','01055652','6 street 445');
insert into USERS values
(6, 'AHMED5','ahm75d@gmail.com','12345','01055652','5 street 445');

insert into PRODUCTS values
(1, 'prod1','for some thing',129,'http//sg');
insert into PRODUCTS values
(2, 'prod2','for some thing',12789,'http//sng');
insert into PRODUCTS values
(3, 'prod3','for some thing',12348,'http//sg');
insert into PRODUCTS values
(4, 'prod4','for some thing',123789,'http//sbg');
insert into PRODUCTS values
(5, 'prod5','for some thing',123789,'http//sg');
insert into PRODUCTS values
(6, 'prod6','for some thing',123789,'http//sg');


insert into FAVORITE values
(1,2);
insert into FAVORITE values
(1,3);
insert into FAVORITE values
(1,4);
insert into FAVORITE values
(2,2);
insert into FAVORITE values
(3,3);
insert into FAVORITE values
(4,4);

insert into PAYMENT values
(1,123789,'cash');
insert into PAYMENT values
(2,123789,'vasa');
insert into PAYMENT values
(3,123789,'cash');

insert into CARTEDATA  values
(1, 2,2);
insert into CARTEDATA  values
(2, 3,4);
insert into CARTEDATA  values
(3, 4,1);

insert into ORDERDATA values
(1, 1000,'10-DEC-2021');
insert into ORDERDATA values
(2, 30000,'10-DEC-2021');
insert into ORDERDATA values
(3, 20000,'10-DEC-2021');

insert into transData values
(1, 3,1);
insert into transData values
(2, 2,2);
insert into transData values
(3, 1,3);

insert into USER_CARTE values
(1, 1);
insert into USER_CARTE values
(1, 2);
insert into USER_CARTE values
(1, 3);


insert into USER_CARTE values
(2, 1);
insert into USER_CARTE values
(2, 2);
insert into USER_CARTE values
(2, 3);


insert into USER_CARTE values
(3, 1);
insert into USER_CARTE values
(3, 2);
insert into USER_CARTE values
(3, 3);

insert into ORDERCART values
(1, 1);
insert into ORDERCART values
(2,2);
insert into ORDERCART values
(3,3);


insert into USER_ORDER values
(1, 1);
insert into USER_ORDER values
(2, 2);
insert into USER_ORDER values
(3, 3);

Commit;