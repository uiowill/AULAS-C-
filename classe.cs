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

// ----------------- QUADRADO --------------------
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

// ---------HERDAR E PUXAR COMO PRIVATE--------------------

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
// -------------------TO STRING-------------------
// using System.Runtime.InteropServices;
// using Microsoft.VisualBasic;

// class Produto{
//     protected string id = "";
//     protected string nome = "";

//     public Produto(string id, string nome){
//         this.id=id;
//         this.nome = nome;
//     }
//         public virtual string ToString(){
//        return $"ID É : {id} / NOME:  {nome},";
//     }
// }
// class Industrializados : Produto{
//     protected int codBarras = 0;
//     protected string Marca = " ";

//     public Industrializados(string id, string nome, int codBarras, string Marca) : base(id, nome)
//     {
//         this.codBarras = codBarras;
//         this.Marca = Marca;
//     }

// }

// class Naturais : Produto{
//     protected double peso = 0.0;

//     public Naturais(string id, string nome, double peso) : base(id, nome)
//     {
//         this.peso = peso;
//     }
//         public override string ToString(){
//         return $"ID É : {id} / NOME:  {nome}, peso é {peso}";
//     }
// }

// class Animal{
//     protected Boolean Comer = true;
//     protected string fazerBarulho = " ";

//     public Animal(Boolean Comer, string fazerBarulho){
//         this.Comer = Comer;
//         this.fazerBarulho = fazerBarulho;
//     }
//     public virtual string ToString(){
//         return $"Comeu? {Comer} / fazBarulho?{fazerBarulho}";
//     }
// }

// class Cachorro : Animal{
//     public Cachorro(Boolean Comer, string fazerBarulho) : base(Comer, fazerBarulho){
//         this.Comer = false;
//         this.fazerBarulho = "auau";
//     }
//      public override string ToString(){
//         return $"Comeu? {Comer} / fazBarulho? {fazerBarulho}";
//     }
// }

// class Gato : Animal{
//     public Gato(Boolean Comer, string fazerBarulho) : base(Comer, fazerBarulho){
//         this.Comer = true;
//         this.fazerBarulho = "miu";
//     }
//         public override string ToString(){
//         return $"Comeu? {Comer} / fazBarulho?{fazerBarulho}";
//     }
// }

// class Passaro : Animal{
//     public Passaro(Boolean Comer, string fazerBarulho) : base(Comer, fazerBarulho){
//         this.Comer = false;
//         this.fazerBarulho = "miu";
//     }
//         public override string ToString(){
//         return $"Comeu? {Comer} / fazBarulho?{fazerBarulho}";
//     }
// }

// --------------------- SOMA--------------------
// class Calculadora{
//     private int resultado;
//     public int GetResultado(){
//         return resultado;
//     }
//     public void Soma(int numero){
//       resultado += numero;
//     }
//     public void Subtrair(int numero){
//     resultado -= numero;
//     }

// }

// -------------- DICIONARIO -----------------
// using System.Reflection.PortableExecutable;
// using System.Runtime.CompilerServices;

// Dictionary<string,string> ips = new Dictionary<string, string>();
// ips["AmericaSul"] = "192.168.0.1"; // O DICIONARIO PEGA TUDO CLASSE, BOOLEAN ETC
// ips.Add("Europa", "dsafdsa");
// ips.Add("Tutorial", "Remover");
// ips.Remove("Tutorial");


// Console.WriteLine(ips.Count); // PARA VER QUANTOS ELEMENTOS TEM
// if(!ips.ContainsKey("brasil")){ /// PARA VER SE O BAGULHO TA LA
//     ips.TryAdd("Brasil", "312321");
// }

// Console.WriteLine(ips["Europa"]); // Para acessar especificamente o que você quiser


// class Rede{
// public Dictionary<string, int> ips = new Dictionary<string, int>();
// public string cidade = "";
// public int ddd = 0;

//    public void Adicionar(string oi, int tchau)
//     {
//             if(!ips.ContainsKey(cidade)){
//         Console.WriteLine("Cidade Já cadastrada");
//         return;
// }
       
//    ips.TryAdd(cidade, ddd);
//    }
//     public void Remover(string oi){
//     ips.Remove(cidade);
//     }
//     public void Atualizar(){
//     if(!ips.ContainsKey(cidade)){
//         Console.WriteLine("Cidade Já cadastrada");
//         return;
// }
//     ips["Brasil"] = 321321321;
//     }
//     public void Imprimir(){
//         Console.WriteLine(ips.Count + ips["Brasil"]);
//            Console.WriteLine(ips["Brasil"]);
   
// }
// }


class Mensagem{
    public static int contador = 0;

    public static void Escrever(string texto){
        contador++;
        Console.WriteLine(texto);
    }
}