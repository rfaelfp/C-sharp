CREATE DATABASE Ferias

CREATE TABLE MarcaFerias (
	Id int identity(1, 1) primary key
,	Nome varchar(50) NOT NULL
,	Cpf varchar (11) UNIQUE NOT NULL
,	DataInicio smalldatetime NOT NULL
,	DataFim smalldatetime NOT NULL
,	Sexo char(1) check (sexo = 'M' or sexo = 'F')
)

select * from MarcaFerias