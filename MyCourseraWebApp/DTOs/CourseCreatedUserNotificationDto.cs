using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCourseraWebApp.Models;

namespace MyCourseraWebApp.DTOs
{
    public class CourseCreatedUserNotificationDto
    {
        public CourseCreatedNotificationDto Notification { get; set; }
        public bool IsDismissed { get; set; }
        public bool IsSeen { get; set; }
    }
}