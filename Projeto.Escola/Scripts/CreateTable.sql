create table Endereco (
	IdEndereco int identity(1,1) primary key,
	Rua nvarchar(50) not null,
	Numero int not null,
	Cep nvarchar(20) not null,
	Complemento nvarchar(50) not null
);

create table Professor (
	IdFuncionario int identity(1,1) primary key,
	Nome nvarchar(50) not null,
	Salario decimal(18,2) not null,
	IdEndereco int not null,
	Disciplina nvarchar(20) not null,
	foreign key (IdEndereco) references Endereco(IdEndereco)
);

create table Turma (
	IdTurma int identity(1,1) primary key,
	Codigo nvarchar(20) not null
);

create table Aluno (
	IdAluno int identity(1,1) primary key,
	Nome nvarchar(50) not null,
	Idade int not null,
	Matricula nvarchar(20) not null,
	foreign key (IdAluno) references Aluno(IdAluno)
)


