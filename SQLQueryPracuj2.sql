use Pracuj

create table Porady
(
	Id int Primary Key identity(1,1),
	Id_Kategorii int,
	Tytu³ varchar(50),
	Data_Utworzenia datetime,
	Body varchar(max)
)

create table Kategorie_Porad
(
	Id int Primary Key identity(1,1),
	Nazwa varchar(50)
)

alter table Porady add constraint FK_Kategorie_Porad_Porady Foreign Key (Id_Kategorii) references Kategorie_Porad(Id)
alter table Porady drop constraint FK__Porady__Id_Kateg__3F466844


USE Pracuj
GO  
EXEC sp_rename 'Kategorie', 'Kategorie_Porad'
go

