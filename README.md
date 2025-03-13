## Jogo de Adivinhação

![](https://i.imgur.com/MsHl6WJ.gif)

# Projeto
Um jogo divertido de adivinhação numérica.

# Como Jogar
- Escolha um nível de dificuldade.
- Digite um número até adivinhar o número sortado.
- Tente acertar antes de estourar suas tentativas.

# Funcionalidades
- **Geração de Número Aleatório:** Em cada desafio, o jogo irá gerar aleatoriamente um número secreto entre 1 e 20.
- **Seleção de Dificuldade:** Existem 3 modos padrão de jogo, (Fácil, Médio e Difícil), onde cada um tem um total de tentativa específico.
- **Modo Personalizado:** Disponibilidade de escolher quantas tentativas deseja e até quanto será gerado o número secreto *(Exemplo: 1 a 50)*.

# Requisitos
- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

# Como Utilizar
1. **Clone o Repositório:**
```
git clone https://github.com/gsvsantos/JogoDeAdivinhacao.git
```

2. Abra o terminal ou prompt de comando e navegue até a pasta raiz do Jogo.

3. Utilize o comando abaixo para restaurar as dependências do projeto.
```
dotnet restore
```

4. Compile e execute o arquivo *.exe* do jogo.
```
dotnet build --configuration Release
```
```
JogoDeAdivinhacao.ConsoleApp.exe
```

### Opcional
- Executar o projeto compilando em tempo real
```
dotnet run --project JogoDeAdivinhacao.ConsoleApp
```

# Sobre o Projeto

Este projeto foi desenvolvido como parte de uma atividade da [Academia do Programador](https://www.instagram.com/academiadoprogramador/).
