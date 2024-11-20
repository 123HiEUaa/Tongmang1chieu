internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ban hay nhap 2 so khong hoac 1");
        switch()
        {
            case 0:
                InputC();
                break;
            case 1:
                InputF();
                break;
            default:
                break;
        }
    }
    
    private static double CtoF(double c)
    {
        double f = (9.0 / 5) * c + 32;
        return f;
    }

    public static double Ftoc(double f)
    {
        double c = (5.0 / 9) * (f - 32);
        return c;
    }

    private static void InputC ()
    {
        Console.WriteLine("nhap vao gia tri do C va chuyen doi do F");
        float resultC = float.Parse(Console.ReadLine());
        Console.WriteLine("Gia tri do F la : {0}", CtoF(resultC));
    }

    private static void InputF ()
    {
        Console.WriteLine("nhap vao gia tri do F va chuyen doi do C");
        float resultF = float.Parse(Console.ReadLine());
        Console.WriteLine("Gia tri do C la : {0}", Ftoc(resultC));
    }
}