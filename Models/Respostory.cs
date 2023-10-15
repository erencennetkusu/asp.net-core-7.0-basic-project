namespace basics.Models
{
    public class Respostory
    {
        private static readonly List<Course> _courses = new();

        static Respostory()
        {
            _courses = new List<Course>(){

            new Course(){
                Id=1,
             Title="asp.Net Kursu",
              Description="Guzel bir proje",
              Image="1.jpg",
              Tags = new string[]{"aspnet","asp.net core","web geliştirme"},
              isActive = true,
              isHome = true
              },
            new Course(){
                Id=2,
             Title="php Kursu",
              Description="Guzel bir proje",
              Image="2.jpg",
              Tags = new string[]{"php","asp.net core","web geliştirme"},
              isActive = true,
              isHome = true
              
              },
            new Course(){
                Id=3,
            Title="django Kursu",
             Description="Guzel bir proje",
             Image="3.jpg",
              Tags = new string[]{"django","asp.net core","web geliştirme"},
              isActive = true,
              isHome = true
             },
            new Course(){
                Id=4,
             Title="c# Kursu",
             Description="Guzel bir proje",
             Image="1.jpg",
              Tags = new string[]{"c#","c#","web geliştirme"},
              isActive = true,
              isHome = true
             },
            new Course(){
                Id=5,
             Title="javascript Kursu",
              Description="Guzel bir proje",
              Image="1.jpg",
              Tags = new string[]{"javascript","javascript","web geliştirme"},
              isActive = true,
              isHome = true
              },
            new Course(){
                Id=6,
                 Title="Laravel Kursu",
                  Description="Guzel bir proje",
                  Image="1.jpg",
              Tags = new string[]{"Laravel","Laravel","web geliştirme"},
              isActive = true,
              isHome = true
                  }
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return Courses.FirstOrDefault(c => c.Id == id);
        }
    }
}