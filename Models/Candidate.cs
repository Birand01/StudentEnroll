using Microsoft.AspNetCore.SignalR;

namespace StudentEnroll.Models
{
    public class Candidate
    {
        public String? Email{get;set;}=String.Empty;
        public String? FirstName{get;set;}=String.Empty;
        public String? LastName{get;set;}=String.Empty;
<<<<<<< HEAD
        public String? FullName=>$"{FirstName} {LastName?.ToUpper()}";
        public int? Age{get;set;}
        public String? SelectedCourse{get;set;}=String.Empty;
        public DateTime ApplyAt{get;set;}

        public Candidate()
        {
            ApplyAt=DateTime.Now;
        }

=======
        public int? Age{get;set;}
        public String? SelectedCourse{get;set;}=String.Empty;
        public DateTime ApplyAt{get;set;}
>>>>>>> 3a9f40c7e3ba5d3926a445594589b540ec90c713
        
        public Candidate()
        {
            ApplyAt=DateTime.Now;
        }
    }






}