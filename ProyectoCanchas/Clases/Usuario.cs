using System;

public class Usuario{
    private int idUsuario, telefonoUsuario;
	private string nombreUsuario, apellidoUsuario, emailUsuario;
	private DateTime fechaNacimientoUsuario;
		
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

    class Dueño : Secretario{

        
			public void auditarUsuario(){
			
			}
    }


}