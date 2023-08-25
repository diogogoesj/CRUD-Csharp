# CRUD em Windows Forms

Este é um projeto de CRUD (Create, Read, Update, Delete) desenvolvido em Windows Forms usando a linguagem C#. O objetivo deste projeto é permitir o cadastro, busca, atualização e exclusão de informações de funcionários em um banco de dados MySQL local.

<p align="center">
  <img src="https://camo.githubusercontent.com/8a0fd75d44546539fbf2a608ae3f608055e0122c8f03b27439c7ab4ceca23629/68747470733a2f2f6d69722d73332d63646e2d63662e626568616e63652e6e65742f70726f6a6563745f6d6f64756c65732f6d61785f313230302f36323263613035323037313736312e353930333465373461626233362e676966" width="250" height="300">
</p>

## Funcionalidades

- **Cadastro**: Permite cadastrar novos funcionários informando nome, e-mail, CPF e endereço.
- **Busca**: Permite buscar um funcionário existente no banco de dados pelo CPF.
- **Atualização**: Permite atualizar os dados de um funcionário já cadastrado, exceto o CPF.
- **Exclusão**: Permite excluir um funcionário do banco de dados.

## Requisitos

- .NET Framework: Certifique-se de ter o .NET Framework instalado em seu computador para executar o projeto.
- MySQL Server: É necessário ter um servidor MySQL instalado localmente para que o CRUD possa se conectar ao banco de dados.

## Como Executar o Projeto

1. Clone este repositório em sua máquina local.
2. Abra o projeto no Visual Studio.
3. Certifique-se de que o MySQL Server esteja em execução e que as credenciais de conexão no arquivo `ConexaoBanco.cs` estejam corretas.
4. Compile e execute o projeto.
5. A janela do CRUD em Windows Forms será aberta, permitindo que você interaja com as funcionalidades.

## Banco de Dados

- O banco de dados utilizado é chamado `dbFuncionarios`.
- A tabela utilizada para armazenar os registros de funcionários é `funcionarios`.
- A estrutura da tabela é a seguinte:
  - `id`: Chave primária, autoincremental, representando o identificador único do funcionário.
  - `nome`: Nome do funcionário.
  - `email`: E-mail do funcionário.
  - `cpf`: CPF do funcionário.
  - `endereco`: Endereço do funcionário.

## Estrutura do Projeto

A estrutura do projeto está organizada da seguinte forma:

- **Pasta Utils**: Contém a classe `Validacoes.cs`, que possui funções auxiliares para validações.
- **Pasta DataAccess**: Contém a classe `ConexaoBanco.cs`, responsável por gerenciar a conexão com o banco de dados MySQL.
- **Pasta Services**: Pode conter classes que implementam a lógica de negócios, como `CadastroFuncionarios.cs`.
- **Arquivo Program.cs**: Ponto de entrada da aplicação.

## Contribuição

Contribuições são bem-vindas! Se você encontrou algum bug, tem alguma sugestão ou deseja adicionar novas funcionalidades, sinta-se à vontade para abrir uma *issue* ou enviar um *pull request*.


