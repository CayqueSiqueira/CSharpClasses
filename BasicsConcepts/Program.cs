


using BasicsConcepts;

bool prossiga = true;

do

{

    try //tratativa de erro 

    {

        Console.WriteLine("Informe o peso");
        float peso = float.Parse(Console.ReadLine());//Console.ReadLine() entrada de dado 
        Console.WriteLine("Informe altura");
        float altura = float.Parse(Console.ReadLine());
        CalculadoraIMC calculadoraIMC = new CalculadoraIMC();
        float imc = calculadoraIMC.Calcular(peso, altura);
        Console.WriteLine(imc);
        Console.WriteLine(calculadoraIMC.Status(imc));
        prossiga = false;

    }

    catch (FormatException e)//variavel q vai ser o erro 

    {

        Console.WriteLine("Informe apenas números");

        Console.WriteLine(e.Message);// exime a mensagem que ferou o erro 

    }

} while (prossiga);