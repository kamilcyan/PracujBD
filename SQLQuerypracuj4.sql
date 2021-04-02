use Pracuj
go

create table Uzytkownik
(
	Id int Primary Key identity(1,1),
	Imiê varchar(50),
	Nazwisko varchar(50),
	Zawod_id int,
	Adres varchar(max),
	Telefon varchar(max),
	Data_urodzenia date,
	Oczekiwane_wynagrodzenie decimal(8,2),
	Doswiadczenie varchar(max),
	Wykszta³cenie varchar(max),
	Jêzyki_id int,
	Umiejêtnoœci varchar(max),
	Certyfikaty varchar(max),
	Rekomendowane_oferty_id int,
	Zapisane_oferty_id int,
	Moje_aplikacje_id int,
	CV varchar(max),
	Wiadomoœci_id int
)

create table Wiadomoœci
(
	Id int Primary Key identity(1,1),
	Nadawca varchar(50),
	Treœæ varchar(max)
)

create table Zawod
(
	Id int Primary Key identity(1,1),
	Nazwa varchar(max),
	Opis varchar(max)
)

create table Jêzyki
(
	Id int Primary Key identity(1,1),
	Nazwa varchar(max),
	Poziom_jêzyka_id int
)

create table Poziom_jêzyka
(
	Id int Primary Key identity(1,1),
	Poziom varchar(20)
)

--alter table Uzytkownik add constraint FK_Profil_zawodowy_U¿ytkownik Foreign Key (Profil_zawodowy_id) references Profil_zawodowy(Id)
alter table Uzytkownik add constraint FK_Rekomendowane_oferty_U¿ytkownik Foreign Key (Rekomendowane_oferty_id) references Oferty_pracy(Id)
alter table Uzytkownik add constraint FK_Zapisane_oferty_U¿ytkownik Foreign Key (Zapisane_oferty_id) references Oferty_pracy(Id)
alter table Uzytkownik add constraint FK_Moje_aplikacje_U¿ytkownik Foreign Key (Moje_aplikacje_id) references Oferty_pracy(Id)
alter table Uzytkownik add constraint FK_Wiadomoœci_U¿ytkownik Foreign Key (Wiadomoœci_id) references Wiadomoœci(Id)
alter table Profil_zawodowy add constraint FK_Zawod_Profil_zawodowy Foreign Key (Zawod_id) references Zawod(Id)
alter table Profil_zawodowy add constraint FK_Jêzyki_Profil_zawodowy Foreign Key (Jêzyki_id) references Jêzyki(Id)
alter table Jêzyki add constraint FK_Poziom_jêzyka_Jêzyki Foreign Key (Poziom_jêzyka_id) references Poziom_jêzyka(Id)

alter table Wiadomoœci drop column Nadawca
alter table Wiadomoœci drop column Treœæ

alter table Wiadomoœci add Nadawca_id int
alter table Wiadomoœci add Treœæ varchar(100)

alter table Wiadomoœci add constraint FK_U¿ytkownik_Wiadomoœci Foreign Key (Nadawca_id) references U¿ytkownik(Id)

drop table U¿ytkownik
drop table Profil_zawodowy

alter table Uzytkownik add constraint FK_Zawod_Uzytkownik Foreign Key (Zawod_id) references Zawod(Id)
alter table Uzytkownik add constraint FK_Jêzyki_Uzytkownik Foreign Key (Jêzyki_id) references Jêzyki(Id)

sp_help 'Uzytkownik'
