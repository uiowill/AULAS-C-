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
Calculadora c = new Calculadora();
Console.WriteLine(c.GetResultado());
c.Soma(5);
Console.WriteLine(c.GetResultado());
c.Soma(30);
Console.WriteLine(c.GetResultado());
c.Subtrair(20);
