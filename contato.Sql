CREATE DATABASE contato

USE contato


CREATE TABLE pessoa
(
idPessoa INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
dataNascimento DATE NOT NULL,
nome VARCHAR(25) NOT NULL
);

CREATE TABLE telefone
(
idTelefone INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
idPessoa INT NOT NULL,
residencial VARCHAR(15),
celular VARCHAR(15),
comercial VARCHAR(15),
fax VARCHAR(15)
);

CREATE TABLE email
(
idEmail INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
idPessoa INT NOT NULL,
pessoal VARCHAR(50),
profissional VARCHAR(50)
);

CREATE PROCEDURE inserirContato
@nome varchar(25),
@nasc date,
@residencial VARCHAR(15),
@celular VARCHAR(15),
@comercial VARCHAR(15),
@fax VARCHAR(15),
@pessoal VARCHAR(50),
@profissional VARCHAR(50)
AS
DECLARE @idPessoa INT;
INSERT INTO pessoa(nome, dataNascimento)values(@nome, @nasc);
set @idPessoa = @@identity;
INSERT INTO telefone(idPessoa, residencial, celular, comercial, fax) values (@idPessoa, @residencial, @celular, @comercial, @fax);
INSERT INTO email(idPessoa, pessoal, profissional) values (@idPessoa, @pessoal, @profissional);
GO


Select * from pessoa


