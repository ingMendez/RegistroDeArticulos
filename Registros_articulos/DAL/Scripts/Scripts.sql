CREATE DATABASE ArticulosDB
go 
use ArticulosDB
go
CREATE TABLE Articulos
(
ArticuloId int primary key identity,
FechaVencimiento datetime,
Descripcion varchar(50),
Precio int,
Existencia int,
CantCotizada int
);

--select *from Articulos