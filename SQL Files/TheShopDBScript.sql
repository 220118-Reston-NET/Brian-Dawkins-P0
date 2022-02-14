--Starts my tables that belong to my customer model 
--Create statement to create customer table 
create table customer(
	CustomerId int identity (1,1) primary key,	
	Name varchar(50),
	_address varchar(50)	
);

create table phoneNumber(
	phoneNumberId int identity (1,1) primary key,
	_pnumber varchar(50) 
);

create table ListOfOrder(
	listId int identity (1,1) primary key,
	listofOrder varchar(50) 
);

--Ends my tables that belong to my customer model
insert into customer 
values ('Brian Dawkins', '5058 Brighton Drive'),
	('Kayla Shirk', '1909 University Blvd S')
	
insert into phoneNumber 
values ('904-654-3613'),
	('904-535-6961')
	
select * from customer 

--Starts the relationship tables between Customer, phonenumber, and ListOfOrder 
--Many to Many between customer and phonenumber (Spouses could have same phone number)
create table customer_phonenumbers(
	CustomerId int foreign key references customer(CustomerId),
	phoneNumberId int foreign key references phoneNumber(phoneNumberId)
);


	
select * from customer_phonenumbers cp 
--One to Many relationship between customer and list of orders
alter table ListOfOrder 
add customerId int foreign key references Customer(CustomerId)

--Where we have our insert statements to add values 


--Ends my relationship tables between Customer, phonenumber, and ListOfOrder 


--Starts my tables that belong to my Order Model
create table Orders(
	OrderId int identity (1,1) primary key,
	total int 
);

select * from Orders o 

insert into Orders (total)  
values (45)
	
	
create table Location(
	StoreId int identity (1,1) primary key,
	LName varchar(50),
	LAddress varchar(50),
);

insert into Location 
values ('Southside', '2431 Southside Blvd'),
	('Northside', '5679 Northside Blvd'),
	('Eastside', '1267 Eastside Blvd'),
	('Westside', '4387 Westside Blvd')

create table LineItems(
	ProductId int foreign key references Product(ProductId),
	OrderId int foreign key references Orders(OrderId),
	Quantity int 
)
alter table LineItems 
add Quantity int

select * from LineItems li 
insert into LineItems 
values ('Jerseys', 50),
	('Helmets', 50),
	('Shoes', 60)
	
--Ends my tables that belong to my Order Model 

--Starts the relationship tables between Orders, Locations, and LineItems 
--One to many (One store can have many Orders)
alter table Orders 
add StoreId int identity (1,1) foreign key references Location(StoreId)

--Many to Many (Many orders can have many Line items)
create table Orders_LineItems(
	OrderId int foreign key references Orders(OrderId),
	ItemId int foreign key references LineItems(ItemId)
)

insert into Orders_LineItems 
values (3,2)

--Many Locations can have many Line Items
create table Locations_LineItems(
	StoreId int foreign key references Location(StoreId),
	ItemId int foreign key references LineItems(ItemId)
)

--Where our insert statements go for values 

select * from Orders o
inner join Orders_LineItems oli on o.OrderId = oli.OrderId 
inner join LineItems li on li.ItemId = oli.ItemId 
--Ends the relationship tables between Orders, Locations, and LineItems 

--Relationship between customers and locations
--Many to Many 
create table customers_locations(
	CustomerId int foreign key references Customer(CustomerId),
	StoreId int foreign key references Location(StoreId)
)

--Relationship between customers and orders 
--One to Many customers can have more than one order
alter table Orders 
add CustomerId int foreign key references Customer(CustomerId)

select c.CustomerId, o.OrderId, o.total  from Orders o  
inner join customer c on o.CustomerId  = c.CustomerId  

select c.CustomerId, oli.OrderId from Orders_LineItems oli 

create table Product(
	ProductId int identity (1,1) primary key,
	Name varchar(50),
	Price int,
	Category varchar(50)
)

create table Inventory(
	ProductId int foreign key references Product(ProductId),
	StoreId int foreign key references Location(StoreId),
	Quantity int
)

select * from Inventory i 


