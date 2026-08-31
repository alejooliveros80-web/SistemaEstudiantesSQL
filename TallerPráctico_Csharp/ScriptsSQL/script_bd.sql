CREATE DATABASE [taller_practico];
GO

USE [taller_practico];
GO

create table contactos
(
documento int primary key,
nombre varchar (100),
telefono varchar (100),
correo varchar (100),
ciudad varchar (100),
);
Go

-- Cambio realizado en la rama de desarrollo --