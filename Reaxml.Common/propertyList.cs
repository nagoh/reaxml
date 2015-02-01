using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Reaxml.Common
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class propertyList
    {

        private object[] itemsField;

        private string dateField;

        private string companyNameField;

        private string techContactNameField;

        private string techContactPhoneField;

        private string techContactEmailField;

        private string usernameField;

        private string passwordField;

        /// <remarks/>
        [XmlElement("business", typeof(business))]
        [XmlElement("commercial", typeof(commercial))]
        [XmlElement("commercialLand", typeof(commercialLand))]
        [XmlElement("holidayRental", typeof(holidayRental))]
        [XmlElement("land", typeof(land))]
        [XmlElement("rental", typeof(rental))]
        [XmlElement("residential", typeof(residential))]
        [XmlElement("rural", typeof(rural))]
        public object[] Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string date
        {
            get { return this.dateField; }
            set { this.dateField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string companyName
        {
            get { return this.companyNameField; }
            set { this.companyNameField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string techContactName
        {
            get { return this.techContactNameField; }
            set { this.techContactNameField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string techContactPhone
        {
            get { return this.techContactPhoneField; }
            set { this.techContactPhoneField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string techContactEmail
        {
            get { return this.techContactEmailField; }
            set { this.techContactEmailField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string username
        {
            get { return this.usernameField; }
            set { this.usernameField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string password
        {
            get { return this.passwordField; }
            set { this.passwordField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class business
    {

        private string agentIDField;

        private marketing marketingField;

        private exclusivity exclusivityField;

        private commercialListingType commercialListingTypeField;

        private underOffer underOfferField;

        private listingAgent[] listingAgentField;

        private franchise franchiseField;

        private price priceField;

        private string priceViewField;

        private businessLease[] businessLeaseField;

        private string takingsField;

        private @return returnField;

        private string currentLeaseEndDateField;

        private string furtherOptionsField;

        private address addressField;

        private string municipalityField;

        private streetDirectory streetDirectoryField;

        private businessCategory[] businessCategoryField;

        private string headlineField;

        private string descriptionField;

        private string termsField;

        private soldDetails soldDetailsField;

        private buildingDetails buildingDetailsField;

        private vendorDetails[] vendorDetailsField;

        private externalLink[] externalLinkField;

        private extraFields extraFieldsField;

        private img[] imagesField;

        private object[] objectsField;

        private uri[] miniwebField;

        private string purchaseOrderField;

        private string modTimeField;

        private businessStatus statusField;

        /// <remarks/>
        public string agentID
        {
            get { return this.agentIDField; }
            set { this.agentIDField = value; }
        }



        /// <remarks/>
        public marketing marketing
        {
            get { return this.marketingField; }
            set { this.marketingField = value; }
        }

        /// <remarks/>
        public exclusivity exclusivity
        {
            get { return this.exclusivityField; }
            set { this.exclusivityField = value; }
        }

        /// <remarks/>
        public commercialListingType commercialListingType
        {
            get { return this.commercialListingTypeField; }
            set { this.commercialListingTypeField = value; }
        }

        /// <remarks/>
        public underOffer underOffer
        {
            get { return this.underOfferField; }
            set { this.underOfferField = value; }
        }

        /// <remarks/>
        [XmlElement("listingAgent")]
        public listingAgent[] listingAgent
        {
            get { return this.listingAgentField; }
            set { this.listingAgentField = value; }
        }

        /// <remarks/>
        public franchise franchise
        {
            get { return this.franchiseField; }
            set { this.franchiseField = value; }
        }

        /// <remarks/>
        public price price
        {
            get { return this.priceField; }
            set { this.priceField = value; }
        }

        /// <remarks/>
        public string priceView
        {
            get { return this.priceViewField; }
            set { this.priceViewField = value; }
        }

        /// <remarks/>
        [XmlElement("businessLease")]
        public businessLease[] businessLease
        {
            get { return this.businessLeaseField; }
            set { this.businessLeaseField = value; }
        }

        /// <remarks/>
        public string takings
        {
            get { return this.takingsField; }
            set { this.takingsField = value; }
        }

        /// <remarks/>
        public @return @return
        {
            get { return this.returnField; }
            set { this.returnField = value; }
        }

        /// <remarks/>
        public string currentLeaseEndDate
        {
            get { return this.currentLeaseEndDateField; }
            set { this.currentLeaseEndDateField = value; }
        }

        /// <remarks/>
        public string furtherOptions
        {
            get { return this.furtherOptionsField; }
            set { this.furtherOptionsField = value; }
        }

        /// <remarks/>
        public address address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        /// <remarks/>
        public string municipality
        {
            get { return this.municipalityField; }
            set { this.municipalityField = value; }
        }

        /// <remarks/>
        public streetDirectory streetDirectory
        {
            get { return this.streetDirectoryField; }
            set { this.streetDirectoryField = value; }
        }

        /// <remarks/>
        [XmlElement("businessCategory")]
        public businessCategory[] businessCategory
        {
            get { return this.businessCategoryField; }
            set { this.businessCategoryField = value; }
        }

        /// <remarks/>
        public string headline
        {
            get { return this.headlineField; }
            set { this.headlineField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string terms
        {
            get { return this.termsField; }
            set { this.termsField = value; }
        }

        /// <remarks/>
        public soldDetails soldDetails
        {
            get { return this.soldDetailsField; }
            set { this.soldDetailsField = value; }
        }

        /// <remarks/>
        public buildingDetails buildingDetails
        {
            get { return this.buildingDetailsField; }
            set { this.buildingDetailsField = value; }
        }

        /// <remarks/>
        [XmlElement("vendorDetails")]
        public vendorDetails[] vendorDetails
        {
            get { return this.vendorDetailsField; }
            set { this.vendorDetailsField = value; }
        }

        /// <remarks/>
        [XmlElement("externalLink")]
        public externalLink[] externalLink
        {
            get { return this.externalLinkField; }
            set { this.externalLinkField = value; }
        }

        /// <remarks/>
        public extraFields extraFields
        {
            get { return this.extraFieldsField; }
            set { this.extraFieldsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("img", IsNullable = false)]
        public img[] images
        {
            get { return this.imagesField; }
            set { this.imagesField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("document", typeof(document), IsNullable = false)]
        [XmlArrayItem("floorplan", typeof(floorplan), IsNullable = false)]
        [XmlArrayItem("img", typeof(img), IsNullable = false)]
        public object[] objects
        {
            get { return this.objectsField; }
            set { this.objectsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("uri", IsNullable = false)]
        public uri[] miniweb
        {
            get { return this.miniwebField; }
            set { this.miniwebField = value; }
        }

        /// <remarks/>
        public string purchaseOrder
        {
            get { return this.purchaseOrderField; }
            set { this.purchaseOrderField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public businessStatus status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class marketing
    {

        private upgrade upgradeField;

        /// <remarks/>
        public upgrade upgrade
        {
            get { return this.upgradeField; }
            set { this.upgradeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class upgrade
    {

        private presentation presentationField;

        /// <remarks/>
        public presentation presentation
        {
            get { return this.presentationField; }
            set { this.presentationField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class presentation
    {

        private presentationStyle styleField;

        private presentationDuration durationField;

        /// <remarks/>
        [XmlAttribute()]
        public presentationStyle style
        {
            get { return this.styleField; }
            set { this.styleField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public presentationDuration duration
        {
            get { return this.durationField; }
            set { this.durationField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum presentationStyle
    {

        /// <remarks/>
        enhanced,

        /// <remarks/>
        premium,

        /// <remarks/>
        elite,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum presentationDuration
    {

        /// <remarks/>
        [XmlEnum("30")]
        Item30,

        /// <remarks/>
        [XmlEnum("90")]
        Item90,

        /// <remarks/>
        [XmlEnum("180")]
        Item180,

        /// <remarks/>
        [XmlEnum("365")]
        Item365,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class exclusivity
    {

        private exclusivityValue valueField;

        /// <remarks/>
        [XmlAttribute()]
        public exclusivityValue value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum exclusivityValue
    {

        /// <remarks/>
        exclusive,

        /// <remarks/>
        open,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class commercialListingType
    {

        private commercialListingTypeValue valueField;

        /// <remarks/>
        [XmlAttribute()]
        public commercialListingTypeValue value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum commercialListingTypeValue
    {

        /// <remarks/>
        sale,

        /// <remarks/>
        lease,

        /// <remarks/>
        both,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class underOffer
    {

        private underOfferValue valueField;

        public underOffer()
        {
            this.valueField = underOfferValue.no;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(underOfferValue.no)]
        public underOfferValue value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum underOfferValue
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class listingAgent
    {
        private string agentIDField;

        private string nameField;

        private telephone[] telephoneField;

        private string emailField;

        private string twitterURLField;

        private string facebookURLField;

        private string linkedInURLField;

        private listingAgentID idField;

        private string externalAgentIDField;

        public listingAgent()
        {
            this.idField = listingAgentID.Item1;
        }

        [XmlAttribute("externalAgentId")]
        public string externalAgentID
        {
            get { return externalAgentIDField; }
            set { this.externalAgentIDField = value; }
        }

        /// <remarks/>
        public string agentID
        {
            get { return this.agentIDField; }
            set { this.agentIDField = value; }
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        [XmlElement("telephone")]
        public telephone[] telephone
        {
            get { return this.telephoneField; }
            set { this.telephoneField = value; }
        }

        /// <remarks/>
        public string email
        {
            get { return this.emailField; }
            set { this.emailField = value; }
        }

        /// <remarks/>
        public string twitterURL
        {
            get { return this.twitterURLField; }
            set { this.twitterURLField = value; }
        }

        /// <remarks/>
        public string facebookURL
        {
            get { return this.facebookURLField; }
            set { this.facebookURLField = value; }
        }

        /// <remarks/>
        public string linkedInURL
        {
            get { return this.linkedInURLField; }
            set { this.linkedInURLField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(listingAgentID.Item1)]
        public listingAgentID id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class telephone
    {

        private telephoneType typeField;

        private string valueField;

        public telephone()
        {
            this.typeField = telephoneType.BH;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(telephoneType.BH)]
        public telephoneType type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum telephoneType
    {

        /// <remarks/>
        BH,

        /// <remarks/>
        AH,

        /// <remarks/>
        mobile,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum listingAgentID
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,

        /// <remarks/>
        [XmlEnum("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class franchise
    {

        private franchiseValue valueField;

        public franchise()
        {
            this.valueField = franchiseValue.no;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(franchiseValue.no)]
        public franchiseValue value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum franchiseValue
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class price
    {

        private range[] itemsField;

        private string textField;

        private priceDisplay displayField;

        private priceTax taxField;

        private pricePlusSAV plusSAVField;

        public price()
        {
            this.displayField = priceDisplay.yes;
            this.taxField = priceTax.unknown;
            this.plusSAVField = pricePlusSAV.no;
        }

        /// <remarks/>
        [XmlElement("range")]
        public range[] Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Text
        {
            get { return this.textField; }
            set { this.textField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(priceDisplay.yes)]
        public priceDisplay display
        {
            get { return this.displayField; }
            set { this.displayField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(priceTax.unknown)]
        public priceTax tax
        {
            get { return this.taxField; }
            set { this.taxField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(pricePlusSAV.no)]
        public pricePlusSAV plusSAV
        {
            get { return this.plusSAVField; }
            set { this.plusSAVField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class range
    {

        private string minField;

        private string maxField;

        /// <remarks/>
        public string min
        {
            get { return this.minField; }
            set { this.minField = value; }
        }

        /// <remarks/>
        public string max
        {
            get { return this.maxField; }
            set { this.maxField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum priceDisplay
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum priceTax
    {

        /// <remarks/>
        unknown,

        /// <remarks/>
        exempt,

        /// <remarks/>
        inclusive,

        /// <remarks/>
        exclusive,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum pricePlusSAV
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class businessLease
    {

        private businessLeasePeriod periodField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public businessLeasePeriod period
        {
            get { return this.periodField; }
            set { this.periodField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum businessLeasePeriod
    {

        /// <remarks/>
        week,

        /// <remarks/>
        month,

        /// <remarks/>
        year,

        /// <remarks/>
        annual,

        /// <remarks/>
        weekly,

        /// <remarks/>
        monthly,

        /// <remarks/>
        yearly,

        /// <remarks/>
        annually,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class @return
    {

        private returnPeriod periodField;

        private bool periodFieldSpecified;

        private returnUnit unitField;

        private bool unitFieldSpecified;

        private string valueField;

        public @return()
        {
            this.periodField = returnPeriod.annual;
            this.unitField = returnUnit.percent;
        }

        /// <remarks/>
        [XmlAttribute()]
        public returnPeriod period
        {
            get { return this.periodField; }
            set { this.periodField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool periodSpecified
        {
            get { return this.periodFieldSpecified; }
            set { this.periodFieldSpecified = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public returnUnit unit
        {
            get { return this.unitField; }
            set { this.unitField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool unitSpecified
        {
            get { return this.unitFieldSpecified; }
            set { this.unitFieldSpecified = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum returnPeriod
    {

        /// <remarks/>
        annual,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum returnUnit
    {

        /// <remarks/>
        percent,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class address
    {

        private string siteField;

        private string subNumberField;

        private string lotNumberField;

        private string streetNumberField;

        private string streetField;

        private suburb suburbField;

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string countryField;

        private addressDisplay displayField;

        private addressStreetview streetviewField;

        private string postCodeField;

        private string stateField;

        public address()
        {
            this.displayField = addressDisplay.yes;
            this.streetviewField = addressStreetview.yes;
        }

        /// <remarks/>
        public string site
        {
            get { return this.siteField; }
            set { this.siteField = value; }
        }

        /// <remarks/>
        public string subNumber
        {
            get { return this.subNumberField; }
            set { this.subNumberField = value; }
        }

        /// <remarks/>
        public string lotNumber
        {
            get { return this.lotNumberField; }
            set { this.lotNumberField = value; }
        }

        /// <remarks/>
        public string streetNumber
        {
            get { return this.streetNumberField; }
            set { this.streetNumberField = value; }
        }

        /// <remarks/>
        public string street
        {
            get { return this.streetField; }
            set { this.streetField = value; }
        }

        /// <remarks/>
        public suburb suburb
        {
            get { return this.suburbField; }
            set { this.suburbField = value; }
        }

        public string postcode
        {
            get { return this.postCodeField; }
            set { this.postCodeField = value; }
        }

        public string state
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <remarks/>
        public string country
        {
            get { return this.countryField; }
            set { this.countryField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        //[System.ComponentModel.DefaultValueAttribute(addressDisplay.yes)]
        public addressDisplay display
        {
            get { return this.displayField; }
            set { this.displayField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(addressStreetview.yes)]
        public addressStreetview streetview
        {
            get { return this.streetviewField; }
            set { this.streetviewField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class suburb
    {

        private suburbDisplay displayField;

        private string valueField;

        public suburb()
        {
            this.displayField = suburbDisplay.yes;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(suburbDisplay.yes)]
        public suburbDisplay display
        {
            get { return this.displayField; }
            set { this.displayField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum suburbDisplay
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        postcode,

        /// <remarks/>
        region,

        /// <remarks/>
        state,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum addressDisplay
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum addressStreetview
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class streetDirectory
    {

        private string pageField;

        private string referenceField;

        private streetDirectoryType typeField;

        /// <remarks/>
        public string page
        {
            get { return this.pageField; }
            set { this.pageField = value; }
        }

        /// <remarks/>
        public string reference
        {
            get { return this.referenceField; }
            set { this.referenceField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public streetDirectoryType type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum streetDirectoryType
    {

        /// <remarks/>
        melways,

        /// <remarks/>
        UBD,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class businessCategory
    {

        private string nameField;

        private businessSubCategory businessSubCategoryField;

        private businessCategoryID idField;

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public businessSubCategory businessSubCategory
        {
            get { return this.businessSubCategoryField; }
            set { this.businessSubCategoryField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public businessCategoryID id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class businessSubCategory
    {

        private string nameField;

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum businessCategoryID
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class soldDetails
    {

        private object itemField;

        private string item1Field;

        private Item1ChoiceType item1ElementNameField;

        /// <remarks/>
        [XmlElement("price", typeof(price))]
        [XmlElement("soldPrice", typeof(soldPrice))]
        public object Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }

        /// <remarks/>
        [XmlElement("date", typeof(string))]
        [XmlElement("soldDate", typeof(string))]
        [XmlChoiceIdentifier("Item1ElementName")]
        public string Item1
        {
            get { return this.item1Field; }
            set { this.item1Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public Item1ChoiceType Item1ElementName
        {
            get { return this.item1ElementNameField; }
            set { this.item1ElementNameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class soldPrice
    {

        private soldPriceDisplay displayField;

        private string valueField;

        public soldPrice()
        {
            this.displayField = soldPriceDisplay.yes;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(soldPriceDisplay.yes)]
        public soldPriceDisplay display
        {
            get { return this.displayField; }
            set { this.displayField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum soldPriceDisplay
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,

        /// <remarks/>
        range,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(IncludeInSchema = false)]
    public enum Item1ChoiceType
    {

        /// <remarks/>
        date,

        /// <remarks/>
        soldDate,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class buildingDetails
    {

        private area[] areaField;

        private string energyRatingField;

        /// <remarks/>
        [XmlElement("area")]
        public area[] area
        {
            get { return this.areaField; }
            set { this.areaField = value; }
        }

        /// <remarks/>
        public string energyRating
        {
            get { return this.energyRatingField; }
            set { this.energyRatingField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class area
    {

        private range[] itemsField;

        private string textField;

        private areaUnit unitField;

        private string ofField;

        public area()
        {
            this.ofField = "total";
        }

        /// <remarks/>
        [XmlElement("range")]
        public range[] Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Text
        {
            get { return this.textField; }
            set { this.textField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public areaUnit unit
        {
            get { return this.unitField; }
            set { this.unitField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute("total")]
        public string of
        {
            get { return this.ofField; }
            set { this.ofField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum areaUnit
    {

        /// <remarks/>
        square,

        /// <remarks/>
        squareMeter,

        /// <remarks/>
        acre,

        /// <remarks/>
        hectare,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class vendorDetails
    {

        private string nameField;

        private telephone[] telephoneField;

        private string emailField;

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        [XmlElement("telephone")]
        public telephone[] telephone
        {
            get { return this.telephoneField; }
            set { this.telephoneField = value; }
        }

        /// <remarks/>
        public string email
        {
            get { return this.emailField; }
            set { this.emailField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class externalLink
    {

        private string hrefField;

        /// <remarks/>
        [XmlAttribute()]
        public string href
        {
            get { return this.hrefField; }
            set { this.hrefField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class extraFields
    {

        private eField[] eFieldField;

        private string tableField;

        /// <remarks/>
        [XmlElement("eField")]
        public eField[] eField
        {
            get { return this.eFieldField; }
            set { this.eFieldField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string table
        {
            get { return this.tableField; }
            set { this.tableField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class eField
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class img
    {

        private imgID idField;

        private string modTimeField;

        private string urlField;

        private string fileField;

        private imgFormat formatField;

        private bool formatFieldSpecified;

        private string valueField;

        public img()
        {
            this.formatField = imgFormat.jpg;
        }

        /// <remarks/>
        [XmlAttribute()]
        public imgID id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string url
        {
            get { return this.urlField; }
            set { this.urlField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string file
        {
            get { return this.fileField; }
            set { this.fileField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public imgFormat format
        {
            get { return this.formatField; }
            set { this.formatField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool formatSpecified
        {
            get { return this.formatFieldSpecified; }
            set { this.formatFieldSpecified = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum imgID
    {

        /// <remarks/>
        m,

        /// <remarks/>
        a,

        /// <remarks/>
        b,

        /// <remarks/>
        c,

        /// <remarks/>
        d,

        /// <remarks/>
        e,

        /// <remarks/>
        f,

        /// <remarks/>
        g,

        /// <remarks/>
        h,

        /// <remarks/>
        i,

        /// <remarks/>
        j,

        /// <remarks/>
        k,

        /// <remarks/>
        l,

        /// <remarks/>
        n,

        /// <remarks/>
        o,

        /// <remarks/>
        p,

        /// <remarks/>
        q,

        /// <remarks/>
        r,

        /// <remarks/>
        s,

        /// <remarks/>
        t,

        /// <remarks/>
        u,

        /// <remarks/>
        v,

        /// <remarks/>
        w,

        /// <remarks/>
        x,

        /// <remarks/>
        y,

        /// <remarks/>
        z,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum imgFormat
    {

        /// <remarks/>
        jpg,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class document
    {

        private documentID idField;

        private string modTimeField;

        private string urlField;

        private string fileField;

        private string titleField;

        private documentFormat formatField;

        private bool formatFieldSpecified;

        private string valueField;

        public document()
        {
            this.formatField = documentFormat.pdf;
        }

        /// <remarks/>
        [XmlAttribute()]
        public documentID id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string url
        {
            get { return this.urlField; }
            set { this.urlField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string file
        {
            get { return this.fileField; }
            set { this.fileField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string title
        {
            get { return this.titleField; }
            set { this.titleField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public documentFormat format
        {
            get { return this.formatField; }
            set { this.formatField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool formatSpecified
        {
            get { return this.formatFieldSpecified; }
            set { this.formatFieldSpecified = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum documentID
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,

        /// <remarks/>
        [XmlEnum("4")]
        Item4,

        /// <remarks/>
        [XmlEnum("5")]
        Item5,

        /// <remarks/>
        [XmlEnum("6")]
        Item6,

        /// <remarks/>
        [XmlEnum("7")]
        Item7,

        /// <remarks/>
        [XmlEnum("8")]
        Item8,

        /// <remarks/>
        [XmlEnum("9")]
        Item9,

        /// <remarks/>
        [XmlEnum("10")]
        Item10,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum documentFormat
    {

        /// <remarks/>
        pdf,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class floorplan
    {

        private floorplanID idField;

        private string idattr;

        private string modTimeField;

        private string urlField;

        private string fileField;

        private floorplanFormat formatField;

        private string valueField;

        public floorplan()
        {
            this.formatField = floorplanFormat.gif;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string id
        {
            get { return this.idattr; }
            set { this.idattr = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string url
        {
            get { return this.urlField; }
            set { this.urlField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string file
        {
            get { return this.fileField; }
            set { this.fileField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(floorplanFormat.gif)]
        public floorplanFormat format
        {
            get { return this.formatField; }
            set { this.formatField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum floorplanID
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum floorplanFormat
    {

        /// <remarks/>
        gif,

        /// <remarks/>
        jpg,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class uri
    {

        private uriID idField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public uriID id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum uriID
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum businessStatus
    {

        /// <remarks/>
        current,

        /// <remarks/>
        withdrawn,

        /// <remarks/>
        sold,

        /// <remarks/>
        offmarket,

        /// <remarks/>
        leased,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class commercial 
    {

        private string agentIDField;

        private marketing marketingField;

        private commercialAuthority commercialAuthorityField;

        private exclusivity exclusivityField;

        private commercialListingType commercialListingTypeField;

        private underOffer underOfferField;

        private listingAgent[] listingAgentField;

        private price priceField;

        private string priceViewField;

        private commercialRent commercialRentField;

        private outgoings outgoingsField;

        private @return returnField;

        private string currentLeaseEndDateField;

        private string tenancyField;

        private string furtherOptionsField;

        private isMultiple isMultipleField;

        private address addressField;

        private string municipalityField;

        private streetDirectory streetDirectoryField;

        private commercialCategory[] commercialCategoryField;

        private string headlineField;

        private string descriptionField;

        private highlight[] highlightField;

        private soldDetails soldDetailsField;

        private landDetails landDetailsField;

        private buildingDetails buildingDetailsField;

        private string propertyExtentField;

        private string carSpacesField;

        private string parkingCommentsField;

        private auction auctionField;

        private vendorDetails[] vendorDetailsField;

        private string zoneField;

        private externalLink[] externalLinkField;

        private videoLink videoLinkField;

        private extraFields extraFieldsField;

        private img[] imagesField;

        private object[] objectsField;

        private uri[] miniwebField;

        private string purchaseOrderField;

        private string modTimeField;

        private commercialStatus statusField;

        /// <remarks/>
        public string agentID
        {
            get { return this.agentIDField; }
            set { this.agentIDField = value; }
        }

        /// <remarks/>
        public marketing marketing
        {
            get { return this.marketingField; }
            set { this.marketingField = value; }
        }

        /// <remarks/>
        public commercialAuthority commercialAuthority
        {
            get { return this.commercialAuthorityField; }
            set { this.commercialAuthorityField = value; }
        }

        /// <remarks/>
        public exclusivity exclusivity
        {
            get { return this.exclusivityField; }
            set { this.exclusivityField = value; }
        }

        /// <remarks/>
        public commercialListingType commercialListingType
        {
            get { return this.commercialListingTypeField; }
            set { this.commercialListingTypeField = value; }
        }

        /// <remarks/>
        public underOffer underOffer
        {
            get { return this.underOfferField; }
            set { this.underOfferField = value; }
        }

        /// <remarks/>
        [XmlElement("listingAgent")]
        public listingAgent[] listingAgent
        {
            get { return this.listingAgentField; }
            set { this.listingAgentField = value; }
        }

        /// <remarks/>
        public price price
        {
            get { return this.priceField; }
            set { this.priceField = value; }
        }

        /// <remarks/>
        public string priceView
        {
            get { return this.priceViewField; }
            set { this.priceViewField = value; }
        }

        /// <remarks/>
        public commercialRent commercialRent
        {
            get { return this.commercialRentField; }
            set { this.commercialRentField = value; }
        }

        /// <remarks/>
        public outgoings outgoings
        {
            get { return this.outgoingsField; }
            set { this.outgoingsField = value; }
        }

        /// <remarks/>
        public @return @return
        {
            get { return this.returnField; }
            set { this.returnField = value; }
        }

        /// <remarks/>
        public string currentLeaseEndDate
        {
            get { return this.currentLeaseEndDateField; }
            set { this.currentLeaseEndDateField = value; }
        }

        /// <remarks/>
        public string tenancy
        {
            get { return this.tenancyField; }
            set { this.tenancyField = value; }
        }

        /// <remarks/>
        public string furtherOptions
        {
            get { return this.furtherOptionsField; }
            set { this.furtherOptionsField = value; }
        }

        /// <remarks/>
        public isMultiple isMultiple
        {
            get { return this.isMultipleField; }
            set { this.isMultipleField = value; }
        }

        /// <remarks/>
        public address address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        /// <remarks/>
        public string municipality
        {
            get { return this.municipalityField; }
            set { this.municipalityField = value; }
        }

        /// <remarks/>
        public streetDirectory streetDirectory
        {
            get { return this.streetDirectoryField; }
            set { this.streetDirectoryField = value; }
        }

        /// <remarks/>
        [XmlElement("commercialCategory")]
        public commercialCategory[] commercialCategory
        {
            get { return this.commercialCategoryField; }
            set { this.commercialCategoryField = value; }
        }

        /// <remarks/>
        public string headline
        {
            get { return this.headlineField; }
            set { this.headlineField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        [XmlElement("highlight")]
        public highlight[] highlight
        {
            get { return this.highlightField; }
            set { this.highlightField = value; }
        }

        /// <remarks/>
        public soldDetails soldDetails
        {
            get { return this.soldDetailsField; }
            set { this.soldDetailsField = value; }
        }

        /// <remarks/>
        public landDetails landDetails
        {
            get { return this.landDetailsField; }
            set { this.landDetailsField = value; }
        }

        /// <remarks/>
        public buildingDetails buildingDetails
        {
            get { return this.buildingDetailsField; }
            set { this.buildingDetailsField = value; }
        }

        /// <remarks/>
        public string propertyExtent
        {
            get { return this.propertyExtentField; }
            set { this.propertyExtentField = value; }
        }

        /// <remarks/>
        public string carSpaces
        {
            get { return this.carSpacesField; }
            set { this.carSpacesField = value; }
        }

        /// <remarks/>
        public string parkingComments
        {
            get { return this.parkingCommentsField; }
            set { this.parkingCommentsField = value; }
        }

        /// <remarks/>
        public auction auction
        {
            get { return this.auctionField; }
            set { this.auctionField = value; }
        }

        /// <remarks/>
        [XmlElement("vendorDetails")]
        public vendorDetails[] vendorDetails
        {
            get { return this.vendorDetailsField; }
            set { this.vendorDetailsField = value; }
        }

        /// <remarks/>
        public string zone
        {
            get { return this.zoneField; }
            set { this.zoneField = value; }
        }

        /// <remarks/>
        [XmlElement("externalLink")]
        public externalLink[] externalLink
        {
            get { return this.externalLinkField; }
            set { this.externalLinkField = value; }
        }

        /// <remarks/>
        public videoLink videoLink
        {
            get { return this.videoLinkField; }
            set { this.videoLinkField = value; }
        }

        /// <remarks/>
        public extraFields extraFields
        {
            get { return this.extraFieldsField; }
            set { this.extraFieldsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("img", IsNullable = false)]
        public img[] images
        {
            get { return this.imagesField; }
            set { this.imagesField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("document", typeof(document), IsNullable = false)]
        [XmlArrayItem("floorplan", typeof(floorplan), IsNullable = false)]
        [XmlArrayItem("img", typeof(img), IsNullable = false)]
        public object[] objects
        {
            get { return this.objectsField; }
            set { this.objectsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("uri", IsNullable = false)]
        public uri[] miniweb
        {
            get { return this.miniwebField; }
            set { this.miniwebField = value; }
        }

        /// <remarks/>
        public string purchaseOrder
        {
            get { return this.purchaseOrderField; }
            set { this.purchaseOrderField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public commercialStatus status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class commercialAuthority
    {

        private commercialAuthorityValue valueField;

        /// <remarks/>
        [XmlAttribute()]
        public commercialAuthorityValue value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum commercialAuthorityValue
    {

        /// <remarks/>
        auction,

        /// <remarks/>
        tender,

        /// <remarks/>
        eoi,

        /// <remarks/>
        sale,

        /// <remarks/>
        forsale,

        /// <remarks/>
        offers,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class commercialRent
    {

        private rentPerSquareMetre[] itemsField;

        private string[] textField;

        private commercialRentPeriod periodField;

        private bool periodFieldSpecified;

        private commercialRentPlusOutgoings plusOutgoingsField;

        private commercialRentTax taxField;

        public commercialRent()
        {
            this.periodField = commercialRentPeriod.annual;
            this.plusOutgoingsField = commercialRentPlusOutgoings.no;
            this.taxField = commercialRentTax.unknown;
        }

        /// <remarks/>
        [XmlElement("rentPerSquareMetre")]
        public rentPerSquareMetre[] Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string[] Text
        {
            get { return this.textField; }
            set { this.textField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public commercialRentPeriod period
        {
            get { return this.periodField; }
            set { this.periodField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool periodSpecified
        {
            get { return this.periodFieldSpecified; }
            set { this.periodFieldSpecified = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(commercialRentPlusOutgoings.no)]
        public commercialRentPlusOutgoings plusOutgoings
        {
            get { return this.plusOutgoingsField; }
            set { this.plusOutgoingsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(commercialRentTax.unknown)]
        public commercialRentTax tax
        {
            get { return this.taxField; }
            set { this.taxField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class rentPerSquareMetre
    {

        private range rangeField;

        /// <remarks/>
        public range range
        {
            get { return this.rangeField; }
            set { this.rangeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum commercialRentPeriod
    {

        /// <remarks/>
        annual,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum commercialRentPlusOutgoings
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum commercialRentTax
    {

        /// <remarks/>
        unknown,

        /// <remarks/>
        exempt,

        /// <remarks/>
        inclusive,

        /// <remarks/>
        exclusive,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class outgoings
    {

        private outgoingsPeriod periodField;

        private bool periodFieldSpecified;

        private string valueField;

        public outgoings()
        {
            this.periodField = outgoingsPeriod.annual;
        }

        /// <remarks/>
        [XmlAttribute()]
        public outgoingsPeriod period
        {
            get { return this.periodField; }
            set { this.periodField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool periodSpecified
        {
            get { return this.periodFieldSpecified; }
            set { this.periodFieldSpecified = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum outgoingsPeriod
    {

        /// <remarks/>
        annual,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class isMultiple
    {

        private isMultipleValue valueField;

        public isMultiple()
        {
            this.valueField = isMultipleValue.no;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(isMultipleValue.no)]
        public isMultipleValue value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum isMultipleValue
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class commercialCategory
    {

        private string nameField;

        private commercialCategoryID idField;

        public commercialCategory()
        {
            this.nameField = "Retail";
            this.idField = commercialCategoryID.Item1;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Retail")]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(commercialCategoryID.Item1)]
        public commercialCategoryID id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum commercialCategoryID
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class highlight
    {

        private highlightID idField;

        private string valueField;

        public highlight()
        {
            this.idField = highlightID.Item1;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(highlightID.Item1)]
        public highlightID id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum highlightID
    {

        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class landDetails
    {

        private area areaField;

        private frontage frontageField;

        private depth[] depthField;

        private crossOver crossOverField;

        /// <remarks/>
        public area area
        {
            get { return this.areaField; }
            set { this.areaField = value; }
        }

        /// <remarks/>
        public frontage frontage
        {
            get { return this.frontageField; }
            set { this.frontageField = value; }
        }

        /// <remarks/>
        [XmlElement("depth")]
        public depth[] depth
        {
            get { return this.depthField; }
            set { this.depthField = value; }
        }

        /// <remarks/>
        public crossOver crossOver
        {
            get { return this.crossOverField; }
            set { this.crossOverField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class frontage
    {

        private frontageUnit unitField;

        private bool unitFieldSpecified;

        private string valueField;

        public frontage()
        {
            this.unitField = frontageUnit.meter;
        }

        /// <remarks/>
        [XmlAttribute()]
        public frontageUnit unit
        {
            get { return this.unitField; }
            set { this.unitField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool unitSpecified
        {
            get { return this.unitFieldSpecified; }
            set { this.unitFieldSpecified = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum frontageUnit
    {

        /// <remarks/>
        meter,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class depth
    {

        private depthUnit unitField;

        private bool unitFieldSpecified;

        private depthSide sideField;

        private string valueField;

        public depth()
        {
            this.unitField = depthUnit.meter;
        }

        /// <remarks/>
        [XmlAttribute()]
        public depthUnit unit
        {
            get { return this.unitField; }
            set { this.unitField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool unitSpecified
        {
            get { return this.unitFieldSpecified; }
            set { this.unitFieldSpecified = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public depthSide side
        {
            get { return this.sideField; }
            set { this.sideField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum depthUnit
    {

        /// <remarks/>
        meter,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum depthSide
    {

        /// <remarks/>
        rear,

        /// <remarks/>
        left,

        /// <remarks/>
        right,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class crossOver
    {

        private crossOverValue valueField;

        /// <remarks/>
        [XmlAttribute()]
        public crossOverValue value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum crossOverValue
    {

        /// <remarks/>
        left,

        /// <remarks/>
        right,

        /// <remarks/>
        center,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class auction
    {

        private string valueField;
        private string dateField;

        /// <remarks/>
        [XmlAttribute()]
        public string date
        {
            get { return this.dateField; }
            set { this.dateField = value; }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class videoLink
    {

        private string hrefField;

        /// <remarks/>
        [XmlAttribute()]
        public string href
        {
            get { return this.hrefField; }
            set { this.hrefField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum commercialStatus
    {

        /// <remarks/>
        current,

        /// <remarks/>
        withdrawn,

        /// <remarks/>
        sold,

        /// <remarks/>
        offmarket,

        /// <remarks/>
        leased,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class commercialLand
    {

        private string agentIDField;

        private marketing marketingField;

        private authority authorityField;

        private commercialListingType commercialListingTypeField;

        private underOffer underOfferField;

        private listingAgent[] listingAgentField;

        private price priceField;

        private string priceViewField;

        private commercialRent commercialRentField;

        private outgoings outgoingsField;

        private @return returnField;

        private string currentLeaseEndDateField;

        private address addressField;

        private string municipalityField;

        private estate estateField;

        private streetDirectory streetDirectoryField;

        private string headlineField;

        private string descriptionField;

        private highlight[] highlightField;

        private soldDetails soldDetailsField;

        private landDetails landDetailsField;

        private auction auctionField;

        private vendorDetails[] vendorDetailsField;

        private externalLink[] externalLinkField;

        private videoLink videoLinkField;

        private extraFields extraFieldsField;

        private img[] imagesField;

        private object[] objectsField;

        private uri[] miniwebField;

        private string purchaseOrderField;

        private string modTimeField;

        private commercialLandStatus statusField;

        /// <remarks/>
        public string agentID
        {
            get { return this.agentIDField; }
            set { this.agentIDField = value; }
        }

        /// <remarks/>
        public marketing marketing
        {
            get { return this.marketingField; }
            set { this.marketingField = value; }
        }

        /// <remarks/>
        public authority authority
        {
            get { return this.authorityField; }
            set { this.authorityField = value; }
        }

        /// <remarks/>
        public commercialListingType commercialListingType
        {
            get { return this.commercialListingTypeField; }
            set { this.commercialListingTypeField = value; }
        }

        /// <remarks/>
        public underOffer underOffer
        {
            get { return this.underOfferField; }
            set { this.underOfferField = value; }
        }

        /// <remarks/>
        [XmlElement("listingAgent")]
        public listingAgent[] listingAgent
        {
            get { return this.listingAgentField; }
            set { this.listingAgentField = value; }
        }

        /// <remarks/>
        public price price
        {
            get { return this.priceField; }
            set { this.priceField = value; }
        }

        /// <remarks/>
        public string priceView
        {
            get { return this.priceViewField; }
            set { this.priceViewField = value; }
        }

        /// <remarks/>
        public commercialRent commercialRent
        {
            get { return this.commercialRentField; }
            set { this.commercialRentField = value; }
        }

        /// <remarks/>
        public outgoings outgoings
        {
            get { return this.outgoingsField; }
            set { this.outgoingsField = value; }
        }

        /// <remarks/>
        public @return @return
        {
            get { return this.returnField; }
            set { this.returnField = value; }
        }

        /// <remarks/>
        public string currentLeaseEndDate
        {
            get { return this.currentLeaseEndDateField; }
            set { this.currentLeaseEndDateField = value; }
        }

        /// <remarks/>
        public address address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        /// <remarks/>
        public string municipality
        {
            get { return this.municipalityField; }
            set { this.municipalityField = value; }
        }

        /// <remarks/>
        public estate estate
        {
            get { return this.estateField; }
            set { this.estateField = value; }
        }

        /// <remarks/>
        public streetDirectory streetDirectory
        {
            get { return this.streetDirectoryField; }
            set { this.streetDirectoryField = value; }
        }

        /// <remarks/>
        public string headline
        {
            get { return this.headlineField; }
            set { this.headlineField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        [XmlElement("highlight")]
        public highlight[] highlight
        {
            get { return this.highlightField; }
            set { this.highlightField = value; }
        }

        /// <remarks/>
        public soldDetails soldDetails
        {
            get { return this.soldDetailsField; }
            set { this.soldDetailsField = value; }
        }

        /// <remarks/>
        public landDetails landDetails
        {
            get { return this.landDetailsField; }
            set { this.landDetailsField = value; }
        }

        /// <remarks/>
        public auction auction
        {
            get { return this.auctionField; }
            set { this.auctionField = value; }
        }

        /// <remarks/>
        [XmlElement("vendorDetails")]
        public vendorDetails[] vendorDetails
        {
            get { return this.vendorDetailsField; }
            set { this.vendorDetailsField = value; }
        }

        /// <remarks/>
        [XmlElement("externalLink")]
        public externalLink[] externalLink
        {
            get { return this.externalLinkField; }
            set { this.externalLinkField = value; }
        }

        /// <remarks/>
        public videoLink videoLink
        {
            get { return this.videoLinkField; }
            set { this.videoLinkField = value; }
        }

        /// <remarks/>
        public extraFields extraFields
        {
            get { return this.extraFieldsField; }
            set { this.extraFieldsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("img", IsNullable = false)]
        public img[] images
        {
            get { return this.imagesField; }
            set { this.imagesField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("document", typeof(document), IsNullable = false)]
        [XmlArrayItem("floorplan", typeof(floorplan), IsNullable = false)]
        [XmlArrayItem("img", typeof(img), IsNullable = false)]
        public object[] objects
        {
            get { return this.objectsField; }
            set { this.objectsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("uri", IsNullable = false)]
        public uri[] miniweb
        {
            get { return this.miniwebField; }
            set { this.miniwebField = value; }
        }

        /// <remarks/>
        public string purchaseOrder
        {
            get { return this.purchaseOrderField; }
            set { this.purchaseOrderField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public commercialLandStatus status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class authority
    {

        private authorityValue valueField;

        /// <remarks/>
        [XmlAttribute()]
        public authorityValue value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum authorityValue
    {

        /// <remarks/>
        auction,

        /// <remarks/>
        exclusive,

        /// <remarks/>
        multilist,

        /// <remarks/>
        conjunctional,

        /// <remarks/>
        open,

        /// <remarks/>
        sale,

        /// <remarks/>
        setsale,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class estate
    {

        private string nameField;

        private string stageField;

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string stage
        {
            get { return this.stageField; }
            set { this.stageField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum commercialLandStatus
    {

        /// <remarks/>
        current,

        /// <remarks/>
        withdrawn,

        /// <remarks/>
        sold,

        /// <remarks/>
        offmarket,

        /// <remarks/>
        leased,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class holidayRental 
    {

        private string agentIDField;

        private listingAgent[] listingAgentField;

        private string dateAvailableField;

        private rent[] rentField;

        private string priceViewField;

        private string bondField;

        private address addressField;

        private string municipalityField;

        private streetDirectory streetDirectoryField;

        private holidayCategory holidayCategoryField;

        private string headlineField;

        private string descriptionField;

        private features featuresField;

        private landDetails landDetailsField;

        private buildingDetails buildingDetailsField;

        private string[] inspectionTimesField;

        private externalLink[] externalLinkField;

        private availabilityLink availabilityLinkField;

        private extraFields extraFieldsField;

        private img[] imagesField;

        private object[] objectsField;

        private string modTimeField;

        private holidayRentalStatus statusField;

        /// <remarks/>
        public string agentID
        {
            get { return this.agentIDField; }
            set { this.agentIDField = value; }
        }


        /// <remarks/>
        [XmlElement("listingAgent")]
        public listingAgent[] listingAgent
        {
            get { return this.listingAgentField; }
            set { this.listingAgentField = value; }
        }

        /// <remarks/>
        public string dateAvailable
        {
            get { return this.dateAvailableField; }
            set { this.dateAvailableField = value; }
        }

        /// <remarks/>
        [XmlElement("rent")]
        public rent[] rent
        {
            get { return this.rentField; }
            set { this.rentField = value; }
        }

        /// <remarks/>
        public string priceView
        {
            get { return this.priceViewField; }
            set { this.priceViewField = value; }
        }

        /// <remarks/>
        public string bond
        {
            get { return this.bondField; }
            set { this.bondField = value; }
        }

        /// <remarks/>
        public address address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        /// <remarks/>
        public string municipality
        {
            get { return this.municipalityField; }
            set { this.municipalityField = value; }
        }

        /// <remarks/>
        public streetDirectory streetDirectory
        {
            get { return this.streetDirectoryField; }
            set { this.streetDirectoryField = value; }
        }

        /// <remarks/>
        public holidayCategory holidayCategory
        {
            get { return this.holidayCategoryField; }
            set { this.holidayCategoryField = value; }
        }

        /// <remarks/>
        public string headline
        {
            get { return this.headlineField; }
            set { this.headlineField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public features features
        {
            get { return this.featuresField; }
            set { this.featuresField = value; }
        }

        /// <remarks/>
        public landDetails landDetails
        {
            get { return this.landDetailsField; }
            set { this.landDetailsField = value; }
        }

        /// <remarks/>
        public buildingDetails buildingDetails
        {
            get { return this.buildingDetailsField; }
            set { this.buildingDetailsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("inspection", IsNullable = false)]
        public string[] inspectionTimes
        {
            get { return this.inspectionTimesField; }
            set { this.inspectionTimesField = value; }
        }

        /// <remarks/>
        [XmlElement("externalLink")]
        public externalLink[] externalLink
        {
            get { return this.externalLinkField; }
            set { this.externalLinkField = value; }
        }

        /// <remarks/>
        public availabilityLink availabilityLink
        {
            get { return this.availabilityLinkField; }
            set { this.availabilityLinkField = value; }
        }

        /// <remarks/>
        public extraFields extraFields
        {
            get { return this.extraFieldsField; }
            set { this.extraFieldsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("img", IsNullable = false)]
        public img[] images
        {
            get { return this.imagesField; }
            set { this.imagesField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("document", typeof(document), IsNullable = false)]
        [XmlArrayItem("floorplan", typeof(floorplan), IsNullable = false)]
        [XmlArrayItem("img", typeof(img), IsNullable = false)]
        public object[] objects
        {
            get { return this.objectsField; }
            set { this.objectsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public holidayRentalStatus status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class rent
    {

        private rentPeriod periodField;

        private rentDisplay displayField;

        private string valueField;

        public rent()
        {
            this.displayField = rentDisplay.yes;
        }

        /// <remarks/>
        [XmlAttribute()]
        public rentPeriod period
        {
            get { return this.periodField; }
            set { this.periodField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(rentDisplay.yes)]
        public rentDisplay display
        {
            get { return this.displayField; }
            set { this.displayField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum rentPeriod
    {

        /// <remarks/>
        week,

        /// <remarks/>
        month,

        /// <remarks/>
        weekly,

        /// <remarks/>
        monthly,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum rentDisplay
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class holidayCategory
    {

        private holidayCategoryName nameField;

        /// <remarks/>
        [XmlAttribute()]
        public holidayCategoryName name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum holidayCategoryName
    {

        /// <remarks/>
        Alpine,

        /// <remarks/>
        Unit,

        /// <remarks/>
        ServicedApartment,

        /// <remarks/>
        House,

        /// <remarks/>
        Terrace,

        /// <remarks/>
        Flat,

        /// <remarks/>
        Studio,

        /// <remarks/>
        Villa,

        /// <remarks/>
        Townhouse,

        /// <remarks/>
        Apartment,

        /// <remarks/>
        [XmlEnum("DuplexSemi-detached")]
        DuplexSemidetached,

        /// <remarks/>
        Retreat,

        /// <remarks/>
        BackpackerHostel,

        /// <remarks/>
        Campground,

        /// <remarks/>
        CaravanHolidayPark,

        /// <remarks/>
        FarmStay,

        /// <remarks/>
        HouseBoat,

        /// <remarks/>
        Hotel,

        /// <remarks/>
        Motel,

        /// <remarks/>
        Lodge,

        /// <remarks/>
        ExecutiveRental,

        /// <remarks/>
        BedAndBreakfast,

        /// <remarks/>
        Resort,

        /// <remarks/>
        SelfContainedCottage,

        /// <remarks/>
        Other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class features
    {

        private string bedroomsField;

        private string bathroomsField;

        private string ensuiteField;

        private string garagesField;

        private string carportsField;

        private string remoteGarageField;

        private string secureParkingField;

        private string airConditioningField;

        private string alarmSystemField;

        private string vacuumSystemField;

        private string intercomField;

        private pool poolField;

        private string poolInGroundField;

        private string poolAboveGroundField;

        private spa spaField;

        private string tennisCourtField;

        private string balconyField;

        private string deckField;

        private string courtyardField;

        private string outdoorEntField;

        private string shedField;

        private string fullyFencedField;

        private string openFirePlaceField;

        private string openSpacesField;

        private string toiletsField;

        private string livingAreasField;

        private heating heatingField;

        private hotWaterService hotWaterServiceField;

        private string insideSpaField;

        private string outsideSpaField;

        private string broadbandField;

        private string builtInRobesField;

        private string dishwasherField;

        private string ductedCoolingField;

        private string ductedHeatingField;

        private string evaporativeCoolingField;

        private string floorboardsField;

        private string gasHeatingField;

        private string gymField;

        private string hydronicHeatingField;

        private string payTVField;

        private string reverseCycleAirConField;

        private string rumpusRoomField;

        private string splitSystemAirConField;

        private string splitSystemHeatingField;

        private string studyField;

        private string workshopField;

        private string otherFeaturesField;

        /// <remarks/>
        public string bedrooms
        {
            get { return this.bedroomsField; }
            set { this.bedroomsField = value; }
        }

        /// <remarks/>
        public string bathrooms
        {
            get { return this.bathroomsField; }
            set { this.bathroomsField = value; }
        }

        /// <remarks/>
        public string ensuite
        {
            get { return this.ensuiteField; }
            set { this.ensuiteField = value; }
        }

        /// <remarks/>
        public string garages
        {
            get { return this.garagesField; }
            set { this.garagesField = value; }
        }

        /// <remarks/>
        public string carports
        {
            get { return this.carportsField; }
            set { this.carportsField = value; }
        }

        /// <remarks/>
        public string remoteGarage
        {
            get { return this.remoteGarageField; }
            set { this.remoteGarageField = value; }
        }

        /// <remarks/>
        public string secureParking
        {
            get { return this.secureParkingField; }
            set { this.secureParkingField = value; }
        }

        /// <remarks/>
        public string airConditioning
        {
            get { return this.airConditioningField; }
            set { this.airConditioningField = value; }
        }

        /// <remarks/>
        public string alarmSystem
        {
            get { return this.alarmSystemField; }
            set { this.alarmSystemField = value; }
        }

        /// <remarks/>
        public string vacuumSystem
        {
            get { return this.vacuumSystemField; }
            set { this.vacuumSystemField = value; }
        }

        /// <remarks/>
        public string intercom
        {
            get { return this.intercomField; }
            set { this.intercomField = value; }
        }

        /// <remarks/>
        public pool pool
        {
            get { return this.poolField; }
            set { this.poolField = value; }
        }

        /// <remarks/>
        public string poolInGround
        {
            get { return this.poolInGroundField; }
            set { this.poolInGroundField = value; }
        }

        /// <remarks/>
        public string poolAboveGround
        {
            get { return this.poolAboveGroundField; }
            set { this.poolAboveGroundField = value; }
        }

        /// <remarks/>
        public spa spa
        {
            get { return this.spaField; }
            set { this.spaField = value; }
        }

        /// <remarks/>
        public string tennisCourt
        {
            get { return this.tennisCourtField; }
            set { this.tennisCourtField = value; }
        }

        /// <remarks/>
        public string balcony
        {
            get { return this.balconyField; }
            set { this.balconyField = value; }
        }

        /// <remarks/>
        public string deck
        {
            get { return this.deckField; }
            set { this.deckField = value; }
        }

        /// <remarks/>
        public string courtyard
        {
            get { return this.courtyardField; }
            set { this.courtyardField = value; }
        }

        /// <remarks/>
        public string outdoorEnt
        {
            get { return this.outdoorEntField; }
            set { this.outdoorEntField = value; }
        }

        /// <remarks/>
        public string shed
        {
            get { return this.shedField; }
            set { this.shedField = value; }
        }

        /// <remarks/>
        public string fullyFenced
        {
            get { return this.fullyFencedField; }
            set { this.fullyFencedField = value; }
        }

        /// <remarks/>
        public string openFirePlace
        {
            get { return this.openFirePlaceField; }
            set { this.openFirePlaceField = value; }
        }

        /// <remarks/>
        public string openSpaces
        {
            get { return this.openSpacesField; }
            set { this.openSpacesField = value; }
        }

        /// <remarks/>
        public string toilets
        {
            get { return this.toiletsField; }
            set { this.toiletsField = value; }
        }

        /// <remarks/>
        public string livingAreas
        {
            get { return this.livingAreasField; }
            set { this.livingAreasField = value; }
        }

        /// <remarks/>
        public heating heating
        {
            get { return this.heatingField; }
            set { this.heatingField = value; }
        }

        /// <remarks/>
        public hotWaterService hotWaterService
        {
            get { return this.hotWaterServiceField; }
            set { this.hotWaterServiceField = value; }
        }

        /// <remarks/>
        public string insideSpa
        {
            get { return this.insideSpaField; }
            set { this.insideSpaField = value; }
        }

        /// <remarks/>
        public string outsideSpa
        {
            get { return this.outsideSpaField; }
            set { this.outsideSpaField = value; }
        }

        /// <remarks/>
        public string broadband
        {
            get { return this.broadbandField; }
            set { this.broadbandField = value; }
        }

        /// <remarks/>
        public string builtInRobes
        {
            get { return this.builtInRobesField; }
            set { this.builtInRobesField = value; }
        }

        /// <remarks/>
        public string dishwasher
        {
            get { return this.dishwasherField; }
            set { this.dishwasherField = value; }
        }

        /// <remarks/>
        public string ductedCooling
        {
            get { return this.ductedCoolingField; }
            set { this.ductedCoolingField = value; }
        }

        /// <remarks/>
        public string ductedHeating
        {
            get { return this.ductedHeatingField; }
            set { this.ductedHeatingField = value; }
        }

        /// <remarks/>
        public string evaporativeCooling
        {
            get { return this.evaporativeCoolingField; }
            set { this.evaporativeCoolingField = value; }
        }

        /// <remarks/>
        public string floorboards
        {
            get { return this.floorboardsField; }
            set { this.floorboardsField = value; }
        }

        /// <remarks/>
        public string gasHeating
        {
            get { return this.gasHeatingField; }
            set { this.gasHeatingField = value; }
        }

        /// <remarks/>
        public string gym
        {
            get { return this.gymField; }
            set { this.gymField = value; }
        }

        /// <remarks/>
        public string hydronicHeating
        {
            get { return this.hydronicHeatingField; }
            set { this.hydronicHeatingField = value; }
        }

        /// <remarks/>
        public string payTV
        {
            get { return this.payTVField; }
            set { this.payTVField = value; }
        }

        /// <remarks/>
        public string reverseCycleAirCon
        {
            get { return this.reverseCycleAirConField; }
            set { this.reverseCycleAirConField = value; }
        }

        /// <remarks/>
        public string rumpusRoom
        {
            get { return this.rumpusRoomField; }
            set { this.rumpusRoomField = value; }
        }

        /// <remarks/>
        public string splitSystemAirCon
        {
            get { return this.splitSystemAirConField; }
            set { this.splitSystemAirConField = value; }
        }

        /// <remarks/>
        public string splitSystemHeating
        {
            get { return this.splitSystemHeatingField; }
            set { this.splitSystemHeatingField = value; }
        }

        /// <remarks/>
        public string study
        {
            get { return this.studyField; }
            set { this.studyField = value; }
        }

        /// <remarks/>
        public string workshop
        {
            get { return this.workshopField; }
            set { this.workshopField = value; }
        }

        /// <remarks/>
        public string otherFeatures
        {
            get { return this.otherFeaturesField; }
            set { this.otherFeaturesField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class pool
    {

        private poolType typeField;

        private string valueField;

        public pool()
        {
            this.typeField = poolType.inground;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(poolType.inground)]
        public poolType type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum poolType
    {

        /// <remarks/>
        inground,

        /// <remarks/>
        aboveground,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class spa
    {

        private spaType typeField;

        private string valueField;

        public spa()
        {
            this.typeField = spaType.inground;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(spaType.inground)]
        public spaType type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum spaType
    {

        /// <remarks/>
        inground,

        /// <remarks/>
        aboveground,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class heating
    {

        private heatingType typeField;

        public heating()
        {
            this.typeField = heatingType.other;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(heatingType.other)]
        public heatingType type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum heatingType
    {

        /// <remarks/>
        gas,

        /// <remarks/>
        electric,

        /// <remarks/>
        GDH,

        /// <remarks/>
        solid,

        /// <remarks/>
        other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class hotWaterService
    {

        private hotWaterServiceType typeField;

        /// <remarks/>
        [XmlAttribute()]
        public hotWaterServiceType type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum hotWaterServiceType
    {

        /// <remarks/>
        gas,

        /// <remarks/>
        electric,

        /// <remarks/>
        solar,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class availabilityLink
    {

        private string hrefField;

        /// <remarks/>
        [XmlAttribute()]
        public string href
        {
            get { return this.hrefField; }
            set { this.hrefField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum holidayRentalStatus
    {

        /// <remarks/>
        current,

        /// <remarks/>
        withdrawn,

        /// <remarks/>
        offmarket,

        /// <remarks/>
        leased,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class land 
    {

        private string agentIDField;

        private authority authorityField;

        private underOffer underOfferField;

        private listingAgent[] listingAgentField;

        private price priceField;

        private string priceViewField;

        private address addressField;

        private string municipalityField;

        private estate estateField;

        private streetDirectory streetDirectoryField;

        private landCategory landCategoryField;

        private string headlineField;

        private string descriptionField;

        private features featuresField;

        private soldDetails soldDetailsField;

        private landDetails landDetailsField;

        private auction auctionField;

        private vendorDetails[] vendorDetailsField;

        private externalLink[] externalLinkField;

        private videoLink videoLinkField;

        private extraFields extraFieldsField;

        private img[] imagesField;

        private views viewsField;

        private object[] objectsField;

        private string modTimeField;

        private landStatus statusField;

        /// <remarks/>
        public string agentID
        {
            get { return this.agentIDField; }
            set { this.agentIDField = value; }
        }

        /// <remarks/>
        public authority authority
        {
            get { return this.authorityField; }
            set { this.authorityField = value; }
        }

        /// <remarks/>
        public underOffer underOffer
        {
            get { return this.underOfferField; }
            set { this.underOfferField = value; }
        }

        /// <remarks/>
        [XmlElement("listingAgent")]
        public listingAgent[] listingAgent
        {
            get { return this.listingAgentField; }
            set { this.listingAgentField = value; }
        }

        /// <remarks/>
        public price price
        {
            get { return this.priceField; }
            set { this.priceField = value; }
        }

        /// <remarks/>
        public string priceView
        {
            get { return this.priceViewField; }
            set { this.priceViewField = value; }
        }

        /// <remarks/>
        public address address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        /// <remarks/>
        public string municipality
        {
            get { return this.municipalityField; }
            set { this.municipalityField = value; }
        }

        /// <remarks/>
        public estate estate
        {
            get { return this.estateField; }
            set { this.estateField = value; }
        }

        /// <remarks/>
        public streetDirectory streetDirectory
        {
            get { return this.streetDirectoryField; }
            set { this.streetDirectoryField = value; }
        }

        /// <remarks/>
        public landCategory landCategory
        {
            get { return this.landCategoryField; }
            set { this.landCategoryField = value; }
        }

        /// <remarks/>
        public string headline
        {
            get { return this.headlineField; }
            set { this.headlineField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public features features
        {
            get { return this.featuresField; }
            set { this.featuresField = value; }
        }

        /// <remarks/>
        public soldDetails soldDetails
        {
            get { return this.soldDetailsField; }
            set { this.soldDetailsField = value; }
        }

        /// <remarks/>
        public landDetails landDetails
        {
            get { return this.landDetailsField; }
            set { this.landDetailsField = value; }
        }

        /// <remarks/>
        public auction auction
        {
            get { return this.auctionField; }
            set { this.auctionField = value; }
        }

        /// <remarks/>
        [XmlElement("vendorDetails")]
        public vendorDetails[] vendorDetails
        {
            get { return this.vendorDetailsField; }
            set { this.vendorDetailsField = value; }
        }

        /// <remarks/>
        [XmlElement("externalLink")]
        public externalLink[] externalLink
        {
            get { return this.externalLinkField; }
            set { this.externalLinkField = value; }
        }

        /// <remarks/>
        public videoLink videoLink
        {
            get { return this.videoLinkField; }
            set { this.videoLinkField = value; }
        }

        /// <remarks/>
        public extraFields extraFields
        {
            get { return this.extraFieldsField; }
            set { this.extraFieldsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("img", IsNullable = false)]
        public img[] images
        {
            get { return this.imagesField; }
            set { this.imagesField = value; }
        }

        /// <remarks/>
        public views views
        {
            get { return this.viewsField; }
            set { this.viewsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("document", typeof(document), IsNullable = false)]
        [XmlArrayItem("floorplan", typeof(floorplan), IsNullable = false)]
        [XmlArrayItem("img", typeof(img), IsNullable = false)]
        public object[] objects
        {
            get { return this.objectsField; }
            set { this.objectsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public landStatus status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class landCategory
    {

        private landCategoryName nameField;

        public landCategory()
        {
            this.nameField = landCategoryName.Residential;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(landCategoryName.Residential)]
        public landCategoryName name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum landCategoryName
    {

        /// <remarks/>
        Commercial,

        /// <remarks/>
        Residential,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class views
    {

        private string cityField;

        private string waterField;

        private string valleyField;

        private string mountainField;

        private string oceanField;

        /// <remarks/>
        public string city
        {
            get { return this.cityField; }
            set { this.cityField = value; }
        }

        /// <remarks/>
        public string water
        {
            get { return this.waterField; }
            set { this.waterField = value; }
        }

        /// <remarks/>
        public string valley
        {
            get { return this.valleyField; }
            set { this.valleyField = value; }
        }

        /// <remarks/>
        public string mountain
        {
            get { return this.mountainField; }
            set { this.mountainField = value; }
        }

        /// <remarks/>
        public string ocean
        {
            get { return this.oceanField; }
            set { this.oceanField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum landStatus
    {

        /// <remarks/>
        current,

        /// <remarks/>
        withdrawn,

        /// <remarks/>
        offmarket,

        /// <remarks/>
        sold,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class rental 
    {

        private string agentIDField;

        private listingAgent[] listingAgentField;

        private string dateAvailableField;

        private rent[] rentField;

        private string priceViewField;

        private string bondField;

        private address addressField;

        private string municipalityField;

        private streetDirectory streetDirectoryField;

        private category categoryField;

        private string headlineField;

        private string descriptionField;

        private features featuresField;

        private holiday holidayField;

        private landDetails landDetailsField;

        private string newConstructionField;

        private buildingDetails buildingDetailsField;

        private string[] inspectionTimesField;

        private externalLink[] externalLinkField;

        private videoLink videoLinkField;

        private extraFields extraFieldsField;

        private img[] imagesField;

        private object[] objectsField;

        private ecoFriendly ecoFriendlyField;

        private views viewsField;

        private allowances allowancesField;

        private string modTimeField;

        private rentalStatus statusField;

        /// <remarks/>
        public string agentID
        {
            get { return this.agentIDField; }
            set { this.agentIDField = value; }
        }

        /// <remarks/>
        [XmlElement("listingAgent")]
        public listingAgent[] listingAgent
        {
            get { return this.listingAgentField; }
            set { this.listingAgentField = value; }
        }

        /// <remarks/>
        public string dateAvailable
        {
            get { return this.dateAvailableField; }
            set { this.dateAvailableField = value; }
        }

        /// <remarks/>
        [XmlElement("rent")]
        public rent[] rent
        {
            get { return this.rentField; }
            set { this.rentField = value; }
        }

        /// <remarks/>
        public string priceView
        {
            get { return this.priceViewField; }
            set { this.priceViewField = value; }
        }

        /// <remarks/>
        public string bond
        {
            get { return this.bondField; }
            set { this.bondField = value; }
        }

        /// <remarks/>
        public address address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        /// <remarks/>
        public string municipality
        {
            get { return this.municipalityField; }
            set { this.municipalityField = value; }
        }

        /// <remarks/>
        public streetDirectory streetDirectory
        {
            get { return this.streetDirectoryField; }
            set { this.streetDirectoryField = value; }
        }

        /// <remarks/>
        public category category
        {
            get { return this.categoryField; }
            set { this.categoryField = value; }
        }

        /// <remarks/>
        public string headline
        {
            get { return this.headlineField; }
            set { this.headlineField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public features features
        {
            get { return this.featuresField; }
            set { this.featuresField = value; }
        }

        /// <remarks/>
        public holiday holiday
        {
            get { return this.holidayField; }
            set { this.holidayField = value; }
        }

        /// <remarks/>
        public landDetails landDetails
        {
            get { return this.landDetailsField; }
            set { this.landDetailsField = value; }
        }

        /// <remarks/>
        public string newConstruction
        {
            get { return this.newConstructionField; }
            set { this.newConstructionField = value; }
        }

        /// <remarks/>
        public buildingDetails buildingDetails
        {
            get { return this.buildingDetailsField; }
            set { this.buildingDetailsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("inspection", IsNullable = false)]
        public string[] inspectionTimes
        {
            get { return this.inspectionTimesField; }
            set { this.inspectionTimesField = value; }
        }

        /// <remarks/>
        [XmlElement("externalLink")]
        public externalLink[] externalLink
        {
            get { return this.externalLinkField; }
            set { this.externalLinkField = value; }
        }

        /// <remarks/>
        public videoLink videoLink
        {
            get { return this.videoLinkField; }
            set { this.videoLinkField = value; }
        }

        /// <remarks/>
        public extraFields extraFields
        {
            get { return this.extraFieldsField; }
            set { this.extraFieldsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("img", IsNullable = false)]
        public img[] images
        {
            get
            {
                if (objectsField != null && objectsField.Any(x => x is img))
                {
                    return objectsField.OfType<img>().ToArray();
                }

                return this.imagesField;
            }
            set { this.imagesField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("document", typeof(document), IsNullable = false)]
        [XmlArrayItem("floorplan", typeof(floorplan), IsNullable = false)]
        [XmlArrayItem("img", typeof(img), IsNullable = false)]
        public object[] objects
        {
            get { return this.objectsField; }
            set { this.objectsField = value; }
        }

        /// <remarks/>
        public ecoFriendly ecoFriendly
        {
            get { return this.ecoFriendlyField; }
            set { this.ecoFriendlyField = value; }
        }

        /// <remarks/>
        public views views
        {
            get { return this.viewsField; }
            set { this.viewsField = value; }
        }

        /// <remarks/>
        public allowances allowances
        {
            get { return this.allowancesField; }
            set { this.allowancesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public rentalStatus status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class category
    {

        private categoryName nameField;

        /// <remarks/>
        [XmlAttribute()]
        public categoryName name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum categoryName
    {

        /// <remarks/>
        House,

        /// <remarks/>
        Unit,

        /// <remarks/>
        Townhouse,

        /// <remarks/>
        Villa,

        /// <remarks/>
        Apartment,

        /// <remarks/>
        Flat,

        /// <remarks/>
        Studio,

        /// <remarks/>
        Warehouse,

        /// <remarks/>
        [XmlEnum("DuplexSemi-detached")]
        DuplexSemidetached,

        /// <remarks/>
        Alpine,

        /// <remarks/>
        [XmlEnum("AcreageSemi-rural")]
        AcreageSemirural,

        /// <remarks/>
        Retirement,

        /// <remarks/>
        BlockOfUnits,

        /// <remarks/>
        Terrace,

        /// <remarks/>
        ServicedApartment,

        /// <remarks/>
        Other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class holiday
    {

        private holidayValue valueField;

        public holiday()
        {
            this.valueField = holidayValue.no;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(holidayValue.no)]
        public holidayValue value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum holidayValue
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class ecoFriendly
    {

        private string solarPanelsField;

        private string solarHotWaterField;

        private string waterTankField;

        private string greyWaterSystemField;

        /// <remarks/>
        public string solarPanels
        {
            get { return this.solarPanelsField; }
            set { this.solarPanelsField = value; }
        }

        /// <remarks/>
        public string solarHotWater
        {
            get { return this.solarHotWaterField; }
            set { this.solarHotWaterField = value; }
        }

        /// <remarks/>
        public string waterTank
        {
            get { return this.waterTankField; }
            set { this.waterTankField = value; }
        }

        /// <remarks/>
        public string greyWaterSystem
        {
            get { return this.greyWaterSystemField; }
            set { this.greyWaterSystemField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class allowances
    {

        private string petFriendlyField;

        private string furnishedField;

        private string smokersField;

        /// <remarks/>
        public string petFriendly
        {
            get { return this.petFriendlyField; }
            set { this.petFriendlyField = value; }
        }

        /// <remarks/>
        public string furnished
        {
            get { return this.furnishedField; }
            set { this.furnishedField = value; }
        }

        /// <remarks/>
        public string smokers
        {
            get { return this.smokersField; }
            set { this.smokersField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum rentalStatus
    {

        /// <remarks/>
        current,

        /// <remarks/>
        withdrawn,

        /// <remarks/>
        offmarket,

        /// <remarks/>
        leased,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class residential
    {

        private string agentIDField;

        private authority authorityField;

        private underOffer underOfferField;

        private isHomeLandPackage isHomeLandPackageField;

        private listingAgent[] listingAgentField;

        private price priceField;

        private string priceViewField;

        private address addressField;

        private string municipalityField;

        private streetDirectory streetDirectoryField;

        private category categoryField;

        private string headlineField;

        private string descriptionField;

        private features featuresField;

        private soldDetails soldDetailsField;

        private landDetails landDetailsField;

        private buildingDetails buildingDetailsField;

        private string[] inspectionTimesField;

        private auction auctionField;

        private vendorDetails[] vendorDetailsField;

        private externalLink[] externalLinkField;

        private videoLink videoLinkField;

        private extraFields extraFieldsField;

        private img[] imagesField;

        private string newConstructionField;

        private ecoFriendly ecoFriendlyField;

        private idealFor idealForField;

        private views viewsField;

        private object[] objectsField;

        private string modTimeField;

        private residentialStatus statusField;

        /// <remarks/>
        public string agentID
        {
            get { return this.agentIDField; }
            set { this.agentIDField = value; }
        }

        /// <remarks/>
        public authority authority
        {
            get { return this.authorityField; }
            set { this.authorityField = value; }
        }

        /// <remarks/>
        public underOffer underOffer
        {
            get { return this.underOfferField; }
            set { this.underOfferField = value; }
        }

        /// <remarks/>
        public isHomeLandPackage isHomeLandPackage
        {
            get { return this.isHomeLandPackageField; }
            set { this.isHomeLandPackageField = value; }
        }

        /// <remarks/>
        [XmlElement("listingAgent")]
        public listingAgent[] listingAgent
        {
            get { return this.listingAgentField; }
            set { this.listingAgentField = value; }
        }

        /// <remarks/>
        public price price
        {
            get { return this.priceField; }
            set { this.priceField = value; }
        }

        /// <remarks/>
        public string priceView
        {
            get { return this.priceViewField; }
            set { this.priceViewField = value; }
        }

        /// <remarks/>
        public address address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        /// <remarks/>
        public string municipality
        {
            get { return this.municipalityField; }
            set { this.municipalityField = value; }
        }

        /// <remarks/>
        public streetDirectory streetDirectory
        {
            get { return this.streetDirectoryField; }
            set { this.streetDirectoryField = value; }
        }

        /// <remarks/>
        public category category
        {
            get { return this.categoryField; }
            set { this.categoryField = value; }
        }

        /// <remarks/>
        public string headline
        {
            get { return this.headlineField; }
            set { this.headlineField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public features features
        {
            get { return this.featuresField; }
            set { this.featuresField = value; }
        }

        /// <remarks/>
        public soldDetails soldDetails
        {
            get { return this.soldDetailsField; }
            set { this.soldDetailsField = value; }
        }

        /// <remarks/>
        public landDetails landDetails
        {
            get { return this.landDetailsField; }
            set { this.landDetailsField = value; }
        }

        /// <remarks/>
        public buildingDetails buildingDetails
        {
            get { return this.buildingDetailsField; }
            set { this.buildingDetailsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("inspection", IsNullable = false)]
        public string[] inspectionTimes
        {
            get { return this.inspectionTimesField; }
            set { this.inspectionTimesField = value; }
        }

        /// <remarks/>
        public auction auction
        {
            get { return this.auctionField; }
            set { this.auctionField = value; }
        }

        /// <remarks/>
        [XmlElement("vendorDetails")]
        public vendorDetails[] vendorDetails
        {
            get { return this.vendorDetailsField; }
            set { this.vendorDetailsField = value; }
        }

        /// <remarks/>
        [XmlElement("externalLink")]
        public externalLink[] externalLink
        {
            get { return this.externalLinkField; }
            set { this.externalLinkField = value; }
        }

        /// <remarks/>
        public videoLink videoLink
        {
            get { return this.videoLinkField; }
            set { this.videoLinkField = value; }
        }

        /// <remarks/>
        public extraFields extraFields
        {
            get { return this.extraFieldsField; }
            set { this.extraFieldsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("img", IsNullable = false)]
        public img[] images
        {
            get
            {
                if (objectsField != null && objectsField.Any(x => x is img))
                {
                    return objectsField.OfType<img>().ToArray();
                }

                return this.imagesField;
            }
            set { this.imagesField = value; }
        }

        /// <remarks/>
        public string newConstruction
        {
            get { return this.newConstructionField; }
            set { this.newConstructionField = value; }
        }

        /// <remarks/>
        public ecoFriendly ecoFriendly
        {
            get { return this.ecoFriendlyField; }
            set { this.ecoFriendlyField = value; }
        }

        /// <remarks/>
        public idealFor idealFor
        {
            get { return this.idealForField; }
            set { this.idealForField = value; }
        }

        /// <remarks/>
        public views views
        {
            get { return this.viewsField; }
            set { this.viewsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("document", typeof(document), IsNullable = false)]
        [XmlArrayItem("floorplan", typeof(floorplan), IsNullable = false)]
        [XmlArrayItem("img", typeof(img), IsNullable = false)]
        public object[] objects
        {
            get
            {
                return this.objectsField;
            }
            set { this.objectsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public residentialStatus status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class isHomeLandPackage
    {

        private isHomeLandPackageValue valueField;

        public isHomeLandPackage()
        {
            this.valueField = isHomeLandPackageValue.no;
        }

        /// <remarks/>
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(isHomeLandPackageValue.no)]
        public isHomeLandPackageValue value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum isHomeLandPackageValue
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class idealFor
    {

        private string firstHomeBuyerField;

        private string investorsField;

        private string downsizingField;

        private string couplesField;

        private string studentsField;

        private string lrgFamiliesField;

        private string retireesField;

        /// <remarks/>
        public string firstHomeBuyer
        {
            get { return this.firstHomeBuyerField; }
            set { this.firstHomeBuyerField = value; }
        }

        /// <remarks/>
        public string investors
        {
            get { return this.investorsField; }
            set { this.investorsField = value; }
        }

        /// <remarks/>
        public string downsizing
        {
            get { return this.downsizingField; }
            set { this.downsizingField = value; }
        }

        /// <remarks/>
        public string couples
        {
            get { return this.couplesField; }
            set { this.couplesField = value; }
        }

        /// <remarks/>
        public string students
        {
            get { return this.studentsField; }
            set { this.studentsField = value; }
        }

        /// <remarks/>
        public string lrgFamilies
        {
            get { return this.lrgFamiliesField; }
            set { this.lrgFamiliesField = value; }
        }

        /// <remarks/>
        public string retirees
        {
            get { return this.retireesField; }
            set { this.retireesField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum residentialStatus
    {

        /// <remarks/>
        current,

        /// <remarks/>
        withdrawn,

        /// <remarks/>
        offmarket,

        /// <remarks/>
        sold,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class rural
    {

        private string agentIDField;

        private authority authorityField;

        private underOffer underOfferField;

        private listingAgent[] listingAgentField;

        private price priceField;

        private string priceViewField;

        private address addressField;

        private string municipalityField;

        private streetDirectory streetDirectoryField;

        private ruralCategory ruralCategoryField;

        private string headlineField;

        private string descriptionField;

        private features featuresField;

        private ruralFeatures ruralFeaturesField;

        private soldDetails soldDetailsField;

        private landDetails landDetailsField;

        private buildingDetails buildingDetailsField;

        private string[] inspectionTimesField;

        private auction auctionField;

        private vendorDetails[] vendorDetailsField;

        private externalLink[] externalLinkField;

        private videoLink videoLinkField;

        private extraFields extraFieldsField;

        private img[] imagesField;

        private ecoFriendly ecoFriendlyField;

        private idealFor idealForField;

        private views viewsField;

        private object[] objectsField;

        private string modTimeField;

        private ruralStatus statusField;

        /// <remarks/>
        public string agentID
        {
            get { return this.agentIDField; }
            set { this.agentIDField = value; }
        }

        /// <remarks/>
        public authority authority
        {
            get { return this.authorityField; }
            set { this.authorityField = value; }
        }

        /// <remarks/>
        public underOffer underOffer
        {
            get { return this.underOfferField; }
            set { this.underOfferField = value; }
        }

        /// <remarks/>
        [XmlElement("listingAgent")]
        public listingAgent[] listingAgent
        {
            get { return this.listingAgentField; }
            set { this.listingAgentField = value; }
        }

        /// <remarks/>
        public price price
        {
            get { return this.priceField; }
            set { this.priceField = value; }
        }

        /// <remarks/>
        public string priceView
        {
            get { return this.priceViewField; }
            set { this.priceViewField = value; }
        }

        /// <remarks/>
        public address address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        /// <remarks/>
        public string municipality
        {
            get { return this.municipalityField; }
            set { this.municipalityField = value; }
        }

        /// <remarks/>
        public streetDirectory streetDirectory
        {
            get { return this.streetDirectoryField; }
            set { this.streetDirectoryField = value; }
        }

        /// <remarks/>
        public ruralCategory ruralCategory
        {
            get { return this.ruralCategoryField; }
            set { this.ruralCategoryField = value; }
        }

        /// <remarks/>
        public string headline
        {
            get { return this.headlineField; }
            set { this.headlineField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public features features
        {
            get { return this.featuresField; }
            set { this.featuresField = value; }
        }

        /// <remarks/>
        public ruralFeatures ruralFeatures
        {
            get { return this.ruralFeaturesField; }
            set { this.ruralFeaturesField = value; }
        }

        /// <remarks/>
        public soldDetails soldDetails
        {
            get { return this.soldDetailsField; }
            set { this.soldDetailsField = value; }
        }

        /// <remarks/>
        public landDetails landDetails
        {
            get { return this.landDetailsField; }
            set { this.landDetailsField = value; }
        }

        /// <remarks/>
        public buildingDetails buildingDetails
        {
            get { return this.buildingDetailsField; }
            set { this.buildingDetailsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("inspection", IsNullable = false)]
        public string[] inspectionTimes
        {
            get { return this.inspectionTimesField; }
            set { this.inspectionTimesField = value; }
        }

        /// <remarks/>
        public auction auction
        {
            get { return this.auctionField; }
            set { this.auctionField = value; }
        }

        /// <remarks/>
        [XmlElement("vendorDetails")]
        public vendorDetails[] vendorDetails
        {
            get { return this.vendorDetailsField; }
            set { this.vendorDetailsField = value; }
        }

        /// <remarks/>
        [XmlElement("externalLink")]
        public externalLink[] externalLink
        {
            get { return this.externalLinkField; }
            set { this.externalLinkField = value; }
        }

        /// <remarks/>
        public videoLink videoLink
        {
            get { return this.videoLinkField; }
            set { this.videoLinkField = value; }
        }

        /// <remarks/>
        public extraFields extraFields
        {
            get { return this.extraFieldsField; }
            set { this.extraFieldsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("img", IsNullable = false)]
        public img[] images
        {
            get { return this.imagesField; }
            set { this.imagesField = value; }
        }

        /// <remarks/>
        public ecoFriendly ecoFriendly
        {
            get { return this.ecoFriendlyField; }
            set { this.ecoFriendlyField = value; }
        }

        /// <remarks/>
        public idealFor idealFor
        {
            get { return this.idealForField; }
            set { this.idealForField = value; }
        }

        /// <remarks/>
        public views views
        {
            get { return this.viewsField; }
            set { this.viewsField = value; }
        }

        /// <remarks/>
        [XmlArrayItem("document", typeof(document), IsNullable = false)]
        [XmlArrayItem("floorplan", typeof(floorplan), IsNullable = false)]
        [XmlArrayItem("img", typeof(img), IsNullable = false)]
        public object[] objects
        {
            get { return this.objectsField; }
            set { this.objectsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string modTime
        {
            get { return this.modTimeField; }
            set { this.modTimeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public ruralStatus status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class ruralCategory
    {

        private ruralCategoryName nameField;

        /// <remarks/>
        [XmlAttribute()]
        public ruralCategoryName name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum ruralCategoryName
    {

        /// <remarks/>
        Cropping,

        /// <remarks/>
        Dairy,

        /// <remarks/>
        Farmlet,

        /// <remarks/>
        Horticulture,

        /// <remarks/>
        Livestock,

        /// <remarks/>
        Viticulture,

        /// <remarks/>
        MixedFarming,

        /// <remarks/>
        Lifestyle,

        /// <remarks/>
        Other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class ruralFeatures
    {

        private string fencingField;

        private string annualRainfallField;

        private string soilTypesField;

        private string improvementsField;

        private string councilRatesField;

        private string irrigationField;

        private string carryingCapacityField;

        private string servicesField;

        /// <remarks/>
        public string fencing
        {
            get { return this.fencingField; }
            set { this.fencingField = value; }
        }

        /// <remarks/>
        public string annualRainfall
        {
            get { return this.annualRainfallField; }
            set { this.annualRainfallField = value; }
        }

        /// <remarks/>
        public string soilTypes
        {
            get { return this.soilTypesField; }
            set { this.soilTypesField = value; }
        }

        /// <remarks/>
        public string improvements
        {
            get { return this.improvementsField; }
            set { this.improvementsField = value; }
        }

        /// <remarks/>
        public string councilRates
        {
            get { return this.councilRatesField; }
            set { this.councilRatesField = value; }
        }

        /// <remarks/>
        public string irrigation
        {
            get { return this.irrigationField; }
            set { this.irrigationField = value; }
        }

        /// <remarks/>
        public string carryingCapacity
        {
            get { return this.carryingCapacityField; }
            set { this.carryingCapacityField = value; }
        }

        /// <remarks/>
        public string services
        {
            get { return this.servicesField; }
            set { this.servicesField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [XmlType(AnonymousType = true)]
    public enum ruralStatus
    {

        /// <remarks/>
        current,

        /// <remarks/>
        withdrawn,

        /// <remarks/>
        offmarket,

        /// <remarks/>
        sold,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class miniweb
    {

        private uri[] uriField;

        /// <remarks/>
        [XmlElement("uri")]
        public uri[] uri
        {
            get { return this.uriField; }
            set { this.uriField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class inspectionTimes
    {

        private string[] inspectionField;

        /// <remarks/>
        [XmlElement("inspection")]
        public string[] inspection
        {
            get { return this.inspectionField; }
            set { this.inspectionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class objects
    {

        private object[] itemsField;

        /// <remarks/>
        [XmlElement("document", typeof(document))]
        [XmlElement("floorplan", typeof(floorplan))]
        [XmlElement("img", typeof(img))]
        public object[] Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(IsNullable = false)]
    public partial class images
    {

        private img[] imgField;

        /// <remarks/>
        [XmlElement("img")]
        public img[] img
        {
            get { return this.imgField; }
            set { this.imgField = value; }
        }
    }
}
