using System.Web;
using System.Web.SessionState;

namespace Eurotherm.PatientManagement.Web.Models
{
    public class SharedPatients
    {
        private static object _syncRoot = new object();

        public static Patients Instance
        {
            get
            {
                HttpSessionState session = HttpContext.Current.Session;

                lock (_syncRoot)
                {
                    if (session["PatientsInstance"] == null)
                    {
                        session["PatientsInstance"] = new Patients();
                    }
                }

                return (Patients)session["PatientsInstance"];
            }
        }
    }
}