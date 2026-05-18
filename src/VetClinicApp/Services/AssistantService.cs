using System.Threading.Tasks;

namespace VetClinicApp.Services
{
    public class AssistantService : IAssistantService
    {
        public async Task<string> GetPatientSummaryAsync(string patientDataPrompt)
        {
            // System prompt instructions for the LLM implementation later:
            // "You are an expert veterinary assistant. Review the provided patient file and medical history. Provide a concise, 3-bullet-point summary of the pet's current status, highlighting any chronic conditions, allergies, or overdue vaccinations."
            
            // Simulate API delay
            await Task.Delay(2000);

            // Dummy implementation returning a static response for UI testing
            return "<ul>\n<li><strong>Patient Status:</strong> Generally healthy, but requires monitoring for previously noted conditions.</li>\n<li><strong>Allergies/Conditions:</strong> Known penicillin allergy. No chronic conditions noted in recent history.</li>\n<li><strong>Vaccinations:</strong> Appears to be up to date based on the latest wellness exam, but verify rabies tag renewal.</li>\n</ul>";
        }
    }
}
