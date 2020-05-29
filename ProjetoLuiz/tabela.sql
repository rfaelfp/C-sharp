drop table MarcaFerias 

CREATE TABLE MarcaFerias (
	Id int identity(1, 1) primary key
,	Nome varchar(50) NOT NULL
,	Cpf varchar (11) UNIQUE
,	DataInicio smalldatetime NOT NULL
,	DataFim smalldatetime NOT NULL
,	Sexo char(1) check (sexo = 'M' or sexo = 'F')
)

select * from MarcaFerias

delete MarcaFerias

insert into MarcaFerias
values ('Luciana', 11244736619, '01/01/2020', '31/01/2020', 'F')