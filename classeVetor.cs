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

// class Produtos{
//     protected string nome = "";
//     protected int preco;

//     public Produtos(string nome, int preco){
//         this.nome = nome;
//         this.preco = preco;
//     }
//     public override bool Equals(object? obj)
//     {
//         Produtos outroProduto = (Produtos)obj!;
//         return nome == outroProduto.nome;
//     }
// }
// ---------------- PESSOA CONTATO 29/08/2024------------
class Pessoa {
    private string nome;
    private string telefone;

    public Pessoa(string nome, string telefone) {
        this.nome = nome;
        this.telefone = telefone;
    }

    public string GetNome() {
        return nome;
    }

    public override string ToString()
    {
        return $"Nome: {nome} | Tel: {telefone}";
    }
} 

class Contatos {
    private List<Pessoa> lista = new List<Pessoa>();

    public void AdicionarPessoa(string nome, string telefone) {
        int indice = BuscarPessoaIndice(nome);

        if (indice >= 0) {
            Console.WriteLine("Pessoa já cadastrada");
            return;
        }

        // Pessoa pessoa = new Pessoa(nome, telefone);
        // lista.Add(pessoa);

        lista.Add(new Pessoa(nome, telefone));
    }

    public void RemoverPessoa(string nome) {
        int indice = BuscarPessoaIndice(nome);

        if(indice < 0) {
            Console.WriteLine("Pessoa não encontrada");
            return;
        }

        lista.RemoveAt(indice);
    }

    public int BuscarPessoaIndice(string nome) {
        for (int i = 0; i < lista.Count; i++) {
            if (nome == lista[i].GetNome()) {
                return i;
            }
        }

        return -1;
    }

    public Pessoa? BuscarPessoaObjeto(string nome) {
        for (int i = 0; i < lista.Count; i++) {
            if (nome == lista[i].GetNome()) {
                return lista[i];
            }
        }

        return null;
    }

    public void ImprimirContatos() {
        foreach (Pessoa pessoa in lista)
        {
            Console.WriteLine(pessoa.ToString());
        }
    }

    public void ImprimirPessoa(string nome) {
        int indice = BuscarPessoaIndice(nome);

        if (indice < 0) {
            Console.WriteLine("Pessoa não encontrada");
            return;
        }

        Console.WriteLine(lista[indice].ToString());
    }
}