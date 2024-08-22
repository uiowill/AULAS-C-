using System.Reflection;

// class Circulo{
//  public double raio;// DEIXAR COMO PUBLIC DEIXA PARA QUE OUTRAS PASTAS CONSIGAM LER

// public double CalcularDiamentro(){
//     return raio * 2;
// }
// }

class Retangulo{
    public double largura;
    public double altura;
    public double CalcularAltura(){
        return largura * altura;
    }
    public double CalcularPerimetro(){
        return 2*(largura + altura);
    }


}