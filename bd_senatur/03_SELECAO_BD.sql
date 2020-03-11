USE  Senatur_Manha;

-- Selects gerais de todas as tabelas:
SELECT * FROM Pacotes;
SELECT * FROM TiposUsuarios;
SELECT * FROM Usuarios;

-- trazer dados do usuário e o título do seu tipo de Usuário
SELECT U.id_Usuario, U.Email, U.fk_TipoUsuario, TU.Titulo FROM Usuarios U
INNER JOIN TiposUsuarios TU
ON U.fk_TipoUsuario = TU.id_TipoUsuario;
GO

-- buscar um usuário por email e senha  
SELECT U.id_Usuario, U.Email, U.fk_TipoUsuario, TU.Titulo FROM Usuarios U
INNER JOIN TiposUsuarios TU
ON U.fk_TipoUsuario = TU.id_TipoUsuario
WHERE Email = 'admin@admin.com' AND Senha = 'admin';
GO

-- Listar todos os pacotes
SELECT * FROM Pacotes;

-- seleceionar um pacote através do seu ID
SELECT * FROM Pacotes
WHERE id_Pacote = 1;

-- Listar somente pacotes ATIVOS
SELECT * FROM Pacotes
WHERE Ativo = 1;

-- Listar somente pacotes INATIVOS
SELECT * FROM Pacotes
WHERE Ativo = 2;

-- Listar pacotes somentes de uma determinada Cidade
SELECT * FROM Pacotes
WHERE NomeCidade = 'São Paulo';

-- Listar pacotes com ordenação DECRESCENTE através do preço
SELECT * FROM Pacotes
ORDER BY Valor desc;

-- Listar pacotes com ordenação CRESCENTE através do preço
SELECT * FROM Pacotes
ORDER BY Valor DESC;