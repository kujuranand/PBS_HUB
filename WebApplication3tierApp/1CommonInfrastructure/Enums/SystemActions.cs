using _1CommonInfrastructure.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Enums
{
    public enum SystemActions
    {

        Administration = 1,

        [ActionGroupDescription("Student", "View")]
        StudentView,

        [ActionGroupDescription("Student", "Create")]
        StudentCreate,

        [ActionGroupDescription("Student", "Update")]
        StudentUpdate,

        [ActionGroupDescription("Student", "Delete")]
        StudentDelete,

        [ActionGroupDescription("Course", "View")]
        CourseView,

        [ActionGroupDescription("Course", "Create")]
        CourseCreate,

        [ActionGroupDescription("Course", "Update")]
        CourseUpdate,

        [ActionGroupDescription("Course", "Delete")]
        CourseDelete,

        [ActionGroupDescription("Employee", "View")]
        EmployeeView,

        [ActionGroupDescription("Employee", "Create")]
        EmployeeCreate,

        [ActionGroupDescription("Employee", "Update")]
        EmployeeUpdate,

        [ActionGroupDescription("Employee", "Delete")]
        EmployeeDelete,

        [ActionGroupDescription("Practitioner", "View")]
        PractitionerView,

        [ActionGroupDescription("Practitioner", "Create")]
        PractitionerCreate,

        [ActionGroupDescription("Practitioner", "Update")]
        PractitionerUpdate,

        [ActionGroupDescription("Practitioner", "Delete")]
        PractitionerDelete,

        [ActionGroupDescription("Client", "View")]
        ClientView,

        [ActionGroupDescription("Client", "Create")]
        ClientCreate,

        [ActionGroupDescription("Client", "Update")]
        ClientUpdate,

        [ActionGroupDescription("Client", "Delete")]
        ClientDelete, 

        [ActionGroupDescription("Subject", "View")]
        SubjectView,

        [ActionGroupDescription("Subject", "Create")]
        SubjectCreate,

        [ActionGroupDescription("Subject", "Update")]
        SubjectUpdate,

        [ActionGroupDescription("Subject", "Delete")]
        SubjectDelete
    }
}



namespace _1CommonInfrastructure.Enums
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ActionGroupDescriptionAttribute : DescriptionAttribute
    {
        public string Group { get; set; }
        public string Action { get; set; }

        public ActionGroupDescriptionAttribute(string group, string action, string description = "")
        {
            this.Group = group;
            this.Action = action;
            this.DescriptionValue = string.IsNullOrEmpty(description) ? $"{group} - {action}" : description;
        }
    }
}