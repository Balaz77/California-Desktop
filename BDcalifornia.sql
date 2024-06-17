create database california;
use california;

create table funcionario
(
	cargoFunc varchar(30),
    codFunc int(10) auto_increment primary key,
    usuarioFunc varchar(30),
    senhaFunc varchar(20),
    nomeFunc varchar(30),
    cpfFunc varchar(30),
    dtNascimento date,
    telefoneFunc varchar(30),
    enderecoFunc varchar(40)
);

 drop table funcionario;
 
create table cliente 
(
	nomeCliente varchar(30),
    cpfCliente varchar(30) primary key,
    telefoneCliente int(11),
    enderecoCliente varchar(40)
);

create table estoque
(
    quantidadeProduto int(7),
    dtEntrada date,
    dtSaida date
);


create table produto
(
	codProduto int(5) auto_increment primary key,
    tamanhoProduto char(5),
    corProduto char(15),
    categoriaProduto char(15),
    nomeProduto varchar(30),
    valorProduto decimal(30)
);
 
create table compras
(
	precoCompra decimal(30),
    quantidadeCompra int(7),
    descontoCompra decimal(4),
    dtVenda datetime,
    codCompra int(5) auto_increment primary key
);


alter table estoque add column codProduto int(5);
alter table estoque add foreign key fk (codProduto) references produto(codProduto) on delete cascade on update cascade;

alter table compras add column codFunc int(10);
alter table compras add foreign key fk2 (codFunc) references funcionario(codFunc) on delete cascade on update cascade;


alter table compras add column codProduto int(5);
alter table compras add foreign key fk3 (codProduto) references produto(codProduto) on delete cascade on update cascade;

alter table compras add column cpfCliente varchar(30);
alter table compras add foreign key fk4 (cpfCLiente) references cliente(cpfCliente) on delete cascade on update cascade;


drop table estoque;

		
    
    

