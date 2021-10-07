using System;

namespace FezaCisimleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Cone cone = new Cone();
            Console.WriteLine("Konusun sahesinin ve hecminin hesablanmasi\n");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Konusun hunduluyun,dogurganligin ve radiusun  daxil edin");
            Console.Write("Height: ");
            cone.Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Radius: ");
            cone.Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Slant_Height: ");
            cone.Slant_Height = Convert.ToDouble(Console.ReadLine());
            double ara = cone.Area();
            Console.WriteLine("Konusun Sahesi:"+ara);
            double volum = cone.Volume();
            Console.WriteLine("Konusun Hecmi:" + volum);
            Console.WriteLine("**************************************");



            Cylinder cly = new Cylinder();
            Console.WriteLine("Silindirin sahesinin ve hecminin hesablanmasi\n");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Silindirin hunduluyun,dogurganligin ve radiusun  daxil edin");
            Console.Write("Height: ");
            cly.Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Radius: ");
            cly.Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Slant_Height: ");
            cly.Slant_Height = Convert.ToDouble(Console.ReadLine());
            double area = cly.Area();
            Console.WriteLine("Silindirin Sahesi:" + area);
            double volumcly = cly.Volume();
            Console.WriteLine("Silindirin Hecmi:" + volumcly);
            Console.WriteLine("***********************************************************");

            RectangularParallelepiped recpa = new RectangularParallelepiped();
            Console.WriteLine("Duzbucaqli Paralepiped sahesinin ve hecminin hesablanmasi\n");
            Console.WriteLine("*********************************************");
            Console.WriteLine("Duzbucaqli Paralepipedin tereflerini  daxil edin");
            Console.Write("a: ");
            recpa.a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            recpa.b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
           recpa.c = Convert.ToDouble(Console.ReadLine());
            double arearecpar = recpa.Area();
            Console.WriteLine("Silindirin Sahesi:" + arearecpar);
            double volumrecpar = recpa.Volume();
            Console.WriteLine("Silindirin Hecmi:" + volumrecpar);



        }
    }
}
