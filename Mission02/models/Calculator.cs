using System;
using System.ComponentModel.DataAnnotations;

namespace Mission02.models
{
    public class CalculatorModel
    {
//        <asp:RangeValidator runat = "server" Type="Integer" 
//MinimumValue="0" MaximumValue="400" ControlToValidate="ValueTextBox" 
//ErrorMessage="Value must be a whole number between 0 and 400" />
        [Required]
        public float assignments { get; set; }
        [Required]
        public float groupprojects { get; set; }
        [Required]
        public float quizzes { get; set; }
        [Required]
        public float exams { get; set; }
        [Required]
        public float intex { get; set; }
    }
}
