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

--Inserindo Contatos
ALTER PROCEDURE inserirContato
@nome varchar(25) null,
@nasc date null,
@residencial VARCHAR(15) null,
@celular VARCHAR(15)null,
@comercial VARCHAR(15) null,
@fax VARCHAR(15) null,
@pessoal VARCHAR(50) null,
@profissional VARCHAR(50) null
AS
DECLARE @idPessoa INT;
INSERT INTO pessoa(nome, dataNascimento)values(@nome, @nasc);
set @idPessoa = @@identity;
INSERT INTO telefone(idPessoa, residencial, celular, comercial, fax) values (@idPessoa, @residencial, @celular, @comercial, @fax);
INSERT INTO email(idPessoa, pessoal, profissional) values (@idPessoa, @pessoal, @profissional);
GO

USE contato

--Buscando Contatos
CREATE PROCEDURE buscarContato
@nome varchar(25)
AS
select pessoa.nome, telefone.celular, telefone.residencial, email.pessoal from pessoa INNER JOIN telefone ON pessoa.idPessoa = telefone.idPessoa 
INNER JOIN email ON pessoa.idPessoa = email.idPessoa
 where 
nome like @nome + '%' 
GO

--listando todos contatos
CREATE PROCEDURE listarContatos
AS
select pessoa.nome, telefone.celular, telefone.residencial, email.pessoal from pessoa INNER JOIN telefone ON pessoa.idPessoa = telefone.idPessoa 
INNER JOIN email ON pessoa.idPessoa = email.idPessoa
order by nome asc 
GO

--Alterando Contato
ALTER PROCEDURE alterarContato
@idPessoa int,
@nome varchar(25) null,
@nasc date null
AS
UPDATE pessoa set
nome = @nome,
dataNascimento = @nasc
where 
idPessoa = @idPessoa
GO
--Excluir Contato
ALTER PROCEDURE excluirContato
@idPessoa int
AS
delete from pessoa where idPessoa = @idPessoa;
delete from telefone where idPessoa = @idPessoa;
delete from email where idPessoa = @idPessoa;
GO

--Alterar Telefone
CREATE PROCEDURE alterarTel
@idPessoa int,
@celular varchar(15) null,
@comercial varchar(15) null,
@residencial varchar(15) null,
@fax varchar null(15)
AS
UpDate telefone set
celular = @celular;
comercial = @comercial;
residencial = @residencial;
fax = @fax
WHERE
idPessoa = @idPessoa
GO;

--Excluir telefone
CREATE PROCEDURE excluirTel
@idPessoa int,
@celular varchar(15),
@comercial varchar(15),
@residencial varchar(15),
@fax varchar(15)
AS
Delete celular from telefone
where celular = @celular;
Delete comercial from telefone
where comercial = @comercial;
Delete residencial from telefone
where residencial = residencial;
Delete fax from telefone 
where fax = @fax;
where idPessoa = @idPessoa
Go;

--Adicionar Telefone
CREATE PROCEDURE adicionarTel
@idPessoa int,
@celular varchar(15) null,
@residencial varchar(15) nul,
@comercial varchar(15) null,
@fax varchar(15) null
AS
INSERT INTO telefone(idPessoa, celular, residencial, comercial, fax)
Values(@idPessoa, @celular, @residencial, @comerial, @fax)
GO;

