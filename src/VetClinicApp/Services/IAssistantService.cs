using System.Threading.Tasks;

namespace VetClinicApp.Services
{
    public interface IAssistantService
    {
        Task<string> GetPatientSummaryAsync(string patientDataPrompt);
    }
}
