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
            public class ReportView
            {
            public static List<string> appNameLabel = new List<string>() { "Appointment Scheduler", "Programador de Citas" };
            public static List<string> pageLabel = new List<string>() { "Report View", "Vista Informes" };
            }
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
                public static List<string> weeklyViewLabel = new List<string>() { "Weekly View", "Vista Semanal" };
                public static List<string> monthlyViewLabel = new List<string>() { "Monthly View", "Vista Semanal" };
                public static List<string> timezoneLabel = new List<string>()
                {
                    "Appointment time in:",
                    "Hora de la cita en:"
                };
                public static List<string> refreshButton = new List<string>() { "Refresh", "Refresca" };
                public static List<string> customerButton = new List<string>() { "Customers", "Clientes" };
                public static List<string> prevButton = new List<string>() { "<  Previous", "<  Previa" };
                public static List<string> nextButton = new List<string>() { "Next  >", "Siguiente  >" };

                public static List<string> mondayLabel = new List<string>() { "Monday", "Lunes" };
                public static List<string> tuesdayLabel = new List<string>() { "Tuesday", "Martes" };
                public static List<string> wednesdayLabel = new List<string>() { "Wednesday", "Miércoles" };
                public static List<string> thursdayLabel = new List<string>() { "Thursday", "Jueves" };
                public static List<string> fridayLabel = new List<string>() { "Friday", "Viernes" };
                
                public static List<string> changeToMonthly = new List<string>() { "Change view to monthly", "Cambiar la vista a mensual" };
                public static List<string> changeToWeekly = new List<string>() { "Change view to weekly", "Cambiar la vista a semanal" };

                public static List<string> reportLabel = new List<string>() { "Generate Reports", "Generar Informes" };
                public static List<string> report1button = new List<string>() { "Appointment Types by Month", "Tipos de Citas por Mes" };
                public static List<string> report2button = new List<string>() { "Consultant Schedules", "Horarios del Consultor" };
                public static List<string> report3button = new List<string>() { "Appointments by Location", "Citas por Localización" };
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
                public static List<string> addButton = new List<string>() { "Add New", "Nuevo" };
                public static List<string> deleteButton = new List<string>() { "Delete", "Borra" };
            }
            public class AppointmentScreen
            {
                public static List<string> pageLabel = new List<string>() { "Appointment Screen", "Vista de Cita" };
                public static List<string> customerPanelLabel = new List<string>() { "Customer Information", "Información al Cliente" };
                public static List<string> deleteButton = new List<string>() { "Delete", "Borra" };
                public static List<string> appointmentPanelLabel = new List<string>() { "Appointment Information", "Información de la Cita" };
                public static List<string> dateLabel = new List<string>() { "Date", "Fecha" };
                public static List<string> startLabel = new List<string>() { "Start", "Comienzo" };
                public static List<string> endLabel = new List<string>() { "End", "Fin" };
                public static List<string> locationLabel = new List<string>() { "Location", "Localización" };
                public static List<string> typeLabel = new List<string>() { "Type", "Tipo" };
                public static List<string> descriptionLabel = new List<string>() { "Description", "Descripción" };
                public static List<string> changeButton = new List<string>() { "Change", "Cambio" };
            }
        }
    }
}
