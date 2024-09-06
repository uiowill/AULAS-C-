using System.Collections;

// int semana = 8;



// switch(semana)
//             {
//                 case 1: 
//                 Console.WriteLine("Segunda Feira");
//                 break;
//                 case 2:
//                 Console.WriteLine("Terça Fera");
//                 break;
//                 case 3:
//                 Console.WriteLine("Quarta");
//                 break;
//                 case 4: 
//                 Console.WriteLine("Quinta");
//                 break;
//                 case 5:
//                 Console.WriteLine("Sexta");
//                 break;
//                 case 6:
//                 Console.WriteLine("Sabado");
//                 break;
//                 case 7:
//                 Console.WriteLine("Domingo");
//                 break;
//                 default:
//                 Console.WriteLine("Numero incorreto");
//                 break;
//             }
// Media x1 = new Media(5, 4, 1);
// x1.CalculoMedia();
// x1.Situacao();

// ----------------------

// double salario = -9;

// if(salario %2 == 0 & salario>0){
//     Console.WriteLine("Positivo e par");
// }
// else if(salario %3== 0 & salario>0){
//     Console.WriteLine("Positivo e impar");
// }

// else if(salario %3 == 0 & salario<0){
//     Console.WriteLine("Negativo e impar");
// }
// if(salario == 0){
//     Console.WriteLine("zero");
// }
// else{
//     Console.WriteLine("par e negativoo");
// }

// int numero = 26;

// if(numero >80 | numero <25 | numero == 40){
//     Console.WriteLine("doadpsadçsad");
// }
// else{
//     Console.WriteLine("fdsffdskod");
// }



// int mes =4;
// switch(mes){
//     case 1: 
//     Console.WriteLine("Janeiro 31 dias");
//     break;
//     case 2: 
//     Console.WriteLine("Fevereiro 28 dias");
//     break;
//     case 3: 
//     Console.WriteLine("Março");
//     break;
//     case 4: 
//     Console.WriteLine("Abril");
//     break;
//     case 5: 
//     Console.WriteLine("Maio");
//     break;
//     case 6: 
//     Console.WriteLine("Junho");
//     break;
//     case 7: 
//     Console.WriteLine("Juho");
//     break;
//     case 8: 
//     Console.WriteLine("Agosto");
//     break;
//     case 9: 
//     Console.WriteLine("Setembro");
//     break;
//     case 10: 
//     Console.WriteLine("outubro");
//     break;
//     case 11: 
//     Console.WriteLine("Novembro");
//     break;
//     case 12: 
//     Console.WriteLine("Dezembro");
//     break;


// }

// int contador = 0;


// while(contador < 9){
// contador++;
// Console.Write(contador  + " ");
// }



// int idades = 0;
// int soma = 0 ;
// int quantidade = 0;

// while (idades != -1)
// {
//     idades = Convert.ToInt32(Console.ReadLine());
//     if(idades == -1){
//         break;
//     }
//     Console.WriteLine("Escreva uma idade" + idades);
//     soma += idades;
//     quantidade++;

// }
//  Console.WriteLine("A media é " + soma / quantidade);   

/*
Random  random = new Random();
var aleatorio = random.Next(0 , 100);
int menorValor = 0;
int armazenamento = 0;
Boolean menor = true;



for (int i = 0; i < 20; i++)
{
    aleatorio = random.Next(0,100);
    Console.Write(aleatorio + " ");

    if(aleatorio > armazenamento){
        armazenamento = aleatorio;
    }
    if (aleatorio < menorValor | menor == true)
    menorValor = aleatorio;
    menor = false;
}
Console.WriteLine($" o maior é {armazenamento} e o menor é {menorValor}");
classe Data
atributos:
-dia
-mes
-ano

funções:
-construtor(dia,mes,ano)
-construtor() -> 01/01/01
-get & set -> Dia
-get & set -> mes
-get & set -> ano
-Nome do Mes()
- ano Bissexto()
-clonar() -> retorna um novo objeto com os mesmo atributos
-comparar(data)
-1: se a data for maior
-0: se for igual
- -1: se a data for menor

var d1 = new Data(10, 1 , 2025)
var d2 = d1.clonar();
d1.comparar(new data(11, 1, 2025))
*/
// class Data 
// {
//     public int dia;

//     public int mes;

//     public int ano;

//     public Data(int dia, int mes, int ano)
//     {
//         this.dia = dia;
//         this.mes = mes;
//         this.ano = ano;
//     }

//     public int Getdia(int dia){
//         return dia;
//     }

//     public int Getmes(int mes)
//     {
//         return mes;
//     }
//     public int Getano(int ano)
//     {
//         return ano;
//     }
//     public int Setdia(int dia)
//     {
//         return dia;
//     }
//      public int Setmes(int mes)
//     {
//         return mes;
//     }
//      public int Setano(int ano)
//     {
//         return ano;
//     }
// }

int[] vetor = new int[10];



for (int i = 0; i < 10; i++)
{
    vetor[i] = 10 - i;
}


for (int i = 0; i < 10; i++)
{
    Console.Write(vetor[i]);
}
