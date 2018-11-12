open System

let Exercicio01() =

    let nome = "Eduardo"
    let idade = 18

    Console.WriteLine "Exercío 1"
    Console.WriteLine ""
    Console.Write "Nome: "
    Console.WriteLine nome
    Console.Write "Idade: "
    Console.WriteLine idade
    Console.WriteLine ""
    Console.WriteLine "-----------------------------"
    Console.WriteLine ""

let Exercicio02() =

    let notas = [5.0 ; 6.0 ; 7.0]
    let somarNotas = notas.[0] + notas.[1] + notas.[2]
    let media = somarNotas / 3.0

    Console.WriteLine "Exercício 2"
    Console.WriteLine ""
    Console.Write "A média das notas é: " 
    Console.WriteLine media
    Console.WriteLine ""
    Console.WriteLine "-----------------------------"
    Console.WriteLine ""

let Exercicio03() =
    
    Console.WriteLine "Exercício 3"
    Console.WriteLine ""

    Console.Write "Digite o seu nome: "
    let nome = Console.ReadLine()
    Console.Write "Digite a sua idade: "
    let idade = Console.ReadLine()

    Console.WriteLine ""
    Console.Write "Nome: "
    Console.WriteLine nome
    Console.Write "Idade: "
    Console.WriteLine idade

    Console.WriteLine ""
    Console.WriteLine "-----------------------------"
    Console.WriteLine ""

let Exercicio04() = 

    Console.WriteLine "Exercício 4"
    Console.WriteLine ""

    Console.Write "Digite um número: "
    let (numero:int) = Console.Read()

    //O comando "Console.Read()" lê apenas o primeiro digito e por algum motivo começa a contar a partir do número 48.

    let numero = (numero-48) + 10

    Console.WriteLine ""
    Console.WriteLine numero

[<EntryPoint>]
let main argv = 
    
    Console.WriteLine "Eduardo da Silva Lamim"
    Console.WriteLine ""

    Exercicio01()
    Exercicio02()
    Exercicio03()
    Exercicio04()


    Console.ReadKey()
    |> ignore

    0 
