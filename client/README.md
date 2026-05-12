# Cloudmersive.APIClient.NET.Speech - the C# library for the speechapi

Speech APIs enable you to recognize speech and convert it to text using advanced machine learning, and also to convert text to speech.

This C# SDK is for the [Cloudmersive Speech and Voice Recognition API](https://cloudmersive.com/voice-recognition-and-speech-api):

- API version: v1
- SDK version: 4.1.2
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NET.Speech.Api;
using Cloudmersive.APIClient.NET.Speech.Client;
using Cloudmersive.APIClient.NET.Speech.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NET.Speech.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Speech.Api;
using Cloudmersive.APIClient.NET.Speech.Client;
using Cloudmersive.APIClient.NET.Speech.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var languageCode = languageCode_example;  // string | ISO 639-3 three-letter language code (e.g. eng, spa, fra). Empty for auto-detect. (optional) 
            var recognitionMode = recognitionMode_example;  // string | Recognition mode: Fast, Normal (default), or Advanced. Advanced is only available on Private Cloud and Managed Instance deployments. (optional)  (default to Normal)
            var speechFile = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Recognize audio input as text using Advanced AI with high-accuracy word-level timestamps
                SpeechRecognitionResultAdvanced result = apiInstance.SpeechRecognizeFileAdvancedPost(languageCode, recognitionMode, speechFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.SpeechRecognizeFileAdvancedPost: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*RecognizeApi* | [**SpeechRecognizeFileAdvancedPost**](docs/RecognizeApi.md#speechrecognizefileadvancedpost) | **POST** /speech/recognize/file/advanced | Recognize audio input as text using Advanced AI with high-accuracy word-level timestamps
*RecognizeApi* | [**SpeechRecognizeFilePost**](docs/RecognizeApi.md#speechrecognizefilepost) | **POST** /speech/recognize/file | Recognize audio input as text using Advanced AI
*SpeakApi* | [**SpeechSpeakTextVoiceBasicAudioPost**](docs/SpeakApi.md#speechspeaktextvoicebasicaudiopost) | **POST** /speech/speak/text/voice/basic/audio | Generate audio from text using Advanced AI
*TasksBatchJobApi* | [**SpeechBatchJobRecognizeFileAdvancedPost**](docs/TasksBatchJobApi.md#speechbatchjobrecognizefileadvancedpost) | **POST** /speech/batch-job/recognize/file/advanced | Recognize audio input as text using Advanced AI with high-accuracy word-level timestamps as a Batch Job
*TasksBatchJobApi* | [**SpeechBatchJobRecognizeFilePost**](docs/TasksBatchJobApi.md#speechbatchjobrecognizefilepost) | **POST** /speech/batch-job/recognize/file | Recognize audio input as text using Advanced AI as a Batch Job
*TasksBatchJobApi* | [**SpeechBatchJobSpeakTextVoiceBasicAudioPost**](docs/TasksBatchJobApi.md#speechbatchjobspeaktextvoicebasicaudiopost) | **POST** /speech/batch-job/speak/text/voice/basic/audio | Generate audio from text using Advanced AI as a Batch Job
*TasksBatchJobApi* | [**SpeechBatchJobStatusGet**](docs/TasksBatchJobApi.md#speechbatchjobstatusget) | **GET** /speech/batch-job/status | Get the status and result of a Speech Batch Job


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.SpeechBatchJobResult](docs/SpeechBatchJobResult.md)
 - [Model.SpeechBatchJobStatusResult](docs/SpeechBatchJobStatusResult.md)
 - [Model.SpeechRecognitionResult](docs/SpeechRecognitionResult.md)
 - [Model.SpeechRecognitionResultAdvanced](docs/SpeechRecognitionResultAdvanced.md)
 - [Model.TextToSpeechRequest](docs/TextToSpeechRequest.md)
 - [Model.TokenTimestamp](docs/TokenTimestamp.md)
 - [Model.WordTimestamp](docs/WordTimestamp.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

