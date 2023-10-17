# Teste backend time de produtos Ímpar

## Pontos principais da refatoração
 - Pequena alteração da arquitetura para 3 camadas, separando em controller, service e utilizando o database context como repositorio já que não temos nenhuma query de alta complexidade
 - Adicionado log no erro da request para observalidade

## Raciocínio sobre a questão dos envios

Considerando o tempo de processamento prolongado das requisições, uma abordagem viável é realizar tarefas em segundo plano para evitar que os usuários fiquem bloqueados na tela. Essa solução deve ser avaliada, uma vez que a execução de tarefas em segundo plano no mesmo banco de dados pode resultar em uma queda de desempenho e problemas de concorrência com outras atividades do sistema.

Como parte da minha solução proposta, criaríamos um serviço capaz de receber mensagens em uma fila para a realização de envio de comunicações de diversos tipos. Utilizar o design patterns strategy para garantir que o código permanecesse bem organizado e pudesse evoluir para N comunicações.

Para lidar com mensagens que resultassem em erros durante o envio, implementaríamos uma lógica de retentativa, onde a mensagem seria reenviada até três vezes. Após três tentativas malsucedidas, a mensagem seria colocada em uma fila separada para registro no sistema, permitindo-nos identificar os usuários que não receberam a mensagem. Esse processo nos forneceria a capacidade de rastrear quais usuários não foram alcançados, a fim de que suas mensagens pudessem ser reprocessadas de forma isolada.

Neste ponto, planejamos a implementação de dois jobs: um para reprocessar uma lista de IDs de usuários específicos e outro para lidar com o envio para o banco de dados completo.

Essa abordagem nos permitiria otimizar o envio de mensagens, melhorar a rastreabilidade das mensagens não entregues e manter o desempenho e a concorrência do sistema sob controle.
