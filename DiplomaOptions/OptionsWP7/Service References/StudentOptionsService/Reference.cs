﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace OptionsWP7.StudentOptionsService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OptionDetail", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class OptionDetail : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string TitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectionDetail", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class SelectionDetail : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int ChoiceIdField;
        
        private System.DateTime CreateDateField;
        
        private string FirstChoiceField;
        
        private string FirstNameField;
        
        private string FourthChoiceField;
        
        private string LastNameField;
        
        private string SecondChoiceField;
        
        private string StudentNumberField;
        
        private string ThirdChoiceField;
        
        private int YearField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ChoiceId {
            get {
                return this.ChoiceIdField;
            }
            set {
                if ((this.ChoiceIdField.Equals(value) != true)) {
                    this.ChoiceIdField = value;
                    this.RaisePropertyChanged("ChoiceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstChoice {
            get {
                return this.FirstChoiceField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstChoiceField, value) != true)) {
                    this.FirstChoiceField = value;
                    this.RaisePropertyChanged("FirstChoice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FourthChoice {
            get {
                return this.FourthChoiceField;
            }
            set {
                if ((object.ReferenceEquals(this.FourthChoiceField, value) != true)) {
                    this.FourthChoiceField = value;
                    this.RaisePropertyChanged("FourthChoice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondChoice {
            get {
                return this.SecondChoiceField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondChoiceField, value) != true)) {
                    this.SecondChoiceField = value;
                    this.RaisePropertyChanged("SecondChoice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentNumber {
            get {
                return this.StudentNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNumberField, value) != true)) {
                    this.StudentNumberField = value;
                    this.RaisePropertyChanged("StudentNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ThirdChoice {
            get {
                return this.ThirdChoiceField;
            }
            set {
                if ((object.ReferenceEquals(this.ThirdChoiceField, value) != true)) {
                    this.ThirdChoiceField = value;
                    this.RaisePropertyChanged("ThirdChoice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentOptionsService.IStudentOptionsService")]
    public interface IStudentOptionsService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IStudentOptionsService/GetOptions", ReplyAction="http://tempuri.org/IStudentOptionsService/GetOptionsResponse")]
        System.IAsyncResult BeginGetOptions(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.OptionDetail> EndGetOptions(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IStudentOptionsService/AddOptionSelection", ReplyAction="http://tempuri.org/IStudentOptionsService/AddOptionSelectionResponse")]
        System.IAsyncResult BeginAddOptionSelection(OptionsWP7.StudentOptionsService.SelectionDetail selection, System.AsyncCallback callback, object asyncState);
        
        int EndAddOptionSelection(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IStudentOptionsService/GetStudentChoices", ReplyAction="http://tempuri.org/IStudentOptionsService/GetStudentChoicesResponse")]
        System.IAsyncResult BeginGetStudentChoices(int year, System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.SelectionDetail> EndGetStudentChoices(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentOptionsServiceChannel : OptionsWP7.StudentOptionsService.IStudentOptionsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetOptionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetOptionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.OptionDetail> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.OptionDetail>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddOptionSelectionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public AddOptionSelectionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetStudentChoicesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetStudentChoicesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.SelectionDetail> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.SelectionDetail>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentOptionsServiceClient : System.ServiceModel.ClientBase<OptionsWP7.StudentOptionsService.IStudentOptionsService>, OptionsWP7.StudentOptionsService.IStudentOptionsService {
        
        private BeginOperationDelegate onBeginGetOptionsDelegate;
        
        private EndOperationDelegate onEndGetOptionsDelegate;
        
        private System.Threading.SendOrPostCallback onGetOptionsCompletedDelegate;
        
        private BeginOperationDelegate onBeginAddOptionSelectionDelegate;
        
        private EndOperationDelegate onEndAddOptionSelectionDelegate;
        
        private System.Threading.SendOrPostCallback onAddOptionSelectionCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetStudentChoicesDelegate;
        
        private EndOperationDelegate onEndGetStudentChoicesDelegate;
        
        private System.Threading.SendOrPostCallback onGetStudentChoicesCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public StudentOptionsServiceClient() {
        }
        
        public StudentOptionsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentOptionsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentOptionsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentOptionsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetOptionsCompletedEventArgs> GetOptionsCompleted;
        
        public event System.EventHandler<AddOptionSelectionCompletedEventArgs> AddOptionSelectionCompleted;
        
        public event System.EventHandler<GetStudentChoicesCompletedEventArgs> GetStudentChoicesCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult OptionsWP7.StudentOptionsService.IStudentOptionsService.BeginGetOptions(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetOptions(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.OptionDetail> OptionsWP7.StudentOptionsService.IStudentOptionsService.EndGetOptions(System.IAsyncResult result) {
            return base.Channel.EndGetOptions(result);
        }
        
        private System.IAsyncResult OnBeginGetOptions(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((OptionsWP7.StudentOptionsService.IStudentOptionsService)(this)).BeginGetOptions(callback, asyncState);
        }
        
        private object[] OnEndGetOptions(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.OptionDetail> retVal = ((OptionsWP7.StudentOptionsService.IStudentOptionsService)(this)).EndGetOptions(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetOptionsCompleted(object state) {
            if ((this.GetOptionsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetOptionsCompleted(this, new GetOptionsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetOptionsAsync() {
            this.GetOptionsAsync(null);
        }
        
        public void GetOptionsAsync(object userState) {
            if ((this.onBeginGetOptionsDelegate == null)) {
                this.onBeginGetOptionsDelegate = new BeginOperationDelegate(this.OnBeginGetOptions);
            }
            if ((this.onEndGetOptionsDelegate == null)) {
                this.onEndGetOptionsDelegate = new EndOperationDelegate(this.OnEndGetOptions);
            }
            if ((this.onGetOptionsCompletedDelegate == null)) {
                this.onGetOptionsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetOptionsCompleted);
            }
            base.InvokeAsync(this.onBeginGetOptionsDelegate, null, this.onEndGetOptionsDelegate, this.onGetOptionsCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult OptionsWP7.StudentOptionsService.IStudentOptionsService.BeginAddOptionSelection(OptionsWP7.StudentOptionsService.SelectionDetail selection, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAddOptionSelection(selection, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int OptionsWP7.StudentOptionsService.IStudentOptionsService.EndAddOptionSelection(System.IAsyncResult result) {
            return base.Channel.EndAddOptionSelection(result);
        }
        
        private System.IAsyncResult OnBeginAddOptionSelection(object[] inValues, System.AsyncCallback callback, object asyncState) {
            OptionsWP7.StudentOptionsService.SelectionDetail selection = ((OptionsWP7.StudentOptionsService.SelectionDetail)(inValues[0]));
            return ((OptionsWP7.StudentOptionsService.IStudentOptionsService)(this)).BeginAddOptionSelection(selection, callback, asyncState);
        }
        
        private object[] OnEndAddOptionSelection(System.IAsyncResult result) {
            int retVal = ((OptionsWP7.StudentOptionsService.IStudentOptionsService)(this)).EndAddOptionSelection(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAddOptionSelectionCompleted(object state) {
            if ((this.AddOptionSelectionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddOptionSelectionCompleted(this, new AddOptionSelectionCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddOptionSelectionAsync(OptionsWP7.StudentOptionsService.SelectionDetail selection) {
            this.AddOptionSelectionAsync(selection, null);
        }
        
        public void AddOptionSelectionAsync(OptionsWP7.StudentOptionsService.SelectionDetail selection, object userState) {
            if ((this.onBeginAddOptionSelectionDelegate == null)) {
                this.onBeginAddOptionSelectionDelegate = new BeginOperationDelegate(this.OnBeginAddOptionSelection);
            }
            if ((this.onEndAddOptionSelectionDelegate == null)) {
                this.onEndAddOptionSelectionDelegate = new EndOperationDelegate(this.OnEndAddOptionSelection);
            }
            if ((this.onAddOptionSelectionCompletedDelegate == null)) {
                this.onAddOptionSelectionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddOptionSelectionCompleted);
            }
            base.InvokeAsync(this.onBeginAddOptionSelectionDelegate, new object[] {
                        selection}, this.onEndAddOptionSelectionDelegate, this.onAddOptionSelectionCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult OptionsWP7.StudentOptionsService.IStudentOptionsService.BeginGetStudentChoices(int year, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetStudentChoices(year, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.SelectionDetail> OptionsWP7.StudentOptionsService.IStudentOptionsService.EndGetStudentChoices(System.IAsyncResult result) {
            return base.Channel.EndGetStudentChoices(result);
        }
        
        private System.IAsyncResult OnBeginGetStudentChoices(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int year = ((int)(inValues[0]));
            return ((OptionsWP7.StudentOptionsService.IStudentOptionsService)(this)).BeginGetStudentChoices(year, callback, asyncState);
        }
        
        private object[] OnEndGetStudentChoices(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.SelectionDetail> retVal = ((OptionsWP7.StudentOptionsService.IStudentOptionsService)(this)).EndGetStudentChoices(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetStudentChoicesCompleted(object state) {
            if ((this.GetStudentChoicesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetStudentChoicesCompleted(this, new GetStudentChoicesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetStudentChoicesAsync(int year) {
            this.GetStudentChoicesAsync(year, null);
        }
        
        public void GetStudentChoicesAsync(int year, object userState) {
            if ((this.onBeginGetStudentChoicesDelegate == null)) {
                this.onBeginGetStudentChoicesDelegate = new BeginOperationDelegate(this.OnBeginGetStudentChoices);
            }
            if ((this.onEndGetStudentChoicesDelegate == null)) {
                this.onEndGetStudentChoicesDelegate = new EndOperationDelegate(this.OnEndGetStudentChoices);
            }
            if ((this.onGetStudentChoicesCompletedDelegate == null)) {
                this.onGetStudentChoicesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetStudentChoicesCompleted);
            }
            base.InvokeAsync(this.onBeginGetStudentChoicesDelegate, new object[] {
                        year}, this.onEndGetStudentChoicesDelegate, this.onGetStudentChoicesCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override OptionsWP7.StudentOptionsService.IStudentOptionsService CreateChannel() {
            return new StudentOptionsServiceClientChannel(this);
        }
        
        private class StudentOptionsServiceClientChannel : ChannelBase<OptionsWP7.StudentOptionsService.IStudentOptionsService>, OptionsWP7.StudentOptionsService.IStudentOptionsService {
            
            public StudentOptionsServiceClientChannel(System.ServiceModel.ClientBase<OptionsWP7.StudentOptionsService.IStudentOptionsService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetOptions(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetOptions", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.OptionDetail> EndGetOptions(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.OptionDetail> _result = ((System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.OptionDetail>)(base.EndInvoke("GetOptions", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginAddOptionSelection(OptionsWP7.StudentOptionsService.SelectionDetail selection, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = selection;
                System.IAsyncResult _result = base.BeginInvoke("AddOptionSelection", _args, callback, asyncState);
                return _result;
            }
            
            public int EndAddOptionSelection(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("AddOptionSelection", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetStudentChoices(int year, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = year;
                System.IAsyncResult _result = base.BeginInvoke("GetStudentChoices", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.SelectionDetail> EndGetStudentChoices(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.SelectionDetail> _result = ((System.Collections.ObjectModel.ObservableCollection<OptionsWP7.StudentOptionsService.SelectionDetail>)(base.EndInvoke("GetStudentChoices", _args, result)));
                return _result;
            }
        }
    }
}
