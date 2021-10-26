create database Farmacia;
use Farmacia;

CREATE table Empleados(
id_Empleado int not null primary key auto_increment,
nombre char(20) not null,
telefono int not null,
domicilio varchar(20)
);

create table Medicine(
id_Medicine int not null primary key auto_increment,
NameMedicine varchar(30) not null,
Quantity int not null,
Precio float not null
);


Create table Ventas(
id_Ventas int primary key auto_increment,
ToPay_Client float not null,
Recibo_Client varchar(200) not null,
id_Empleado int not null,
id_Medicine int not null,
Foreign Key (id_Medicine) references Medicine(id_Medicine),
Foreign key (id_Empleado) references Empleados(id_Empleado)
);

Update Empleados 
set nombre = 'null', telefono = 0,  domicilio = 'null'
where id_Empleado = 1;


drop table Ventas;
drop table Medicine;
drop table Empleados;



select * from Medicine;

select Precio from Medicine where id_Medicine=1;