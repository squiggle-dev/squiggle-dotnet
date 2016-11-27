/* 
 * Squiggle API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.0.1
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

namespace Squiggle.Model
{
    /// <summary>
    /// Snippet
    /// </summary>
    [DataContract]
    public partial class Snippet :  IEquatable<Snippet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Snippet" /> class.
        /// </summary>
        /// <param name="ContentHtml">ContentHtml.</param>
        /// <param name="ContentPlaintext">ContentPlaintext.</param>
        /// <param name="Image">Image.</param>
        public Snippet(string ContentHtml = null, string ContentPlaintext = null, FileObject Image = null)
        {
            this.ContentHtml = ContentHtml;
            this.ContentPlaintext = ContentPlaintext;
            this.Image = Image;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// Gets or Sets ContentHtml
        /// </summary>
        [DataMember(Name="content_html", EmitDefaultValue=false)]
        public string ContentHtml { get; set; }
        /// <summary>
        /// Gets or Sets ContentPlaintext
        /// </summary>
        [DataMember(Name="content_plaintext", EmitDefaultValue=false)]
        public string ContentPlaintext { get; set; }
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public FileObject Image { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; private set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Snippet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContentHtml: ").Append(ContentHtml).Append("\n");
            sb.Append("  ContentPlaintext: ").Append(ContentPlaintext).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Snippet);
        }

        /// <summary>
        /// Returns true if Snippet instances are equal
        /// </summary>
        /// <param name="other">Instance of Snippet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Snippet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ContentHtml == other.ContentHtml ||
                    this.ContentHtml != null &&
                    this.ContentHtml.Equals(other.ContentHtml)
                ) && 
                (
                    this.ContentPlaintext == other.ContentPlaintext ||
                    this.ContentPlaintext != null &&
                    this.ContentPlaintext.Equals(other.ContentPlaintext)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ContentHtml != null)
                    hash = hash * 59 + this.ContentHtml.GetHashCode();
                if (this.ContentPlaintext != null)
                    hash = hash * 59 + this.ContentPlaintext.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
