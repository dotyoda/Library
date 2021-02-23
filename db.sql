-- CRIAÇÃO DO BANCO DE DADOS
CREATE DATABASE Library;

-- CRIAR TABELA LEITOR
CREATE TABLE [readers] (
    id int IDENTITY PRIMARY KEY,
    [name] NVARCHAR(200) NOT NULL,
    rg NVARCHAR(25) NOT NULL,
    [Phone] NVARCHAR(20),
    [Email] NVARCHAR(100)
);


-- CRIAR TABELA BIBLIOTECÁRIO
CREATE TABLE [librarians] (
    id int IDENTITY PRIMARY KEY,
    [name] NVARCHAR(200) NOT NULL,
    [Phone] NVARCHAR(20),
    [Email] NVARCHAR(100),
    [Username] NVARCHAR(50) NOT NULL UNIQUE,
    [Password] NVARCHAR(255) NOT NULL,
);

-- CRIAR TABELA LIVROS
CREATE TABLE [books] (
    isbn NVARCHAR(100) PRIMARY KEY,
    [title] NVARCHAR(200) NOT NULL,
    [author] NVARCHAR(150) NOT NULL,
    [numPages] INT,
    [publisher] NVARCHAR(100),
    [format] NVARCHAR(50),
    [price] MONEY DEFAULT 0.0,
    [quantity] INT DEFAULT 0,
);

-- CRIAR TABELA RESERVAS
CREATE TABLE [reservations] (
    id int IDENTITY PRIMARY KEY,
    [readerId] int,
    [bookId] NVARCHAR(100),
    checkoutIn DATE,
    [status] INT NOT NULL CHECK ([status] IN(0, 1, 2)),
    CONSTRAINT fk_reader_id FOREIGN KEY (readerId) REFERENCES [readers] (id),
    CONSTRAINT fk_book_id FOREIGN KEY (bookId) REFERENCES [books] (isbn)
);

-- CRIAR TABELA EMPRESTIMOS
CREATE TABLE [lendings] (
    id int IDENTITY PRIMARY KEY,
    [readerId] int NOT NULL,
    [bookId] NVARCHAR(100) NOT NULL,
    [checkout] DATE NOT NULL,
    [checkin] DATE,
    CONSTRAINT fk_lending_reader FOREIGN KEY (readerId) REFERENCES [readers] (id),
    CONSTRAINT fk_lending_book FOREIGN KEY (bookId) REFERENCES [books] (isbn)
);

-- CRIAR TABELA DE TRANSAÇÕES
CREATE TABLE [transactions] (
    id int IDENTITY PRIMARY KEY,
    [lendingId] int NOT NULL,
    [price] MONEY NOT NULL,
    [fine] MONEY,
    [createdAt] DATETIME NOT NULL,
    CONSTRAINT fk_transaction_lending FOREIGN KEY (lendingId) REFERENCES [lendings] (id)
);

-- INSERIR USUÁRIO PADRÃO
INSERT INTO [librarians]([name], [Username], [Password]) VALUES ('Admin', 'admin', 'admin');

-- EXECUTAR A CRIAÇÃO DAS VIEWS DE FORMA INDIVIDUAL

-- CRIAR VIEW PARA RELATÓRIO DE RESERVAS
CREATE VIEW vwReservation AS
SELECT RS.id, RS.checkoutIn, R.name, B.title FROM [reservations] AS RS INNER JOIN [readers] AS R ON RS.readerId = R.[id] INNER JOIN [books] AS B ON RS.bookId = B.isbn;

-- CRIA VIEW PARA RELATÓRIO DE EMPRÉSTIMOS
CREATE VIEW vwLending AS
SELECT 
    L.id,
    R.name,
    B.title,
    ISNULL(T.price + T.fine, 0) AS total,
    CASE
        WHEN (L.checkin <= '01/01/0001') THEN 'PENDENTE'
        ELSE 'CONCLUIDO'
    END  AS [status]
FROM [lendings] AS L 
INNER JOIN [readers] AS R ON L.readerId = R.[id] 
INNER JOIN [books] AS B ON L.bookId = B.isbn
LEFT JOIN [transactions] AS T ON T.lendingId = L.id;