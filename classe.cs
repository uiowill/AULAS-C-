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
