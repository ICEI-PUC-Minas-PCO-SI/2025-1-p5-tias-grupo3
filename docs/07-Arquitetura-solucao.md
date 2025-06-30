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

![image](https://github.com/user-attachments/assets/8935696c-479c-414d-bafe-04dccebbd5b0)


### Benefícios da Arquitetura <br>
- Manutenção facilitada (separação clara de responsabilidades) <br>
- Escalabilidade (possibilidade de integração futura com outras modalidades e funcionalidades) <br>
- Segurança e desempenho adequados ao ambiente acadêmico e de gestão da academia <br>

## Diagrama de classes


![image](https://github.com/user-attachments/assets/72891e1e-2471-4527-854a-9dc022ef1b72)


##  Modelo de dados

![image](https://github.com/user-attachments/assets/ada56f3b-d165-4c95-81bf-b0de38b8c236)


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



## Hospedagem

Atualmente, a hospedagem e o lançamento da plataforma ainda não foram realizados, pois o cliente (Academia Sigma) está em processo de análise para definição da melhor opção de ambiente que gere o menor custo possível.

A escolha da hospedagem será feita considerando fatores como viabilidade financeira, segurança, escalabilidade e suporte técnico, de forma a garantir que o sistema seja implantado em um ambiente que atenda às necessidades operacionais da academia sem comprometer o orçamento disponível. Assim que a decisão for concluída, será realizado o processo de configuração do servidor, publicação da aplicação e treinamento dos usuários finais para utilização plena da solução.


## Qualidade de software

A demanda por um sistema de gestão de desempenho dos alunos para a academia está diretamente relacionada ao Objetivo de Desenvolvimento Sustentável (ODS) 9 - Indústria, Inovação e Infraestrutura, proposto pela ONU. Esse objetivo incentiva a inovação e a modernização dos processos para tornar as empresas mais eficientes e sustentáveis.   

Ao implementar um sistema automatizado para gestão de desempenho dos alunos, a academia promoverá o uso da tecnologia para melhorar sua infraestrutura e otimizar a gestão de recursos. Isso pode contribuir para um ambiente mais organizado, melhor planejamento dos horários e alocação de profissionais, além de reduzir desperdícios operacionais.   

Além disso, esse projeto também dialoga com o ODS 3 - Saúde e Bem-Estar, pois a análise dos dados de frequência pode ajudar a academia a incentivar hábitos mais saudáveis entre os alunos e possibilitar um maior desenvolvimento dentro da arte marcial. Permitindo os mestres orientadores serem mais precisos em suas aulas, identificando padrões de comparecimento e criando estratégias para reduzir a evasão e aumentar o engajamento na prática de atividades físicas. 
