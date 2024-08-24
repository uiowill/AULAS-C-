using Microsoft.VisualBasic;

class Aluno{
    private double matricula;
    private string nome;
    private double nota1;
    private double nota2;
    private double notaTrabalho;

    public double GetDouble(){
        return matricula + nota1 + nota2 + notaTrabalho;
    }
    public string GetString(){
        return nome;
    }
        public double soma(double soma){
        soma = nota1 + nota2 + notaTrabalho;
        return soma / 3;
    }


}