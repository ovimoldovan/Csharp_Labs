﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HW2_Front.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AddUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddUser", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AddUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Signin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        HW2_Front.ServiceReference1.SigninResponse Signin(HW2_Front.ServiceReference1.SigninRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Signin", ReplyAction="*")]
        System.Threading.Tasks.Task<HW2_Front.ServiceReference1.SigninResponse> SigninAsync(HW2_Front.ServiceReference1.SigninRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Post", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Post(int idUser, string title, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Post", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> PostAsync(int idUser, string title, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Load", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Load();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Load", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> LoadAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/postedBy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string postedBy(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/postedBy", ReplyAction="*")]
        System.Threading.Tasks.Task<string> postedByAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeletePost", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool DeletePost(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeletePost", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeletePostAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MakeAdmin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool MakeAdmin(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MakeAdmin", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> MakeAdminAsync(string username);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Signin", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SigninRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int isAdmin;
        
        public SigninRequest() {
        }
        
        public SigninRequest(string username, string password, int id, int isAdmin) {
            this.username = username;
            this.password = password;
            this.id = id;
            this.isAdmin = isAdmin;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SigninResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SigninResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int SigninResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int isAdmin;
        
        public SigninResponse() {
        }
        
        public SigninResponse(int SigninResult, int id, int isAdmin) {
            this.SigninResult = SigninResult;
            this.id = id;
            this.isAdmin = isAdmin;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : HW2_Front.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<HW2_Front.ServiceReference1.WebService1Soap>, HW2_Front.ServiceReference1.WebService1Soap {
        
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
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public string AddUser(string username, string password) {
            return base.Channel.AddUser(username, password);
        }
        
        public System.Threading.Tasks.Task<string> AddUserAsync(string username, string password) {
            return base.Channel.AddUserAsync(username, password);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HW2_Front.ServiceReference1.SigninResponse HW2_Front.ServiceReference1.WebService1Soap.Signin(HW2_Front.ServiceReference1.SigninRequest request) {
            return base.Channel.Signin(request);
        }
        
        public int Signin(string username, string password, ref int id, ref int isAdmin) {
            HW2_Front.ServiceReference1.SigninRequest inValue = new HW2_Front.ServiceReference1.SigninRequest();
            inValue.username = username;
            inValue.password = password;
            inValue.id = id;
            inValue.isAdmin = isAdmin;
            HW2_Front.ServiceReference1.SigninResponse retVal = ((HW2_Front.ServiceReference1.WebService1Soap)(this)).Signin(inValue);
            id = retVal.id;
            isAdmin = retVal.isAdmin;
            return retVal.SigninResult;
        }
        
        public System.Threading.Tasks.Task<HW2_Front.ServiceReference1.SigninResponse> SigninAsync(HW2_Front.ServiceReference1.SigninRequest request) {
            return base.Channel.SigninAsync(request);
        }
        
        public bool Post(int idUser, string title, string content) {
            return base.Channel.Post(idUser, title, content);
        }
        
        public System.Threading.Tasks.Task<bool> PostAsync(int idUser, string title, string content) {
            return base.Channel.PostAsync(idUser, title, content);
        }
        
        public System.Data.DataSet Load() {
            return base.Channel.Load();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> LoadAsync() {
            return base.Channel.LoadAsync();
        }
        
        public string postedBy(string title) {
            return base.Channel.postedBy(title);
        }
        
        public System.Threading.Tasks.Task<string> postedByAsync(string title) {
            return base.Channel.postedByAsync(title);
        }
        
        public bool DeletePost(string title) {
            return base.Channel.DeletePost(title);
        }
        
        public System.Threading.Tasks.Task<bool> DeletePostAsync(string title) {
            return base.Channel.DeletePostAsync(title);
        }
        
        public bool MakeAdmin(string username) {
            return base.Channel.MakeAdmin(username);
        }
        
        public System.Threading.Tasks.Task<bool> MakeAdminAsync(string username) {
            return base.Channel.MakeAdminAsync(username);
        }
    }
}