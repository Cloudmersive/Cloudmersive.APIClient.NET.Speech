# Cloudmersive.APIClient.NET.Speech - the C# library for the speechapi

Speech APIs enable you to recognize speech and convert it to text using advanced machine learning, and also to convert text to speech.

This C# SDK is for the [Cloudmersive Speech and Voice Recognition API](https://cloudmersive.com/voice-recognition-and-speech-api):

- API version: v1
- SDK version: 4.0.1
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
            var speechFile = new System.IO.Stream(); // System.IO.Stream | Speech file to perform the operation on.  Common file formats such as WAV, MP3 are supported.

            try
            {
                // Recognize audio input as text using machine learning
                SpeechRecognitionResult result = apiInstance.RecognizeFile(speechFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.RecognizeFile: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*RecognizeApi* | [**RecognizeFile**](docs/RecognizeApi.md#recognizefile) | **POST** /speech/recognize/file | Recognize audio input as text using machine learning
*SpeakApi* | [**SpeakPost**](docs/SpeakApi.md#speakpost) | **POST** /speech/speak/text/basicVoice/{format} | Perform text-to-speech on a string


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.SpeechRecognitionResult](docs/SpeechRecognitionResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

