﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication.WebServiceNamespace {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentData", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class StudentData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourseIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourseNameField;
        
        private int GradeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentIDField, value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string CourseID {
            get {
                return this.CourseIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CourseIDField, value) != true)) {
                    this.CourseIDField = value;
                    this.RaisePropertyChanged("CourseID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string CourseName {
            get {
                return this.CourseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CourseNameField, value) != true)) {
                    this.CourseNameField = value;
                    this.RaisePropertyChanged("CourseName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Grade {
            get {
                return this.GradeField;
            }
            set {
                if ((this.GradeField.Equals(value) != true)) {
                    this.GradeField = value;
                    this.RaisePropertyChanged("Grade");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceNamespace.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WindowsFormsApplication.WebServiceNamespace.HelloWorldResponse HelloWorld(WindowsFormsApplication.WebServiceNamespace.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication.WebServiceNamespace.HelloWorldResponse> HelloWorldAsync(WindowsFormsApplication.WebServiceNamespace.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name ReadFromDatabaseResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadFromDatabase", ReplyAction="*")]
        WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseResponse ReadFromDatabase(WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadFromDatabase", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseResponse> ReadFromDatabaseAsync(WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication.WebServiceNamespace.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WindowsFormsApplication.WebServiceNamespace.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication.WebServiceNamespace.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WindowsFormsApplication.WebServiceNamespace.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadFromDatabaseRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadFromDatabase", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequestBody Body;
        
        public ReadFromDatabaseRequest() {
        }
        
        public ReadFromDatabaseRequest(WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ReadFromDatabaseRequestBody {
        
        public ReadFromDatabaseRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadFromDatabaseResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadFromDatabaseResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseResponseBody Body;
        
        public ReadFromDatabaseResponse() {
        }
        
        public ReadFromDatabaseResponse(WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadFromDatabaseResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApplication.WebServiceNamespace.StudentData[] ReadFromDatabaseResult;
        
        public ReadFromDatabaseResponseBody() {
        }
        
        public ReadFromDatabaseResponseBody(WindowsFormsApplication.WebServiceNamespace.StudentData[] ReadFromDatabaseResult) {
            this.ReadFromDatabaseResult = ReadFromDatabaseResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WindowsFormsApplication.WebServiceNamespace.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApplication.WebServiceNamespace.WebService1Soap>, WindowsFormsApplication.WebServiceNamespace.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication.WebServiceNamespace.HelloWorldResponse WindowsFormsApplication.WebServiceNamespace.WebService1Soap.HelloWorld(WindowsFormsApplication.WebServiceNamespace.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WindowsFormsApplication.WebServiceNamespace.HelloWorldRequest inValue = new WindowsFormsApplication.WebServiceNamespace.HelloWorldRequest();
            inValue.Body = new WindowsFormsApplication.WebServiceNamespace.HelloWorldRequestBody();
            WindowsFormsApplication.WebServiceNamespace.HelloWorldResponse retVal = ((WindowsFormsApplication.WebServiceNamespace.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication.WebServiceNamespace.HelloWorldResponse> WindowsFormsApplication.WebServiceNamespace.WebService1Soap.HelloWorldAsync(WindowsFormsApplication.WebServiceNamespace.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication.WebServiceNamespace.HelloWorldResponse> HelloWorldAsync() {
            WindowsFormsApplication.WebServiceNamespace.HelloWorldRequest inValue = new WindowsFormsApplication.WebServiceNamespace.HelloWorldRequest();
            inValue.Body = new WindowsFormsApplication.WebServiceNamespace.HelloWorldRequestBody();
            return ((WindowsFormsApplication.WebServiceNamespace.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseResponse WindowsFormsApplication.WebServiceNamespace.WebService1Soap.ReadFromDatabase(WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequest request) {
            return base.Channel.ReadFromDatabase(request);
        }
        
        public WindowsFormsApplication.WebServiceNamespace.StudentData[] ReadFromDatabase() {
            WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequest inValue = new WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequest();
            inValue.Body = new WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequestBody();
            WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseResponse retVal = ((WindowsFormsApplication.WebServiceNamespace.WebService1Soap)(this)).ReadFromDatabase(inValue);
            return retVal.Body.ReadFromDatabaseResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseResponse> WindowsFormsApplication.WebServiceNamespace.WebService1Soap.ReadFromDatabaseAsync(WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequest request) {
            return base.Channel.ReadFromDatabaseAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseResponse> ReadFromDatabaseAsync() {
            WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequest inValue = new WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequest();
            inValue.Body = new WindowsFormsApplication.WebServiceNamespace.ReadFromDatabaseRequestBody();
            return ((WindowsFormsApplication.WebServiceNamespace.WebService1Soap)(this)).ReadFromDatabaseAsync(inValue);
        }
    }
}
