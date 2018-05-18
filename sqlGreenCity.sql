sp_password '', ''

create table usuario(
id int identity(0,1) primary key,
nome varchar(50) not null,
senha varchar(50) not null,
adm int
)

create table mercado(
milho int not null 




)

create table fazenda(
id int identity(0,1) primary key,
dinheiro int not null,
qtd_adubo int,
qtd_inseticida int,
lvl_silo int not null,
id_usuario int not null,
constraint fk_usuario_fazenda foreign key(id_usuario) references usuario(id)
--id_planta int,
--id_animal int,
--constraint fk_planta_fazenda foreign key(id_planta) references planta(id_planta),
--constraint fk_animal_fazenda foreign key(id_animal) references animal(id_animal),
)

create table planta(
id int identity(0,1) primary key,
nome varchar(50) not null,
idade int not null,
nivel int not null,
numero int,
id_fazenda int not null,
constraint fk_fazenda_planta foreign key(id_fazenda) references fazenda(id)
)

create table animal(
id int identity (0,1) primary key ,
nome varchar(50) not null,
idade int not null,
nivel int not null,
numero int,
id_fazenda int not null,
constraint fk_fazenda_animal foreign key(id_fazenda) references fazenda(id)
)

drop table planta
drop table animal
drop table fazenda

select * from usuario
select * from fazenda
select * from planta
select * from animal

insert into fazenda values(300, 3, 5, 2)
insert into fazenda values(1000, 10, 12, 3)

insert into planta values('milho', 1, 1, 1, 0)
insert into planta values('trigo', 3, 2, 2, 0)
insert into planta values('milho', 5, 4, 1, 1)
insert into planta values('milho', 3, 5, 2, 1)
insert into planta values('milho', 1, 2, 3, 1)

insert into animal values('vaca'   , 1, 1, 1, 0)
insert into animal values('porco'  , 3, 2, 2, 0)
insert into animal values('galinha', 5, 4, 1, 1)
insert into animal values('porco'  , 3, 5, 2, 1)
insert into animal values('cavalo' , 1, 2, 3, 1)


