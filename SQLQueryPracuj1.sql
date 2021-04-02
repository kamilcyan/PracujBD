use Pracuj
go

create table Uslugi_dla_firm
(
	Id int Primary Key identity(1,1),
	Nazwa varchar(20),
	Czas_publikacji int,
	Opis varchar(100),
	Cena decimal(8,2)
)
go

create table Porady_dla_firm
(
	Id int Primary Key identity(1,1),
	Id_Kategorii int,
	Tytu³ varchar(50),
	Data_Utworzenia datetime,
	Body varchar(max)
)

create table Kategorie_Porad_dla_firm
(
	Id int Primary Key identity(1,1),
	Nazwa varchar(50)
)

create table FAQ
(
	Id int Primary Key identity(1,1),
	Tresc varchar(100),
	Odpowiedz varchar(100)
)

alter table Porady_dla_firm add constraint FK_Kategorie_Porad_dla_firm_Porady_dla_firm Foreign Key (Id_Kategorii) references Kategorie_Porad_dla_firm(Id)