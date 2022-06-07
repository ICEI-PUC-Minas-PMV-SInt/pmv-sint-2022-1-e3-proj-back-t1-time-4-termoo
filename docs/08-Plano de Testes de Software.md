# Plano de Testes de Software

|Caso de Teste|Inserir uma palavra inválida|
|--|--|
|Requisitos Associados| Tela principal e requisição ao dicionário|
|Objetivo do Teste| Validar se o jogo verifica uma palavra inválida
|Passos|1) Preencha os campos da palavra com uma palavra inválida. 2) Verifique se o jogo informará que a palavra não é valida pois não existe.
|Critérios de Êxito| O usuário deve receber uma mensagem de erro informando que está palavra não existe.


|Caso de Teste|Inserir uma palavra válida|
|--|--|
|Requisitos Associados| Tela principal e requisição ao dicionário|
|Objetivo do Teste| Validar se o jogo verifica uma palavra existe
|Passos|1) Preencha os campos da palavra com uma palavra válida. 2) Verifique se o jogo preenche os campos com a cor verde, caso a letra esteja na posição correta. 3) Verifique se o jogo preenche os campos com as cor amarela, caso a letra esteja na posição incorreta mas existe na palavra. 4) Verifique se o jogo preenche os campos com as cor cinza, caso a letra esteja não faça parte da palavra.
|Critérios de Êxito| O usuário deve receber um feedback visual conforme as regras das letras na palavra.


|Caso de Teste|Validação quando a palavra correta é inserida|
|--|--|
|Requisitos Associados| Tela principal e requisição ao dicionário|
|Objetivo do Teste| Validar se a palavra inserida está correta
|Passos|1) Preencha os campos da palavra com uma palavra válida. 2) Caso a palavra inserida esteja correta, o software deve preencher todos os campos com a cor verde e informar ao usuário que a palavra está correta.
|Critérios de Êxito| O usuário deve receber um feedback visual e em texto informando que a palavra está correta.

|Caso de Teste|Validação quando o usuário utilizar todas as chances disponíveis|
|--|--|
|Requisitos Associados| Tela principal e requisição ao dicionário|
|Objetivo do Teste| Validar se é informado ao usuário qual a palavra correta quando as tentativas se esgotarem
|Passos|1) Preencha os campos da palavra com uma palavra válida. 2) Ao utilizar todas as tentativas, informar ao usuário que a palavra está incorreta e apresentar a palavra correta.
|Critérios de Êxito| O usuário deve receber um feedback visual e em texto informando que utilizou todas as chances disponíveis e qual a palavra correta.
