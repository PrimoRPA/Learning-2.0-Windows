# About
Primo RPA robot uses elements of the package to automate interaction with Primo AI Server intelligent data recognition server by Primo RPA company.

# How to Use
In Primo RPA studio, create a project that will be executed by  Primo RPA robot. Install this package via the ".Dependencies -> Manage Dependencies" menu; the "AI" node with package elements will appear in Elements tree.  

The "Primo AI server" element is a container for all other package elements. This element is used to connect to the server and to authenticate.  
In pure code projects use the element as follows:

```
//app - [Primo.AI.Server.PrimoAIApp] PrimoAIApp application
//server - Server: [String] Server URL
//login - Login: [String] User login
//password - Password: [String] User password
//spassword - Secure password: [SecureString] Secure password
//to - Time-out: [Int32] Server interactions time-out (ms)
Primo.AI.Server.PrimoAIApp app = Primo.AI.Server.PrimoAIApp.Init(wf, server, [to], [login], [spassword], [password]);
```

The "Smart OCR\Create request OCR" element sends a request for document recognition. In response, it receives the request key.  
In pure code projects:

```
//app - [Primo.AI.Server.PrimoAIApp] PrimoAIApp application
//modelType - [String] Model type for document processing
//file - Document: [String] Path to document file
System.Guid txt = app.CreateInference(file, modelType);
```

The "Smart OCR\Get result OCR" element receives the processing result from the server.  
In pure code:

```
//app - [Primo.AI.Server.PrimoAIApp] PrimoAIApp application
//requestKey - [System.Guid] Request key
Primo.AI.Server.Model.InferenceResult txt = app.GetInference(requestKey);
```

The "Smart OCR\Validate document" element validates the recognized data and allows you to correct them.  
It is not used in pure code.

The "NLP\Create request NLP" element sends a request NLP. In response, it receives the request key.  
In pure code projects:

```
//app - [Primo.AI.Server.PrimoAIApp] PrimoAIApp application
//modelType - Routing key: [String] Routing key for request
//prompt - Prompt: [String] Text to be processed
//responseLength - Response length: [Int32] Maximum length of model responses in tokens
//responseSchema - Response keys: [List<String>] Parameters specific to each NLP task
//temperature - Temperature: [Double] The lower the temperature, the less variability in generation
//minP - Min p: [Double] An additional parameter that defines the threshold in the range of token selection (0 is any, 1 is the most likely)
//contextFile - Context: [String] Path to context file (.json)
System.Guid txt = app.CreateRequestNlp(modelType, prompt, responseLength, [responseSchema], [temperature], [minP], [contextFile]);
```

The "NLP\Get result NLP" element receives the result of the request NLP from the server.  
In pure code:

```
//app - [Primo.AI.Server.PrimoAIApp] PrimoAIApp application
//requestKey - [System.Guid] Request key
Primo.AI.Server.Model.NlpResult txt = app.GetRequestNlp(requestKey);
```



# Key Features

- High performance
- Supports .NET Framework 4.6.1+

# Main Types

- Primo.AI.Server.Elements.WFAttachPrimoAIServer
- Primo.AI.Server.Elements.WFPrimoAICreateInference
- Primo.AI.Server.Elements.WFPrimoAIGetInference
- Primo.AI.Server.Elements.WFPrimoAIValidate
- Primo.AI.Server.PrimoAIApp
- Primo.AI.Server.Model.BoundingBox
- Primo.AI.Server.Model.ImageTransforms
- Primo.AI.Server.Model.RectangleItemModel
- Primo.AI.Server.Model.InferenceResult
- Primo.AI.Server.Model.InferenceResultContent
- Primo.AI.Server.Model.InferenceResultFile
- Primo.AI.Server.Model.InferenceResultItem
- Primo.AI.Server.Model.InferenceResultItemRow
- Primo.AI.Server.Model.NlpResult
- Primo.AI.Server.Model.NlpResultContent

# Feedback

 Bug reports and contributions are welcome at [Primo RPA chat](https://t.me/primo_RPA_chat)