using System.Collections.Generic;
using System.Linq;

namespace Eurotherm.PatientManagement.Web.Models
{
    public class Patients : List<Patient>
    {
        public bool Create(Patient newPatient)
        {
            // Check for any current patients
            if (!this.Any())
            {
                this.Add(newPatient);
                return true;
            }

            // Check for a matching patient
            Patient matchingPatient = this.FirstOrDefault(p => p.Name == newPatient.Name
                                                            && p.Surname == newPatient.Surname
                                                            && p.Dob.Date == newPatient.Dob.Date);
            if (matchingPatient != null)
            {
                // Notification a match already exists
                return false;
            }

            this.Add(newPatient);
            return true;
        }
    }
}