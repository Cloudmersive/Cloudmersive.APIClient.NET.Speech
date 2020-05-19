/* 
 * nlpapiv2
 *
 * The powerful Natural Language Processing APIs (v2) let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = Cloudmersive.APIClient.NET.NLP.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.NLP.Model
{
    /// <summary>
    /// Input to a profanity analysis operation
    /// </summary>
    [DataContract]
    public partial class ProfanityAnalysisRequest :  IEquatable<ProfanityAnalysisRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfanityAnalysisRequest" /> class.
        /// </summary>
        /// <param name="textToAnalyze">Text to analyze.</param>
        public ProfanityAnalysisRequest(string textToAnalyze = default(string))
        {
            this.TextToAnalyze = textToAnalyze;
        }
        
        /// <summary>
        /// Text to analyze
        /// </summary>
        /// <value>Text to analyze</value>
        [DataMember(Name="TextToAnalyze", EmitDefaultValue=false)]
        public string TextToAnalyze { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfanityAnalysisRequest {\n");
            sb.Append("  TextToAnalyze: ").Append(TextToAnalyze).Append("\n");
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
            return this.Equals(input as ProfanityAnalysisRequest);
        }

        /// <summary>
        /// Returns true if ProfanityAnalysisRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfanityAnalysisRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfanityAnalysisRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TextToAnalyze == input.TextToAnalyze ||
                    (this.TextToAnalyze != null &&
                    this.TextToAnalyze.Equals(input.TextToAnalyze))
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
                if (this.TextToAnalyze != null)
                    hashCode = hashCode * 59 + this.TextToAnalyze.GetHashCode();
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
