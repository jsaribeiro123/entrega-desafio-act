# Desafio - ACT

    Descritivo

    Um comerciante precisa controlar o seu fluxo de caixa diario 
    com os lançamentos (debitos e creditos), também precisa de um 
    relatorio que disponibilize o saldo diario consolidado.

    Requisitos de negócio

        Serviço que faça o controle de lançamentos
        Servico que gera relatorio do tipo consolidado diário

    Requisitos Tecnicos

    * Desenho da Solução
    * Pode ser feito na linguagem que voce domina
    * Boas praticas são bem vindas (Design Patterns, Padrões de arquitetura, SOLID e etc)
    * Readme com instruções de como subir a aplicação local, container e utilização dos serviços
    * Hospedar em repositorio publico (Github) 

    Dicas
    - criar teste unitário, 
    - usar abstrações e exceções da forma correta, 
    - aplicar conceitos e padrões de REST e Minimal API etc.

    Tecnologias:

    Swagger
    Apis Rest
    Arquitetura de linguagem monolítica
    Microsserviços
    Docker 
    Git
    .net core
    .net/Web Api, WCF, Log4Net e Nhibernate

    Levantamentos de requisitos funcionais e não funcionais

    Intermediário:

    Docker
    Kafka/RabbitMQ
    Bancos de dados MySQL, Oracle, ou SQL Server
    Ferramenta de monitoração

## Requisitos

### Definições

    Enunciado:

    Ampliando o enunciado do desafio, definiu-se que o comerciante compra e vende NFTs, um produto digital representado por um token associado a um ativo digital.  

    Foi utlizado o conceito de carteira (wallet) para representar o caixa do comerciante de NFTs.  

    Serão necessarios para a movimentação da carteira os serviços de lançamentos do tipo credito e tipo debito, e o servico report   

    Ator:
            Comerciante, responsável pelo uso da aplicação para o registro dos lançamentos de compra e venda de NFTs.  

    Sistemas : 
                App, responsavel pela entrada de dados do ator
                Servicos, composto de dois serviços, lançamento e report. 
                Gateway, gerenciamento das apis
                Api, responsavel pela implementação dos serviços.
                Mensageria, responsavel pela comunicação entre App e Api        
    
    Informações do produto digital NFT:

            Nome do nft,
            Descriçao do nft,
            Chave do NFT,
            Tipo do lançamento,
            Valor, 
            Data do lançamento.

    Termos definidos:  

        Lançamento do tipo Crédito:
        
        Lançamento do Debito:      

        Saldo:
            Obtido da diferença da soma dos lançamentos do tipo credito menos os lançamento do tipo debito.

        Report diario: 
            Lista dos lançamentos do tipo credito e lançamentos do tipo debito realizados no intervalo de um dia, informando o total dos dois tipos de lançameto e o saldo.

    Regras:

    1 - A carteira não poderá ter saldo negativo. 

    2 - O primeiro lançamento deverá ser um do tipo credito pra viabilizar a regra 1. 

    3 - A cada lançamento do tipo debito deve ser verificado o saldo para que o lançamento seja efetivado.    

    4 - Caso o valor do saldo seja menor que o valor do debito, uma msg deve ser apresentada informando o saldo e a impossibilidade de efetuar o lançamento.    

    5 - A cada lançamento seja do tipo debito ou credito uma mensagem de confirmação da efetividade do lançamento deve ser emitida.   

## Aplicação web

    Pagina de apresentação - Home
    Pagina para a interação do usuário - Lançamentos

## APIs - Serviços

    Divididas em 

        Api.Consumer.Lancamento
                        /consumer/lancamento
                        Get
        Api.Consumer.Report
                        /consumer/Report
                        Get
        Api.Producer.Lancamento
                        /producer/lancamento
                        Post
        Api.Producer.Report
                        /producer/Report
                        Post

## APIs - Versionamento

        Implementar modelo

## APIs - Segurança

        Definir , JWT , Token

## Gateway

        Api.Consumer.Lancamento
                        gateway/consumer/lancamento
                        Get
        Api.Consumer.Report
                        gateway/consumer/Report
                        Get
        Api.Producer.Lancamento
                        gateway/producer/lancamento
                        Post
        Api.Producer.Report
                        gateway/producer/Report
                        Post

## DB

    Models :
                Lancamento
                Report
    Debizium            

## Kafka

    Preparar o container

## Monitoramento

    Site Check
    Monitor Kafka

## Testes

    AppWeb
    Apis
    Integrado
    BDD
    Kafka

## Documentação

    C4Model
    C4Builder

## Plano de testes

    Utilização do pattern Page Object para a elaboração dos testes.
    Utilização de testes unitarios
    Testes integrados 

### Casos de testes

    Abrir a carteira
    Efetuar lançamento do tipo credito na carteira
    Efetuar lançamento do tipo debito na carteira com saldo negativo
    Efetuar lançamento do tipo debito na carteira com saldo positivo
    Obter o consolidado do periodo diario.
    Obter o consolidado em um periodo definido.

## Implementando

    git init --initial-branch=main
    git remote add origin https://github.com/jsaribeiro123/NFT.git
    git add .
    git commit -m "Abertura do projeto"
    git push -u origin main 
    
    npm i -g c4builder
    c4builder 
    c4builder site    

    O Modelo C4 define quatro níveis de diagramas:

    Contexto(L1):   nível mais alto, mostra como o sistema se relaciona 
                    com os usuários e outros sistemas.

    Container(L2):  divide o sistema em containers inter-relacionados, 
                    containers são subsistemas executáveis ​​e implementáveis. 

    Componente(L3): pega os contêineres e os decompõe em componentes inter-relacionados, 
                    relaciona-os com outros contêineres ou outros sistemas. 

    Código(L4):     fornece mais detalhes sobre como o código real está sendo implementado. 

    Fluxo
     Setup
        criar topico lancamento
        criar topico relatorio
        criar banco de dados

        - post
        api/producer/lancamento/debito 
        registra mensagem de um lancamento do tipo Debito no topico lancamento
            
        - post
        api/producer/lancamento/credito
        registra mensagem de um lancamento do tipo Credito no topico lancamento
            
        - post
        api/producer/report/diario 
        registra mensagem de pedido de relatorio do tipo diario no topico consolidado
            
        - get
        api/producer/report 
        registra mensagem de pedido de relatorio
            
        - get
        api/consumer/lancamento 
        obtem as mensagens do topico lancamento
            
        - get
        api/consumer/relatorio 
        obtem as mensagens do topico relatorio

## Implantando

    - A implantação foi realizada no Docker Desktop ambiente windows.

    - O projeto pode ser visualizado seguindo os passos
        Instalação do C4Builder
            npm i -g c4builder
        Entrar na pasta Project e executar
            c4builder 
            c4builder site  

    - Entrar no diretorio principal e executar:
            docker-compose up

    - A execução dos testes é feita entrando na pasta Tests e executando no prompt do power shell
        ./testproject.ps1        

## Resultado Esperado

    Prototipo para um mvp

## Resultados Obtidos

## Referencias

    https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio

    https://www.twilio.com/blog/test-aspnetcore-minimal-apis

    https://anasdidi.dev/articles/200713-docker-compose-postgres/

    https://github.com/adrianvlupu/C4-Builder

    https://www.codeproject.com/Articles/5323228/Blazor-Web-Assembly-WASM-Theme-Switching

    https://learn.microsoft.com/pt-br/aspnet/core/tutorials/razor-pages/model?view=aspnetcore-6.0&tabs=visual-studio-code

    https://github.com/adrianvlupu/C4-Builder

    https://github.com/adrianvlupu/C4Builder-Demo    
