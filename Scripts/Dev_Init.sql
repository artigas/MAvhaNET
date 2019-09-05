--CREATE DATABASE MAvhaNET;

USE MAvhaNET;

CREATE TABLE Personas (
	PersonaId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    NombreCompleto VARCHAR(255) NOT NULL,
    FechaDeNacimiento DATE NOT NULL,
    Edad TINYINT,
    Sexo VARCHAR(50)
);

INSERT INTO Personas (NombreCompleto, FechaDeNacimiento, Edad, Sexo)
VALUES	('Manuel Artigas', '1995-01-17', 24, 'Hombre'),
		('Carla Perez', '2003-08-16', 16, 'Mujer')

