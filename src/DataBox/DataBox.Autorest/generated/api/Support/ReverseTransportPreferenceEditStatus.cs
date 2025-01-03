// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support
{

    /// <summary>The Editable status for Reverse Transport preferences</summary>
    public partial struct ReverseTransportPreferenceEditStatus :
        System.IEquatable<ReverseTransportPreferenceEditStatus>
    {
        /// <summary>Edit is disabled for Reverse Transport Preferences.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ReverseTransportPreferenceEditStatus Disabled = @"Disabled";

        /// <summary>Reverse Transport Preferences can be edited.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ReverseTransportPreferenceEditStatus Enabled = @"Enabled";

        /// <summary>
        /// Edit is not supported for Reverse Transport Preferences. Either subscription feature is not available or SKU doesn't support
        /// this feature.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ReverseTransportPreferenceEditStatus NotSupported = @"NotSupported";

        /// <summary>
        /// the value for an instance of the <see cref="ReverseTransportPreferenceEditStatus" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ReverseTransportPreferenceEditStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ReverseTransportPreferenceEditStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ReverseTransportPreferenceEditStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ReverseTransportPreferenceEditStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ReverseTransportPreferenceEditStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type ReverseTransportPreferenceEditStatus (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ReverseTransportPreferenceEditStatus && Equals((ReverseTransportPreferenceEditStatus)obj);
        }

        /// <summary>Returns hashCode for enum ReverseTransportPreferenceEditStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="ReverseTransportPreferenceEditStatus"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ReverseTransportPreferenceEditStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ReverseTransportPreferenceEditStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ReverseTransportPreferenceEditStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ReverseTransportPreferenceEditStatus" />.</param>

        public static implicit operator ReverseTransportPreferenceEditStatus(string value)
        {
            return new ReverseTransportPreferenceEditStatus(value);
        }

        /// <summary>Implicit operator to convert ReverseTransportPreferenceEditStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ReverseTransportPreferenceEditStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ReverseTransportPreferenceEditStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ReverseTransportPreferenceEditStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ReverseTransportPreferenceEditStatus e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ReverseTransportPreferenceEditStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ReverseTransportPreferenceEditStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ReverseTransportPreferenceEditStatus e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ReverseTransportPreferenceEditStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}