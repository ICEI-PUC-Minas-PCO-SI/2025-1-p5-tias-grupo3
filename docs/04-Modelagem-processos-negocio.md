# Modelagem dos processos de negócio<br>

<span style="color:red">Pré-requisitos: <a href="02-Especificacao.md"> Especificação do projeto</a></span>

## Modelagem da situação atual (Modelagem AS IS)<br>

Atualmente, o controle de frequência e acompanhamento técnico dos alunos de Jiu-jitsu na Academia Sigma é realizado manualmente, com utilização de: <br>
- Planilhas impressas para registro de presença, preenchidas em cada aula pelo instrutor. <br>
- Cadernos ou fichas físicas onde os instrutores anotam observações sobre o desempenho técnico de cada aluno, como golpes aprendidos ou dificuldades específicas.<br>
- Comunicação verbal ou via WhatsApp entre instrutores e gestão para compartilhar informações sobre evolução ou faltas recorrentes dos alunos.<br>
- Controle de matrículas e turmas realizado pela secretária por meio de planilhas digitais simples no computador da recepção, sem integração com relatórios de frequência ou evolução. <br>

### Problemas identificados no processo atual
- Alto risco de perda ou extravio de informações registradas em papel. <br>
- Falta de integração entre frequência, matrícula e evolução técnica dos alunos. <br>
- Retrabalho constante, pois dados registrados em papel precisam ser transcritos para planilhas digitais posteriormente. <br>
- Dificuldade de acesso rápido a informações estratégicas pelos gestores, como alunos com baixa frequência ou evolução estagnada.<br>
- Dependência de múltiplos arquivos e cadernos, gerando desorganização e falhas de comunicação.<br>

## Descrição geral da proposta (Modelagem TO BE)

A solução proposta consiste na implantação de um sistema web integrado que automatiza o registro de frequência, cadastro de alunos, turmas e acompanhamento técnico individual, permitindo acesso simultâneo por gestores, instrutores e secretários. Com isso, os dados passam a ser armazenados em banco de dados relacional, garantindo segurança, integridade e facilidade de consulta.

### Principais mudanças e oportunidades de melhoria
- Eliminação do registro manual em papel, substituindo por registro direto no sistema via notebook, tablet ou smartphone. <br>
- Integração dos cadastros de alunos, frequência, turmas e evolução técnica, possibilitando emissão de relatórios automáticos.<br>
- Acesso rápido a indicadores de desempenho e frequência, apoiando a gestão pedagógica e administrativa.<br>
- Comunicação facilitada entre secretários, gestores e instrutores por meio do sistema centralizado.<br>

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
