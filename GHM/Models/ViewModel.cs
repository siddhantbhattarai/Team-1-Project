namespace GHM.Models
{
    
    /// Represents a module view model.
    public class ModuleViewModel
    {
        
        /// Gets or sets the module ID.
        public int Id { get; set; }

        
        /// Gets or sets the module name.
        public string Name { get; set; }
    }

    
    /// Represents a teacher view model.
    public class TeacherViewModel
    {
        
        /// Gets or sets the teacher ID.
        public int Id { get; set; }

        
        /// Gets or sets the teacher name.
        public string Name { get; set; }

        
        /// Gets or sets the module ID.
        public int ModuleId { get; set; }

        /// Gets or sets the module name
        public string Module { get; set; }
    }

    
    /// Represents a feedback question view model.
    public class FeedbackQuestionViewModel
    {
        
        /// Gets or sets the feedback question ID.
        public int Id { get; set; }
    
        
        /// Gets or sets the question 1.
        public string Qn { get; set; }
        public string Q1 { get; set; }
    
        
        /// Gets or sets the question 2.
        public string Q2 { get; set; }
    
        
        /// Gets or sets the question 3.
        public string Q3 { get; set; }
    
        
        /// Gets or sets the question 4.
        public string Q4 { get; set; }
        
        /// Gets or sets the answer.
    }

    public class FeedbackViewModel
    {
        public int SelectedModule { get; set; }
        public int SelectedTeacher { get; set; }
        public List<ModuleViewModel> Modules { get; set; }
        public List<TeacherViewModel> Teachers { get; set; }
        public List<int> Answers { get; set; } = new List<int>();
        public List<FeedbackQuestionViewModel> FeedbackQuestions { get; set; }
        // public int Answer { get; set; }
    }


}