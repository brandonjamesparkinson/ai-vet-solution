using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VetClinicApp.Data;
using VetClinicApp.Models;

namespace VetClinicApp.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _context;

        public AppointmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Appointment>> GetAppointmentsByDateAsync(DateTime date)
        {
            return await _context.Appointments
                .Include(a => a.Patient)
                    .ThenInclude(p => p.Client)
                .Include(a => a.Doctor)
                .Where(a => a.StartTime.Date == date.Date)
                .OrderBy(a => a.StartTime)
                .ToListAsync();
        }

        public async Task<Appointment> GetAppointmentByIdAsync(int id)
        {
            return await _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Doctor)
                .FirstOrDefaultAsync(a => a.AppointmentId == id);
        }

        public async Task<Appointment> CreateAppointmentAsync(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return appointment;
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            _context.Entry(appointment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Doctor>> GetDoctorsAsync()
        {
            var doctors = await _context.Doctors.ToListAsync();
            if (!doctors.Any())
            {
                // Seed a default doctor if none exists
                var doc = new Doctor { FirstName = "Sarah", LastName = "Smith", Specialty = "General Practice" };
                _context.Doctors.Add(doc);
                await _context.SaveChangesAsync();
                doctors.Add(doc);
            }
            return doctors;
        }
    }
}
