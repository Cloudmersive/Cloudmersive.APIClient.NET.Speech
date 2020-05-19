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
    /// Output of a sentiment analysis operation
    /// </summary>
    [DataContract]
    public partial class SentimentAnalysisResponse :  IEquatable<SentimentAnalysisResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResponse" /> class.
        /// </summary>
        /// <param name="successful">True if the sentiment analysis operation was successful, false otherwise.</param>
        /// <param name="sentimentClassificationResult">Classification of input text into a sentiment classification; possible values are \&quot;Positive\&quot;, \&quot;Negative\&quot; or \&quot;Neutral\&quot;.</param>
        /// <param name="sentimentScoreResult">Sentiment classification score between -1.0 and +1.0 where scores less than 0 are negative sentiment, scores greater than 0 are positive sentiment and scores close to 0 are neutral.  The greater the value deviates from 0.0 the stronger the sentiment, with +1.0 and -1.0 being maximum positive and negative sentiment, respectively..</param>
        /// <param name="sentenceCount">Number of sentences in input text.</param>
        public SentimentAnalysisResponse(bool? successful = default(bool?), string sentimentClassificationResult = default(string), double? sentimentScoreResult = default(double?), int? sentenceCount = default(int?))
        {
            this.Successful = successful;
            this.SentimentClassificationResult = sentimentClassificationResult;
            this.SentimentScoreResult = sentimentScoreResult;
            this.SentenceCount = sentenceCount;
        }
        
        /// <summary>
        /// True if the sentiment analysis operation was successful, false otherwise
        /// </summary>
        /// <value>True if the sentiment analysis operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Classification of input text into a sentiment classification; possible values are \&quot;Positive\&quot;, \&quot;Negative\&quot; or \&quot;Neutral\&quot;
        /// </summary>
        /// <value>Classification of input text into a sentiment classification; possible values are \&quot;Positive\&quot;, \&quot;Negative\&quot; or \&quot;Neutral\&quot;</value>
        [DataMember(Name="SentimentClassificationResult", EmitDefaultValue=false)]
        public string SentimentClassificationResult { get; set; }

        /// <summary>
        /// Sentiment classification score between -1.0 and +1.0 where scores less than 0 are negative sentiment, scores greater than 0 are positive sentiment and scores close to 0 are neutral.  The greater the value deviates from 0.0 the stronger the sentiment, with +1.0 and -1.0 being maximum positive and negative sentiment, respectively.
        /// </summary>
        /// <value>Sentiment classification score between -1.0 and +1.0 where scores less than 0 are negative sentiment, scores greater than 0 are positive sentiment and scores close to 0 are neutral.  The greater the value deviates from 0.0 the stronger the sentiment, with +1.0 and -1.0 being maximum positive and negative sentiment, respectively.</value>
        [DataMember(Name="SentimentScoreResult", EmitDefaultValue=false)]
        public double? SentimentScoreResult { get; set; }

        /// <summary>
        /// Number of sentences in input text
        /// </summary>
        /// <value>Number of sentences in input text</value>
        [DataMember(Name="SentenceCount", EmitDefaultValue=false)]
        public int? SentenceCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SentimentAnalysisResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  SentimentClassificationResult: ").Append(SentimentClassificationResult).Append("\n");
            sb.Append("  SentimentScoreResult: ").Append(SentimentScoreResult).Append("\n");
            sb.Append("  SentenceCount: ").Append(SentenceCount).Append("\n");
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
            return this.Equals(input as SentimentAnalysisResponse);
        }

        /// <summary>
        /// Returns true if SentimentAnalysisResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SentimentAnalysisResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SentimentAnalysisResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.SentimentClassificationResult == input.SentimentClassificationResult ||
                    (this.SentimentClassificationResult != null &&
                    this.SentimentClassificationResult.Equals(input.SentimentClassificationResult))
                ) && 
                (
                    this.SentimentScoreResult == input.SentimentScoreResult ||
                    (this.SentimentScoreResult != null &&
                    this.SentimentScoreResult.Equals(input.SentimentScoreResult))
                ) && 
                (
                    this.SentenceCount == input.SentenceCount ||
                    (this.SentenceCount != null &&
                    this.SentenceCount.Equals(input.SentenceCount))
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.SentimentClassificationResult != null)
                    hashCode = hashCode * 59 + this.SentimentClassificationResult.GetHashCode();
                if (this.SentimentScoreResult != null)
                    hashCode = hashCode * 59 + this.SentimentScoreResult.GetHashCode();
                if (this.SentenceCount != null)
                    hashCode = hashCode * 59 + this.SentenceCount.GetHashCode();
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
