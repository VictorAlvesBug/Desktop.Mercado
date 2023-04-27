# Desktop.Mercado

Este projeto foi desenvolvido com objetivo de participar de um processo seletivo.
Sua proposta é gerenciar **Usuários**, **Produtos** e **Categorias** de um
**supermercado**, com diferentes níveis de **permissão de usuário**.

## Configurando o projeto

Primeiramente, configure as seguintes variáveis de ambiente, conforme o servidor 
SQL Server que deseja utilizar, em **Windows** > **Variáveis de Ambiente** > 
**Variáveis de Ambiente...**:
- **DB_ADDRESS**: IP do servidor de banco;
- **DB_USER_ID**: Usuário de login do banco, caso seja diferente de **sa**;
- **DB_PASSWORD**: Senha de login do banco;

**OBS.:** Caso seja necessário alterar o valor destas variáveis enquanto o 
projeto estiver **aberto no Visual Studio**, será necessário **reiniciar a IDE**, 
pois os valores das variáveis de ambiente são recuperados apenas no ato de abrir
o **Visual Studio**.

Execute o 
[Script SQL](https://github.com/VictorAlvesBug/Desktop.Mercado/blob/master/Script%20de%20Cria%C3%A7%C3%A3o%20das%20Tabelas.sql) 
de criação de **banco**, **tabelas** e inserção dos **dados iniciais** de 
algumas tabelas.

Realize o clone do repositório com o comando abaixo:

```bash
git clone https://github.com/VictorAlvesBug/Desktop.Mercado.git
```

Abra o projeto no **Visual Studio** e pressione **Start**.

## Executando o projeto

O sistema consiste na **gestão de Produtos** de um supermercado, separados por
**Categoria**.

Para acessar os produtos é necessário realizar um **cadastro e login** de usuário,
de forma que, usuários cadastrados via sistema tem permissão de **usuário comum**, 
sem a possibilidade de cadastrar, alterar e excluir produtos e categorias, 
**apenas visualização**. 

Apenas **usuários administradores** são capazes de cadastrar, alterar e excluir 
dados, de forma que a **exclusão** é realizada apenas **logicamente** (Ativo = 0).

### Formulário de Login de Usuário

Neste formulário o usuário pode **logar no sistema** e, caso não tenha cadastro, 
acessar o formulário de **Criação de Contas**.

Inicialmente o sistema já traz o login de um **usuário administrador** preenchido:

```
E-mail: victoralvesbug@gmail.com
Senha: Teste.12345
```

Validações:
- E-mail preenchido é um **e-mail válido**;
- E-mail e senha estão **corretos** (foram encontrados na base de dados); 

### Formulário de Criação de Contas

Nesta tela o usuário consegue se cadastrar, informando:
- **Nome**;
- **E-mail**;
- **Senha**;
- **Confirmação de Senha**;

Usuários cadastrados por esta tela possuem apenas a permissão de **usuário comum**.

Para evitar a **falha de segurança** de salvar a senha do usuário diretamente no 
banco de dados, é feita a criptografia básica para um **hash** via **MD5** e este 
valor é salvo no lugar da senha. 

Para verificar se a senha informada é a correta no ato de login, o sistema 
converte a senha informada para **hash** também e compara os hashes, ao invés de
comparar as senhas diretamente.

Validações:
- **Nome** possui **de 3 até 100 caracteres**;
- E-mail preenchido possui **de 5 até 100 caracteres** e é um **e-mail válido**;
- E-mail é validado também para **evitar** que seja cadastrado mais de um usuário 
com o **mesmo e-mail**;
- **Senha** preenchida possui:
    - **De 8 até 20 caracteres**;
    - Ao menos **1 número**;
    - Ao menos **1 letra maiúscula**;
    - Ao menos **1 letra minúscula**;
    - Ao menos **1 caracter especial** (caracteres que não são número nem letras);
- Senha e confirmação de senha são **iguais**; 

### Formulário de Gestão de Produtos (Principal)

Ao realizar o login, esta tela é exibida. Aqui é possível visualizar a lista de **Produtos** já cadastrados e atualizar a listagem caso seja necessário. Esta 
tela também permite acessar as telas de gestão de **Categorias** e alteração de 
**Dados da Conta**.

Caso o usuário logado seja um **administrador**, ele também conseguirá acessar 
os formulário de **cadastro** de produtos, assim como a **edição** e **exclusão** 
de um **produto selecionado**.

No canto superior direito é possível encontrar um botão para **sair da conta** 
logada.

### Formulário de Cadastro e Edição de Produtos

Este formulário, acessível **apenas para administradores**, é responsável por
**cadastrar** novos produtos e **editar** produtos já existentes, informando:
- **Nome** do Produto;
- **Preço**;
- **Categoria**;
- **Foto**;

Validações:
- **Nome** do produto possui **de 3 até 100 caracteres**;
- **Preço** possui uma **máscara de dinheiro** em reais e permite apenas valores 
**de R$ 0,01 até R$ 999.999,99**;
- **Categoria** selecionada de acordo com a lista de **categorias cadastradas**;
- **Foto** foi selecionada corretamente;

### Formulário de Gestão de Categorias

Nesta tela é realizada toda a gestão das **Categorias** (**administradores**), 
bem como sua listagem (**todos os usuários**). 

Ao **selecionar uma categoria**, 
você pode **editar** seu nome ou **excluí-la** e para **cadastrar** uma nova 
categoria basta **não selecionar** nenhuma das categorias da listagem e 
**informar o nome** da nova categoria.

A lista de **categorias selecionaveis** na tela de Produtos é atualizada 
**automaticamente**.

Validações:
- **Nome** da categoria deve ter **de 3 até 100 caracteres**;
- Apenas **categorias já cadastradas** podem ser **excluídas**;
- Categorias **com produtos** vinculados **não** podem ser **excluídas**;

### Formulário de Alteração de Dados de Usuário

Aqui você pode alterar todos os dados da sua conta, como **nome**, **e-mail** e 
**senha**.

Validações:
- **Nome** possui **de 3 até 100 caracteres**;
- E-mail preenchido possui **de 5 até 100 caracteres** e é um **e-mail válido**;
- E-mail é validado também para **evitar** que seja cadastrado mais de um usuário 
com o **mesmo e-mail**;
- **Senha** preenchida possui:
    - **De 8 até 20 caracteres**;
    - Ao menos **1 número**;
    - Ao menos **1 letra maiúscula**;
    - Ao menos **1 letra minúscula**;
    - Ao menos **1 caracter especial** (caracteres que não são número nem letras);
- Senha e confirmação de senha são **iguais**; 