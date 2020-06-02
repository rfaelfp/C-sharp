CREATE TABLE MarcaFerias (
	Id int identity(1, 1) primary key
,	Nome varchar(50) NOT NULL
,	Cpf varchar (11) UNIQUE NOT NULL
,	DataInicio smalldatetime NOT NULL
,	DataFim smalldatetime NOT NULL
,	Sexo char(1) check (sexo = 'M' or sexo = 'F')
)

select * from MarcaFerias

delete MarcaFerias

insert into MarcaFerias
values ('Luciana', NULL, '01/01/2020', '31/01/2020', 'F')

CREATE TABLE CadastroFuncionarios (
	id int identity(1, 1) PRIMARY KEY
,	Nome VARCHAR (50) NOT NULL
,	Cpf VARCHAR (11) UNIQUE NOT NULL
,	Email VARCHAR (50) NOT NULL
,	Celular VARCHAR (12) NOT NULL
,	Sexo CHAR (1) CHECK (SEXO = 'M' OR SEXO = 'F')
,	Endereco varchar(100) NOT NULL
,	Bairro varchar (50) NOT NULL
,	Numero varchar (12) NOT NULL
,	Cep varchar (8) NOT NULL
)

SELECT * FROM CadastroFuncionarios

