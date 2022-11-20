internal class Program
{
    private static void Main(string[] args)
    {
       int n1,n2;
       Console.WriteLine("digite el primer numero");
       n1=int.Parse(Console.ReadLine());
       Console.WriteLine("digite el primer numero");
       n2=int.Parse(Console.ReadLine());
       if(n1>n2){
        Console.WriteLine("el numero mayor es" + n1);


       }
       else{
        Console.WriteLine("el numero mayor es" + n2);
       }
    }
}