﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace AjaxModuleTest.Models
{
    public partial class Enrollment
    {
        private int? _courseID;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? CourseID
        {
            get { return this._courseID; }
            set { this._courseID = value; }
        }
        
        private int? _enrollmentID;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? EnrollmentID
        {
            get { return this._enrollmentID; }
            set { this._enrollmentID = value; }
        }
        
        private int? _grade;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Grade
        {
            get { return this._grade; }
            set { this._grade = value; }
        }
        
        private int? _studentID;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? StudentID
        {
            get { return this._studentID; }
            set { this._studentID = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Enrollment class.
        /// </summary>
        public Enrollment()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken courseIDValue = inputObject["CourseID"];
                if (courseIDValue != null && courseIDValue.Type != JTokenType.Null)
                {
                    this.CourseID = ((int)courseIDValue);
                }
                JToken enrollmentIDValue = inputObject["EnrollmentID"];
                if (enrollmentIDValue != null && enrollmentIDValue.Type != JTokenType.Null)
                {
                    this.EnrollmentID = ((int)enrollmentIDValue);
                }
                JToken gradeValue = inputObject["Grade"];
                if (gradeValue != null && gradeValue.Type != JTokenType.Null)
                {
                    this.Grade = ((int)gradeValue);
                }
                JToken studentIDValue = inputObject["StudentID"];
                if (studentIDValue != null && studentIDValue.Type != JTokenType.Null)
                {
                    this.StudentID = ((int)studentIDValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Enrollment
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.CourseID != null)
            {
                outputObject["CourseID"] = this.CourseID.Value;
            }
            if (this.EnrollmentID != null)
            {
                outputObject["EnrollmentID"] = this.EnrollmentID.Value;
            }
            if (this.Grade != null)
            {
                outputObject["Grade"] = this.Grade.Value;
            }
            if (this.StudentID != null)
            {
                outputObject["StudentID"] = this.StudentID.Value;
            }
            return outputObject;
        }
    }
}