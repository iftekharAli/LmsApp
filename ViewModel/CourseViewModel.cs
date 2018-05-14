using System;
using System.Collections.Generic;
using System.Text;
using Common.Model;
using Common.ViewModel;
using Model;

namespace ViewModel
{
    public class CourseViewModel:BaseViewModel<Course>
    {
        public CourseViewModel(Course course):base(course)
        {
            Name = course.Name;
            Topic = course.Topic;
            IsFree = course.IsFree;
        }

        public CourseViewModel(Entity entity) : base(entity)
        {
        }

        public string Name { get; set; }
        public string Topic { get; set; }
        public bool IsFree { get; set; }
    }
}
