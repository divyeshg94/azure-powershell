// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Support.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Extensions;

    /// <summary>Contact information associated with the support ticket.</summary>
    public partial class UpdateContactProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Support.Models.IUpdateContactProfile,
        Microsoft.Azure.PowerShell.Cmdlets.Support.Models.IUpdateContactProfileInternal
    {

        /// <summary>Backing field for <see cref="AdditionalEmailAddress" /> property.</summary>
        private System.Collections.Generic.List<string> _additionalEmailAddress;

        /// <summary>
        /// Email addresses listed will be copied on any correspondence about the support ticket.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AdditionalEmailAddress { get => this._additionalEmailAddress; set => this._additionalEmailAddress = value; }

        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        /// <summary>Country of the user. This is the ISO 3166-1 alpha-3 code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public string Country { get => this._country; set => this._country = value; }

        /// <summary>Backing field for <see cref="FirstName" /> property.</summary>
        private string _firstName;

        /// <summary>First name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public string FirstName { get => this._firstName; set => this._firstName = value; }

        /// <summary>Backing field for <see cref="LastName" /> property.</summary>
        private string _lastName;

        /// <summary>Last name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public string LastName { get => this._lastName; set => this._lastName = value; }

        /// <summary>Backing field for <see cref="PhoneNumber" /> property.</summary>
        private string _phoneNumber;

        /// <summary>Phone number. This is required if preferred contact method is phone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public string PhoneNumber { get => this._phoneNumber; set => this._phoneNumber = value; }

        /// <summary>Backing field for <see cref="PreferredContactMethod" /> property.</summary>
        private string _preferredContactMethod;

        /// <summary>Preferred contact method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public string PreferredContactMethod { get => this._preferredContactMethod; set => this._preferredContactMethod = value; }

        /// <summary>Backing field for <see cref="PreferredSupportLanguage" /> property.</summary>
        private string _preferredSupportLanguage;

        /// <summary>
        /// Preferred language of support from Azure. Support languages vary based on the severity you choose for your support ticket.
        /// Learn more at [Azure Severity and responsiveness](https://azure.microsoft.com/support/plans/response/). Use the standard
        /// language-country code. Valid values are 'en-us' for English, 'zh-hans' for Chinese, 'es-es' for Spanish, 'fr-fr' for French,
        /// 'ja-jp' for Japanese, 'ko-kr' for Korean, 'ru-ru' for Russian, 'pt-br' for Portuguese, 'it-it' for Italian, 'zh-tw' for
        /// Chinese and 'de-de' for German.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public string PreferredSupportLanguage { get => this._preferredSupportLanguage; set => this._preferredSupportLanguage = value; }

        /// <summary>Backing field for <see cref="PreferredTimeZone" /> property.</summary>
        private string _preferredTimeZone;

        /// <summary>
        /// Time zone of the user. This is the name of the time zone from [Microsoft Time Zone Index Values](https://support.microsoft.com/help/973627/microsoft-time-zone-index-values).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public string PreferredTimeZone { get => this._preferredTimeZone; set => this._preferredTimeZone = value; }

        /// <summary>Backing field for <see cref="PrimaryEmailAddress" /> property.</summary>
        private string _primaryEmailAddress;

        /// <summary>Primary email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Origin(Microsoft.Azure.PowerShell.Cmdlets.Support.PropertyOrigin.Owned)]
        public string PrimaryEmailAddress { get => this._primaryEmailAddress; set => this._primaryEmailAddress = value; }

        /// <summary>Creates an new <see cref="UpdateContactProfile" /> instance.</summary>
        public UpdateContactProfile()
        {

        }
    }
    /// Contact information associated with the support ticket.
    public partial interface IUpdateContactProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Email addresses listed will be copied on any correspondence about the support ticket.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Email addresses listed will be copied on any correspondence about the support ticket.",
        SerializedName = @"additionalEmailAddresses",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AdditionalEmailAddress { get; set; }
        /// <summary>Country of the user. This is the ISO 3166-1 alpha-3 code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Country of the user. This is the ISO 3166-1 alpha-3 code.",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string Country { get; set; }
        /// <summary>First name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"First name.",
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        string FirstName { get; set; }
        /// <summary>Last name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Last name.",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        string LastName { get; set; }
        /// <summary>Phone number. This is required if preferred contact method is phone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Phone number. This is required if preferred contact method is phone.",
        SerializedName = @"phoneNumber",
        PossibleTypes = new [] { typeof(string) })]
        string PhoneNumber { get; set; }
        /// <summary>Preferred contact method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Preferred contact method.",
        SerializedName = @"preferredContactMethod",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Support.PSArgumentCompleterAttribute("email", "phone")]
        string PreferredContactMethod { get; set; }
        /// <summary>
        /// Preferred language of support from Azure. Support languages vary based on the severity you choose for your support ticket.
        /// Learn more at [Azure Severity and responsiveness](https://azure.microsoft.com/support/plans/response/). Use the standard
        /// language-country code. Valid values are 'en-us' for English, 'zh-hans' for Chinese, 'es-es' for Spanish, 'fr-fr' for French,
        /// 'ja-jp' for Japanese, 'ko-kr' for Korean, 'ru-ru' for Russian, 'pt-br' for Portuguese, 'it-it' for Italian, 'zh-tw' for
        /// Chinese and 'de-de' for German.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Preferred language of support from Azure. Support languages vary based on the severity you choose for your support ticket. Learn more at [Azure Severity and responsiveness](https://azure.microsoft.com/support/plans/response/). Use the standard language-country code. Valid values are 'en-us' for English, 'zh-hans' for Chinese, 'es-es' for Spanish, 'fr-fr' for French, 'ja-jp' for Japanese, 'ko-kr' for Korean, 'ru-ru' for Russian, 'pt-br' for Portuguese, 'it-it' for Italian, 'zh-tw' for Chinese and 'de-de' for German.",
        SerializedName = @"preferredSupportLanguage",
        PossibleTypes = new [] { typeof(string) })]
        string PreferredSupportLanguage { get; set; }
        /// <summary>
        /// Time zone of the user. This is the name of the time zone from [Microsoft Time Zone Index Values](https://support.microsoft.com/help/973627/microsoft-time-zone-index-values).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Time zone of the user. This is the name of the time zone from [Microsoft Time Zone Index Values](https://support.microsoft.com/help/973627/microsoft-time-zone-index-values).",
        SerializedName = @"preferredTimeZone",
        PossibleTypes = new [] { typeof(string) })]
        string PreferredTimeZone { get; set; }
        /// <summary>Primary email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Support.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Primary email address.",
        SerializedName = @"primaryEmailAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryEmailAddress { get; set; }

    }
    /// Contact information associated with the support ticket.
    internal partial interface IUpdateContactProfileInternal

    {
        /// <summary>
        /// Email addresses listed will be copied on any correspondence about the support ticket.
        /// </summary>
        System.Collections.Generic.List<string> AdditionalEmailAddress { get; set; }
        /// <summary>Country of the user. This is the ISO 3166-1 alpha-3 code.</summary>
        string Country { get; set; }
        /// <summary>First name.</summary>
        string FirstName { get; set; }
        /// <summary>Last name.</summary>
        string LastName { get; set; }
        /// <summary>Phone number. This is required if preferred contact method is phone.</summary>
        string PhoneNumber { get; set; }
        /// <summary>Preferred contact method.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Support.PSArgumentCompleterAttribute("email", "phone")]
        string PreferredContactMethod { get; set; }
        /// <summary>
        /// Preferred language of support from Azure. Support languages vary based on the severity you choose for your support ticket.
        /// Learn more at [Azure Severity and responsiveness](https://azure.microsoft.com/support/plans/response/). Use the standard
        /// language-country code. Valid values are 'en-us' for English, 'zh-hans' for Chinese, 'es-es' for Spanish, 'fr-fr' for French,
        /// 'ja-jp' for Japanese, 'ko-kr' for Korean, 'ru-ru' for Russian, 'pt-br' for Portuguese, 'it-it' for Italian, 'zh-tw' for
        /// Chinese and 'de-de' for German.
        /// </summary>
        string PreferredSupportLanguage { get; set; }
        /// <summary>
        /// Time zone of the user. This is the name of the time zone from [Microsoft Time Zone Index Values](https://support.microsoft.com/help/973627/microsoft-time-zone-index-values).
        /// </summary>
        string PreferredTimeZone { get; set; }
        /// <summary>Primary email address.</summary>
        string PrimaryEmailAddress { get; set; }

    }
}