# Teste backend time de produtos Ímpar

## O problema
Você está construindo um sistema web que irá realizar o disparo de mensagens (SMS, Email, Whatsapp...) para um grande número de usuários. Você irá reparar que a solução inicial já faz o envio da mensagem para todos os usuários cadastrados no banco de dados, porém, como todo o código está sendo executado diretamente no controller da API, a solução está suscetível a timeouts.
Importante: Não vale aumentar o tempo de timeout 😉

## O que você irá precisar
Visual Studio Community 2022
Azure Data Studio ou SSMS
SQL Server local

## Como começar
Primeiramente, você precisa ter o banco de dados rodando localmente, para isso, disponibilizamos um arquivo backpack (impar-evaluation-db.bacpac) que já contém a estrutura básica do banco e a tabela de usuários já preenchida com 30 mil usuários de exemplo.
Na sequência, clone para sua máquina o repositório disponibilizado (ou faça download manual). Nele se encontra a solução base para que você possa seguir com suas atividades.
Crie um repositório novo no seu GitHub, e versione seu código por lá. Utílize nosso repositório apenas para baixar o código base.

## Seus objetivos nesta tarefa são: 
Estruturar melhor a solução, preferencialmente seguindo os principios de Clean Architecture
Fique à vontade para criar novos projetos dentro da solução, capriche nos nomes e na organização, este é um fator determinante para nós
Use injeção de dependências para acessar os recursos
* Dica: Mantenha em mente os princípios SOLID
Aprimorar o envio de mensagens para que ele não ocorra diretamente na controller da API
* Dica: Paralelismo pode lhe auxiliar nessa hora, mas fique de olho na quantidade de tarefas em paralelo 😉
* Dica: Azure Functions ou um job para realizar a carga pode ser uma boa saída


## O que esperamos receber
* Link do seu repositório
* Arquivo de backup do seu banco de dados (caso alguma mudança tenha sido feita no banco de dados)
* Breve descrição das atividades que realizou
** Pontos principais da refatoração
** Seu raciocínio sobre a questão dos envios


## Dicas
* Se for utilizar Chat GPT, utilize com parcimônia. Caso seu processo siga para a próxima fase, iremos discutir sobre a solução que você apresentou. É muito melhor que seja uma solução mais simples, mas que você tenha total conhecimento, do que uma solução extremamente complexa gerada pelo Open AI e que você não a entenda completamente.
* Aqui na Ímpar, trabalhamos em equipe, acertamos juntos e erramos juntos. Então não deixe de entregar seu desafio pensando que não é a versão mais perfeita possível. 
* Comente seu código apenas com comentários pertinentes
* Além dos pontos comentados acima, a solução tem algumas coisas que podem ser melhoradas, fique atento 🙂
