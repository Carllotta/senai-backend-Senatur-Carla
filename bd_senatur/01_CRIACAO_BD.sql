--DDL
CREATE DATABASE  Senatur_Manha;

USE  Senatur_Manha;

CREATE TABLE Pacotes(
id_Pacote INT PRIMARY KEY IDENTITY,
NomePacote VARCHAR (255) NOT NULL,
Descricao TEXT,
DataIda DATE NOT NULL,
DataVolta DATE NOT NULL,
Valor DECIMAL NOT NULL,
Ativo BIT NOT NULL,
NomeCidade VARCHAR (255) NOT NULL
);

CREATE TABLE TiposUsuarios(
id_TipoUsuario INT PRIMARY KEY IDENTITY,
Titulo VARCHAR (255) NOT NULL UNIQUE
);

CREATE TABLE  Usuarios(
id_Usuario INT PRIMARY KEY IDENTITY, 
Email VARCHAR (255) NOT NULL UNIQUE,
Senha VARCHAR (255) NOT NULL,
fk_TipoUsuario INT FOREIGN KEY REFERENCES TiposUsuarios(id_TipoUsuario)
);