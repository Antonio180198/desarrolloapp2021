//calcular la paga total de un trabajador

using System;

namespace p04_pagatrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, salida;
            int horas;
            float pago, pagobruto, impuesto, pagoneto;
            const float tasa=0.3f;

            Console.WriteLine("Calculando la paga de un trabjador\n");
            Console.Write("Dame tu nombre  "); nombre=Console.ReadLine();
            Console.Write("Horas trbajadas "); horas=int.Parse(Console.ReadLine());
            Console.Write("Pago por hora ");pago=float.Parse(Console.ReadLine());

            pagobruto=horas*pago;
            impuesto=pagobruto*tasa;
            pagoneto=pagobruto-impuesto;

            salida=$"\n El trabajador {nombre}, trabajo {horas} horas, con un pago de {pago}\n" +
                    $"Pago bruto: {pagobruto}\n impuesto: {impuesto}\n pago neto:{pagoneto}";

            Console.WriteLine(salida);
        }
    }
}
