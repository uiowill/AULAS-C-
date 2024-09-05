// // Circulo c = new Circulo();
// // c.raio=2;
// // double d = c.CalcularDiamentro();
// // Console.WriteLine(d);

// // CIRCULO C ESTÁ PEGADO DE CLASSE

// Retangulo c = new Retangulo();
// c.altura=2;
// c.largura=4; 
// double d = c.CalcularAltura();
// double e = c.CalcularPerimetro();

// Console.WriteLine("A altura é " + d + " O perimetro é " + e);

// Pessoa a1 = new Pessoa("Pedro", 1965, 1.45);

// var nome = a1.mostrarIdade();

// -----------------------------REDIMENSIONAR--------------------------
// Quadrado q1 = new Quadrado(4);
// Console.WriteLine(q1.calcularArea());

// q1.Redimensionar(10);
// Console.WriteLine(q1.calcularArea());
// -------------------------------CONTA DE BANCO------------------
// Banco x1 = new Banco(12345678, 15);
// x1.saque(15);
// Console.WriteLine($"Conta: {x1.Getsaldo()} - Saldo: {x1.GetnumeroConta()}");
// x1.deposito(20);
// Console.Write($"Conta: {x1.Getsaldo()} - Saldo: {x1.GetnumeroConta()}");
// -------------------------------MEDIA ALUNO------------------
// Aluno a1= new Aluno(1, "A,", 9, 9, 9);
// Console.WriteLine(a1.CalculoNotaProvaFinal());
// -----------------------------PROTECTED E HERDAR-----------------

// Funcionario p = new Funcionario(2, "pedreiro", "Oid", 094);
// p.ImprimirDetalhes();

// -----------------------PRODUTOS----------------
// var a1 = new Animal(true, "");
// // a1.ToString();
// var c1 = new Cachorro(false, "au");
// // c1.ToString();
// var g1 = new Gato(true, "miau");
// // g1.ToString();
// var p1 = new Passaro(false, "piu");
// p1.ToString();
// ----------------- CALCULADORA-----------------
// Calculadora c = new Calculadora();
// Console.WriteLine(c.GetResultado());
// c.Soma(5);
// Console.WriteLine(c.GetResultado());
// c.Soma(30);
// Console.WriteLine(c.GetResultado());
// c.Subtrair(20);
// -------------------- VETOR-------------
// using System.Security.Cryptography;

// Banco b1 = new Banco(1);
// // Banco b2 = new Banco(2);
// b1.Depositar(40);
// b1.sacar(25);
// b1.sacar(4);
// b1.ImprimirHistorico();
// Console.WriteLine($"Saldo: R${b1.Getsaldo()}");

// --------------- TESTAR PRA VER SE É IGUAL

// Produtos p1 = new Produtos("oi", 43);
// Produtos x1 = new Produtos("ofdsafds", 43);

// Console.WriteLine(p1.Equals(x1));


// -------- PESSOA TELEFONE VETOR CONTATO
// Contatos contatos = new Contatos();
// contatos.AdicionarPessoa("A", "1");
// contatos.AdicionarPessoa("B", "2");
// contatos.AdicionarPessoa("C", "3");
// contatos.AdicionarPessoa("D", "4");

// contatos.RemoverPessoa("E");

// contatos.ImprimirPessoa("T");

// contatos.ImprimirContatos();

// Rede b1 = new Rede();
// b1.Adicionar("Brasil", 132313);
// b1.Imprimir();
// b1.Remover("Brasil");
// b1.Imprimir();
// b1.Atualizar();

///

Empresa empresa = new Empresa();

pessoaFisica pessoaFisica1 = new pessoaFisica(10, "0", "Nome", "dasdsa@hotmail.com");

pessoaFisica pessoaFisica2 = new pessoaFisica(32, "4", "Nome", "fdsakojfkdsa@gmail.com");

pessoaJuridica pessoaJuridica1 = new pessoaJuridica(32, "4", "Nome", "fdsakojfkdsa@gmail.com");

pessoaJuridica pessoaJuridica2 = new pessoaJuridica(34, "4", "Nome", "fdsakojfkdsa@gmail.com");

empresa.Adicionar(pessoaFisica1);
empresa.Adicionar(pessoaJuridica1);

empresa.listarPessoasFisica();
empresa.listarPessoasJuridica();