Bootcamp | PneuStore <a name="Aqui"></a>
![Badge](https://img.shields.io/date/1630014400)
================

![Swagger Methods](https://i.imgur.com/45aCtO9.png)


📖 Conheça o projeto
================
<!--ts-->
* [Qual é o propósito deste projeto?](#Propósito)
* [Sobre o desenvolvimento back-end](#Back-End)
     * [Tecnologias utilizadas](#Tecnologias)
     * [Como baixar o back-end](#DownloadBKE)
     * [Como utilizar o back-end](#Usar)
* [Funcionalidades](#Funcionalidades)
* [Sobre o desenvolvimento front-end](#Front-End)
     * [Tecnologias utilizadas](#TecnologiasFront)
     * [Como baixar o front-end](#DownloadFTE)
     * [Como utilizar o projeto](#UsarFTE)
* [Nossas soluções para o checkout](#Soluções)
     * [Layout](#Layout)
     * [Barra de progresso](#Barra-de-Progresso)
     * [Destaque](#Destaque)
     * [Modal para endereços](#Modal-Endereços)
     * [Render otimizado](#Render-Otimizado)
* [Equipe e gerenciamento do projeto](#Gerenciamento)
* [Metodologia Kanban](#Kanban)
* [Versionamento de código e branches](#GitHub)
* [Server no Discord](#Discord)
* [Nossos agradecimentos](#Agradecimentos)
<!--te-->



⁉️ Qual é o propósito deste projeto? <a name="Propósito"></a>
================

Nosso cliente, o **Grupo Level**, entendendo o potencial que possui com o seu grande diferencial de serviço de venda de pneus através da [PneuStore](https://www.pneustore.com.br/), solicitou o desenvolvimento de um MVP para o ckeckout de vendas do site e do mobile que seja campeão em conversões, aprimorando o que já está em produção atualmente, destacando os seus serviços diferenciados:

### 🚙 Móvel
*Uma van que instala o pneu no endereço escolhido pelo cliente nas regiões de atuação.*

### 🏛️ Parceiro
*O cliente escolhe em qual oficina parceira o serviço deve ser feito.*


🏗️ Sobre o desenvolvimento back-end <a name="Back-End"></a>
================

### Tecnologias utilizadas <a name="Tecnologias"></a>

🖱️ C# 
💻 .NET
💠 VisualStudio

### Como baixar o back-end <a name="DownloadBKE"></a>

O código deste projeto está disponível para download, em arquivo .zip, aqui mesmo no Github. Basta clicar em "Code" depois em "Download Zip". :octocat: 

![DownloadBackEnd](https://i.imgur.com/cuJ7fUP.png)

### Como utilizar o back-end <a name="Usar"></a>

O projeto todo de back-end está na nuvem, hospedado no AZURE, através deste link: ☁️ [https://equipe2-pneustore.azurewebsites.net](https://equipe2-pneustore.azurewebsites.net)
☁️ que qualquer aplicação front-end pode consumir.

Para testar apenas o back-end, basta fazer o [Download do Postman](https://www.postman.com/downloads/) e utilizar os endpoints, métodos e JSONs [mostrados aqui](#Aqui) e [aqui](#Funcionalidades).


🔆 Funcionalidades <a name="Funcionalidades"></a>
================

- [x] Registro de Usuários <a name="Aqui"></a>
- [x] Token de Autenticação para Usuários
- [x] Consulta de Categorias
- [x] CRUD de Clientes
- [x] Consulta de Parceiros
- [x] Consulta e Cadastro de Pneus

![Postman](https://i.imgur.com/pxxDPaN.png)

⚒️ Sobre o desenvolvimento front-end <a name="Front-End"></a>
================

### Tecnologias utilizadas <a name="TecnologiasFront"></a>

⚛️ React
💢 SCSS
🆚 Visual Studio Code

### Como baixar o front-end <a name="DownloadFTE"></a>

Basta seguir o mesmo passo informado do download do back-end, através deste repositório:

        https://github.com/vitorlombardi/PneuStore-BTC

Se você não lembra como fazer o download, basta [ver aqui](#DownloadBKE).

### Como utilizar o projeto <a name="UsarFTE"></a>

No diretório do projeto você pode executar o comando a seguir para baixar as dependências so projeto: 

        npm install

Após esta etapa, execute o comando a seguir para começar:

        npm start

A aplicação de front-end está disponível no VERCEL, através do link: [https://pneu-store-btc.vercel.app/](https://pneu-store-btc.vercel.app/)


# 💹 Nossas Soluções para o Checkout <a name="Soluções"></a>

   * 🏁 Layout <a name="Layout"></a>
   
   Limpo e mantendo sempre o carrinho de compras do lado direito da tela, dando fluidez.

   ![Layout](https://i.imgur.com/i8b8D9r.png)

   * 🤩 Barra de Progresso <a name="Barra-de-Progresso"></a>
   
   Incluímos um "Wizard", indicando as etapas do processo de compras e em qual delas o cliente está. Dessa forma o cliente não se sente perdido e evita que ele desista da compra.
   
   ![Wizard](https://i.imgur.com/NrI6drO.png)

   * 🆕 Destaque dos Serviços <a name="Destaque"></a>
   
   Neste momento em que o cliente insere o seu CEP, temos o destaque dos serviços da PneuStore para a Montagem Móvel no primeiro card e para a montagem em um Parceiro no segundo card.
   
   ![Destaques](https://i.imgur.com/nyRNxze.png)

   * 👀 Modal de Endereços <a name="Modal-Endereços"></a>
   
   A ideia de inserir um modal para o endereço, já com outras informações como data de agendamento do serviço / entrega, é ideal para gerar um gatilho no cliente de que esse passo é um informação complementar necessária, mas evita de poluir a tela com mais cards.
   
   ![ModalEndereços](https://i.imgur.com/wcjpAtr.png)

   * ▶️ Render Otimizado <a name="Render-Otimizado"></a>
   
   O desenvolvimento com o React possibilita aplicações que recarregam informações de atualização na página em tempo real, sem a necessidade de um recarregamento da página, como acontece na aplicação atual. O recarregamento pode impactar em perda de vendas por diversos fatores, como por exemplo uma perda de conexão ou falha no carregamento. Não é possível mostrar como fica isso através de uma foto, então que tal fazer o teste na aplicação? 🛫  


🧩 Equipe e Gerenciamento do Projeto <a name="Gerenciamento"></a>
================

Utilizamos o Scrum, uma metologia ágil bastante presente hoje e dia nas organizações, principlamente em times de projetos em TI. Nosso time, então, seguiu a seguinte formatação:

[![EduMeirelles](https://i.imgur.com/P8MxiV4.png)](https://github.com/edumeirelles)
[![Josucka](https://i.imgur.com/WUDSy7y.png)](https://github.com/Josucka)
[![CodeThales](https://i.imgur.com/ba5g1d3.png)](https://github.com/CodeThales)
[![EduTeodoro](https://i.imgur.com/t8YKd7j.png)](https://github.com/GHEPT)
[![VictorLombardi](https://i.imgur.com/MSr8ZHw.png)](https://github.com/vitorlombardi)
[![IgorPrati](https://i.imgur.com/lgRs6Sb.png)](https://github.com/igorprati)

🕋 Metodologia Kanban <a name="Kanban"></a>
================

[![Notion_Kanban](https://i.imgur.com/SjWLVA6.png)](https://www.notion.so/45233b2ccaaa42ee996ccb6a0c510384?v=293f797e8aa3445f8d24eef331f6072c)

A ferramenta de gerenciamento de tarefas que utilizamos neste projeto foi o 🗒️ Notion. Durante as dailys com o time o Scrum Master incluia tarefas para o dia e assim fomos avançando semana a semana.

🥇 Versionamento de Código e Branches <a name="GitHub"></a>
================

[![Github](https://i.imgur.com/KsfhdEd.png)](https://github.com/GHEPT/btc-pneustore-api)

Na nossa equipe temos integrantes que já estão no mercado de trabalho dev e, graças a eles, pudemos replicar as boas práticas de versionamento de código do mercado de trabalho, usando duas branches: uma dev e outra main. Também fizemos o uso do recurso "fork" do github, de onde comitamos as atualizações para a nuvem da nossa aplicação. 🤙 
O time se adaptou muito fácil e o versionamento aconteceu sem maiores problemas, com mais de 60 commits no back-end e sem qualquer conflito em merges!! ✈️

💻 Server no Discord <a name="Discord"></a>
================

![Discord](https://i.imgur.com/4VzqxbZ.png)

Não podia faltar o nosso querido Discord! Criamos um server para que o assunto pudesse fluir fora dos horários de aula e também o usamos para compartilhar pontos importantes para o desenvolvimento do projeto, com canais como: backlog, git, bugs, po_information, react, csharp... 🎉

㊗️ Nossos Agradecimentos <a name="Agradecimentos"></a>
================

Somos gratos a todos os envolvidos nesse bootcamp que nos proporcionou uma oportunidade de vivenciar uma rotina real de DEV, somando mais um tijolinho na construçao da nossa carreira, dando uma bagagem muito bacana pra nós, devs juniores!

[![BLUEEDTECH](https://i.imgur.com/PUFuODa.gif)](https://blueedtech.com.br/)

💙 **Blue Edtech**

[![GrupoLevel](https://i.imgur.com/xuo0up0.png)](https://www.grupolevel.com.br/empresas)

💜 **Grupo Level | PneuStore**

[![Violigon](https://i.imgur.com/cUUEiiY.png)](https://github.com/violigon)

🧠 **Vinícius Oliveira Gonçalves | Ele, o Brabo do Bootcamp!**

[![ThiCode](https://i.imgur.com/camnUvJ.png)](https://github.com/codethi)

🧔 **Thiago Lima | Ele, papai do ano!** 
