# Modelagem dos processos de negócio<br>

<span style="color:red">Pré-requisitos: <a href="02-Especificacao.md"> Especificação do projeto</a></span>

## Modelagem da situação atual (Modelagem AS IS)<br>

Atualmente, o controle de frequência e acompanhamento técnico dos alunos de Jiu-jitsu na Academia Sigma é realizado manualmente, com utilização de: <br>
- Planilhas impressas para registro de presença, preenchidas em cada aula pelo instrutor. <br>
- Cadernos ou fichas físicas onde os instrutores anotam observações sobre o desempenho técnico de cada aluno, como golpes aprendidos ou dificuldades específicas.<br>
- Comunicação verbal ou via WhatsApp entre instrutores e gestão para compartilhar informações sobre evolução ou faltas recorrentes dos alunos.<br>
- Controle de matrículas e turmas realizado pela secretária por meio de planilhas digitais simples no computador da recepção, sem integração com relatórios de frequência ou evolução. <br>

## Descrição geral da proposta (Modelagem TO BE)

Tendo identificado os gargalos dos modelos AS-IS, apresentem uma descrição da proposta de solução, buscando maior eficiência com a introdução da tecnologia. Abordem também os limites dessa solução e seu alinhamento com as estratégias e objetivos do contexto de negócio escolhido.

Cole aqui os modelos da solução proposta (modelo TO-BE), elaborados com o apoio da ferramenta baseada em BPMN utilizada na disciplina. Cada processo identificado deve ter seu modelo TO-BE específico. Descrevam as oportunidades de melhoria de cada processo da solução proposta.

Apresente aqui uma descrição da sua proposta, abordando seus limites e suas ligações com as estratégias e objetivos do negócio. Apresente também as oportunidades de melhoria.

## Modelagem dos processos

[PROCESSO 1 - Nome do processo](./processes/processo-1-nome-do-processo.md "Detalhamento do processo 1.")

[PROCESSO 2 - Nome do processo](./processes/processo-2-nome-do-processo.md "Detalhamento do processo 2.")


## Indicadores de desempenho

Apresente aqui os principais indicadores de desempenho e algumas metas para o processo. Atenção: as informações necessárias para gerar os indicadores devem estar contempladas no diagrama de classe. Coloque no mínimo 5 indicadores.

Use o seguinte modelo:

| **Indicador** | **Objetivos** | **Descrição** | **Fonte de dados** | **Fórmula de cálculo** |
| ---           | ---           | ---           | ---             | ---             |
| Percentual de reclamações | Avaliar quantitativamente as reclamações | Percentual de reclamações em relação ao total de atendimentos | Tabela Reclamações | número total de reclamações / número total de atendimentos |
| Taxa de requisições atendidas | Melhorar a prestação de serviços medindo a porcentagem de requisições atendidas| Mede a % de requisições atendidas na semana | Tabela Solicitações | (número de requisições atendidas / número total de requisições) * 100 |
| Taxa de entrega de material | Manter controle sobre os materiais que estão sendo entregues | Mede % de material entregue dentro do mês | Tabela Pedidos | (número de pedidos entregues / número total de pedidos) * 100 |


Obs.: todas as informações necessárias para gerar os indicadores devem estar no diagrama de classe a ser apresentado posteriormente.
