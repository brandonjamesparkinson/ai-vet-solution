using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinicApp.Models;

namespace VetClinicApp.Services
{
    public interface IAppointmentService
    {
        Task<List<Appointment>> GetAppointmentsByDateAsync(DateTime date);
        Task<Appointment> GetAppointmentByIdAsync(int id);
        Task<Appointment> CreateAppointmentAsync(Appointment appointment);
        Task UpdateAppointmentAsync(Appointment appointment);
        Task DeleteAppointmentAsync(int id);
        Task<List<Doctor>> GetDoctorsAsync();
    }
}
