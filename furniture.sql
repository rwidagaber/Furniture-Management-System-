Create database furnture


create table staff(
    staffID int primary key identity,
    sName varchar(50),
    sPhone varchar(15),
    sRole varchar(50),
    username varChar(50) unique,
    upass varchar(10) not null,
)

insert into staff values('Rwida','01016516600','manager','admin','1956')

create table category(
    catID int primary key identity,
    catName varChar(50)
)


create table product(
    pID int primary key identity,
    pName varChar(50),
    pPrice float,
    categoryID int FOREIGN KEY REFERENCES category(catID),
    pImage image
)

create table orders(
    oID int,
    pID int,
    pQty int,
    pAmount int 
    primary key (oID,pID) 
)




create table customers(
    Phone varChar(20) primary key,
    custName varChar(20)
)



create table orderDetail(
    oID int primary key identity,
    custPhone varchar(20) FOREIGN KEY REFERENCES customers(Phone),
    odate date,
    otime time,
    total float,
    Recieve float,
    change float
)
alter table orderDetail add cashierName varchar(50) 













create table tblMain
(
    MainID int primary key identity,
    aDate date,
    aTime varchar(15),
    TableName varchar(10),
    WaiterName varchar(15),
    status varchar(15),
    orderType varchar(15),
    total float,
    recevied float,
    change float,
)

create table tblDetails
(
    DetailID int primary key identity,
    MainID int,
    proID int,
    qty int,
    price float,
    amount float
)