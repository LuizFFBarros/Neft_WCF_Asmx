﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetFW.ServicoSoapPaciente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PacienteTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class PacienteTO : NetFW.ServicoSoapPaciente.TOBase {
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeMaeField;
        
        private System.Nullable<System.DateTime> NascimentoField;
        
        private NetFW.ServicoSoapPaciente.SexoEnum SexoField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string NomeMae {
            get {
                return this.NomeMaeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeMaeField, value) != true)) {
                    this.NomeMaeField = value;
                    this.RaisePropertyChanged("NomeMae");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<System.DateTime> Nascimento {
            get {
                return this.NascimentoField;
            }
            set {
                if ((this.NascimentoField.Equals(value) != true)) {
                    this.NascimentoField = value;
                    this.RaisePropertyChanged("Nascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public NetFW.ServicoSoapPaciente.SexoEnum Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((this.SexoField.Equals(value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TOBase", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(NetFW.ServicoSoapPaciente.PacienteTO))]
    public partial class TOBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private NetFW.ServicoSoapPaciente.StatusEmRelacaoAoBanco StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public NetFW.ServicoSoapPaciente.StatusEmRelacaoAoBanco Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusEmRelacaoAoBanco", Namespace="http://tempuri.org/")]
    public enum StatusEmRelacaoAoBanco : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NaoModificado = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Modificado = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Adicionado = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Excluido = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SexoEnum", Namespace="http://tempuri.org/")]
    public enum SexoEnum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Masculino = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Feminino = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NaoInformado = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicoSoapPaciente.ServicoSOAPSoap")]
    public interface ServicoSOAPSoap {
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento GetMeusPacientesResult no namespace http://tempuri.org/ não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMeusPacientes", ReplyAction="*")]
        NetFW.ServicoSoapPaciente.GetMeusPacientesResponse GetMeusPacientes(NetFW.ServicoSoapPaciente.GetMeusPacientesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMeusPacientes", ReplyAction="*")]
        System.Threading.Tasks.Task<NetFW.ServicoSoapPaciente.GetMeusPacientesResponse> GetMeusPacientesAsync(NetFW.ServicoSoapPaciente.GetMeusPacientesRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento GetPacientePorIdResult no namespace http://tempuri.org/ não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPacientePorId", ReplyAction="*")]
        NetFW.ServicoSoapPaciente.GetPacientePorIdResponse GetPacientePorId(NetFW.ServicoSoapPaciente.GetPacientePorIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPacientePorId", ReplyAction="*")]
        System.Threading.Tasks.Task<NetFW.ServicoSoapPaciente.GetPacientePorIdResponse> GetPacientePorIdAsync(NetFW.ServicoSoapPaciente.GetPacientePorIdRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento paciente no namespace http://tempuri.org/ não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AtualizaPaciente", ReplyAction="*")]
        NetFW.ServicoSoapPaciente.AtualizaPacienteResponse AtualizaPaciente(NetFW.ServicoSoapPaciente.AtualizaPacienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AtualizaPaciente", ReplyAction="*")]
        System.Threading.Tasks.Task<NetFW.ServicoSoapPaciente.AtualizaPacienteResponse> AtualizaPacienteAsync(NetFW.ServicoSoapPaciente.AtualizaPacienteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMeusPacientesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMeusPacientes", Namespace="http://tempuri.org/", Order=0)]
        public NetFW.ServicoSoapPaciente.GetMeusPacientesRequestBody Body;
        
        public GetMeusPacientesRequest() {
        }
        
        public GetMeusPacientesRequest(NetFW.ServicoSoapPaciente.GetMeusPacientesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetMeusPacientesRequestBody {
        
        public GetMeusPacientesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMeusPacientesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMeusPacientesResponse", Namespace="http://tempuri.org/", Order=0)]
        public NetFW.ServicoSoapPaciente.GetMeusPacientesResponseBody Body;
        
        public GetMeusPacientesResponse() {
        }
        
        public GetMeusPacientesResponse(NetFW.ServicoSoapPaciente.GetMeusPacientesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMeusPacientesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NetFW.ServicoSoapPaciente.PacienteTO[] GetMeusPacientesResult;
        
        public GetMeusPacientesResponseBody() {
        }
        
        public GetMeusPacientesResponseBody(NetFW.ServicoSoapPaciente.PacienteTO[] GetMeusPacientesResult) {
            this.GetMeusPacientesResult = GetMeusPacientesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPacientePorIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPacientePorId", Namespace="http://tempuri.org/", Order=0)]
        public NetFW.ServicoSoapPaciente.GetPacientePorIdRequestBody Body;
        
        public GetPacientePorIdRequest() {
        }
        
        public GetPacientePorIdRequest(NetFW.ServicoSoapPaciente.GetPacientePorIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPacientePorIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetPacientePorIdRequestBody() {
        }
        
        public GetPacientePorIdRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPacientePorIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPacientePorIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public NetFW.ServicoSoapPaciente.GetPacientePorIdResponseBody Body;
        
        public GetPacientePorIdResponse() {
        }
        
        public GetPacientePorIdResponse(NetFW.ServicoSoapPaciente.GetPacientePorIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPacientePorIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NetFW.ServicoSoapPaciente.PacienteTO GetPacientePorIdResult;
        
        public GetPacientePorIdResponseBody() {
        }
        
        public GetPacientePorIdResponseBody(NetFW.ServicoSoapPaciente.PacienteTO GetPacientePorIdResult) {
            this.GetPacientePorIdResult = GetPacientePorIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AtualizaPacienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AtualizaPaciente", Namespace="http://tempuri.org/", Order=0)]
        public NetFW.ServicoSoapPaciente.AtualizaPacienteRequestBody Body;
        
        public AtualizaPacienteRequest() {
        }
        
        public AtualizaPacienteRequest(NetFW.ServicoSoapPaciente.AtualizaPacienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AtualizaPacienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NetFW.ServicoSoapPaciente.PacienteTO paciente;
        
        public AtualizaPacienteRequestBody() {
        }
        
        public AtualizaPacienteRequestBody(NetFW.ServicoSoapPaciente.PacienteTO paciente) {
            this.paciente = paciente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AtualizaPacienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AtualizaPacienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public NetFW.ServicoSoapPaciente.AtualizaPacienteResponseBody Body;
        
        public AtualizaPacienteResponse() {
        }
        
        public AtualizaPacienteResponse(NetFW.ServicoSoapPaciente.AtualizaPacienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AtualizaPacienteResponseBody {
        
        public AtualizaPacienteResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicoSOAPSoapChannel : NetFW.ServicoSoapPaciente.ServicoSOAPSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoSOAPSoapClient : System.ServiceModel.ClientBase<NetFW.ServicoSoapPaciente.ServicoSOAPSoap>, NetFW.ServicoSoapPaciente.ServicoSOAPSoap {
        
        public ServicoSOAPSoapClient() {
        }
        
        public ServicoSOAPSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoSOAPSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoSOAPSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoSOAPSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NetFW.ServicoSoapPaciente.GetMeusPacientesResponse NetFW.ServicoSoapPaciente.ServicoSOAPSoap.GetMeusPacientes(NetFW.ServicoSoapPaciente.GetMeusPacientesRequest request) {
            return base.Channel.GetMeusPacientes(request);
        }
        
        public NetFW.ServicoSoapPaciente.PacienteTO[] GetMeusPacientes() {
            NetFW.ServicoSoapPaciente.GetMeusPacientesRequest inValue = new NetFW.ServicoSoapPaciente.GetMeusPacientesRequest();
            inValue.Body = new NetFW.ServicoSoapPaciente.GetMeusPacientesRequestBody();
            NetFW.ServicoSoapPaciente.GetMeusPacientesResponse retVal = ((NetFW.ServicoSoapPaciente.ServicoSOAPSoap)(this)).GetMeusPacientes(inValue);
            return retVal.Body.GetMeusPacientesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NetFW.ServicoSoapPaciente.GetMeusPacientesResponse> NetFW.ServicoSoapPaciente.ServicoSOAPSoap.GetMeusPacientesAsync(NetFW.ServicoSoapPaciente.GetMeusPacientesRequest request) {
            return base.Channel.GetMeusPacientesAsync(request);
        }
        
        public System.Threading.Tasks.Task<NetFW.ServicoSoapPaciente.GetMeusPacientesResponse> GetMeusPacientesAsync() {
            NetFW.ServicoSoapPaciente.GetMeusPacientesRequest inValue = new NetFW.ServicoSoapPaciente.GetMeusPacientesRequest();
            inValue.Body = new NetFW.ServicoSoapPaciente.GetMeusPacientesRequestBody();
            return ((NetFW.ServicoSoapPaciente.ServicoSOAPSoap)(this)).GetMeusPacientesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NetFW.ServicoSoapPaciente.GetPacientePorIdResponse NetFW.ServicoSoapPaciente.ServicoSOAPSoap.GetPacientePorId(NetFW.ServicoSoapPaciente.GetPacientePorIdRequest request) {
            return base.Channel.GetPacientePorId(request);
        }
        
        public NetFW.ServicoSoapPaciente.PacienteTO GetPacientePorId(int id) {
            NetFW.ServicoSoapPaciente.GetPacientePorIdRequest inValue = new NetFW.ServicoSoapPaciente.GetPacientePorIdRequest();
            inValue.Body = new NetFW.ServicoSoapPaciente.GetPacientePorIdRequestBody();
            inValue.Body.id = id;
            NetFW.ServicoSoapPaciente.GetPacientePorIdResponse retVal = ((NetFW.ServicoSoapPaciente.ServicoSOAPSoap)(this)).GetPacientePorId(inValue);
            return retVal.Body.GetPacientePorIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NetFW.ServicoSoapPaciente.GetPacientePorIdResponse> NetFW.ServicoSoapPaciente.ServicoSOAPSoap.GetPacientePorIdAsync(NetFW.ServicoSoapPaciente.GetPacientePorIdRequest request) {
            return base.Channel.GetPacientePorIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<NetFW.ServicoSoapPaciente.GetPacientePorIdResponse> GetPacientePorIdAsync(int id) {
            NetFW.ServicoSoapPaciente.GetPacientePorIdRequest inValue = new NetFW.ServicoSoapPaciente.GetPacientePorIdRequest();
            inValue.Body = new NetFW.ServicoSoapPaciente.GetPacientePorIdRequestBody();
            inValue.Body.id = id;
            return ((NetFW.ServicoSoapPaciente.ServicoSOAPSoap)(this)).GetPacientePorIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NetFW.ServicoSoapPaciente.AtualizaPacienteResponse NetFW.ServicoSoapPaciente.ServicoSOAPSoap.AtualizaPaciente(NetFW.ServicoSoapPaciente.AtualizaPacienteRequest request) {
            return base.Channel.AtualizaPaciente(request);
        }
        
        public void AtualizaPaciente(NetFW.ServicoSoapPaciente.PacienteTO paciente) {
            NetFW.ServicoSoapPaciente.AtualizaPacienteRequest inValue = new NetFW.ServicoSoapPaciente.AtualizaPacienteRequest();
            inValue.Body = new NetFW.ServicoSoapPaciente.AtualizaPacienteRequestBody();
            inValue.Body.paciente = paciente;
            NetFW.ServicoSoapPaciente.AtualizaPacienteResponse retVal = ((NetFW.ServicoSoapPaciente.ServicoSOAPSoap)(this)).AtualizaPaciente(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NetFW.ServicoSoapPaciente.AtualizaPacienteResponse> NetFW.ServicoSoapPaciente.ServicoSOAPSoap.AtualizaPacienteAsync(NetFW.ServicoSoapPaciente.AtualizaPacienteRequest request) {
            return base.Channel.AtualizaPacienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<NetFW.ServicoSoapPaciente.AtualizaPacienteResponse> AtualizaPacienteAsync(NetFW.ServicoSoapPaciente.PacienteTO paciente) {
            NetFW.ServicoSoapPaciente.AtualizaPacienteRequest inValue = new NetFW.ServicoSoapPaciente.AtualizaPacienteRequest();
            inValue.Body = new NetFW.ServicoSoapPaciente.AtualizaPacienteRequestBody();
            inValue.Body.paciente = paciente;
            return ((NetFW.ServicoSoapPaciente.ServicoSOAPSoap)(this)).AtualizaPacienteAsync(inValue);
        }
    }
}