namespace ProyectoProgramacionAvanzada.Models.Clases
{
    public class Usuario
    {
        private int idUsuario, telefonoUsuario;
        private string nombreUsuario, ApellidoUsuario, emailUsuario, rolUsuario;
        private DateTime fechaNacimientoUsuario;

        public void verificarLogin()
        {

        }

        public void registrarUsuario()
        {

        }

        public void actualizarDatos()
        {

        }

        public void solicitarArriendo()
        {

        }

        public void historialArriendo()
        {

        }

        class Secretario : Usuario
        {
            public void revisarArriendo()
            {

            }

            public void modificarArriendo()
            {

            }

        }

        class Dueño : Secretario
        {
            public void auditarUsuario()
            {

            }
        }

    }
}
