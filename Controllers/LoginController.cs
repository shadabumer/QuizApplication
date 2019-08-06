using Microsoft.AspNetCore.Mvc;
using QuizApplication.Models;

namespace QuizApplication.Controllers {
    public class LoginController: Controller {

        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult  Login(Login model) {
            // Quiz quiz = new Quiz();
            if(model.email == "user@example.com" && model.password == "asdfjkl")
                return RedirectToAction("Quiz", "Quiz"); // id = 1, because we are loading the first quiestion in the view as default.
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    }
}