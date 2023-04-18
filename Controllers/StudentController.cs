using Microsoft.AspNetCore.Mvc;
using Model_ViewModel.DataAccess;
using Model_ViewModel.Models;
using System.Collections.Generic;


namespace Model_ViewModel.Controllers
{
    public class StudentController:Controller
    {
        public ViewResult Index()
        {

            ViewModel.ViewModel viewM = new ViewModel.ViewModel();
            viewM.Students = Data.Students;
            
            
            viewM.Groups = Data.Groups;

            return View(viewM);
        }

        public ViewResult Detail(int id)
        {
            List<Student> students = Data.Students;

            Student st = students.Find(x => x.Id == id);

            return View(st);
        }
    }
}
