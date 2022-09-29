var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
  
namespace DocInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of the project!");
        }
    }
     
    class User
    {
        int id;
        string phoneNumber;
        string name;
        Role role;
        
        User()
        {
            Registration();
        }
        
        private void Registration()
        {
            
        }
        
        private void Authorization()
        {
            
        }
    } 
     
    class Doctor
    {
        int id;
        string name;
        Speciality speciality;
        
        Doctor()
        {
            AddDoctor();
        }
        
        void AddDoctor()
        {
            
        }
        
        void RemoveDoctor()
        {
            
        } 
        
        List<Doctor> GetDoctorList()
        {
            return null;
        }
        
        Doctor GetDoctorById(Doctor id)
        {
            return null;
        }
    }
    
    class Appointment
    {
        DateTime appointmentStart;
        DateTime appointmentEnd;
        int patientId;
        int doctorId;
        
        void GetDoctorSchedule()
        {
            
        }
        
        void SaveAppointment()
        {
            
        }
        
        List<DateOnly> GetFreeDate()
        {
            return null;
        }
        
        void ChangeSchedule()
        {
            
        }
    } 
     
    class Role
    {
        private string role;
        
        Role GetRole()
        {
            return null;
        }
    }
     
    class Speciality
    {
        int id;
        string name;
        
        List<Speciality> GetSpecialitiesList()
        {
            return null;
        }
    }
     
    class Schedule
    {
        int doctorId;
        TimeOnly workdayStart;
        TimeOnly workdayEnd;
    }
}
