// class Compras{
//     private string[] produtos = new string[5];
//     private List <string> lista = new List<string>(); //LISTA NÃO TEM TAMANHO DEFINIDO

//     private double valorTotal = 0;

//     public void AdicionarItem(string nome, double preco){
//         lista[0] = "produto";
//         Console.WriteLine(lista[0]);
//         lista.Add(nome);
//         for (int i = 0; i< produtos.Length; i++){
//             if(string.IsNullOrEmpty(produtos[i])) {
//                 produtos[i] = nome;
//                 valorTotal += preco;
//                 return;
//             }
//         }
//     }
//  public double GetValorTotal(){
//     return valorTotal;
//  }
//  public void ImprimirProdutos(){
//     for(int i = 0; i < produtos.Length; i++){
//         Console.WriteLine($"{i} - {produtos[i]}");
//         }
//     }
// }
// ---------- BANCO COM LISTA---------------

// using System.ComponentModel;

// class Banco{
//     protected double saldo = 0;
//     protected double numero =0;

//     private List<string> historico;
    
//     public Banco(int numero){
//         this.numero = numero;
//         historico = new List<string>();
    
//     }
//     public void Depositar(int valor){
//         if(valor<=0){
//           return;
//           }
//         else{
//             saldo += valor;
//             historico.Add($"Depositou R${valor}");
//         }
//     }

//     public void sacar(int valor){
//         if(valor>saldo){
//             return;
//         }
//     else{
//         saldo-=valor;
//          historico.Add($"Sacou R${valor}");
//     }       
//     }
//     public double Getsaldo(){
//         return saldo;
//     }
//     public double GetnumeroConta(){
//         return numero;
//     }
//     public void ImprimirHistorico(){
//         foreach (string op in historico)
//         {
//         Console.WriteLine(op);
//         }
//     }

//     // ISSO DAQUI É SE EU FOSSE CRIAR OUTRO EQUALS SO QUE COM OUTRO NOME 
//     // public bool Igual(Banco outroBanco){
//     //     return numero == outroBanco.numero;
//     // }


//     // ISSO DAQUI É PRA COMPARAR SE UMA CONTA É IGUAL A OUTRA ENTRE VARIAVEIS SEM PRECISAR DE CRIAR OUTRAS
//     public override bool Equals(object? obj)
//     {
        
//         Banco outraConta = (Banco)obj!;
//         return numero == outraConta.numero;
//         }
//     }

class Produtos{
    protected string nome = "";
    protected int preco;

    public Produtos(string nome, int preco){
        this.nome = nome;
        this.preco = preco;
    }
    public override bool Equals(object? obj)
    {
        Produtos outroProduto = (Produtos)obj!;
        return nome == outroProduto.nome;
    }
}