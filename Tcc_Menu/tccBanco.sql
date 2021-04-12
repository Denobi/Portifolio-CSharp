create database db_tcc;

use db_tcc;

create table tb_Prod(
CodBarra varchar(50) primary key not null,
NomeProd varchar(100) not null,
QtdProd int not null,
ValorProd decimal(8,2)
);
select*from tb_prod;
drop table tb_prod;
insert into tb_Prod(CodBarra,NomeProd,QtdProd,ValorProd)values('12','Coca-cola',12,06.90);

create table tb_Caixa(
valorTotal decimal(8,2),
custoMensal decimal(8,2)
);

create table tb_contas(
ContasFixo decimal(8,2),
ContasMes decimal(8,2),
nomeConta varchar(100)
);
create table tb_contas( ContasFixo decimal(8,2), ContasMes decimal(8,2), nomeConta varchar(100) );
SELECT CodBarra,NomeProd,QtdProd,ValorProd FROM tb_Prod WHERE CodBarra = 2018;