# Ponderada M10 S4: Métricas em Dotnet

## Parte 1: Criando uma métrica personalizada

### 1. Criando Console Application
Rodar o comando no diretório criado
`dotnet new console`

![image](assets\metrica-customizada\criando-console-app.png)


### 2. Adicionando package para usar métricas
Rodar o comando `dotnet add package System.Diagnostics.DiagnosticSource`

![image](assets\metrica-customizada\add-package-metricas.png)

### 3. Substituindo o código
Acessar o arquivo Program.cs dentro do projeto e substituir pelo código do tutorial. 

![image](assets\metrica-customizada\codigo-substituido.png)

### 4. Executando o código
Na raiz do projeto, rodar o comando `dotnet run`

![image](assets\metrica-customizada\executando.png)

### 5. Configurando para exibir as métricas
Em outro terminal, na pasta do projeto rodar o comando `dotnet tool update -g dotnet-counters`

![image](assets\metrica-customizada\config-exibir-metricas.png)

### 6. Monitorando a métrica
No mesmo terminal do passo anterior, rodar o comando `dotnet-counters monitor -n nome-do-programa-criado --counters HatCo.Store` 

![imagem](assets\metrica-customizada\monitorando-contador.png)


## Parte 2: Medidor por meio de injeção de dependência

### 1. Criando Web Application
Rodar o comando no diretório criado
`dotnet new webapi`

![image](assets\metrica-injecao-dependencia\criando-web-app.png)

### 2. Adicionando package para usar métricas
Rodar o comando `dotnet add package System.Diagnostics.DiagnosticSource`

![image](assets\metrica-injecao-dependencia\add-package.png)

### 3. Substituindo o código
Acessar o arquivo Program.cs dentro do projeto e substituir pelo código do tutorial adaptado. 

![image](assets\metrica-injecao-dependencia\substituindo-codigo.png)

### 4. Executando o código
Na raiz do projeto, rodar o comando `dotnet run`

![image](assets\metrica-injecao-dependencia\executando.png)

### 5. Mandando requisições
Usando o postman, configurar uma requisição do tipo POST usando a URL http://localhost:5055/complete-sale/10

![image](assets\metrica-injecao-dependencia\mandando-requisicao.png)

### 6. Monitorando a métrica
Em outro terminal, rodar o comando `dotnet-counters monitor -n nome-do-programa-criado --counters HatCo.Store` 

![image](assets\metrica-injecao-dependencia\exibindo-metrica.png)