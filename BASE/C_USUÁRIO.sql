USE master
GO

IF EXISTS(SELECT 1 FROM SYS.databases WHERE name = 'LOJA')
	DROP DATABASE LOJA
GO

CREATE DATABASE LOJA
GO

USE LOJA
GO

CREATE TABLE USUARIO(
	ID INT PRIMARY KEY IDENTITY (1,1),
	NomeUsuario VARCHAR(150),
	Senha VARCHAR(100),
	Ativo BIT
)
GO


EXEC SP_InserirUsuario 0, 'TESTE','123',1
go
EXEC SP_InserirUsuario 0, 'BRUNO','123456',1
go



/*-----------------------------------------------------------------------------------*/
CREATE PROCEDURE SP_InserirUsuario
	@ID int OUTPUT,
	@NomeUsuario VARCHAR(150),
	@Senha VARCHAR(100),
	@Ativo BIT
AS
	INSERT INTO USUARIO(Ativo, NomeUsuario, Senha)
	Values(@Ativo, @NomeUsuario, @Senha)
	SET @ID = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO
/*-----------------------------------------------------------------------------------*/

CREATE PROCEDURE SP_BuscarUsuario
	@filtro varchar(250) = ''
as
	select ID,Ativo,NomeUsuario,Senha from USUARIO WHERE NomeUsuario LIKE '%' + @filtro + '%'
	GO

	EXEC SP_BuscarUsuario 'B'
go
/*-----------------------------------------------------------------------------------*/

CREATE PROCEDURE SP_AlterarUsuario
	@ID int,
	@Ativo BIT,
	@NomeUsuario VARCHAR(50),
	@Senha VARCHAR(50)
	AS
	UPDATE USUARIO SET
	Ativo = @Ativo,
	NomeUsuario = @NomeUsuario,
	Senha = @Senha
	WHERE ID = @ID
	GO

	SELECT*FROM USUARIO