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
    /// uomschedule
    /// </summary>
    public partial class MicrosoftDynamicsCRMuomschedule
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuomschedule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMuomschedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuomschedule
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMuomschedule(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string name = default(string), string _modifiedbyexternalpartyValue = default(string), string baseuomname = default(string), string description = default(string), long? versionnumber = default(long?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _organizationidValue = default(string), string _createdbyexternalpartyValue = default(string), string _createdonbehalfbyValue = default(string), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statecode = default(int?), string uomscheduleid = default(string), int? importsequencenumber = default(int?), IList<MicrosoftDynamicsCRMcontractdetail> contractDetailUnitOfMeasureSchedule = default(IList<MicrosoftDynamicsCRMcontractdetail>), IList<MicrosoftDynamicsCRMproduct> unitOfMeasurementScheduleProducts = default(IList<MicrosoftDynamicsCRMproduct>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMuom> unitOfMeasureScheduleConversions = default(IList<MicrosoftDynamicsCRMuom>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> uoMScheduleBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMasyncoperation> uoMScheduleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMsyncerror> uoMScheduleSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMproductpricelevel> unitOfMeasureScheduleProductPriceLevel = default(IList<MicrosoftDynamicsCRMproductpricelevel>))
        {
            Modifiedon = modifiedon;
            Name = name;
            this._modifiedbyexternalpartyValue = _modifiedbyexternalpartyValue;
            Baseuomname = baseuomname;
            Description = description;
            Versionnumber = versionnumber;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            this._organizationidValue = _organizationidValue;
            this._createdbyexternalpartyValue = _createdbyexternalpartyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            Statecode = statecode;
            Uomscheduleid = uomscheduleid;
            Importsequencenumber = importsequencenumber;
            ContractDetailUnitOfMeasureSchedule = contractDetailUnitOfMeasureSchedule;
            UnitOfMeasurementScheduleProducts = unitOfMeasurementScheduleProducts;
            Modifiedby = modifiedby;
            UnitOfMeasureScheduleConversions = unitOfMeasureScheduleConversions;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            UoMScheduleBulkDeleteFailures = uoMScheduleBulkDeleteFailures;
            UoMScheduleAsyncOperations = uoMScheduleAsyncOperations;
            UoMScheduleSyncErrors = uoMScheduleSyncErrors;
            Organizationid = organizationid;
            UnitOfMeasureScheduleProductPriceLevel = unitOfMeasureScheduleProductPriceLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedbyexternalparty_value")]
        public string _modifiedbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseuomname")]
        public string Baseuomname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdbyexternalparty_value")]
        public string _createdbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomscheduleid")]
        public string Uomscheduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_detail_unit_of_measure_schedule")]
        public IList<MicrosoftDynamicsCRMcontractdetail> ContractDetailUnitOfMeasureSchedule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_schedule_products")]
        public IList<MicrosoftDynamicsCRMproduct> UnitOfMeasurementScheduleProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measure_schedule_conversions")]
        public IList<MicrosoftDynamicsCRMuom> UnitOfMeasureScheduleConversions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoMSchedule_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> UoMScheduleBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoMSchedule_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> UoMScheduleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoMSchedule_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> UoMScheduleSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measure_schedule_product_price_level")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> UnitOfMeasureScheduleProductPriceLevel { get; set; }

    }
}
