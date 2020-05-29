select * from MarcaFerias

delete MarcaFerias

insert into MarcaFerias (id, Nome, Cpf, DataInicio, DataFim, sexo)
values (select max(id from MarcaFerias), 'Rafael', 11244736619, '01/01/2020', '31/01/2020', 'M'))


