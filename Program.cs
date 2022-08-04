using System;

namespace CsharpAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hola Mundo");
				Console.WriteLine("----------------");
				String numero = "1234567890", OrdenServicio = ""; int operador = numero.Length;
				switch (operador)
				{
				case 0:
				 OrdenServicio = "";
				 break;
				case 4: case 5:	case 6:	case 7:	case 8:
				 OrdenServicio = numero;
				 break;
				
				case 9:
				 OrdenServicio = numero.Substring(0, 9);
				 break;
				
				case 10:
				OrdenServicio = numero.Substring(0, 10);
				break;
		
				
	            default:
				OrdenServicio = numero.Substring(0, 10);
                break;
        }
		Console.WriteLine("----------------");
		Console.WriteLine("OrdenServicio : {0}, NumerosCaracteres : {1}", OrdenServicio, operador); 


	Console.WriteLine("----------------------------------------------------------------------");
		Console.WriteLine("Ver casos de fechas");
		
		DateTime fecha = DateTime.Now;
		string Dia = fecha.Day.ToString(),
		Mes = fecha.Month.ToString(),
		Anio = fecha.Year.ToString(),
		Archivo = "CONVENIO",
		ArchivoPDF = Archivo + '_' + Dia + Mes + Anio + ".PDF";
		
		
        Console.WriteLine("Hoy es {0} del mes {1} de {2}",
            fecha.Day, fecha.Month, fecha.Year);
        DateTime dia_siguiente = fecha.AddDays(1);
        Console.WriteLine("Mañana será {0}",  dia_siguiente.Day);
		
		Console.WriteLine("Nombre del Archivo : {0}", ArchivoPDF); 




        }
    }
}
