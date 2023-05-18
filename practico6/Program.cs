// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// int a;
// int b;

// a=10;
// b=a;

// Console.WriteLine(" valor de a :" + a);
// Console.WriteLine(" valor de b :" +b);

Console.WriteLine("Ingrese un numero:");
String? num = Console.ReadLine();
int number;
if (int.TryParse(num, out number))
{
    if(number>=10){
        int resto =0;
        int divisor =number;
        int invertido=0;
        int i= 10;
        do
        {
            resto = divisor % 10;
            divisor = divisor / 10;
            invertido = invertido*i + resto;
            // i = i*10; 
        } while (divisor>0);
     Console.WriteLine("Numero original:" + number);
     Console.WriteLine("Numero Invertido: " + invertido);
    }
}else{
    Console.WriteLine("No ingreso un numero");
}