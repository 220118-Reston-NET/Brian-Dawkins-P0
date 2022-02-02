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


--Starts the relationship tables between Customer, phonenumber, and ListOfOrder 
--Many to Many between customer and phonenumber (Spouses could have same phone number)
create table customer_phonenumbers(
	CustomerId int foreign key references customer(CustomerId),
	phoneNumberId int foreign key references phoneNumber(phoneNumberId)
);

--One to Many relationship between customer and list of orders
alter table ListOfOrder 
add customerId int foreign key references Customer(CustomerId)

--Where we have our insert statements to add values 


--Ends my relationship tables between Customer, phonenumber, and ListOfOrder 


--Starts my tables that belong to my Order Model
create table Orders(
	OrderId int primary key,
	location varchar(50),
	total double(50,50)
);



