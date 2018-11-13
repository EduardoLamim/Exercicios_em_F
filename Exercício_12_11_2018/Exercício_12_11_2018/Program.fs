open System

let Exercicio01() =

    Console.WriteLine "Exercício 1"
    Console.WriteLine ""

    let lista = [0 ; 1 ; 2 ; 3 ; 4 ; 5]
    let elevarLista = List.map (fun num -> num * num) lista

    Console.WriteLine "Lista com os números ao quadrado:"
    Console.WriteLine ""

    for n in elevarLista do 
        Console.Write(n)
        Console.Write "\t"

let Exercicio02() = 
    
    Console.WriteLine ""
    Console.WriteLine ""
    Console.WriteLine "-------------------------------------------"
    Console.WriteLine ""
    Console.WriteLine "Exercício 2"
    Console.WriteLine ""

    let listaNomes = ["Eduardo" ; "Wagner" ; "Tamara" ; "Bruna" ; "João"]
    
    let teste = List.filter (fun (nomes:string) -> nomes.StartsWith "T") listaNomes

    Console.WriteLine "Nomes da lista que começam com a letra T:"
    Console.WriteLine ""

    for n in teste do
        Console.WriteLine(n)
        Console.WriteLine "\t"
  

let Exercicio03() =

    Console.WriteLine ""
    Console.WriteLine "-------------------------------------------"
    Console.WriteLine ""
    Console.WriteLine "Exercício 3"
    Console.WriteLine ""
    
    let lista = [1..6]

    let multiplicarLista = List.reduce (fun acumulador num -> acumulador * num) lista

    Console.WriteLine ""
    Console.Write "Multiplicação de todos os números da lista: "
    Console.WriteLine(multiplicarLista)
    Console.WriteLine ""

let Exercicio04() =

    Console.WriteLine "-------------------------------------------"
    Console.WriteLine ""
    Console.WriteLine "Exercício 4"
    Console.WriteLine ""

    let lista = [1..10]

    Console.Write "Digite um número: "
    let n = Console.ReadLine()

    let numerosPares = List.filter (fun num -> num % 2 = 0) lista
    let numerosMaioresN = List.filter (fun num -> num > (int)n) lista

 

    Console.WriteLine ""
    
    Console.WriteLine "Números pares:"
    Console.WriteLine ""
    for n in numerosPares do
        Console.Write(n)
        Console.Write "\t"
    
    Console.WriteLine ""
    Console.WriteLine ""

    Console.Write "Números maiores que "
    Console.Write n
    Console.WriteLine ":"
    Console.WriteLine ""

    for n in numerosMaioresN do
        Console.Write(n)
        Console.Write "\t"

    Console.WriteLine ""
    Console.WriteLine ""
    Console.WriteLine "-------------------------------------------"

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