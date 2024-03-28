# 📦 Stock Project 

Uma aplicação simples para gerenciar fornecedores e produtos.

## 📋 Pré-requisitos
Antes de começar, certifique-se de ter instalado:

- 🐳 [Docker](https://www.docker.com/get-started)
- ⚙️ [.NET SDK](https://dotnet.microsoft.com/download)
- 🖥️ [Visual Studio Community 2022](https://visualstudio.microsoft.com/vs/community/) ou sua IDE preferida.

## Rodando Localmente 🚀

Para rodar este projeto localmente, siga as instruções abaixo:

1. **Clone o projeto:**

```bash
git clone https://github.com/antoniomrrds/StockProject.git
```

2. **Entre no diretório do projeto:**

```bash
cd ./StockProject
```

3. **Inicie o ambiente com Docker Compose: 🐳**

```bash
docker-compose up -d 
```

4. **Execute as migrações para preparar o banco de dados:**

```bash
dotnet tool install --global dotnet-ef
dotnet ef database update
```

5. **Abra o projeto no Visual Studio Community 2022 (ou sua IDE preferida):**

   - Abra o Visual Studio.
   - Clique em "Arquivo" > "Abrir" > "Projeto/Solução...".
   - Navegue até a pasta do projeto e selecione o arquivo `StockProject.sln`.
   - Clique em "Abrir".

6. **Execute o projeto:**

   - No Visual Studio, pressione F5 ou clique em "Depurar" > "Iniciar Depuração".

   Ou

   - No terminal, execute o comando:

   ```bash
   dotnet run
   ```
     O projeto estará acessível em `http://localhost:5084` no seu navegador.

 Ou

   - No terminal, execute o comando:

   ```bash
   dotnet watch
   ```
 
## Screenshots 📸
- Home
  ![image](https://github.com/antoniomrrds/StockProject/assets/62305370/ea0c1d62-18ab-4bac-9b2a-c83b61e2cc32)

## Stack utilizada 🛠️
**Front-end:**  
- 🧶 Razor Pages
- 🌐 HTML
- 🎨 CSS
- 🅱️ Bootstrap

**Back-end:** 
- 🖥️ C#
- ⚙️ ASP.NET Core
- 📦 Entity Framework Core

**DataBase:** 
- 🗄️ MySQL


## 🚀 Sobre mim ℹ️
Eu sou um desenvolvedor backend em ascensão, apaixonado por tecnologia e sempre em busca de aprender coisas novas. Este projeto é um exemplo do meu trabalho e aprendizado contínuo na área de desenvolvimento de software. Se tiver alguma sugestão ou feedback, sinta-se à vontade para entrar em contato! 😊✨

Espero que isso atenda às suas expectativas! Se precisar de mais alguma coisa, estou à disposição.
