﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _072_ClienteWeb.ProxySomadora {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxySomadora.ISomadora")]
    public interface ISomadora {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISomadora/Somar", ReplyAction="http://tempuri.org/ISomadora/SomarResponse")]
        int Somar(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISomadora/Somar", ReplyAction="http://tempuri.org/ISomadora/SomarResponse")]
        System.Threading.Tasks.Task<int> SomarAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISomadoraChannel : _072_ClienteWeb.ProxySomadora.ISomadora, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SomadoraClient : System.ServiceModel.ClientBase<_072_ClienteWeb.ProxySomadora.ISomadora>, _072_ClienteWeb.ProxySomadora.ISomadora {
        
        public SomadoraClient() {
        }
        
        public SomadoraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SomadoraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SomadoraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SomadoraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Somar(int x, int y) {
            return base.Channel.Somar(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SomarAsync(int x, int y) {
            return base.Channel.SomarAsync(x, y);
        }
    }
}
