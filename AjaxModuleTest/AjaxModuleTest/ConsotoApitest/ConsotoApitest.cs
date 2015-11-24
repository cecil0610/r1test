﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using AjaxModuleTest;
using Microsoft.Rest;

namespace AjaxModuleTest
{
    public partial class ConsotoApitest : ServiceClient<ConsotoApitest>, IConsotoApitest
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private ServiceClientCredentials _credentials;
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        public ServiceClientCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private ICourses _courses;
        
        public virtual ICourses Courses
        {
            get { return this._courses; }
        }
        
        private IEnrollments _enrollments;
        
        public virtual IEnrollments Enrollments
        {
            get { return this._enrollments; }
        }
        
        private IStudents _students;
        
        public virtual IStudents Students
        {
            get { return this._students; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ConsotoApitest class.
        /// </summary>
        public ConsotoApitest()
            : base()
        {
            this._courses = new Courses(this);
            this._enrollments = new Enrollments(this);
            this._students = new Students(this);
            this._baseUri = new Uri("http://conapi2.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the ConsotoApitest class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ConsotoApitest(params DelegatingHandler[] handlers)
            : base(handlers)
        {
            this._courses = new Courses(this);
            this._enrollments = new Enrollments(this);
            this._students = new Students(this);
            this._baseUri = new Uri("http://conapi2.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the ConsotoApitest class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ConsotoApitest(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
            : base(rootHandler, handlers)
        {
            this._courses = new Courses(this);
            this._enrollments = new Enrollments(this);
            this._students = new Students(this);
            this._baseUri = new Uri("http://conapi2.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the ConsotoApitest class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ConsotoApitest(Uri baseUri, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._baseUri = baseUri;
        }
        
        /// <summary>
        /// Initializes a new instance of the ConsotoApitest class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ConsotoApitest(ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the ConsotoApitest class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ConsotoApitest(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._baseUri = baseUri;
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
    }
}