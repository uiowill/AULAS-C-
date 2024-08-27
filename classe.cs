// using System.Reflection;

// // class Circulo{
// //  public double raio;// DEIXAR COMO PUBLIC DEIXA PARA QUE OUTRAS PASTAS CONSIGAM LER

// // public double CalcularDiamentro(){
// //     return raio * 2;
// // }
// // }

// class Retangulo{
//     private double largura; // ELA SÓ PODE FICAR PRIVADO POR CAUSA DO THIS EM RELAÇÃO AO PUBLIC RETANGULO.
//     private double altura;
//     public Retangulo(double largura, double altura){ // ESSAS VARIAVEIS SÓ EXISTEM NESSE ESCOPO MESMO TENDO O MESMO NOME.
//         this.largura = largura; // O THIS ELE FALA PARA A PROPRIA LARGURA DO ESCOPO
//         this.altura = altura; // O THIS ELE FALA PARA A PROPRIA ALTURA DO ESCOPO
//     }
//     public double CalcularAltura(){
//         return largura * altura;
//     }
//     public double CalcularPerimetro(){
//         return 2*(largura + altura);
//     }


// }


// -------------------- USANDO CONSTRUTOR -----------------

// class Pessoa{
//     private string nome;
//     private double ano;
//     private double altura;

//     public Pessoa(string nome, double ano, double altura){
//         this.nome= nome;
//         this.altura = altura;
//         this.ano = ano ;

//     }
//     public double calcularIdade(){
//     return 2024 - ano;
//     }
//     public string mostrarIdade(){
//     Console.WriteLine($"Nome: {nome} - Altura: {altura} - Idade: {calcularIdade()}");
//     return nome + altura;
//     }
// }

// --------------------- QUADRADO ---------------------------
// class Quadrado{
//     private double tamanho;

//     public Quadrado(double tamanho){
//     this.tamanho = tamanho;
//     }
//     public double calcularArea(){
//         return tamanho * tamanho;
//     }
// public void Redimensionar(double novoTamanho){
//     tamanho=novoTamanho;
// }
//     public void imprimirDados(){
//         double area = calcularArea();
//         Console.Write($"Tamanho: {tamanho} Area: {area}");
//     }
// }
// --------------------- BANCO -------------------


// -----------------------PROTECTED-----------------
// class Mae{
//     public bool atributoMaeBool = false;
// }
// class Pai:Mae{
//     public string atributoPaiString = "";
//     protected int atributoPaiInt = 0;
//     private char atributoPaiCar = ' ';
// }

// class Filho: Pai{
//     void Teste() {
//         atributoPaiString = " ";
//         atributoPaiInt = 0;
//         atributoMaeBool = true;
//     }
// }

// -----------------HERDAR E PUXAR COMO PRIVATE----------------------

// using System.Reflection.Metadata.Ecma335;

// class Pessoa{
//     protected string atributoNome = "oi";
//     protected int atributoCPF = 5;
//     public Pessoa(string atributoNome, int atributoCPF){ // PARA QUE MUDE UMA COISA SÓ É NECESSARIO MUDAR A PESSOA PARA AS COISAS QUE ELES HERDAM MUDAR TB
//         this.atributoCPF = atributoCPF;
//         this.atributoNome = atributoNome;
//     }
// }
// class Funcionario : Pessoa{
//     protected double atributoSalario = 4.0;
//     protected string atributoCargo = "blz";

//     public Funcionario(double atributoSalario, string atributoCargo, string atributoNome, int atributoCPF) : base(atributoNome, atributoCPF){
//         this.atributoSalario = atributoSalario;
//         this.atributoCargo = atributoCargo;
//     }
//     public void ImprimirDetalhes(){
//         Console.WriteLine($"{atributoNome} de cpf: {atributoCPF}, salario {atributoSalario} com cargo {atributoCargo}");
//     }
// }

