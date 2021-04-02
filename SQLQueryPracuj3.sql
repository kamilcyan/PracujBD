create database Pracuj

/*
drop table [Oferty pracy]
drop table [Rodzaje umowy]
drop table [Poziomy doswiadczenia]
drop table [Wielkosc etatu]
*/

use Pracuj

create table [Oferty_pracy] 
(
	Id int Primary Key identity(1,1),
	[Stanowisko_pracy] varchar(100),
	[Rodzaj_umowy_id] int,
	[Nazwa_firmy] varchar(100),
	[Poziom_doswiadczenia_id] int,
	Etat_id int,
	Wymagane varchar(max),
	[Mile_widziane] varchar(max),
	[Zakres_obowiazkow] varchar(max),
	[Nasze_wymagania] varchar(max),
	Oferujemy varchar(max),
	[Opis_stanowiska] varchar(max)
)

create table [Rodzaje_umowy] 
(
	Id int Primary Key identity(1,1),
	Nazwa varchar(50)
)

create table [Poziomy_doswiadczenia]
(
	Id int Primary Key identity(1,1),
	Nazwa varchar(50)
)

create table [Wielkosc_etatu]
(
	Id int Primary Key identity(1,1),
	Nazwa varchar(50)
)

alter table [Oferty_pracy] add Foreign Key ([Rodzaj_umowy_id]) references [Rodzaje_umowy](Id)

alter table [Oferty_pracy] add Foreign Key ([Poziom_doswiadczenia_id]) references [Poziomy_doswiadczenia](Id)

alter table [Oferty_pracy] add Foreign Key (Etat_id) references [Wielkosc_etatu](Id)
