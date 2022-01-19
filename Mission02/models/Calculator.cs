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
        [Range(0, 100)]
        public float assignments { get; set; }
        [Required]
        [Range(0, 100)]
        public float groupprojects { get; set; }
        [Required]
        [Range(0, 100)]
        public float quizzes { get; set; }
        [Required]
        [Range(0, 100)]
        public float exams { get; set; }
        [Required]
        [Range(0, 100)]
        public float intex { get; set; }
    }
}
