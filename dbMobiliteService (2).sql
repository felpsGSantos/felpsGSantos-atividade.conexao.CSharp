drop database dbMobiliteService;

create database dbMobiliteService;

use dbMobiliteService;








create table tbFuncionarios(
codFunc int not null auto_increment,
nome varchar(100) not null,
email varchar(100),
cpf char(14) not null,
telefone char(15),
sexo varchar(10) default 'Feminino' check(sexo in ('Feminino','Masculino')),
endereco varchar(100),
numero char(10),
cep char(9),
bairro varchar(100),
cidade varchar(100),
estado char(2),
primary key(codFunc));


create table tbUsuarios(
codUsu int not null auto_increment,
codFunc int not null,
nomeUsu varchar (20) not null,
senhaUsu varchar(20) not null,
primary key(codUsu),
foreign key(codFunc) references tbFuncionarios(codFunc));
--insert into tbClientes (nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado)values(nome,email,cpf,telefone,sexo,endereco,numero,cep,bairro,cidade,estado)

create table tbClientes(
codCli int not null auto_increment,
codUsu int not null,
nome varchar(100) not null,
email varchar(100),
cpf char(14) not null,
telefone char(15),
sexo varchar(10) default 'Feminino' check(sexo in ('Feminino','Masculino')),
endereco varchar(100),
numero char(10),
cep char(9),
bairro varchar(100),
cidade varchar(100),
estado char(2),
primary key(codCli),
foreign key(codUsu) references tbUsuarios(codUsu));



-- busca por código

select * from tbClientes where codCli = 1;

-- busca por nome 

select * from tbclientes where nome like '%s%'; 

select * from tbClientes where nome = 'Senac largo Treze';

update tbClientes set nome = '' , email = '' , telefone = '' , cpf = '', telefone = '' , sexo = '' , endereco = '' , numero = '' , cep = '' , bairro = '' , cidade = "" , estado = '' where codCli = 1;

delete from tbClientes where codCli = "+codCli+ ";";


"Select codFunc as 'Código', nome as 'Nome', email as 'E-mail',cpf as 'CPF', telefone as 'Telefone',sexo as 'Sexo', endereco as 'Endereço', numero as 'Número', cep as 'CEP' , bairro as 'Bairro' , cidade as 'Cidade' , estado as 'Estado' from * tbFuncionarios;

insert into tbusuarios(nomeUsu, senhaUsu)values('admin','admin@admin');

select * from tbUsuarios where nomeUsu = '' and senhaUsu = '';