// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.VictimServices.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// invoice
    /// </summary>
    public partial class MicrosoftDynamicsCRMinvoice
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMinvoice
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMinvoice
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoice(string name = default(string), int? statuscode = default(int?), object totaltax = default(object), int? onholdtime = default(int?), bool? ispricelocked = default(bool?), object discountamountBase = default(object), string shiptoFax = default(string), string entityimageid = default(string), int? pricingerrorcode = default(int?), object discountpercentage = default(object), string _modifiedbyValue = default(string), string _createdbyValue = default(string), object freightamount = default(object), string shiptoCity = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string shiptoPostalcode = default(string), string shiptoLine2 = default(string), object totallineitemdiscountamount = default(object), string description = default(string), object totallineitemamountBase = default(object), int? statecode = default(int?), string _modifiedonbehalfbyValue = default(string), string billtoPostalcode = default(string), string shiptoComposite = default(string), string shiptoStateorprovince = default(string), int? importsequencenumber = default(int?), string shiptoLine1 = default(string), string processid = default(string), string entityimageUrl = default(string), object totalamountBase = default(object), object exchangerate = default(object), string _opportunityidValue = default(string), string _accountidValue = default(string), string shiptoTelephone = default(string), string billtoLine3 = default(string), object discountamount = default(object), string billtoTelephone = default(string), int? prioritycode = default(int?), string billtoComposite = default(string), string _salesorderidValue = default(string), object freightamountBase = default(object), string traversedpath = default(string), string shiptoCountry = default(string), string _contactidValue = default(string), string _owningbusinessunitValue = default(string), string _slaidValue = default(string), string _pricelevelidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string billtoStateorprovince = default(string), string billtoLine2 = default(string), string shiptoLine3 = default(string), object totaldiscountamount = default(object), int? timezoneruleversionnumber = default(int?), object totallineitemdiscountamountBase = default(object), long? versionnumber = default(long?), int? paymenttermscode = default(int?), object totalamount = default(object), string _owningteamValue = default(string), System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), object totalamountlessfreight = default(object), string _slainvokedidValue = default(string), string shiptoName = default(string), bool? willcall = default(bool?), string invoicenumber = default(string), string billtoFax = default(string), string billtoCountry = default(string), string _createdonbehalfbyValue = default(string), string stageid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owneridValue = default(string), string invoiceid = default(string), int? utcconversiontimezonecode = default(int?), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? datedelivered = default(System.DateTimeOffset?), string billtoName = default(string), object totalamountlessfreightBase = default(object), object entityimage = default(object), string _owninguserValue = default(string), System.DateTimeOffset? lastbackofficesubmit = default(System.DateTimeOffset?), string billtoCity = default(string), int? shiptoFreighttermscode = default(int?), object totaldiscountamountBase = default(object), int? shippingmethodcode = default(int?), object totallineitemamount = default(object), string _customeridValue = default(string), string billtoLine1 = default(string), long? entityimageTimestamp = default(long?), object totaltaxBase = default(object), System.DateTimeOffset? duedate = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMcontact> contactinvoicesAssociation = default(IList<MicrosoftDynamicsCRMcontact>), MicrosoftDynamicsCRMsla slaInvoiceSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMappointment> invoiceAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMconnection> invoiceConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMactivityparty> invoiceActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> invoiceRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMactivitypointer> invoiceActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMphonecall> invoicePhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMemail> invoiceEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMbulkdeletefailure> invoiceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMletter> invoiceLetters = default(IList<MicrosoftDynamicsCRMletter>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), IList<MicrosoftDynamicsCRMtask> invoiceTasks = default(IList<MicrosoftDynamicsCRMtask>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> invoiceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMconnection> invoiceConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMinvoicedetail> invoiceDetails = default(IList<MicrosoftDynamicsCRMinvoicedetail>), IList<MicrosoftDynamicsCRMfax> invoiceFaxes = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMpricelevel pricelevelid = default(MicrosoftDynamicsCRMpricelevel), IList<MicrosoftDynamicsCRMsocialactivity> invoiceSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMannotation> invoiceAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> invoiceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceInvoice = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMsla slainvokedidInvoiceSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMserviceappointment> invoiceServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMsalesorder salesorderid = default(MicrosoftDynamicsCRMsalesorder))
        {
            Name = name;
            Statuscode = statuscode;
            Totaltax = totaltax;
            Onholdtime = onholdtime;
            Ispricelocked = ispricelocked;
            DiscountamountBase = discountamountBase;
            ShiptoFax = shiptoFax;
            Entityimageid = entityimageid;
            Pricingerrorcode = pricingerrorcode;
            Discountpercentage = discountpercentage;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            Freightamount = freightamount;
            ShiptoCity = shiptoCity;
            Createdon = createdon;
            ShiptoPostalcode = shiptoPostalcode;
            ShiptoLine2 = shiptoLine2;
            Totallineitemdiscountamount = totallineitemdiscountamount;
            Description = description;
            TotallineitemamountBase = totallineitemamountBase;
            Statecode = statecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            BilltoPostalcode = billtoPostalcode;
            ShiptoComposite = shiptoComposite;
            ShiptoStateorprovince = shiptoStateorprovince;
            Importsequencenumber = importsequencenumber;
            ShiptoLine1 = shiptoLine1;
            Processid = processid;
            EntityimageUrl = entityimageUrl;
            TotalamountBase = totalamountBase;
            Exchangerate = exchangerate;
            this._opportunityidValue = _opportunityidValue;
            this._accountidValue = _accountidValue;
            ShiptoTelephone = shiptoTelephone;
            BilltoLine3 = billtoLine3;
            Discountamount = discountamount;
            BilltoTelephone = billtoTelephone;
            Prioritycode = prioritycode;
            BilltoComposite = billtoComposite;
            this._salesorderidValue = _salesorderidValue;
            FreightamountBase = freightamountBase;
            Traversedpath = traversedpath;
            ShiptoCountry = shiptoCountry;
            this._contactidValue = _contactidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._slaidValue = _slaidValue;
            this._pricelevelidValue = _pricelevelidValue;
            Modifiedon = modifiedon;
            BilltoStateorprovince = billtoStateorprovince;
            BilltoLine2 = billtoLine2;
            ShiptoLine3 = shiptoLine3;
            Totaldiscountamount = totaldiscountamount;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            TotallineitemdiscountamountBase = totallineitemdiscountamountBase;
            Versionnumber = versionnumber;
            Paymenttermscode = paymenttermscode;
            Totalamount = totalamount;
            this._owningteamValue = _owningteamValue;
            Lastonholdtime = lastonholdtime;
            Totalamountlessfreight = totalamountlessfreight;
            this._slainvokedidValue = _slainvokedidValue;
            ShiptoName = shiptoName;
            Willcall = willcall;
            Invoicenumber = invoicenumber;
            BilltoFax = billtoFax;
            BilltoCountry = billtoCountry;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Stageid = stageid;
            Overriddencreatedon = overriddencreatedon;
            this._owneridValue = _owneridValue;
            Invoiceid = invoiceid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Datedelivered = datedelivered;
            BilltoName = billtoName;
            TotalamountlessfreightBase = totalamountlessfreightBase;
            Entityimage = entityimage;
            this._owninguserValue = _owninguserValue;
            Lastbackofficesubmit = lastbackofficesubmit;
            BilltoCity = billtoCity;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            TotaldiscountamountBase = totaldiscountamountBase;
            Shippingmethodcode = shippingmethodcode;
            Totallineitemamount = totallineitemamount;
            this._customeridValue = _customeridValue;
            BilltoLine1 = billtoLine1;
            EntityimageTimestamp = entityimageTimestamp;
            TotaltaxBase = totaltaxBase;
            Duedate = duedate;
            ContactinvoicesAssociation = contactinvoicesAssociation;
            SlaInvoiceSla = slaInvoiceSla;
            Modifiedby = modifiedby;
            CustomeridContact = customeridContact;
            InvoiceAppointments = invoiceAppointments;
            InvoiceConnections1 = invoiceConnections1;
            Owningbusinessunit = owningbusinessunit;
            Transactioncurrencyid = transactioncurrencyid;
            StageidProcessstage = stageidProcessstage;
            InvoiceActivityParties = invoiceActivityParties;
            InvoiceRecurringAppointmentMasters = invoiceRecurringAppointmentMasters;
            InvoiceActivityPointers = invoiceActivityPointers;
            InvoicePhonecalls = invoicePhonecalls;
            Owninguser = owninguser;
            InvoiceEmails = invoiceEmails;
            InvoiceBulkDeleteFailures = invoiceBulkDeleteFailures;
            InvoiceLetters = invoiceLetters;
            Createdonbehalfby = createdonbehalfby;
            Ownerid = ownerid;
            InvoiceTasks = invoiceTasks;
            Modifiedonbehalfby = modifiedonbehalfby;
            InvoiceSyncErrors = invoiceSyncErrors;
            Opportunityid = opportunityid;
            InvoiceConnections2 = invoiceConnections2;
            InvoiceDetails = invoiceDetails;
            InvoiceFaxes = invoiceFaxes;
            Owningteam = owningteam;
            CustomeridAccount = customeridAccount;
            Pricelevelid = pricelevelid;
            InvoiceSocialActivities = invoiceSocialActivities;
            InvoiceAnnotation = invoiceAnnotation;
            InvoiceAsyncOperations = invoiceAsyncOperations;
            Createdby = createdby;
            SlakpiinstanceInvoice = slakpiinstanceInvoice;
            SlainvokedidInvoiceSla = slainvokedidInvoiceSla;
            InvoiceServiceAppointments = invoiceServiceAppointments;
            Salesorderid = salesorderid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax")]
        public object Totaltax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onholdtime")]
        public int? Onholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispricelocked")]
        public bool? Ispricelocked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount_base")]
        public object DiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountpercentage")]
        public object Discountpercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount")]
        public object Freightamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount")]
        public object Totallineitemdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount_base")]
        public object TotallineitemamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_postalcode")]
        public string BilltoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_composite")]
        public string ShiptoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount_base")]
        public object TotalamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line3")]
        public string BilltoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount")]
        public object Discountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_telephone")]
        public string BilltoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prioritycode")]
        public int? Prioritycode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_composite")]
        public string BilltoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salesorderid_value")]
        public string _salesorderidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount_base")]
        public object FreightamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_pricelevelid_value")]
        public string _pricelevelidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_stateorprovince")]
        public string BilltoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line2")]
        public string BilltoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount")]
        public object Totaldiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount_base")]
        public object TotallineitemdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymenttermscode")]
        public int? Paymenttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount")]
        public object Totalamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastonholdtime")]
        public System.DateTimeOffset? Lastonholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight")]
        public object Totalamountlessfreight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slainvokedid_value")]
        public string _slainvokedidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoicenumber")]
        public string Invoicenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_fax")]
        public string BilltoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_country")]
        public string BilltoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoiceid")]
        public string Invoiceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datedelivered")]
        public System.DateTimeOffset? Datedelivered { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_name")]
        public string BilltoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight_base")]
        public object TotalamountlessfreightBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public object Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastbackofficesubmit")]
        public System.DateTimeOffset? Lastbackofficesubmit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_city")]
        public string BilltoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount_base")]
        public object TotaldiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount")]
        public object Totallineitemamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line1")]
        public string BilltoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax_base")]
        public object TotaltaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duedate")]
        public System.DateTimeOffset? Duedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactinvoices_association")]
        public IList<MicrosoftDynamicsCRMcontact> ContactinvoicesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_invoice_sla")]
        public MicrosoftDynamicsCRMsla SlaInvoiceSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> InvoiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> InvoiceConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> InvoiceActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> InvoiceRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> InvoiceActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> InvoicePhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Emails")]
        public IList<MicrosoftDynamicsCRMemail> InvoiceEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> InvoiceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Letters")]
        public IList<MicrosoftDynamicsCRMletter> InvoiceLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> InvoiceTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> InvoiceSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> InvoiceConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoice_details")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> InvoiceDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> InvoiceFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public MicrosoftDynamicsCRMpricelevel Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> InvoiceSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> InvoiceAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> InvoiceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_invoice")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_invoice_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidInvoiceSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> InvoiceServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public MicrosoftDynamicsCRMsalesorder Salesorderid { get; set; }

    }
}
