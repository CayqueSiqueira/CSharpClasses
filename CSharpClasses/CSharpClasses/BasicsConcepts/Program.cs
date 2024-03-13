bool prossiga = true;

do

{

    try //tratativa de erro 

    {

        Console.WriteLine("Informe o peso");
        float peso = float.Parse(Console.ReadLine());//Console.ReadLine() entrada de dado 

        Console.WriteLine("Informe o peso");
        float altura = float.Parse(Console.ReadLine());

        float imc = peso / (altura * altura);
        Console.WriteLine($"o imc é {imc:f1}"); //o :f1 é pra tratar as casas depois da virgula 
        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
            break;
        }
        else if (imc < 24.9)
        {
            Console.WriteLine("Peso normal");
            break;
        }
        else if (imc < 29.9)
        {
            Console.WriteLine("Sobrepeso");
            break;
        }
        else if (imc < 34.9)
        {
            Console.WriteLine("Obesidade grau 1 ");
            break;
        }
        else if (imc < 39.9)
        {
            Console.WriteLine("Obesidade grau 2");
            break;
        }
        else
        {
            Console.WriteLine("Obesidade grau 3");
        }
        prossiga = false;

    }

    catch (FormatException e)//variavel q vai ser o erro 

    {

        Console.WriteLine("Informe apenas números");

        Console.WriteLine(e.Message);// exime a mensagem que ferou o erro 

    }

} while (prossiga);