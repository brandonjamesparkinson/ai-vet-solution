using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinicApp.Models;

namespace VetClinicApp.Services
{
    public interface IVetService
    {
        // Client operations
        Task<List<Client>> GetClientsAsync();
        Task<Client> GetClientByIdAsync(int clientId);
        Task<Client> AddClientAsync(Client client);
        Task UpdateClientAsync(Client client);
        Task DeleteClientAsync(int clientId);

        // Patient operations
        Task<List<Patient>> GetPatientsByClientIdAsync(int clientId);
        Task<Patient> GetPatientByIdAsync(int patientId);
        Task<Patient> AddPatientAsync(Patient patient);
        Task UpdatePatientAsync(Patient patient);
        Task DeletePatientAsync(int patientId);

        // Medical Record operations
        Task<List<MedicalRecord>> GetMedicalRecordsByPatientIdAsync(int patientId);
        Task<MedicalRecord> AddMedicalRecordAsync(MedicalRecord record);
        Task UpdateMedicalRecordAsync(MedicalRecord record);
        Task DeleteMedicalRecordAsync(int recordId);
    }
}
