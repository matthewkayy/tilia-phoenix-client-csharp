/* 
 * tilia Phoenix API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 7.0.6
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TiliaLabs.Phoenix.Client.SwaggerDateConverter;

namespace TiliaLabs.Phoenix.Model
{
    /// <summary>
    /// Flat component
    /// </summary>
    [DataContract]
        public partial class Flat :  IEquatable<Flat>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Flat for value: Flat
            /// </summary>
            [EnumMember(Value = "Flat")]
            Flat = 1,
            /// <summary>
            /// Enum Bound for value: Bound
            /// </summary>
            [EnumMember(Value = "Bound")]
            Bound = 2,
            /// <summary>
            /// Enum Folded for value: Folded
            /// </summary>
            [EnumMember(Value = "Folded")]
            Folded = 3,
            /// <summary>
            /// Enum Tiled for value: Tiled
            /// </summary>
            [EnumMember(Value = "Tiled")]
            Tiled = 4        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Flat" /> class.
        /// </summary>
        /// <param name="dieDesign">dieDesign (required).</param>
        /// <param name="spacing">spacing (required).</param>
        /// <param name="offcut">offcut.</param>
        /// <param name="bundleSize">Bundle size.</param>
        /// <param name="type">type (required).</param>
        /// <param name="total">Total number of copies of this component being produced in the project.</param>
        /// <param name="placed">Total placed count of this component across all layouts in the project.</param>
        /// <param name="fulfilled">Whether order quantity of this component has been fulfilled.</param>
        /// <param name="layouts">layouts.</param>
        /// <param name="overrun">Total number of overruns above ordered quantity.</param>
        public Flat(DieDesign dieDesign = default(DieDesign), Spacing spacing = default(Spacing), Offcut offcut = default(Offcut), int? bundleSize = default(int?), TypeEnum type = default(TypeEnum), int? total = default(int?), int? placed = default(int?), bool? fulfilled = default(bool?), List<BoundsignatureLayouts> layouts = default(List<BoundsignatureLayouts>), int? overrun = default(int?))
        {
            // to ensure "dieDesign" is required (not null)
            if (dieDesign == null)
            {
                throw new InvalidDataException("dieDesign is a required property for Flat and cannot be null");
            }
            else
            {
                this.DieDesign = dieDesign;
            }
            // to ensure "spacing" is required (not null)
            if (spacing == null)
            {
                throw new InvalidDataException("spacing is a required property for Flat and cannot be null");
            }
            else
            {
                this.Spacing = spacing;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Flat and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Offcut = offcut;
            this.BundleSize = bundleSize;
            this.Total = total;
            this.Placed = placed;
            this.Fulfilled = fulfilled;
            this.Layouts = layouts;
            this.Overrun = overrun;
        }
        
        /// <summary>
        /// Unique ID
        /// </summary>
        /// <value>Unique ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets DieDesign
        /// </summary>
        [DataMember(Name="die-design", EmitDefaultValue=false)]
        public DieDesign DieDesign { get; set; }

        /// <summary>
        /// Gets or Sets Spacing
        /// </summary>
        [DataMember(Name="spacing", EmitDefaultValue=false)]
        public Spacing Spacing { get; set; }

        /// <summary>
        /// Gets or Sets Offcut
        /// </summary>
        [DataMember(Name="offcut", EmitDefaultValue=false)]
        public Offcut Offcut { get; set; }

        /// <summary>
        /// Bundle size
        /// </summary>
        /// <value>Bundle size</value>
        [DataMember(Name="bundle-size", EmitDefaultValue=false)]
        public int? BundleSize { get; set; }


        /// <summary>
        /// Total number of copies of this component being produced in the project
        /// </summary>
        /// <value>Total number of copies of this component being produced in the project</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Total placed count of this component across all layouts in the project
        /// </summary>
        /// <value>Total placed count of this component across all layouts in the project</value>
        [DataMember(Name="placed", EmitDefaultValue=false)]
        public int? Placed { get; set; }

        /// <summary>
        /// Whether order quantity of this component has been fulfilled
        /// </summary>
        /// <value>Whether order quantity of this component has been fulfilled</value>
        [DataMember(Name="fulfilled", EmitDefaultValue=false)]
        public bool? Fulfilled { get; set; }

        /// <summary>
        /// Gets or Sets Layouts
        /// </summary>
        [DataMember(Name="layouts", EmitDefaultValue=false)]
        public List<BoundsignatureLayouts> Layouts { get; set; }

        /// <summary>
        /// Total number of overruns above ordered quantity
        /// </summary>
        /// <value>Total number of overruns above ordered quantity</value>
        [DataMember(Name="overrun", EmitDefaultValue=false)]
        public int? Overrun { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flat {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DieDesign: ").Append(DieDesign).Append("\n");
            sb.Append("  Spacing: ").Append(Spacing).Append("\n");
            sb.Append("  Offcut: ").Append(Offcut).Append("\n");
            sb.Append("  BundleSize: ").Append(BundleSize).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Placed: ").Append(Placed).Append("\n");
            sb.Append("  Fulfilled: ").Append(Fulfilled).Append("\n");
            sb.Append("  Layouts: ").Append(Layouts).Append("\n");
            sb.Append("  Overrun: ").Append(Overrun).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Flat);
        }

        /// <summary>
        /// Returns true if Flat instances are equal
        /// </summary>
        /// <param name="input">Instance of Flat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Flat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DieDesign == input.DieDesign ||
                    (this.DieDesign != null &&
                    this.DieDesign.Equals(input.DieDesign))
                ) && 
                (
                    this.Spacing == input.Spacing ||
                    (this.Spacing != null &&
                    this.Spacing.Equals(input.Spacing))
                ) && 
                (
                    this.Offcut == input.Offcut ||
                    (this.Offcut != null &&
                    this.Offcut.Equals(input.Offcut))
                ) && 
                (
                    this.BundleSize == input.BundleSize ||
                    (this.BundleSize != null &&
                    this.BundleSize.Equals(input.BundleSize))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Placed == input.Placed ||
                    (this.Placed != null &&
                    this.Placed.Equals(input.Placed))
                ) && 
                (
                    this.Fulfilled == input.Fulfilled ||
                    (this.Fulfilled != null &&
                    this.Fulfilled.Equals(input.Fulfilled))
                ) && 
                (
                    this.Layouts == input.Layouts ||
                    (this.Layouts != null &&
                    this.Layouts.SequenceEqual(input.Layouts))
                ) && 
                (
                    this.Overrun == input.Overrun ||
                    (this.Overrun != null &&
                    this.Overrun.Equals(input.Overrun))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DieDesign != null)
                    hashCode = hashCode * 59 + this.DieDesign.GetHashCode();
                if (this.Spacing != null)
                    hashCode = hashCode * 59 + this.Spacing.GetHashCode();
                if (this.Offcut != null)
                    hashCode = hashCode * 59 + this.Offcut.GetHashCode();
                if (this.BundleSize != null)
                    hashCode = hashCode * 59 + this.BundleSize.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Placed != null)
                    hashCode = hashCode * 59 + this.Placed.GetHashCode();
                if (this.Fulfilled != null)
                    hashCode = hashCode * 59 + this.Fulfilled.GetHashCode();
                if (this.Layouts != null)
                    hashCode = hashCode * 59 + this.Layouts.GetHashCode();
                if (this.Overrun != null)
                    hashCode = hashCode * 59 + this.Overrun.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
