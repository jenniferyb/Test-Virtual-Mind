create database Usuarios;
go
use Usuarios;

create table UserTable(
id int not null primary key,
nombre varchar(100),
apellido varchar(100),
email varchar(100),
password varchar(100),
);

go

insert into UserTable(id,nombre,apellido,email,password)values(1,'Jennifer','Bayarri','jennifer.yb19@gmail.com','hola');
insert into UserTable(id,nombre,apellido,email,password)values(2,'Priscila','Pagnotta','pris_pagnotta@gmail.com','chau');
insert into UserTable(id,nombre,apellido,email,password)values(3,'Eric','Tarelli','eric_tarelli@gmail.com','eric')


select * from UserTable
