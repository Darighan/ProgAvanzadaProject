using System;
					
public class Program{
	
	class Usuario{
		private int idUsuario, telefonoUsuario;
			private string nombreUsuario, apellidoUsuario, emailUsuario;
			//date fechaNacimientoUsuario;
		
		public void verificarLogin(){
					
		}
		public void registrarse(){
		
		}
		public void actualizarDatos(){
		
		}
		public void solicitarArriendo(){
			
		}
		public void historialArriendo(){
		
		}
		
	class Secretario : Usuario{
		
		public void revisarArriendo(){
		
		}
		
		public void modificarArriendo(){
		
		}
	
	}	
		class Dueño : Secretario {
			
			public void auditarUsuario(){
			
			}
		
			
		}

		class Arriendo {
			private int idArriendo, precioArriendo; //, idArrendatario;  lo separe porque esto llegaria por una fk
			private string estadoArriendo; //,nombreArrendatario; aqui tambien seria una fk
			//private date fechaInicioArriendo, fechaFinArriendo;  como se llama una fecha a los atributos?

			public void procesarPago(){

			}

			public void datosArriendo(){

			}


		}

		class RecintoDeportivo{
			private string nombreRecinto, direccionRecinto;
			private int telefonoRecinto;
			

		}
		
		class Cancha {
			private string tipodeCancha,estadoCancha;
			private int idCancha,dimensionesCancha,cantJugadores;

			public void agregarCancha(){

			}

			public void eliminarCancha(){

			}

			public void actualizarestado(){

			}

			public void actualizarDatos(){


			}

		



		}
	}
	
	
	
	public static void Main()
	{
		
	}
}