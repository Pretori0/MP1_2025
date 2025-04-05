/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 2/4/2025
 * Hora: 16:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace MP1_TP1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
            Pila pilanum = new Pila();
            Cola colanum = new Cola();
            llenar(pilanum);
           /* colanum.llenar();
            pilanum.informar();
            colanum.informar();*/
            	
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public void llenar()
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Numero comparable = new Numero(rnd.Next(10, 30));
                elementos.agregar(comparable);
            }
        }
		
		

     }
		
 }