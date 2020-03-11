/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 18/09/2019
 * Hora: 09:29 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejemplo7_ListaDoble
{
	class Program
	{
		public static Boolean eliminarNodo( ref Nodo inicio,ref Nodo fin, int datoEliminar){
			Nodo anterior, siguiente;
			anterior=new Nodo();
			siguiente=new Nodo();
			Nodo actual=Buscar(inicio, datoEliminar);
			if(actual == null)
				return false;
			if(actual==inicio){
				inicio=inicio.Der;
				inicio.Izq=null;
			}else if(actual==fin){
				fin=fin.Izq;
				fin.Der=null;
				
				
			}else{
				anterior=actual.Izq;
				siguiente=actual.Der;
				anterior.Der=siguiente;
				siguiente.Izq=anterior;
			}
			
		return true;
	
	}
	public static Boolean InsertarNuevoNodo( Nodo inicio,ref Nodo fin, int datoBuscar, int datoInsertar){
		Nodo temp, aux;
		Nodo actual=Buscar(inicio, datoBuscar);
		if(actual == null)
			return false;
		aux = new Nodo(datoInsertar);
		if(actual.Der!=null){
			temp = actual.Der;
			
			actual.Der = aux;
			aux.Izq = actual;
			aux.Der = temp;
			temp.Izq = aux;
		}else{
			
			actual.Der=aux;
			aux.Izq = actual;
			fin=aux;
			
		}
		return true;
	}
	
	public static Nodo Buscar(Nodo actual, int dato){
		if(actual==null)
			return  null;
		
		if(actual.Dato == dato)
			return actual;
		else
			return Buscar(actual.Der,dato);
		
	}
	public static String MostrarLista(Nodo actual, String cadena){
		if(actual.Der != null){
			cadena+=actual.Dato+","+ MostrarLista(actual.Der, cadena);
		}
		else{
			cadena = actual.Dato.ToString();
		}
		
		return cadena;
	}
	public static void InsertarNodo(ref Nodo end, ref Nodo start, int dato){
		
		Nodo aux = new Nodo(dato);
		if(end!=null){//cuando tenga uno o ms elementos
			
			end.Der = aux;
			aux.Izq = end;
			
		}else{// la lista este vacia
			
			start=aux;
		}
		end=aux;
		
	}
	public static void Main(string[] args)
	{
		Nodo inicio,fin;
		inicio = null;
		fin = null;
		
		InsertarNodo(ref fin,ref inicio, 10);
		InsertarNodo(ref fin, ref inicio, 5);
		InsertarNodo(ref fin, ref inicio, 7);
		
		String lista =	MostrarLista(inicio, "");
		Console.WriteLine(" La lista es: " +lista);
		
		InsertarNuevoNodo( inicio, ref fin, 10, 8);
		lista =	MostrarLista(inicio, "");
		Console.WriteLine(" La lista despues de insertar es: " +lista);
		
		
		Boolean el =eliminarNodo( ref inicio, ref fin, 5);
		lista =	MostrarLista(inicio, "");
		Console.WriteLine(" La lista despues de eliminar es: " +lista);
//			Console.WriteLine(" El dato Inicio es: "+inicio.Dato);
//			Console.WriteLine(" El dato Fin es: "+fin.Dato);
		if(el ==false)
			Console.WriteLine(" El dato a eliminar no se encontro.");
        else
        	Console.WriteLine(" El dato se elimino con exito.");
		
		Nodo pos = Buscar(inicio, 5);

		if(pos!=null)
			Console.WriteLine(" El valor fue encotrado:  "+pos.Dato);
		else
			Console.WriteLine(" No encontrado ");
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
}