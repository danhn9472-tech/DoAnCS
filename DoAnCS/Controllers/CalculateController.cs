using Microsoft.AspNetCore.Mvc;

namespace DoAnCS.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult index()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Calculate(double weight, double height, int age, string gender, string activityLevel)
        {
            if (weight <= 0 || height <= 0 || age <= 0)
            {
                ViewBag.Error = "Please enter valid input values.";
                return View("Index");
            }
            double brm = 0;
            if (gender.ToLower() == "male") //ToLower để chuyển đổi chuỗi thành chữ thường, giúp so sánh không phân biệt chữ hoa chữ thường, gender là tham số chữ dữ liệu về giới tính 
            {
                brm = (10 * weight) + (6.25 * height) - (5 * age) + 5;  //Công thức dành cho nam
            }
            else
            {
                brm = (10 * weight) + (6.25 * height) - (5 * age) - 161; //Công thức dành cho nữ
            }
            double factor = activityLevel switch //Switch expression để xác định hệ số hoạt động dựa trên mức độ hoạt động của người dùng, activityLevel là tham số chữ dữ liệu về mức độ hoạt động
            {
                "sedentary" => 1.2, //Dành cho mức độ vận động ít
                "light" => 1.375, //Vận động nhẹ
                "moderate" => 1.55, //Vận động vừa phải
                "active" => 1.725, //Vận động nhiều
                "very_active" => 1.9, //Vận động rất nhiều
                _ => 1.2 // Giá trị mặc định nếu không khớp
            };


            double tdee = brm * factor; //TDEE = BRM x mức độ hoạt động
            ViewBag.BRM = Math.Round(brm, 2); //Làm tròn BRM đến 2 chữ số thập phân
            ViewBag.TDEE = Math.Round(tdee, 2); //Làm tròn TDEE đến 2 chữ số thập phân
            ViewBag.Protein = Math.Round(weight * 2, 2); //Lượng protein cần thiết (2g protein trên mỗi kg trọng lượng cơ thể)



            return View("CalculateCalories"); //Trả về view

        }*/
    }
}



