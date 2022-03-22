using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZOI.APP.Models
{
    public class CoursePhase1
    {

        //personalDetails
        [Required(ErrorMessage="Kindly Provide Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Kindly Provide Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Kindly Provide City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Kindly Provide Pincode")]
        public string Pincode { get; set; }
        [Required(ErrorMessage = "Kindly Provide State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Kindly Provide Telephone")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "Kindly Provide Mobile")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Kindly Provide Qualification")]
        public string Qualification { get; set; }
        [Required(ErrorMessage = "Kindly Provide Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Kindly Provide MaritalStatus")]
        public string MaritalStatus { get; set; }
        [Required(ErrorMessage = "Kindly Provide Age")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Kindly Provide DOB")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Kindly Provide Designation")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Kindly Provide Email")]
        public string Email { get; set; }

        //OfficialDetails
        [Required(ErrorMessage = "Kindly Provide Office NUmber")]
        public string OfficeNumber { get; set; }
        [Required(ErrorMessage = "Kindly Provide Occpation")]
        public string Occupation { get; set; }
        [Required(ErrorMessage = "Kindly Provide Office Address")]
        public string OfficeAddress { get; set; }
        [Required(ErrorMessage = "Kindly Provide Office Pincode")]
        public string OfficePincode { get; set; }
        [Required(ErrorMessage = "Kindly Provide Office City")]
        public string OfficeCity { get; set; }
        [Required(ErrorMessage = "Kindly Provide Office State")]
        public string OfficeState { get; set; }

        //Course Details
        [Required(ErrorMessage = "Kindly Provide CourseFrom")]
        public string CourseFrom { get; set; }
        [Required(ErrorMessage = "Kindly Provide CourseTo")]
        public string CourseTo { get; set; }
        [Required(ErrorMessage = "Kindly Provide Place")]
        public string Place { get; set; }
        [Required(ErrorMessage = "Kindly Provide Main Teacher Name")]
        public string MainTeacherName { get; set; }
        [Required(ErrorMessage = "Kindly Provide Initiation Date")]
        public string InitiationDate { get; set; }
        [Required(ErrorMessage = "Kindly Provide Initiator Name")]
        public string InitiatiorName { get; set; }
        [Required(ErrorMessage = "Kindly Provide AMCFrom")]
        public DateTime AMCFrom { get; set; }
        [Required(ErrorMessage = "Kindly Provide AMCTo")]
        public DateTime AMCTo { get; set; }
        [Required(ErrorMessage = "Kindly Provide Place")]
        public string AMCPlace { get; set; }
        [Required(ErrorMessage = "Kindly Provide SSYFrom1")]
        public string SSYFrom1 { get; set; }
        [Required(ErrorMessage = "Kindly Provide SSYTo1")]
        public string SSYTo1 { get; set; }
        [Required(ErrorMessage = "Kindly Provide SSYFRom2")]
        public string SSYFrom2 { get; set; }
        [Required(ErrorMessage = "Kindly Provide SSYTo2")]
        public string SSYTo2 { get; set; }
        [Required(ErrorMessage = "Kindly Provide AMCFrom1")]
        public string AMCFrom1 { get; set; }
        [Required(ErrorMessage = "Kindly Provide AMCTo1")]
        public string AMCTo1 { get; set; }
        [Required(ErrorMessage = "Kindly Provide AMCFrom2")]
        public string AMCFrom2 { get; set; }
        [Required(ErrorMessage = "Kindly Provide AMCTo2")]
        public string AMCTo2 { get; set; }

        //Add Course Details
        [Required(ErrorMessage = "Kindly Provide From")]
        public DateTime AddCourseFrom { get; set; }
        [Required(ErrorMessage = "Kindly Provide To")]
        public DateTime AddCourseTo { get; set; }
        [Required(ErrorMessage = "Kindly Provide Place")]

        public string AddCoursePlace { get; set; }
        [Required(ErrorMessage = "Kindly Provide Parent Teachers Name")]
        public string ParentTeachersName { get; set; }



        //Attachment Detail
        [Required(ErrorMessage = "Kindly Provide Brief Note")]
        public string BriefNote { get; set; }
        [Required(ErrorMessage = "Kindly Provide Certificate")]
        public string Certificate { get; set; }
        [Required(ErrorMessage = "Kindly Provide Photo")]
        public string Photo { get; set; }
        [Required(ErrorMessage = "Kindly Provide Date")]

        public string OathCeremDate { get; set; }
        [Required(ErrorMessage = "Kindly Provide Place")]
        public string OathCeremPlace { get; set; }
        [Required(ErrorMessage = "Kindly Provide Name")]
        public string OathCeremName { get; set; }
        [Required(ErrorMessage = "Kindly Provide Place")]

        public string Place1 { get; set; }
        [Required(ErrorMessage = "Kindly Provide Date")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Kindly Provide Signature")]
        public string Signature { get; set; }



        //Recommend Details

        [Required(ErrorMessage = "Kindly Provide Place")]
        public string RecommendTeacherPlace { get; set; }
        [Required(ErrorMessage = "Kindly Provide Date")]
        public string RecommendTeacherDate { get; set; }

        //Remark Details
        [Required(ErrorMessage = "Kindly Provide Place")]
        public string RemarkPlace { get; set; }
        [Required(ErrorMessage = "Kindly Provide Date")]
        public string RemarkDate { get; set; }
        [Required(ErrorMessage = "Kindly Provide Name")]

        public string Name1 { get; set; }
        [Required(ErrorMessage = "Kindly Provide Region")]

        public string Region { get; set; }


    }
}
