-- USE master; DROP DATABASE Mercado;
CREATE DATABASE Mercado;
GO

USE Mercado;
GO

-- DROP TABLE TipoUsuario
CREATE TABLE TipoUsuario
(
	Codigo INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100) NOT NULL,
	DataHoraCadastro DATETIME NOT NULL DEFAULT GETDATE(),
	Ativo BIT NOT NULL DEFAULT 1
);
GO

INSERT INTO	TipoUsuario
	(Nome)
VALUES
	('Administrador'),
	('Comum');
GO

-- DROP TABLE Categoria
CREATE TABLE Categoria
(
	Codigo INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100) NOT NULL,
	DataHoraCadastro DATETIME NOT NULL DEFAULT GETDATE(),
	Ativo BIT NOT NULL DEFAULT 1
);
GO

INSERT INTO	Categoria
	(Nome)
VALUES
	('Padaria'),
	('Alimentos (cereais e grãos)'),
	('Congelados e frios'),
	('Hortifruti'),
	('Produtos de limpeza'),
	('Higiene pessoal'),
	('Bebidas'),
	('Papelaria');
GO


-- DROP TABLE Usuario
CREATE TABLE Usuario
(
	Codigo INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	HashSenha VARCHAR(100) NOT NULL,
	CodigoTipoUsuario INT NOT NULL DEFAULT 2,
	DataHoraCadastro DATETIME NOT NULL DEFAULT GETDATE(),
	Ativo BIT NOT NULL DEFAULT 1,
    FOREIGN KEY (CodigoTipoUsuario) REFERENCES TipoUsuario(Codigo)
);
GO

INSERT INTO Usuario
	(Nome, 
	Email, 
	HashSenha, 
	CodigoTipoUsuario)
VALUES
	('Victor Alves Bugueno', 
	'victoralvesbug@gmail.com', 
	'4fb46160dcfb38affadcd91b368a833a', /* 'Teste.12345' */ 
	1);
GO

-- DROP TABLE Produto
CREATE TABLE Produto
(
	Codigo INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100) NOT NULL,
	Preco MONEY NOT NULL,
	Foto VARCHAR(100) NOT NULL,
	CodigoCategoria INT NOT NULL,
	DataHoraCadastro DATETIME NOT NULL DEFAULT GETDATE(),
	Ativo BIT NOT NULL DEFAULT 1,
    FOREIGN KEY (CodigoCategoria) REFERENCES Categoria(Codigo)
);
GO


SELECT * FROM Mercado..TipoUsuario
SELECT * FROM Mercado..Categoria
SELECT * FROM Mercado..Usuario
SELECT * FROM Mercado..Produto