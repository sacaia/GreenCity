sp_password '', ''

create table usuario(
id int identity(0,1) primary key,
nome varchar(50) not null,
senha varchar(50) not null,
adm int
)