# Coarev

O nome Coarev vem de um [artigo](https://cursoestudomemorizacao.com.br/memoria-psicologia/) de psicologia sobre a memória. São alguns dos processos psicológicos básicos:
- Codificação
- Armazenamento
- Evocação

## Actions tracker

> Este projeto é apenas para praticar um pouco com Blazor WASM, API e SQL.

### Idéia geral da aplicação

- Uma solução que permita contabilizar ações que fazemos repetidamente.
- Gerar um resumo de quantas vezes/tempo total a ação foi realizada em um determinado período.
- Algum controle de usuário/senha pra proteção dos dados.
- ações em modo privado? Não acessíveis automaticamente na visão padrão. (nice to have)
- classificação das ações por tags.
- permitir acrescentar anotações quando registrar ocorrencia de uma ação.
- Uma ação pode conter sub-ações (nice to have)
  - Exemplo: track de idas à academia (quantas vezes e tempo). Mas também permitir saber quais exercícios foram feitos (repetições/tempo).
- Permitir de definir unidade pro valor da ação (Km / copos / paginas / minutos)

### Iterações

Criar um usuário:
- Alias
- email
- senha

Criar uma ação para tracking:
- Descrição da ação
- Definir tipo de tracking:
  - Quantidade/valor
  - Tempo
  - Ambos
- Standard tags
- Unidade para Qt/Val
- Defaults
  - valor default
  - duração default

Criar um tracking:
- Entrar ação (a partir de uma lista)
- Detalhes de acordo com configuração da ação
  - Data-hora de início e fim
  - Valor
- Tags (já trazer as padrões)
- Anotação


### O que isso gera:

- Visualização em um formato de calendário
- Sumário das ações e respectivos totais dentro de um período de tempo
- Lista de todas as ações realizadas em um período de tempo, com o sumário.
- Permitir filtragem pelas tags

### Rascunho de um modelo de dados:

Users
- Id
- Alias
- Email
- Password

TrackTypes (not editable)
- Id
- TrackTypeDesc

Unities
- Id
- UnityDesc
- UsersId

Tags
- Id
- TagDesc
- UsersId

Actions
- Id
- ActionDesc
- TrackTypesId
- Quantity
- UnitiesId
- Duration
- TagList
- AllowSubActions
- IsArchived
- UsersId

Tracks
- Id
- ActionsId
- StartAt
- EndAt
- Quantity
- TagList
- Notes
- SubActions

### Rascunho de uma API (endpoints desing)

Users  
GET: /users/me  
POST: /users  
PUT: /users/me  
DELETE: /users/me  

TrackTypes  
GET: /tracktypes  

Unities  
GET: /unities  
GET: /unities/id  
POST: /unities  
PUT: /unities/id  
DELETE: /unities/id  

Tags  
GET: /tags  
POST: /tags  
PUT: /tags/id  
DELETE: /tags/id  

Actions  
GET: /actions  
GET: /actions/id  
POST: /actions  
PUT: /actions/id  
DELETE: /actions/id  

Tracks  
GET: /tracks  
GET: /tracks/id  
POST: /tracks  
PUT: /tracks/id  
DELETE: /tracks/id  
