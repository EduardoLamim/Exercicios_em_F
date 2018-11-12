open System

let Exercicio01() =

    Console.WriteLine "Exercicio 1"
    Console.WriteLine ""
   
    Console.Write "Digite a saudação: "
    let saudacao = Console.ReadLine()

    Console.WriteLine ""
    Console.Write "Digite o seu nome: "
    let nome = Console.ReadLine()


    let concatenar = saudacao + " " + nome
    
    Console.WriteLine ""
    Console.WriteLine concatenar
    Console.WriteLine ""
    Console.WriteLine "---------------------------------"
    Console.WriteLine ""

let Exercicio02() =

    let concatenar saudacoes nome = 
        saudacoes + nome
    
    Console.WriteLine "Exercicío 2"
    Console.WriteLine ""
    Console.Write "Digite seu nome: "
    let nome = Console.ReadLine()

    let Ola = "Seja bem-vindo, "

    let concatenarSaudacoes = concatenar Ola

    let concatenarNome = concatenarSaudacoes nome
    Console.WriteLine ""
    Console.WriteLine concatenarNome

    let Tchau = "Até logo, "

    let concatenarSaudacoes = concatenar Tchau

    let concatenarNome = concatenarSaudacoes nome
    Console.WriteLine ""
    Console.WriteLine concatenarNome

[<EntryPoint>]
let main argv = 
   
   Console.WriteLine "Eduardo da Silva Lamim"
   Console.WriteLine ""

   Exercicio01()
   Exercicio02()

   Console.ReadKey()
    |> ignore

   0