﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirlinesClient.ReservationService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Flight", Namespace="http://schemas.datacontract.org/2004/07/AirlinesReservation.Models")]
    [System.SerializableAttribute()]
    public partial class Flight : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TakenSitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ToCityField;
        
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
        public double Cost {
            get {
                return this.CostField;
            }
            set {
                if ((this.CostField.Equals(value) != true)) {
                    this.CostField = value;
                    this.RaisePropertyChanged("Cost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FromCity {
            get {
                return this.FromCityField;
            }
            set {
                if ((object.ReferenceEquals(this.FromCityField, value) != true)) {
                    this.FromCityField = value;
                    this.RaisePropertyChanged("FromCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sits {
            get {
                return this.SitsField;
            }
            set {
                if ((this.SitsField.Equals(value) != true)) {
                    this.SitsField = value;
                    this.RaisePropertyChanged("Sits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TakenSits {
            get {
                return this.TakenSitsField;
            }
            set {
                if ((this.TakenSitsField.Equals(value) != true)) {
                    this.TakenSitsField = value;
                    this.RaisePropertyChanged("TakenSits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ToCity {
            get {
                return this.ToCityField;
            }
            set {
                if ((object.ReferenceEquals(this.ToCityField, value) != true)) {
                    this.ToCityField = value;
                    this.RaisePropertyChanged("ToCity");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/AirlinesReservation.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AirlinesClient.ReservationService.Sex GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public System.DateTime Birth {
            get {
                return this.BirthField;
            }
            set {
                if ((this.BirthField.Equals(value) != true)) {
                    this.BirthField = value;
                    this.RaisePropertyChanged("Birth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirlinesClient.ReservationService.Sex Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Sex", Namespace="http://schemas.datacontract.org/2004/07/AirlinesReservation.Models")]
    public enum Sex : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Male = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Female = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reservation", Namespace="http://schemas.datacontract.org/2004/07/AirlinesReservation.Models")]
    [System.SerializableAttribute()]
    public partial class Reservation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DurationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AirlinesClient.ReservationService.Flight FlightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FlightIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AirlinesClient.ReservationService.ReservationType ReservationTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AirlinesClient.ReservationService.Ticket TicketField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TicketIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AirlinesClient.ReservationService.User UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public System.DateTime CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DurationTime {
            get {
                return this.DurationTimeField;
            }
            set {
                if ((this.DurationTimeField.Equals(value) != true)) {
                    this.DurationTimeField = value;
                    this.RaisePropertyChanged("DurationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirlinesClient.ReservationService.Flight Flight {
            get {
                return this.FlightField;
            }
            set {
                if ((object.ReferenceEquals(this.FlightField, value) != true)) {
                    this.FlightField = value;
                    this.RaisePropertyChanged("Flight");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FlightId {
            get {
                return this.FlightIdField;
            }
            set {
                if ((this.FlightIdField.Equals(value) != true)) {
                    this.FlightIdField = value;
                    this.RaisePropertyChanged("FlightId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirlinesClient.ReservationService.ReservationType ReservationType {
            get {
                return this.ReservationTypeField;
            }
            set {
                if ((this.ReservationTypeField.Equals(value) != true)) {
                    this.ReservationTypeField = value;
                    this.RaisePropertyChanged("ReservationType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirlinesClient.ReservationService.Ticket Ticket {
            get {
                return this.TicketField;
            }
            set {
                if ((object.ReferenceEquals(this.TicketField, value) != true)) {
                    this.TicketField = value;
                    this.RaisePropertyChanged("Ticket");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TicketId {
            get {
                return this.TicketIdField;
            }
            set {
                if ((this.TicketIdField.Equals(value) != true)) {
                    this.TicketIdField = value;
                    this.RaisePropertyChanged("TicketId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirlinesClient.ReservationService.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ticket", Namespace="http://schemas.datacontract.org/2004/07/AirlinesReservation.Models")]
    [System.SerializableAttribute()]
    public partial class Ticket : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsBoughtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AirlinesClient.ReservationService.TicketType TypeField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsBought {
            get {
                return this.IsBoughtField;
            }
            set {
                if ((this.IsBoughtField.Equals(value) != true)) {
                    this.IsBoughtField = value;
                    this.RaisePropertyChanged("IsBought");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirlinesClient.ReservationService.TicketType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ReservationType", Namespace="http://schemas.datacontract.org/2004/07/AirlinesReservation.Models")]
    public enum ReservationType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pending = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Done = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TicketType", Namespace="http://schemas.datacontract.org/2004/07/AirlinesReservation.Models")]
    public enum TicketType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FirstClass = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BusinessClass = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RoundTrip = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReservationService.IReservationService")]
    public interface IReservationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/AddReservation", ReplyAction="http://tempuri.org/IReservationService/AddReservationResponse")]
        void AddReservation(AirlinesClient.ReservationService.Flight flight, AirlinesClient.ReservationService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/AddReservation", ReplyAction="http://tempuri.org/IReservationService/AddReservationResponse")]
        System.Threading.Tasks.Task AddReservationAsync(AirlinesClient.ReservationService.Flight flight, AirlinesClient.ReservationService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CheckReservation", ReplyAction="http://tempuri.org/IReservationService/CheckReservationResponse")]
        AirlinesClient.ReservationService.Reservation CheckReservation(System.Guid number, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CheckReservation", ReplyAction="http://tempuri.org/IReservationService/CheckReservationResponse")]
        System.Threading.Tasks.Task<AirlinesClient.ReservationService.Reservation> CheckReservationAsync(System.Guid number, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/ShowAllReservation", ReplyAction="http://tempuri.org/IReservationService/ShowAllReservationResponse")]
        AirlinesClient.ReservationService.Reservation[] ShowAllReservation(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/ShowAllReservation", ReplyAction="http://tempuri.org/IReservationService/ShowAllReservationResponse")]
        System.Threading.Tasks.Task<AirlinesClient.ReservationService.Reservation[]> ShowAllReservationAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetConfirmation", ReplyAction="http://tempuri.org/IReservationService/GetConfirmationResponse")]
        byte[] GetConfirmation(System.Guid user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetConfirmation", ReplyAction="http://tempuri.org/IReservationService/GetConfirmationResponse")]
        System.Threading.Tasks.Task<byte[]> GetConfirmationAsync(System.Guid user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReservationServiceChannel : AirlinesClient.ReservationService.IReservationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReservationServiceClient : System.ServiceModel.ClientBase<AirlinesClient.ReservationService.IReservationService>, AirlinesClient.ReservationService.IReservationService {
        
        public ReservationServiceClient() {
        }
        
        public ReservationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReservationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddReservation(AirlinesClient.ReservationService.Flight flight, AirlinesClient.ReservationService.User user) {
            base.Channel.AddReservation(flight, user);
        }
        
        public System.Threading.Tasks.Task AddReservationAsync(AirlinesClient.ReservationService.Flight flight, AirlinesClient.ReservationService.User user) {
            return base.Channel.AddReservationAsync(flight, user);
        }
        
        public AirlinesClient.ReservationService.Reservation CheckReservation(System.Guid number, string username) {
            return base.Channel.CheckReservation(number, username);
        }
        
        public System.Threading.Tasks.Task<AirlinesClient.ReservationService.Reservation> CheckReservationAsync(System.Guid number, string username) {
            return base.Channel.CheckReservationAsync(number, username);
        }
        
        public AirlinesClient.ReservationService.Reservation[] ShowAllReservation(string username) {
            return base.Channel.ShowAllReservation(username);
        }
        
        public System.Threading.Tasks.Task<AirlinesClient.ReservationService.Reservation[]> ShowAllReservationAsync(string username) {
            return base.Channel.ShowAllReservationAsync(username);
        }
        
        public byte[] GetConfirmation(System.Guid user) {
            return base.Channel.GetConfirmation(user);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetConfirmationAsync(System.Guid user) {
            return base.Channel.GetConfirmationAsync(user);
        }
    }
}
