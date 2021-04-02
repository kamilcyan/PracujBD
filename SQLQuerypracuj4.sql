use Pracuj
go

create table Uzytkownik
(
	Id int Primary Key identity(1,1),
	Imi� varchar(50),
	Nazwisko varchar(50),
	Zawod_id int,
	Adres varchar(max),
	Telefon varchar(max),
	Data_urodzenia date,
	Oczekiwane_wynagrodzenie decimal(8,2),
	Doswiadczenie varchar(max),
	Wykszta�cenie varchar(max),
	J�zyki_id int,
	Umiej�tno�ci varchar(max),
	Certyfikaty varchar(max),
	Rekomendowane_oferty_id int,
	Zapisane_oferty_id int,
	Moje_aplikacje_id int,
	CV varchar(max),
	Wiadomo�ci_id int
)

create table Wiadomo�ci
(
	Id int Primary Key identity(1,1),
	Nadawca varchar(50),
	Tre�� varchar(max)
)

create table Zawod
(
	Id int Primary Key identity(1,1),
	Nazwa varchar(max),
	Opis varchar(max)
)

create table J�zyki
(
	Id int Primary Key identity(1,1),
	Nazwa varchar(max),
	Poziom_j�zyka_id int
)

create table Poziom_j�zyka
(
	Id int Primary Key identity(1,1),
	Poziom varchar(20)
)

--alter table Uzytkownik add constraint FK_Profil_zawodowy_U�ytkownik Foreign Key (Profil_zawodowy_id) references Profil_zawodowy(Id)
alter table Uzytkownik add constraint FK_Rekomendowane_oferty_U�ytkownik Foreign Key (Rekomendowane_oferty_id) references Oferty_pracy(Id)
alter table Uzytkownik add constraint FK_Zapisane_oferty_U�ytkownik Foreign Key (Zapisane_oferty_id) references Oferty_pracy(Id)
alter table Uzytkownik add constraint FK_Moje_aplikacje_U�ytkownik Foreign Key (Moje_aplikacje_id) references Oferty_pracy(Id)
alter table Uzytkownik add constraint FK_Wiadomo�ci_U�ytkownik Foreign Key (Wiadomo�ci_id) references Wiadomo�ci(Id)
alter table Profil_zawodowy add constraint FK_Zawod_Profil_zawodowy Foreign Key (Zawod_id) references Zawod(Id)
alter table Profil_zawodowy add constraint FK_J�zyki_Profil_zawodowy Foreign Key (J�zyki_id) references J�zyki(Id)
alter table J�zyki add constraint FK_Poziom_j�zyka_J�zyki Foreign Key (Poziom_j�zyka_id) references Poziom_j�zyka(Id)

alter table Wiadomo�ci drop column Nadawca
alter table Wiadomo�ci drop column Tre��

alter table Wiadomo�ci add Nadawca_id int
alter table Wiadomo�ci add Tre�� varchar(100)

alter table Wiadomo�ci add constraint FK_U�ytkownik_Wiadomo�ci Foreign Key (Nadawca_id) references U�ytkownik(Id)

drop table U�ytkownik
drop table Profil_zawodowy

alter table Uzytkownik add constraint FK_Zawod_Uzytkownik Foreign Key (Zawod_id) references Zawod(Id)
alter table Uzytkownik add constraint FK_J�zyki_Uzytkownik Foreign Key (J�zyki_id) references J�zyki(Id)

sp_help 'Uzytkownik'
