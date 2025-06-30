![image](https://github.com/user-attachments/assets/bff42400-653f-4763-acc7-e1e0b7e42f56)
# Metodologia <br>

<span style="color:red">Pré-requisitos: <a href="02-Especificacao.md"> Especificação do projeto</a></span>

Para abordar o desenvolvimento do sistema de gerenciamento da Academia Sigma, a equipe adotou metodologias ágeis, com foco no framework Scrum para organizar as entregas e promover a colaboração contínua entre os membros. A escolha por Scrum se deu por sua flexibilidade, capacidade de adaptação e ciclos curtos de entrega (Sprints), o que favoreceu a organização incremental do projeto.<br>


## Controle de versão <br>

A ferramenta de controle de versão adotada no projeto foi o [Git](https://git-scm.com/), sendo que o [GitHub](https://github.com) foi utilizado para hospedagem do repositório. <br>

O projeto segue a seguinte convenção para o nome de branches: <br>

- `main`: Versão principal e estável do sistema. Reúne as entregas consolidadas. <br>
- `Integracao_FrontEnd_Alunos`: Branch focada na integração entre as telas do front-end e os dados de alunos. <br>
- `Integracao_Telas_Frontend	`: Responsável pela construção e conexão das interfaces gráficas do sistema. <br>
- `Lista_e_Cadastro_Turmas`: Implementa funcionalidades de listagem e cadastro de turmas. <br>
- `Listagem_De_Frequencia	`: Contém a lógica de exibição das frequências dos alunos. <br>
- `Lucas-H	`: Branch onde o front-end foi inicialmente estruturado e publicado. Contém a base visual e os componentes principais da interface. <br>
- `Pedro	`: Branch do integrante Pedro, onde foram implementados: Plano de Testes de Software e Plano de Testes de Usabilidade. <br>
- `Versao-1.0 `: Primeira versão completa do sistema funcionando. Inclui funcionalidades principais, correções de layout e integração inicial. <br>
- `Versao-1.1	`: Segunda versão estável, com melhorias adicionais de usabilidade, ajustes visuais e refinamentos nas funcionalidades implementadas. <br>

  
Quanto à gerência de issues, o projeto adota a seguinte convenção para etiquetas: (TIRAR ESSA PARTE?)

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gestão de tags, merges, commits e branches é realizada. Discuta também como a gestão de issues foi feita.

> **Links úteis**:
> - [Documentação](https://docs.google.com/document/d/1iHhh2hjOmBgQGTWVt_aO8kXqRS3qxbHHrhcOum2YHgo/edit?usp=sharing) <br>
> - [Link Figma] (https://www.figma.com/design/YLEuOfqvxmMry87SxlO8mm/Black-Belt?node-id=0-1&p=f&t=VtBiJCURuEpvY7Ud-0) <br>
> - [Link Trello](https://trello.com/invite/b/6814ae14f3805d476e3b9e53/ATTI436aa969575c9c0f8c9370f0fef8ed8876D1B3AD/black-belt) <br>
> - [Github](https://github.com/ICEI-PUC-Minas-PCO-SI/2025-1-p5-tias-grupo3.git)<br>
> - [Link Caso de Teste](https://sgapucminasbr-my.sharepoint.com/personal/1452976_sga_pucminas_br/_layouts/15/guestaccess.aspx?share=EbYkJV8cdrpCg2ftZamBx1MBr_ypgZHEQDfnDPPJxNpvbg&e=ofIhjb )<br>

## Planejamento do projeto

###  Divisão de papéis

> Apresente a divisão de papéis entre os membros do grupo em cada Sprint. O desejável é que, em cada Sprint, o aluno assuma papéis diferentes na equipe. Siga o modelo do exemplo abaixo:

#### Sprint 1
- _Scrum master_: Vinicius
- Protótipos: Lucas e Vinicius
- Testes: Pedro e Rafael
- Documentação: Sandy e Bruna

#### Sprint 2
- _Scrum master_: Vinicius
- Desenvolvedor _front-end_: Lucas, Carolina e Bruna
- Desenvolvedor _back-end_: Carolina e Vinicius
- Testes: Pedro e Rafael

###  Quadro de tarefas

> Apresente a divisão de tarefas entre os membros do grupo e o acompanhamento da execução, conforme o exemplo abaixo.

#### Sprint 1 <br>

Atualizado em: 21/04/2024

| Responsável   | Tarefa/Requisito  | Iniciado em    | Prazo      | Status | Terminado em    |<br>
| :----         |    :----          |      :----:    | :----:     | :----: | :----:          |<br>
| Vinicius| Login  | 12/05/2025      | 30/06/2025                 | ✔️ | 05/02/2024      |<br>
| Vinicius e Lucas | CRUD de Usuários  | 12/05/2025 | 30/06/2025  | ✔️ | 05/02/2024      |<br>
| Lucas e Vinicius | CRUD de Turmas	  |28/05/2025 | 30/06/2025   | ✔️ |                 |<br>
| Pedro e Vinicius | CRUD de Alunos	  | 28/05/2025 | 30/06/2025   | ✔️ |                 |<br>
| Lucas e Pedro | Menu Principal	  | 12/05/2025| 30/06/2025     | ✔️  |       |<br>
| Caolina, Vinicius e Lucas   | Perfil do Aluno	 |30/06/2025 | 12/02/2005 | ✔️  |       |<br>
| Bruna e Vinicius| Registrar Presença| 28/05/2025| 30/06/2025   | ✔️  |       |<br>
| Vinicus | Modificar estrutura do banco | 29/05/2025| 30/06/2025 | ✔️  |       |<br>

#### Sprint 2 <br>

Atualizado em: 21/04/2024

| Responsável   | Tarefa/Requisito | Iniciado em    | Prazo      | Status | Terminado em    | <br>
| :----         |    :----         |      :----:    | :----:     | :----: | :----:          | <br>
| AlunaX        | 	Integração Login   | 01/02/2024     |30/06/2025 | ✔️    | 05/02/2024      |<br>
| AlunaZ        |Integração Home	    | 03/02/2024     | 30/06/2025 | ✔️    |                 | <br>
| AlunoY        | Integração Turmas	  | 01/02/2024     | 30/06/2025 | ✔️    |                 |<br>
| AlunoK        |Integração Usuários	  |  01/01/2024    | 30/06/2025 | ✔️  |                 |<br>
| AlunoK        |Integração Alunos		  |  01/01/2024    | 30/06/2025 | ✔️  |                 |<br>
| Bruna         |Registrar Aula	        |  01/01/2024    | 30/06/2025 | ✔️  |                 |<br>
| AlunoK        |Ajuste exclusão de turmas         	  |  30/06/2025    | 12/03/2024 | ✔️ |                 |<br>
| AlunoK        |Ajuste exclusão de alunos		  |  30/06/2025    | 12/03/2024 | ✔️  |                 |<br>
| AlunoK        |	Documentação de testes		  |  30/06/2025    | 12/03/2024 | ✔️  |                 |<br>
| Carolina      |Pop-ups (opcional)			  |  27/06/2025 | 30/06/2025 | ✔️ |                 |<br>
| AlunoK        |Ajuste na frequência			  |  30/06/2025    | 30/06/2025 | ✔️ |                 |<br>
| AlunoK        | Atualizar banco com exclusão			  | 30/06/2025  | 30/06/2025 | ✔️ |                 |<br>
| Carolina       | Ajustar os filtros de pesquisa		  | 27/06/2025  | 30/06/2025 | ✔️ |                 |<br>





Legenda:
- ✔️: terminado
- 📝: em execução
- ⌛: atrasado
- ❌: não iniciado




### Processo

Coloque informações sobre detalhes da implementação do Scrum seguido pelo grupo. O grupo deverá fazer uso do recurso de gerenciamento de projeto oferecido pelo GitHub, que permite acompanhar o andamento do projeto, a execução das tarefas e o status de desenvolvimento da solução.


## Relação de ambientes de trabalho

Os artefatos do projeto são desenvolvidos a partir de diversas plataformas. Todos os ambientes e frameworks utilizados no desenvolvimento da aplicação estão listados na seção abaixo.

### Ferramentas

Liste todas as ferramentas que foram empregadas no projeto, justificando a escolha delas, sempre que possível.

Exemplo: os artefatos do projeto são desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito é apresentada na tabela que se segue.

| Ambiente                            | Plataforma                         | Link de acesso                         |
|-------------------------------------|------------------------------------|----------------------------------------|
| Repositório de código fonte         | GitHub                             | https://github.com/ICEI-PUC-Minas-PCO-SI/2025-1-p5-tias-grupo3.git|<br>
| Documentos do projeto               | Google Docs                        | https://docs.google.com/document/d/1iHhh2hjOmBgQGTWVt_aO8kXqRS3qxbHHrhcOum2YHgo/edit?usp=sharing |<br>
| Link Figma                          | Figma                              | https://www.figma.com/design/YLEuOfqvxmMry87SxlO8mm/Black-Belt?node-id=0-1&p=f&t=VtBiJCURuEpvY7Ud-0| <br>
| Link Caso de Teste                  | Word                               | https://sgapucminasbr my.sharepoint.com/personal/1452976_sga_pucminas_br/_layouts/15/guestaccess.aspx?share=EbYkJV8cdrpCg2ftZamBx1MBr_ypgZHEQDfnDPPJxNpvbg&e=ofIhjb  | <br>
| Hospedagem - Explicação sobre a hospedagem no Tópico 7 – Arquitetura de Solução |
 
