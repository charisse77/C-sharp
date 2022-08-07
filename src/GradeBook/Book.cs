namespace GradeBook{
    class Book
    {
        public Book(string name)
        {
            //constructor method: same name as class, no return type, code always executes 
            grades = new List<double>(); 
            this.name = name; 
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue; //starting high grade at lowest possible value 
            var lowGrade = double.MaxValue; 
            foreach(double number in grades)
            {

                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number; 
            }
            result /= grades.Count; 
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}");
        }

        //Field - adding state 
        private List<double> grades; 
        private string name; 
    } 
    
            
}