﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CollegeManagement.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/fetchData", ReplyAction="http://tempuri.org/IService1/fetchDataResponse")]
        System.Data.DataSet fetchData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/fetchData", ReplyAction="http://tempuri.org/IService1/fetchDataResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> fetchDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CollegeManagement.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CollegeManagement.ServiceReference1.IService1>, CollegeManagement.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet fetchData() {
            return base.Channel.fetchData();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> fetchDataAsync() {
            return base.Channel.fetchDataAsync();
        }
    }
}
