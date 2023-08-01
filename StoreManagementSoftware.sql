Create Database StoreManagementSoftware
Go

Use StoreManagementSoftware
Go

Create Table InvoiceDetails
(
idinvoicedetails int not null,
tablename nvarchar(50) not null,
productname nvarchar(50) not null,
quantity int not null,
unitprice int not null,
)
Go

Create Table Invoice
(
idinvoicedetails int not null,
totalprice int not null,
datefounded date not null,
PRIMARY KEY (idinvoicedetails),
)
Go

Create Table ProductType
(
idproducttype int identity(1,1) not null,
producttype nvarchar(50) not null,
PRIMARY KEY (idproducttype),
)
Go

Create Table Product
(
idproduct int identity(1,1) not null,
productname nvarchar(50) not null,
producttype nvarchar(50) not null,
unitprice int not null,
imageproduct image not null,
PRIMARY KEY (idproduct),
)
Go

Create Table CustomerInformation
(
idcustomer int identity(1,1) not null,
fullname nvarchar(50) not null,
gender nvarchar(50) not null,
dateofbirth date not null,
address nvarchar(50) not null,
email nvarchar(50) not null,
phone int not null,
member nvarchar(50) not null,
imagecustomer image not null,
PRIMARY KEY (idcustomer),
)
Go

Create Table EmployeeInformation
(
idemployee int identity(1,1) not null,
fullname nvarchar(50) not null,
gender nvarchar(50) not null,
dateofbirth date not null,
address nvarchar(50) not null,
email nvarchar(50) not null,
phone int not null,
position nvarchar(50) not null,
salary int not null,
imageemployee image not null,
PRIMARY KEY (idemployee),
)
Go

Create Table Account
(
idemployee int not null,
username nvarchar(50) not null,
password nvarchar(50) not null,
PRIMARY KEY (idemployee),
CONSTRAINT FK_EIidemployee FOREIGN KEY (idemployee) REFERENCES EmployeeInformation(idemployee),
)
Go

