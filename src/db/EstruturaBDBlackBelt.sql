use DBBlackBelt;
create table Usuarios(
	Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
	CPF NVARCHAR(11) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Telefone NVARCHAR(11),
	Dt_Nascimento date,
	Tipo_Usuario int not null,
);

create table _Login(
	Id INT PRIMARY KEY IDENTITY(1,1),
    Id_Usuario int NOT NULL,
	Senha NVARCHAR(15) NOT NULL,
	Perfil NVARCHAR(100) NOT NULL,
	Dt_Login date,
	Host nvarchar(10)
);

create table Alunos(
	Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
	CPF NVARCHAR(11) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Telefone NVARCHAR(11),
	Dt_Nascimento date,
	Nivel_Faixa int,
	Dt_Matricula date not null,
);

CREATE TABLE Turmas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Instrutor int not null,
	Horario nvarchar(4) not null,
	Status_Turma int not null,
    CONSTRAINT FK_Instrutor FOREIGN KEY (Instrutor) REFERENCES Usuarios(Id)
);

create table Aulas(
	Id INT PRIMARY KEY IDENTITY(1,1),
    Id_Turma int not null,
	Id_Aluno int not null,
	Dt_Aula date,
	Presenca int not null
);

CREATE TABLE ProgressoGeral (
    Id_Aluno int NOT NULL,
    Dt_Avaliacao date,
	Desempenho_Medio float,
    CONSTRAINT FK_Aluno FOREIGN KEY (Id_Aluno) REFERENCES Alunos(Id)
);

CREATE TABLE Faixas (
    Id int PRIMARY KEY IDENTITY(1,1),
    Nome nvarchar(50)
);

CREATE TABLE Habilidades (
    Id int PRIMARY KEY IDENTITY(1,1),
    Nome nvarchar(50),
	Descricao nvarchar(200)
);

create table HabilidadeAluno (
	Id_Aluno int not null,
	Id_Habilidade int not null
	CONSTRAINT FK_Aluno FOREIGN KEY (Id_Aluno) REFERENCES Alunos(Id),
	CONSTRAINT FK_Habilidade FOREIGN KEY (Id_Habilidade) REFERENCES Habilidades(Id)
);

