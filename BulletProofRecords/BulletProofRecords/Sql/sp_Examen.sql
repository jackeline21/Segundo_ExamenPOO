USE BulletProofRecords
GO

CREATE PROCEDURE sp_crearCancion
(
	@nombre nvarchar(200),
	@artista int,
	@album int,
	@genero nvarchar(100),
	@a�oCreacion nvarchar(4)
)
AS
BEGIN
	INSERT INTO Music.Cancion(Nombre, Artista, Album, Genero, A�oCreacion)
	VALUES (@nombre, @artista, @album, @genero, @a�oCreacion)
END
GO

CREATE PROCEDURE sp_listarCancion
(
	@id int
)
AS
BEGIN
	SELECT * FROM Music.Cancion WHERE id = @id
END
GO


CREATE PROCEDURE sp_eliminarCancion
(
	@id int
)
AS
BEGIN
	DELETE FROM Music.Cancion WHERE id = @id
END
GO
