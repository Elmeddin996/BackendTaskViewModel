using Model_ViewModel.Models;
using System.Collections.Generic;

namespace Model_ViewModel.DataAccess
{
    public class Data
    {
        public static List<Student> Students = new List<Student>()
        {
                new Student{ Id = 1,FullName = "Elməddin Mirzəyev", Point=100},
                new Student{ Id = 2,FullName = "Əmrəli Sarsılmaz", Point=100},
                new Student{ Id = 3,FullName = "Elshad Rzaguliyev", Point=100},
                new Student{ Id = 4,FullName = "Kazim Abbasaliyev", Point=100},
                new Student{ Id = 5,FullName = "Hikmat Gulizada", Point=100},
                new Student{ Id = 6,FullName = "Jan Koksal", Point = 100}

        };


        public static List<Group> Groups = new List<Group>()
        {
            new Group{ Id = 1,Name = "P328"},
            new Group{ Id = 1,Name = "P316"},
            new Group{ Id = 1,Name = "D125"},
            new Group{ Id = 1,Name = "DM218"}
        };


    }

}
