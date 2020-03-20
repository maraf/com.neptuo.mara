using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuo.Mara.Models.Resumes
{
    public class ResumeModel
    {
        public BasicsModel Basics { get; set; }
        public EducationModel[] Education { get; set; }
        public SkillModel[] Skills { get; set; }
        public WorkModel[] Work { get; set; }
        public ProjectModel[] Projects { get; set; }
        public InterestModel[] Interests { get; set; }
    }

    public class BasicsModel
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public string Birth { get; set; }
        public string Summary { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public LocationModel Location { get; set; }
        public ProfileModel[] Profiles { get; set; }
    }

    public class LocationModel
    {
        public string City { get; set; }
        public string CountryCode { get; set; }
    }

    public class ProfileModel
    {
        public string Username { get; set; }
        public string Url { get; set; }
        public string Network { get; set; }
    }

    public class EducationModel
    {
        public string EndDate { get; set; }
        public string StartDate { get; set; }
        public string Area { get; set; }
        public string StudyType { get; set; }
        public string Institution { get; set; }
    }

    public class SkillModel
    {
        public string[] Keywords { get; set; }
        public string Level { get; set; }
        public string Name { get; set; }
    }

    public class WorkModel
    {
        public string Summary { get; set; }
        public string[] Highlights { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class ProjectModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }

    public class InterestModel
    {
        public string Name { get; set; }
    }
}
