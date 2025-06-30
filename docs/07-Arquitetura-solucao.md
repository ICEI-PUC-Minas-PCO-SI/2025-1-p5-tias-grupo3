# Arquitetura da solução

<span style="color:red">Pré-requisitos: <a href="05-Projeto-interface.md"> Projeto de interface</a></span>

A solução proposta foi estruturada utilizando a arquitetura MVC (Model-View-Controller), garantindo separação clara de responsabilidades e melhor organização do código para manutenção futura. O sistema será desenvolvido como uma aplicação web, acessível por diferentes dispositivos (desktop, tablet e smartphone).

### Componentes da Solução 
1. Front-end (View – Camada de Apresentação) <br>
Descrição: <br>
Responsável pela interface com o usuário (gestores, instrutores e secretários), permitindo a interação direta com as funcionalidades do sistema de forma intuitiva e responsiva.

Tecnologias Utilizadas: <br>

HTML5 <br>
CSS3 <br>
Bootstrap <br>

2. Back-end (Controller – Camada de Lógica de Negócio) <br>
Descrição: <br>
Gerencia a lógica do sistema, processamento de regras de negócio, autenticação de usuários e validação de dados, conectando a interface ao banco de dados. <br>

Tecnologias Utilizadas: <br>

Linguagem: C# <br>
Framework: ASP.NET MVC (Model-View-Controller) <br>
Plataforma: .NET <br>

3. Banco de Dados (Model – Camada de Dados)
Descrição:<br>
Responsável pelo armazenamento seguro e consistente de todas as informações, incluindo cadastros, registros de frequência e dados técnicos dos alunos. <br>

Tecnologia Utilizada:
Banco de Dados Relacional: SQL Server <br>

## Ambiente de Hospedagem
O ambiente de hospedagem previsto para a aplicação é composto por: <br>

Servidor Web:<br>
Hospedagem do sistema ASP.NET MVC em ambiente compatível com .NET, podendo ser um servidor IIS (Internet Information Services) local ou cloud.

Servidor de Banco de Dados: <br>
Hospedado em instância SQL Server, localmente ou em nuvem, garantindo acesso seguro às tabelas do sistema. <br>

Acesso ao Sistema: <br>
Realizado por meio de navegador web em dispositivos desktop ou mobile, com autenticação de usuário e controle de permissões por perfil (gestor, instrutor, secretária). <br>

### Benefícios da Arquitetura <br>
- Manutenção facilitada (separação clara de responsabilidades) <br>
- Escalabilidade (possibilidade de integração futura com outras modalidades e funcionalidades) <br>
- Segurança e desempenho adequados ao ambiente acadêmico e de gestão da academia <br>

## Diagrama de classes


![image](https://github.com/user-attachments/assets/72891e1e-2471-4527-854a-9dc022ef1b72)


##  Modelo de dados

O desenvolvimento da solução proposta requer a existência de bases de dados que permitam realizar o cadastro de dados e os controles associados aos processos identificados, assim como suas recuperações.

Utilizando a notação do DER (Diagrama Entidade-Relacionamento), elabore um modelo, usando alguma ferramenta, que contemple todas as entidades e atributos associados às atividades dos processos identificados. Deve ser gerado um único DER que suporte todos os processos escolhidos, visando, assim, uma base de dados integrada. O modelo deve contemplar também o controle de acesso dos usuários (partes interessadas nos processos) de acordo com os papéis definidos nos modelos do processo de negócio.

Apresente o modelo de dados por meio de um modelo relacional que contemple todos os conceitos e atributos apresentados na modelagem dos processos.


### Modelo físico

Insira aqui o script de criação das tabelas do banco de dados.

Veja um exemplo:

```sql
-- Criação da tabela Medico
CREATE TABLE Medico (
    MedCodigo INTEGER PRIMARY KEY,
    MedNome VARCHAR(100)
);

-- Criação da tabela Paciente
CREATE TABLE Paciente (
    PacCodigo INTEGER PRIMARY KEY,
    PacNome VARCHAR(100)
);

-- Criação da tabela Consulta
CREATE TABLE Consulta (
    ConCodigo INTEGER PRIMARY KEY,
    MedCodigo INTEGER,
    PacCodigo INTEGER,
    Data DATE,
    FOREIGN KEY (MedCodigo) REFERENCES Medico(MedCodigo),
    FOREIGN KEY (PacCodigo) REFERENCES Paciente(PacCodigo)
);

-- Criação da tabela Medicamento
CREATE TABLE Medicamento (
    MdcCodigo INTEGER PRIMARY KEY,
    MdcNome VARCHAR(100)
);

-- Criação da tabela Prescricao
CREATE TABLE Prescricao (
    ConCodigo INTEGER,
    MdcCodigo INTEGER,
    Posologia VARCHAR(200),
    PRIMARY KEY (ConCodigo, MdcCodigo),
    FOREIGN KEY (ConCodigo) REFERENCES Consulta(ConCodigo),
    FOREIGN KEY (MdcCodigo) REFERENCES Medicamento(MdcCodigo)
);
```
Esse script deverá ser incluído em um arquivo .sql na pasta [de scripts SQL](../src/db).


## Tecnologias

Descreva qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.


| **Dimensão**   | **Tecnologia**  |
| ---            | ---             |
| Front-end      | HTML + CSS + JS + React |
| Back-end       | Node.js         |
| SGBD           | MySQL           |
| Deploy         | Vercel          |


## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foram realizados.

> **Links úteis**:
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando seu site no Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)

## Qualidade de software

Conceituar qualidade é uma tarefa complexa, mas ela pode ser vista como um método gerencial que, por meio de procedimentos disseminados por toda a organização, busca garantir um produto final que satisfaça às expectativas dos stakeholders.

No contexto do desenvolvimento de software, qualidade pode ser entendida como um conjunto de características a serem atendidas, de modo que o produto de software atenda às necessidades de seus usuários. Entretanto, esse nível de satisfação nem sempre é alcançado de forma espontânea, devendo ser continuamente construído. Assim, a qualidade do produto depende fortemente do seu respectivo processo de desenvolvimento.

A norma internacional ISO/IEC 25010, que é uma atualização da ISO/IEC 9126, define oito características e 30 subcaracterísticas de qualidade para produtos de software. Com base nessas características e nas respectivas subcaracterísticas, identifique as subcaracterísticas que sua equipe utilizará como base para nortear o desenvolvimento do projeto de software, considerando alguns aspectos simples de qualidade. Justifique as subcaracterísticas escolhidas pelo time e elenque as métricas que permitirão à equipe avaliar os objetos de interesse.

> **Links úteis**:
> - [ISO/IEC 25010:2011 - Systems and Software Engineering — Systems and Software Quality Requirements and Evaluation (SQuaRE) — System and Software Quality Models](https://www.iso.org/standard/35733.html/)
> - [Análise sobre a ISO 9126 – NBR 13596](https://www.tiespecialistas.com.br/analise-sobre-iso-9126-nbr-13596/)
> - [Qualidade de software - Engenharia de Software](https://www.devmedia.com.br/qualidade-de-software-engenharia-de-software-29/18209)
