﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using AjaxModuleTest.Models;
using Newtonsoft.Json.Linq;

namespace AjaxModuleTest.Models
{
    public static partial class EnrollmentCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<Enrollment> DeserializeJson(JToken inputObject)
        {
            IList<Enrollment> deserializedObject = new List<Enrollment>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                Enrollment enrollment = new Enrollment();
                enrollment.DeserializeJson(iListValue);
                deserializedObject.Add(enrollment);
            }
            return deserializedObject;
        }
    }
}
