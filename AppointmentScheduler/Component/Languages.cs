using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppointmentScheduluer
{
    public class Language
    {
        public static List<string> Languages = new List<string>() { "English","Español" };
        public class Label
        {
            public class LoginView
            {
                public static List<string> Username = new List<string>() { "Username", "Usuario" };
                public static List<string> Password = new List<string>() { "Password", "Contraseña" };
                public static List<string> Title = new List<string>() { "Appointment Scheduler", "Programador de Citas" };
                public static List<string> Status_Please = new List<string>() { "Please login", "Por favor iniciar sesión" };
                public static List<string> Status_Success = new List<string>() { "Logging in...", "Iniciando sesión..." };
                public static List<string> Status_Failure = new List<string>()
                {
                    "Username and password combination not found.",
                    "No se encontró la combinación de nombre de usuario y contraseña."
                };
                public static List<string> Login = new List<string>() { "Login", "Acceso" };
                public static List<string> Language = new List<string>() { "Language", "Idioma" };
                public static List<string> Location = new List<string>() { "Location", "Localización" };
            }
            public class WeeklyView
            {
                public static List<string> appNameLabel = new List<string>() { "Appointment Scheduler", "Programador de Citas" };
                public static List<string> locationLabel = new List<string>()
                {
                    "Displaying times for location:",
                    "Visualización de tiempos para la ubicación:"
                };
                public static List<string> pageLabel = new List<string>() { "Weekly View", "Vista Semanal" };
                public static List<string> timezoneLabel = new List<string>()
                {
                    "Appointment time in:",
                    "Hora de la cita en:"
                };
                public static List<string> customerButton = new List<string>() { "Customers", "Clientes" };
            }
            public class CustomerView
            {
                public static List<string> appNameLabel = new List<string>() { "Appointment Scheduler", "Programador de Citas" };
                public static List<string> pageLabel = new List<string>() { "Customer View", "Vista Cliente" };
                public static List<string> listGroupboxLabel = new List<string>() { "List", "Lista" };
                public static List<string> infoGroupboxLabel = new List<string>() { "Info", "Info" };
                public static List<string> searchLabel = new List<string>() { "Search", "Buscar" };
                public static List<string> listLabel = new List<string>() { "List", "Lista" };
                public static List<string> nameLabel = new List<string>() { "Name", "Nombre" };
                public static List<string> addressLabel = new List<string>() { "Address", "Dirección" };
                public static List<string> address2Label = new List<string>() { "Address 2", "Dirección 2" };
                public static List<string> cityLabel = new List<string>() { "City", "Ciudad" };
                public static List<string> postalCodeLabel = new List<string>() { "Postal Code", "Código Postal" };
                public static List<string> countryLabel = new List<string>() { "Country", "País" };
                public static List<string> phoneLabel = new List<string>() { "Phone", "Teléfono" };
                public static List<string> statusLabel = new List<string>() { "Status", "Estado" };
                public static List<string> activeButton = new List<string>() { "Active", "Activa" };
                public static List<string> inactiveButton = new List<string>() { "Inactive", "Inactiva" };
                public static List<string> editButton = new List<string>() { "Edit", "Editar" };
                public static List<string> cancelButton = new List<string>() { "Cancel", "Cancelar" };
                public static List<string> submitButton = new List<string>() { "Submit", "Entrar" };
                public static List<string> backButton = new List<string>() { "Back", "Retroceso" };




                
                
            }
        }
    }
}
