--DROP TABLE ITENS_NOTAS_FISCAIS;
--DROP TABLE NOTAS_FISCAIS;
--DROP TABLE TABELA_DE_CLIENTES;
--DROP TABLE TABELA_DE_PRODUTOS;
--DROP TABLE TABELA_DE_VENDEDORES;

CREATE TABLE TABELA_DE_CLIENTES(
	CPF VARCHAR(11) NOT NULL,
	NOME VARCHAR(100) NULL,
	ENDERECO_1 VARCHAR(150) NULL,
	ENDERECO_2 VARCHAR(150) NULL,
	BAIRRO VARCHAR(50) NULL,
	CIDADE VARCHAR(50) NULL,
	ESTADO VARCHAR(2) NULL,
	CEP VARCHAR(8) NULL,
	DATA_DE_NASCIMENTO DATE NULL,
	IDADE INTEGER NULL,
	GENERO VARCHAR(1) NULL,
	LIMITE_DE_CREDITO FLOAT NULL,
	VOLUME_DE_COMPRA FLOAT NULL,
	PRIMEIRA_COMPRA BIT NULL);

ALTER TABLE TABELA_DE_CLIENTES ADD CONSTRAINT PK_TABELA_DE_CLIENTES PRIMARY KEY (CPF);

CREATE TABLE TABELA_DE_PRODUTOS(
	CODIGO_DO_PRODUTO VARCHAR(10) NOT NULL,
	NOME_DO_PRODUTO VARCHAR(50) NULL,
	EMBALAGEM VARCHAR(20) NULL,
	TAMANHO VARCHAR(10) NULL,
	SABOR VARCHAR(20) NULL,
	PRECO_DE_LISTA FLOAT NOT NULL);

	ALTER TABLE TABELA_DE_PRODUTOS ADD CONSTRAINT 
PK_TABELA_DE_PRODUTOS PRIMARY KEY (CODIGO_DO_PRODUTO);

CREATE TABLE TABELA_DE_VENDEDORES(
	MATRICULA VARCHAR(5) NOT NULL,
	NOME VARCHAR(100) NULL,
	PERCENTUAL_COMISSAO FLOAT NULL,
	DATA_ADMISSAO DATE NULL,
	DE_FERIAS BIT NULL,
	BAIRRO VARCHAR(50) NULL);

	ALTER TABLE TABELA_DE_VENDEDORES ADD CONSTRAINT 
PK_TABELA_DE_VENDEDORES PRIMARY KEY (MATRICULA);

 CREATE TABLE NOTAS_FISCAIS(
	CPF VARCHAR(11) NOT NULL,
	MATRICULA VARCHAR(5) NOT NULL,
	DATA_VENDA DATE NULL,
	NUMERO INTEGER NOT NULL,
	IMPOSTO FLOAT NOT NULL);

	ALTER TABLE NOTAS_FISCAIS ADD CONSTRAINT 
PK_NOTAS_FISCAIS PRIMARY KEY (NUMERO);

ALTER TABLE NOTAS_FISCAIS
ADD CONSTRAINT FK_NOTAS_FISCAIS1
   FOREIGN KEY (MATRICULA)
   REFERENCES TABELA_DE_VENDEDORES (MATRICULA);	
   
ALTER TABLE NOTAS_FISCAIS
ADD CONSTRAINT FK_NOTAS_FISCAIS2
   FOREIGN KEY (CPF)
   REFERENCES TABELA_DE_CLIENTES (CPF);	

   CREATE TABLE ITENS_NOTAS_FISCAIS(
	NUMERO INTEGER NOT NULL,
	CODIGO_DO_PRODUTO VARCHAR(10) NOT NULL,
	QUANTIDADE INTEGER NOT NULL,
	PRECO FLOAT NOT NULL);

	ALTER TABLE ITENS_NOTAS_FISCAIS ADD CONSTRAINT 
PK_ITENS_NOTAS_FISCAIS PRIMARY KEY (NUMERO, CODIGO_DO_PRODUTO);

ALTER TABLE ITENS_NOTAS_FISCAIS
ADD CONSTRAINT FK_ITENS_NOTAS_FISCAIS1
   FOREIGN KEY (CODIGO_DO_PRODUTO)
   REFERENCES TABELA_DE_PRODUTOS (CODIGO_DO_PRODUTO);

ALTER TABLE ITENS_NOTAS_FISCAIS
ADD CONSTRAINT FK_ITENS_NOTAS_FISCAIS2
   FOREIGN KEY (NUMERO)
   REFERENCES NOTAS_FISCAIS (NUMERO);	

 