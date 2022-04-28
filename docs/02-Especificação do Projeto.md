# Especificações do Projeto

## Personas

<table>
  <tr>
    <th>Foto</th>
    <th>Descrição</th>
    <th>Aplicativos</th>
    <th>Motivações</th>
    <th>Frustrações</th>
    <th>Hobbies, História</th>
  </tr>
  <tr>
    <td><img src="https://user-images.githubusercontent.com/81269204/161469622-9b978e9c-7657-4746-987f-09a212a40416.jpg" width="300px"/></td>
    <td>
      <ul>
        <li>Marcelo Rodrigues</li>
        <li>25 anos</li>
        <li>Analista de suporte em uma multinacional do setor de logística</li>
        <li>Mora em Divinópolis – MG</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Facebook</li>
        <li>Instagram</li>
        <li>LinkedIn</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Ajudar sua família.</li>
        <li>Sempre buscando inovações tecnológicas e aprender coisas novas.</li>
      </ul>
    </td>
    <td>
        Por não ter veículo próprio, gasta muito tempo se deslocando do trabalho para casa.
    </td>
    <td>
        Atualmente mora com seus pais na cidade de Divinópolis, formado em Sistemas de Informação, tem um filho de 3 anos. Nas horas vagas gosta de jogar jogos online e passear com seu filho.
    </td>
  </tr>
  <tr>
    <td><img src="https://user-images.githubusercontent.com/81269204/161470036-e19bb90b-1c30-409f-ae4c-db5463878c40.jpg" width="300px"/>
    </td>
    <td>
      <ul>
        <li>Thiago Feres</li>
        <li>36 anos</li>
        <li>Proprietário de um estacionamento</li>
        <li>Mora em São Paulo - SP</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Facebook</li>
        <li>Instagram</li>
        <li>WhatsApp</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Expandir seu empreendimento para uma rede de estacionamentos.</li>
        <li>Empreender e criar novos postos de trabalho.</li>
      </ul>
    </td>
    <td>
        Ter mais tempo livre e poder dedica-los as suas filhas e família.
    </td>
    <td>
        Formado em Administração de Empresas pela UNIFESP, casado e tem duas filhas gêmeas. Gosta de viajar com sua família, passear com suas filhas e esposa em parques, assistir futebol e fazer churrasco em família.
    </td>
  </tr>
  <tr>
    <td><img src="https://user-images.githubusercontent.com/81269204/161470050-ba91c385-7754-4203-888a-d7268b785626.jpg" width="300px"/></td>
    <td>
      <ul>
        <li>Magda Silva</li>
        <li>42 anos</li>
        <li>Professora em uma escola de ensino infantil</li>
        <li>Mora em Vitória - ES</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Instagram</li>
        <li>WhatsApp</li>
        <li>Pinterest</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Ajudar pessoas carentes.</li>
        <li>Evoluir no âmbito pessoal e espiritual.</li>
      </ul>
    </td>
    <td>
        Desigualdade social na cidade onde vive.
    </td>
    <td>
        Formada em Pedagogia, trabalha em uma escola de ensino infantil na cidade de Vitoria, solteira, possui um projeto social de apoio as famílias carentes e nas horas vagas gosta de passear com seu cachorro, praticar atividade física ao ar livre e sair com os amigos.
  </tr>
  <tr>
    <td><img src="https://user-images.githubusercontent.com/81269204/161469505-b939de82-a97e-455e-b826-87dcd52b4e8b.jpg" width="300px"/></td>
    <td>
      <ul>
        <li>Patrícia Pires</li>
        <li>14 anos</li>
        <li>Estudante do ensino fundamental</li>
        <li>Mora em Brasília – DF</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Instagram</li>
        <li>Youtube</li>
        <li>Tik Tok</li>
      </ul>
    </td>
    <td>
      <ul>
        <li>Ser jogadora profissional de handball.</li>
        <li>Criar um canal de sucesso no Youtube.</li>
      </ul>
    </td>
    <td>
        Não ter ganhado o campeonato estudantil de handball.
    </td>
    <td>
        Estudante do 9º ano do ensino fundamental, mora com seus pais em Brasília, adora praticar esportes, jogar jogos digitais, passear no shopping e assistir series.
    </td>
  </tr>
</table>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`     | QUERO/PRECISO ... `FUNCIONALIDADE`                          |PARA ... `MOTIVO/VALOR`                              |
|-------------------------|-------------------------------------------------------------|-----------------------------------------------------|
|Eu como Magda Silva      |Preciso de um painel com meu percentual de acertos           |Para acompanhar meu progresso no jogo.               |
|Eu como Marcelo Rodrigues|Quero convidar amigos                                        |Para compararmos os resultados e progressos no jogo. |
|Eu como Thiago Feres     |Quero visualizar com quantas tentativas eu acertei a palavra |Para melhorar minha estratégia no jogo.              |
|Eu como Patrícia Pires   |Quero poder resetar a palavra adivinhada                     |Para jogar mais e testar meu raciocínio logico.      |
|Eu como Marcelo Rodrigues|Quero visualizar as instruções de jogo                       |Para ficar mais fácil jogar.                         |
|Eu como Patrícia Pires   |Quero mudar o plano de fundo                                 |Para personalizar meu jogo.                          |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito                                           | Prioridade |
|------|------------------------------------------------------------------|------------|
|RF-001| O sistema deve conter uma tela de cadastro                       | ALTA       | 
|RF-002| O sistema deve conter a opção de logon                           | ALTA       |
|RF-003| A aplicação deve conter botão de configurações e ajustes         | MÉDIA      |
|RF-004| A aplicação deve conter painel para visualização de estatísticas | MÉDIA      |
|RF-005| O sistema deve ter painel para visualizar progresso no jogo      | MÉDIA      | 
|RF-006| O sistema deve conter botão para resetar a palavra de adivinhação| ALTA       |
|RF-007| O sistema deve conter painel com as instruções de jogo           | ALTA       |

### Requisitos não Funcionais

|ID     | Descrição do Requisito                                |Prioridade |
|-------|-------------------------------------------------------|-----------|
|RNF-001| A aplicação deverá ter o design amigável              |  ALTA     | 
|RNF-002| Deve processar requisições do usuário em no máximo 5s |  MÉDIA    | 
|RNF-003| A aplicação deve ser responsivo                       |  ALTA     | 
|RNF-004| A aplicação ficará disponivel 24 horas por dia        |  ALTA     | 
|RNF-005| O sistema será construído para rodar em ambiente web  |  MÉDIA    | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                                 |
|--|-----------------------------------------------------------|
|01| Primeira versão será lançada apenas Web                   |
|02| O sistema deve permitir apenas um cadastro por usuário    |
|03| O projeto deverá ser entregue até o final do semestre     |
