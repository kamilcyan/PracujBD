use Pracuj
go

create table Job_offert
(
	Id int Primary Key identity(1,1),
	Workplace varchar(50),
	Type_of_contract_id int,
	Company_name varchar(50),
	Level_of_experience_id int,
	Post varchar(10),
	Requirements varchar(100),
	Nice_to_have varchar(100),
	Responsabilities varchar(100),
	We_propose varchar(100),
	Job_description varchar(100)
)

create table Type_of_contract 
(
	Id int Primary Key identity(1,1),
	Name varchar(50)
)

create table Level_of_experience
(
	Id int Primary Key identity(1,1),
	Name varchar(50)
)

create table Advice
(
	Id int Primary Key identity(1,1),
	Advice_category_id int,
	Subject varchar(50),
	Creation_date datetime2,
	Body varchar(200)
)

create table Advice_category
(
	Id int Primary Key identity(1,1),
	Name varchar(50)
)

create table Bussines_services
(
	Id int Primary Key identity(1,1),
	Name varchar(20),
	Publication_time datetimeoffset,
	Description varchar(100),
	Price decimal(8,2)
)

create table FAQ
(
	Id int Primary Key identity(1,1),
	Question varchar(100),
	Answer varchar(100)
)

create table Service_user
(
	Id int Primary Key identity(1,1),
	First_name varchar(50),
	Last_name varchar(50),
	Profession varchar(50),
	Adress varchar(100),
	Pnone_number varchar(20),
	Date_of_birth date,
	Expected_salary decimal(8,2),
	Experience varchar(200),
	Education varchar(200),
	Language varchar(100),
	Skills varchar(200),
	Certification varchar(200),
	Recomended_offert_id int,
	Saved_offert_id int,
	My_application_id int,
	CV varchar(max),
	Message_id int
)

create table Message
(
	Id int Primary Key identity(1,1),
	Sender_id int,
	Body varchar(100)
)

create table Level_of_language
(
	Id int Primary Key identity(1,1),
	Level varchar(20)
)

alter table Job_offert add constraint FK_Type_of_contract_Job_offert Foreign Key (Type_of_contract_id) references Type_of_contract(Id)
alter table Job_offert add constraint FK_Level_of_experience_Job_offert Foreign Key (Level_of_experience_id) references Level_of_experience(Id)
alter table Advice add constraint FK_Advice_category_Advice Foreign Key (Advice_category_id) references Advice_category(Id)
alter table Service_user add constraint FK_Recomended_offert_Service_user Foreign Key (Recomended_offert_id) references Job_offert(Id)
alter table Service_user add constraint FK_Saved_offert_Service_user Foreign Key (Saved_offert_id) references Job_offert(Id)
alter table Service_user add constraint FK_My_application_Service_user Foreign Key (My_application_id) references Job_offert(Id)
alter table Service_user add constraint FK_Message_Service_user Foreign Key (Message_id) references Message(Id)

alter table Service_user add Level_of_language_id int 

alter table Service_user add constraint FK_Level_of_language_Service_user Foreign Key (Level_of_language_id) references Level_of_language(Id)
