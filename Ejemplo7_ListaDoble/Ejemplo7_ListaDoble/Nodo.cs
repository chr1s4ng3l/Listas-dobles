/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 09/09/2019
 * Hora: 03:39 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejemplo7_ListaDoble
{
	/// <summary>
	/// Description of Nodo.
	/// </summary>
	public class Nodo
	{
		private int dato;
		public Nodo  Izq,Der;
		
		public Nodo()
		{
		}
		public Nodo(int dato){
			this.dato=dato;
			
		}
		public int GetDato(){
			return this.dato;
		}
		
		public int Dato{
			
			get{
				return this.dato;
			}
			
			set{
				if(value>0)
					this.dato = value;
					else
						this.dato=0;
			}
		}
	}
}
