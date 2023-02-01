namespace Ugly_Number;
class Program
{
    public bool NumeroFeio(int numero){
        //vamos verificar o número, se é "feio" ou não
        //se ele for menor que 1, não é feio
        if( numero < 1){
            Console.WriteLine("Não");
            return false;
        }

        //Dividindo o número
        while (numero > 1){
            if (numero % 2 == 0){
                numero = numero/2;
            }
            else if (numero % 3 == 0){
                numero = numero/3;
            }
            else if (numero % 5 == 0){
                numero = numero/5;
            }
            else{
                Console.WriteLine("Não");
                return false;
            }
        }
        //Saindo dessa exceção, dizer sim
        Console.WriteLine("Sim");
        return true;
    }
    static void Main(string[] args)
    {

        Program verificar = new Program();
        //inserir os números
        int numero;

        Console.Write("Insira o número aqui: ");
        numero = Console.Read();

        //verificar o número
        verificar.NumeroFeio(numero);
    }
}
