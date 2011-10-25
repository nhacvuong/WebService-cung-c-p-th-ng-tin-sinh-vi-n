﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UsingLibrary.ServiceLibrary {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceLibrary.IServiceLibrary")]
    public interface IServiceLibrary {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibrary/GetAuthor", ReplyAction="http://tempuri.org/IServiceLibrary/GetAuthorResponse")]
        string GetAuthor();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IServiceLibrary/GetAuthor", ReplyAction="http://tempuri.org/IServiceLibrary/GetAuthorResponse")]
        System.IAsyncResult BeginGetAuthor(System.AsyncCallback callback, object asyncState);
        
        string EndGetAuthor(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLibrary/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceLibrary/GetDataUsingDataContractResponse")]
        UsingLibrary.ServiceLibrary.CompositeType GetDataUsingDataContract(UsingLibrary.ServiceLibrary.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IServiceLibrary/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IServiceLibrary/GetDataUsingDataContractResponse")]
        System.IAsyncResult BeginGetDataUsingDataContract(UsingLibrary.ServiceLibrary.CompositeType composite, System.AsyncCallback callback, object asyncState);
        
        UsingLibrary.ServiceLibrary.CompositeType EndGetDataUsingDataContract(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IServiceLibraryChannel : UsingLibrary.ServiceLibrary.IServiceLibrary, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class GetAuthorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAuthorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public UsingLibrary.ServiceLibrary.CompositeType Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((UsingLibrary.ServiceLibrary.CompositeType)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ServiceLibraryClient : System.ServiceModel.ClientBase<UsingLibrary.ServiceLibrary.IServiceLibrary>, UsingLibrary.ServiceLibrary.IServiceLibrary {
        
        private BeginOperationDelegate onBeginGetAuthorDelegate;
        
        private EndOperationDelegate onEndGetAuthorDelegate;
        
        private System.Threading.SendOrPostCallback onGetAuthorCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetDataUsingDataContractDelegate;
        
        private EndOperationDelegate onEndGetDataUsingDataContractDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataUsingDataContractCompletedDelegate;
        
        public ServiceLibraryClient() {
        }
        
        public ServiceLibraryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceLibraryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLibraryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLibraryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetAuthorCompletedEventArgs> GetAuthorCompleted;
        
        public event System.EventHandler<GetDataUsingDataContractCompletedEventArgs> GetDataUsingDataContractCompleted;
        
        public string GetAuthor() {
            return base.Channel.GetAuthor();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAuthor(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAuthor(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetAuthor(System.IAsyncResult result) {
            return base.Channel.EndGetAuthor(result);
        }
        
        private System.IAsyncResult OnBeginGetAuthor(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAuthor(callback, asyncState);
        }
        
        private object[] OnEndGetAuthor(System.IAsyncResult result) {
            string retVal = this.EndGetAuthor(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAuthorCompleted(object state) {
            if ((this.GetAuthorCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAuthorCompleted(this, new GetAuthorCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAuthorAsync() {
            this.GetAuthorAsync(null);
        }
        
        public void GetAuthorAsync(object userState) {
            if ((this.onBeginGetAuthorDelegate == null)) {
                this.onBeginGetAuthorDelegate = new BeginOperationDelegate(this.OnBeginGetAuthor);
            }
            if ((this.onEndGetAuthorDelegate == null)) {
                this.onEndGetAuthorDelegate = new EndOperationDelegate(this.OnEndGetAuthor);
            }
            if ((this.onGetAuthorCompletedDelegate == null)) {
                this.onGetAuthorCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAuthorCompleted);
            }
            base.InvokeAsync(this.onBeginGetAuthorDelegate, null, this.onEndGetAuthorDelegate, this.onGetAuthorCompletedDelegate, userState);
        }
        
        public UsingLibrary.ServiceLibrary.CompositeType GetDataUsingDataContract(UsingLibrary.ServiceLibrary.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetDataUsingDataContract(UsingLibrary.ServiceLibrary.CompositeType composite, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetDataUsingDataContract(composite, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public UsingLibrary.ServiceLibrary.CompositeType EndGetDataUsingDataContract(System.IAsyncResult result) {
            return base.Channel.EndGetDataUsingDataContract(result);
        }
        
        private System.IAsyncResult OnBeginGetDataUsingDataContract(object[] inValues, System.AsyncCallback callback, object asyncState) {
            UsingLibrary.ServiceLibrary.CompositeType composite = ((UsingLibrary.ServiceLibrary.CompositeType)(inValues[0]));
            return this.BeginGetDataUsingDataContract(composite, callback, asyncState);
        }
        
        private object[] OnEndGetDataUsingDataContract(System.IAsyncResult result) {
            UsingLibrary.ServiceLibrary.CompositeType retVal = this.EndGetDataUsingDataContract(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataUsingDataContractCompleted(object state) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataUsingDataContractAsync(UsingLibrary.ServiceLibrary.CompositeType composite) {
            this.GetDataUsingDataContractAsync(composite, null);
        }
        
        public void GetDataUsingDataContractAsync(UsingLibrary.ServiceLibrary.CompositeType composite, object userState) {
            if ((this.onBeginGetDataUsingDataContractDelegate == null)) {
                this.onBeginGetDataUsingDataContractDelegate = new BeginOperationDelegate(this.OnBeginGetDataUsingDataContract);
            }
            if ((this.onEndGetDataUsingDataContractDelegate == null)) {
                this.onEndGetDataUsingDataContractDelegate = new EndOperationDelegate(this.OnEndGetDataUsingDataContract);
            }
            if ((this.onGetDataUsingDataContractCompletedDelegate == null)) {
                this.onGetDataUsingDataContractCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataUsingDataContractDelegate, new object[] {
                        composite}, this.onEndGetDataUsingDataContractDelegate, this.onGetDataUsingDataContractCompletedDelegate, userState);
        }
    }
}