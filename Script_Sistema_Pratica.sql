

CREATE DATABASE ERP_RENOVO_BARBER;


CREATE USER 'SYSDBAPRO'@'%' IDENTIFIED BY 'masterkey';

GRANT ALL ON *.* TO 'SYSDBAPRO'@'%' WITH GRANT OPTION;


flush privileges;


USE ERP_RENOVO_BARBER;

/***** TABELA PAIS *****/
CREATE TABLE tb_pais (
  id_pais int auto_increment primary key,
  nome varchar(100),
  sigla varchar(3),
  DDI varchar(3),
  data_criacao datetime,
  data_ult_alteracao datetime
);

/***** TABELA ESTADOS *****/
CREATE TABLE tb_estados (
  id_estado int auto_increment primary key,
  nome varchar(100),
  uf varchar(2), 
  id_pais int not null,
  data_criacao datetime,
  data_ult_alteracao datetime,
  FOREIGN KEY (id_pais) REFERENCES tb_pais(id_pais)
);

/***** TABELA CIDADES *****/
CREATE TABLE tb_cidades (
  id_cidade int auto_increment primary key,
  nome varchar(100),
  DDD varchar(3), 
  id_estado int not null,
  data_criacao datetime,
  data_ult_alteracao datetime,
  FOREIGN KEY (id_estado) REFERENCES tb_estados(id_estado)
);

/***** TABELA CLIENTES *****/
CREATE TABLE tb_clientes (
  id_cliente int auto_increment primary key,
  status_cliente varchar(1),
  nome varchar(50),
  sexo varchar(1),
  apelido varchar(50),
  rg varchar (30),
  cpf varchar (20),
  email varchar(200),
  telefone varchar(30),
  celular varchar(30),
  cep varchar(100),
  endereco varchar (255),
  numero int,
  complemento varchar (200),
  bairro varchar (100),
  id_cidade int not null,
  data_nasc datetime,
  data_criacao datetime,
  data_ult_alteracao datetime,
  FOREIGN KEY (id_cidade) REFERENCES tb_cidades(id_cidade)
);

/***** TABELA FORNECEDORES *****/

CREATE TABLE tb_fornecedores (
  id_fornecedor int auto_increment primary key,
  status_fornecedor varchar(1),
  nome_fantasia varchar(100),
  razao_social varchar(100),
  data_fundacao datetime,
  insc_municipal varchar(50),
  insc_estadual varchar(50),
  cnpj varchar (100),
  email varchar(200),
  telefone varchar(30),
  celular varchar(30),
  cep varchar(100),
  endereco varchar (255),
  numero int,
  complemento varchar (200),
  bairro varchar (100),
  data_criacao datetime,
  data_ult_alteracao datetime,
  id_cidade int not null,
  FOREIGN KEY (id_cidade) REFERENCES tb_cidades(id_cidade)
);

/***** TABELA CARGOS *****/

CREATE TABLE  tb_cargos (
  id_cargo int auto_increment primary key,
  status_cargo varchar(1),
  cargo varchar(100),
  data_criacao datetime,
  data_ult_alteracao datetime
)

/***** TABELA FUNCIONARIOS *****/

CREATE TABLE tb_funcionarios (
  id_funcionario int auto_increment primary key, 
  status_funcionario varchar(1),
  nome varchar(100),
  apelido varchar(100),
  sexo varchar(1),
  rg varchar (30),
  cpf varchar (20),
  email varchar(200),
  senha varchar(10),
  telefone varchar(30),
  celular varchar(30),
  cep varchar(100),
  endereco varchar (255),
  numero int,
  complemento varchar (200),
  bairro varchar (100),
  data_nasc datetime,
  data_criacao datetime,
  data_ult_alteracao datetime,
  id_cargo int not null,
  id_cidade int not null,
  FOREIGN KEY (id_cidade) REFERENCES tb_cidades(id_cidade),
  FOREIGN KEY (id_cargo) REFERENCES tb_cargos(id_cargo)
);

/***** TABELA SERVICO *****/
CREATE TABLE tb_servicos(
  id_servico int auto_increment primary key,
  descricao varchar(100),
  status_servico varchar (1),
  duracao time,
  valor decimal(10),
  data_criacao datetime,
  data_ult_alteracao datetime
);

/***** TABELA FORMA DE PAGAMENTO *****/
CREATE TABLE tb_forma_pagamento(
  id_forma int auto_increment primary key,
  status_forma varchar (1),
  forma varchar(50) not null,
  data_criacao datetime,
  data_ult_alteracao datetime
);

/***** TABELA CONDIÇÃO DE PAGAMENTO *****/
CREATE TABLE tb_condicao_pagamento(
  id_condicao int auto_increment primary key,
  condicao varchar(30) not null,
  parcelas int not null,
  taxa decimal(10) not null,
  multa decimal(10) not null, 
  desconto decimal(10) not null,
  data_criacao datetime,
  data_ult_alteracao datetime
);

create table tb_parcelas(
  id_condicao int not null,
  num_parcela int not null,
  id_forma int not null,
  dias_totais int not null,
  porcentagem decimal(5,2),
  data_criacao datetime,
  data_ult_alteracao datetime,
  primary key (id_condicao, num_parcela, id_forma),
  FOREIGN KEY (id_condicao) REFERENCES tb_condicao_pagamento(id_condicao) ON DELETE CASCADE
);

CREATE TABLE tb_produtos (
  id_produto int auto_increment primary key not null,
  descricao_produto varchar(50) not null,
  unidade_medida varchar(50) not null,
  marca varchar(50) not null,
  preco_custo decimal (10,2) not null,
  preco_venda decimal (10,2) not null,
  qtd_estoque int not null,
  data_criacao datetime,
  data_ult_alteracao datetime
);

CREATE TABLE tb_compras(
  num_nfc int not null,
  modelo_nfc int not null,
  serie_nfc int not null,
  id_fornecedor int not null,
  id_condicao int not null,
  valor_total decimal not null,
  valor_frete decimal not null,
  valor_seguro decimal not null,
  valor_outras_despesas decimal not null,
  data_chegada datetime not null,
  data_emissao datetime not null,
  data_cancelamento datetime,
  data_criacao datetime,
  PRIMARY KEY (num_nfc, modelo_nfc, serie_nfc, id_fornecedor),
  FOREIGN KEY (id_fornecedor) REFERENCES tb_fornecedores(id_fornecedor)
);

CREATE TABLE tb_itens_compras(
  num_nfc int not null,
  modelo_nfc int not null,
  serie_nfc int not null,
  id_fornecedor int not null,
  id_produto int not null,
  qtd_produto int not null,
  preco_custo decimal (10,2) not null,
  total_custo decimal (10,2) not null,
  percentual_compra decimal (10,2) not null,
  media_ponderada decimal (10,2) not null,
  data_criacao datetime,
  PRIMARY KEY (num_nfc, modelo_nfc, serie_nfc, id_fornecedor, id_produto),
  FOREIGN KEY (num_nfc, modelo_nfc, serie_nfc) REFERENCES tb_compras (num_nfc, modelo_nfc, serie_nfc),
  FOREIGN KEY (id_produto) REFERENCES tb_produtos (id_produto),
  FOREIGN KEY (id_fornecedor) REFERENCES tb_fornecedores(id_fornecedor)
)

CREATE TABLE tb_contas_pagar(
  num_nfc int not null,
  modelo_nfc int not null,
  serie_nfc int not null,
  num_parcela int not null,
  id_fornecedor int not null,
  id_condicao int not null,
  valor decimal(10,2) not null,
  situacao varchar(10) not null,
  data_baixa datetime,
  data_vencimento datetime not null,
  data_criacao datetime not null,
  data_ult_alteracao datetime not null,
  PRIMARY KEY (num_nfc, modelo_nfc, serie_nfc, id_fornecedor, num_parcela),
  FOREIGN KEY (num_nfc, modelo_nfc, serie_nfc) REFERENCES tb_compras (num_nfc, modelo_nfc, serie_nfc),
  FOREIGN KEY (id_fornecedor) REFERENCES tb_fornecedores(id_fornecedor),
  FOREIGN KEY (id_condicao) REFERENCES tb_condicao_pagamento (id_condicao)
)

CREATE TABLE tb_agenda(
  id_agenda int auto_increment primary key not null,
  id_agenda_referencia int, 
  id_funcionario int not null,
  id_cliente int,
  data_agenda datetime not null,
  id_servico int,
  id_receber int,
  id_condicao int,
  intervalo int,
  FOREIGN KEY (id_funcionario) REFERENCES tb_funcionarios(id_funcionario),
  FOREIGN KEY (id_cliente) REFERENCES tb_clientes(id_cliente),
  FOREIGN KEY (id_condicao) REFERENCES tb_condicao_pagamento(id_condicao),
  FOREIGN KEY (id_receber) REFERENCES tb_agenda(id_condicao)
)

CREATE TABLE tb_contas_receber(
  id_receber int not null auto_increment primary key,
  id_condicao int,
  situacao varchar(10),
  data_criacao datetime not null,
)

