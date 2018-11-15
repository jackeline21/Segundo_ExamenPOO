/* Objetivo: Creación de la base de datos BulletProofRecords.
			 Utilizada para el examen de POO 2018 II Parcial.
   Autor: Ing. Héctor Sabillón
   Fecha: 14/Noviembre/2018 
 */

  -- Utilizar la base de datos por defecto
USE tempdb
GO

-- Eliminar la base de datos si existe
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'BulletProofRecords')
	BEGIN
		DROP DATABASE BulletProofRecords
	END
GO

-- Paso 0: Crear la base de datos
-- En este caso el nombre de la BD será "BulletProofRecords"
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'BulletProofRecords')
	BEGIN
		CREATE DATABASE BulletProofRecords
	END
GO

USE BulletProofRecords
GO

-- Paso 1: Crear el esquema a utilizar
CREATE SCHEMA Music
GO

-- Paso 2: Creación de las tablas
CREATE TABLE Music.Artista (
	Id INT NOT NULL IDENTITY(1,1)
		CONSTRAINT PK_Id_Music_Artista PRIMARY KEY CLUSTERED,
	Nombre NVARCHAR(100) NOT NULL,
	Estado BIT NOT NULL
);
GO

CREATE TABLE Music.Album (
	Id INT NOT NULL IDENTITY(10,1)
		CONSTRAINT PK_Id_Music_Album PRIMARY KEY CLUSTERED,
	Nombre NVARCHAR(200) NOT NULL,
	Artista INT NOT NULL
);
GO

CREATE TABLE Music.Cancion (
	Id INT NOT NULL IDENTITY(100,1)
		CONSTRAINT PK_Id_Music_Cancion PRIMARY KEY CLUSTERED,
	Nombre NVARCHAR(200) NOT NULL,
	Artista INT NOT NULL,
	Album INT NOT NULL,
	Genero NVARCHAR(100),
	AñoCreacion NVARCHAR(4)
);
GO

-- Paso 3: Restricciones de llave foránea
ALTER TABLE Music.Album
	ADD CONSTRAINT FK_Music_Album$Tiene$Music_Artista
		FOREIGN KEY (Artista) REFERENCES Music.Artista(Id)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION

ALTER TABLE Music.Cancion
	ADD CONSTRAINT FK_Music_Cancion$Tiene$Music_Artista
		FOREIGN KEY (Artista) REFERENCES Music.Artista(Id)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION

ALTER TABLE Music.Cancion
	ADD CONSTRAINT FK_Music_Cancion$Pertenece$Music_Album
		FOREIGN KEY (Album) REFERENCES Music.Album(Id)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
GO