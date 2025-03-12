## Jogo de Adivinha��o

![](https://i.imgur.com/icRPLm5.gif)

# Projeto
Um jogo divertido de adivinha��o num�rica.

# Como Jogar
- Escolha um n�vel de dificuldade.
- Digite um n�mero at� adivinhar o n�mero sortado.
- Tente acertar antes de estourar suas tentativas.

# Funcionalidades
- **Gera��o de N�mero Aleat�rio:** Em cada desafio, o jogo ir� gerar aleatoriamente um n�mero secreto entre 1 e 20.
- **Sele��o de Dificuldade:** Existem 3 modos padr�o de jogo, (F�cil, M�dio e Dif�cil), onde cada um tem um total de tentativa espec�fico.
- **Modo Personalizado:** Disponibilidade de escolher quantas tentativas deseja e at� quanto ser� gerado o n�mero secreto *(Exemplo: 1 a 50)*.

# Requisitos
- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.

# Como Utilizar
1. **Clone o Reposit�rio:**
```
git clone https://github.com/gsvsantos/JogoDeAdivinhacao.git
```

2. Abra o terminal ou prompt de comando e navegue at� a pasta raiz do Jogo.

3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.
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
