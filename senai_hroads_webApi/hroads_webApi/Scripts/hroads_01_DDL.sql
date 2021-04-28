CREATE DATABASE Senai_HROADS_Manha

USE Senai_HROADS_Manha;
CREATE TABLE TipoHabilidade
(
	IdTipoHabilidade	INT PRIMARY KEY IDENTITY
   ,TipoHabilidade		VARCHAR(200) NOT NULL
);


CREATE TABLE Habilidade
(
	 IdHabilidade		INT PRIMARY KEY IDENTITY
	,NomeHabilidade		VARCHAR(200) NOT NULL
	,IdTipoHabilidade	INT FOREIGN KEY REFERENCES TipoHabilidade (IdTipoHabilidade)
);


CREATE TABLE Classe
(
	 IdClasse		INT PRIMARY KEY IDENTITY
	,NomeClasse		VARCHAR(200) NOT NULL
);


CREATE TABLE ClasseHabilidade
(
	 IdClasseHabilidade	INT PRIMARY KEY IDENTITY
	,IdHabilidade		INT FOREIGN KEY REFERENCES Habilidade (IdHabilidade)
	,IdClasse			INT FOREIGN KEY REFERENCES Classe     (IdClasse)
);


CREATE TABLE Personagem
(
	IdPersonagem		INT PRIMARY KEY IDENTITY
	,NomePersonagem		VARCHAR(200) NOT NULL
	,IdClasse			INT FOREIGN KEY REFERENCES Classe (IdClasse)
	,VidaMáxima			VARCHAR(100) NOT NULL
	,ManaMáxima			VARCHAR(80)  NOT NULL
	,DataAtualizacao	DATE
	,DataCriacao		DATE
);
CREATE TABLE TipoUsuario
(
	idTipoUsuario	INT PRIMARY KEY IDENTITY
	,TipoUsuario	VARCHAR (200) NOT NULL UNIQUE
)



CREATE TABLE Usuario
(
	idTipoUsuario	INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario)
	,idUsuario		INT PRIMARY KEY IDENTITY
	,nomeUsuario	VARCHAR(200) NOT NULL
	,email			VARCHAR(200) NOT NULL UNIQUE
	,senha			VARCHAR(200) NOT NULL

)
