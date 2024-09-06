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


// class Mensagem{
//     public static int contador = 0;

//     public static void Escrever(string texto){
//         contador++;
//         Console.WriteLine(texto);
//     }
// }


// -------------------- EMPRESA JURIDICA E PESSOAL -------------------

using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

// class Cliente{
//     protected string ID;
//     protected string Nome;
//     protected string Email;

//     public Cliente(string ID, string Nome, string Email){
//         this.ID = ID;
//         this.Nome = Nome;
//         this.Email = Email;
//     }

//     public string GetID(){
//         return ID;
//     }

//     public virtual void ImprimirDetalhes(){
//       Console.WriteLine($"{ID} - {Nome} - {Email}");
//     }
// }

// class pessoaFisica : Cliente{
//     protected int cpf;

//     public pessoaFisica(int cpf, string ID, string Nome, string Email) : base(ID, Nome, Email){
//         this.cpf = cpf;
//     }
//     public override void ImprimirDetalhes()
//     {
//         Console.WriteLine($"{ID} - {Nome} - {Email} - {cpf}");
//     }
// }

// class pessoaJuridica : Cliente{
//     protected int cnpj = 0;
//     public pessoaJuridica(int cnpj, string ID, string Nome, string Email) : base(ID, Nome, Email){
//         this.cnpj = cnpj;
//     }

//     public override void ImprimirDetalhes()
//     {
//         Console.WriteLine($"{ID} - {Nome} - {Email} - {cnpj}");
//     }
// }

// class Empresa{

// protected List<Cliente> listaCliente = new List<Cliente>();


// public void Adicionar(Cliente cliente){
//     foreach (Cliente c  in listaCliente)
//     {
//         if(c.GetID() == cliente.GetID()){
//             Console.WriteLine("Cliente já cadastradp");
//             return;
//         }
//     }
//     listaCliente.Add(cliente);
// }

// public void Remover(Cliente cliente){
//     if (listaCliente.Remove(cliente))
//     {
//         Console.WriteLine("Cliente removido");
//     }
//     else{
//         Console.WriteLine("Cliente não removido");        
//     }

// }

// public void listarPessoasFisica(){
//     foreach (Cliente cliente in listaCliente)
//     {
//         if (cliente is pessoaFisica)
//         {
//             cliente.ImprimirDetalhes();
//         }
//     }
// }


// public void listarPessoasJuridica(){

//     foreach (Cliente cliente in listaCliente)
//     {
//         if (cliente is pessoaJuridica)
//         {
//             cliente.ImprimirDetalhes();
//         }
//         }
//     }
// }

class Data{

    protected int dia;
    protected int mes;
    protected int ano;

    public Data(int dia, int mes, int ano){
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }

    public Data(){
        dia = 01;
        mes = 01;
        ano = 01;
    }
    public int Setdia(int valor){
    return dia = valor;        
    }

    public int Setmes(int valor){
    return mes = valor;
    }
    public int Setano(int valor){
    return ano = valor;
    }

public int Getdia(){
return dia;
}


public int Getmes(){
return mes;
}


public int Getano(){
return ano;
}

public void nomedoMes(){
switch(mes){
    case 1:
    Console.WriteLine("Janeiro");
    break;
        case 2:
    Console.WriteLine("Fevereiro");
    break;
        case 3:
    Console.WriteLine("Março");
    break;
        case 4:
    Console.WriteLine("Abril");
    break;
        case 5:
    Console.WriteLine("Maio");
    break;
        case 6:
    Console.WriteLine("Junho");
    break;
        case 7:
    Console.WriteLine("Julho");
    break;
        case 8:
    Console.WriteLine("Agosto");
    break;
         case 9:
    Console.WriteLine("Setembro");
    break;
         case 10:
    Console.WriteLine("Outubro");
    break;
         case 11:
    Console.WriteLine("Novembro");
    break;
         case 12:
    Console.WriteLine("Dezembro");
    break;
    default:
    Console.WriteLine("SELECIONE UM MÊS DE 1 A 12");
    break;
    }
}
public void AnoBissexto(){
    if (DateTime.IsLeapYear(ano)){
        Console.WriteLine($"O ano {ano} é um ano bissexto");
    }
    else{
        Console.WriteLine($"O ano {ano} não é um ano bissexto");
    }
}

public Data Clonar(){
   return new Data(dia, mes, ano);
    }
    
}