using Microsoft.AspNetCore.Mvc;
using QuizApplication.Models;
using System.Collections.Generic;  
using System.Linq;  

namespace QuizApplication.Controllers {
    public class QuizController : Controller {
        QuizDataAccessLayer objquiz = new QuizDataAccessLayer();
        
        [HttpGet]
        public IActionResult Quiz() {
            List<Quiz> ListQuestions = new List<Quiz>();  
            ListQuestions = objquiz.GetAllQuestions(1).ToList();

            return View(ListQuestions);
        }

        [HttpPost]
        public IActionResult Quiz(int id, int QuestionID) {
            if (id <= 5) {
                List<Quiz> ListQuestions = new List<Quiz>();
                ListQuestions = objquiz.GetAllQuestions(id).ToList();

                return View(ListQuestions);
            } else {
                return View("Score");
            }
        }
    }
}