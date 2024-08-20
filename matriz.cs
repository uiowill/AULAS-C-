int[,] matriz = new int[5 , 5]; // EIXO X E Y
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        matriz[i, j] = 0;
        matriz[j, i] = 1;
                Console.Write(matriz[i, j] + " ");
    }
        Console.WriteLine();
        
}
    Console.WriteLine();
