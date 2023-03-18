# ProdutosAPI
Projeto de API .NET6 com AutoMapper para CRUD de Produto

## Descrição
Este é um projeto de API simples em .NET6 que utiliza AutoMapper para mapear entidades de Produto para DTOs e realizar operações CRUD básicas. A API permite que um usuário crie, leia, atualize e exclua produtos, cada um com um nome, preço e descrição.

## Pré-requisitos
Para utilizar esta API, é necessário ter instalado o .NET6 e um editor de código de sua escolha (como Visual Studio ou VSCode). Além disso, é recomendável ter familiaridade com conceitos básicos de desenvolvimento de API RESTful e de programação em C#.

## Instalação
Faça o clone do repositório em sua máquina local.
Abra o projeto em seu editor de código de escolha.
Execute o comando dotnet run para compilar e executar o projeto.
Acesse a API em seu navegador ou em uma ferramenta de teste de API (como Postman ou Insomnia) através da URL http://localhost:5000.
Rotas
A seguir estão as rotas disponíveis nesta API:

## GET /api/produtos
Retorna uma lista de todos os produtos cadastrados.

## GET /api/produtos/{id}
Retorna o produto com o ID especificado.

## POST /api/produtos
Cria um novo produto com as informações fornecidas no corpo da solicitação.

## PUT /api/produtos/{id}
Atualiza o produto com o ID especificado com as informações fornecidas no corpo da solicitação.

## PATCH /api/produtos/{id}
Atualiza o produto parcialmente com o ID especificado com as informações fornecidas no corpo da solicitação.

## DELETE /api/produtos/{id}
Exclui o produto com o ID especificado.

## Exemplo de uso
Para criar um novo produto, envie uma solicitação POST para a rota /api/produtos com o seguinte corpo:
```
{
    "id": 0,
    "nome": "Produto A",
    "preco": 9.99,
    "descricao": "Este é o produto A"
}
```


## Contribuição
Este é um projeto simples e qualquer contribuição é bem-vinda! Sinta-se livre para enviar um pull request com melhorias ou correções de erros.

