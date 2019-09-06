# Extra UnityEngine

Provides extension methods to extend classes/structs under `UnityEngine` namespace

## Installation

```bash
upm add package dev.upm-packages.extraunityengine
```

## Extension methods

### `UnityWebRequest`

#### `ApplyDownloadHandler`

```csharp
public static UnityWebRequest ApplyDownloadHandler(this UnityWebRequest self, DownloadHandler downloadHandler) {}
```

Set DownloadHandler instance to UnityWebRequest instance via `downloadHandler` property.

#### `ApplyUploadHandler`

```csharp
public static UnityWebRequest ApplyUploadHandler(this UnityWebRequest self, UploadHandler uploadHandler) {}
```

Set DownloadHandler instance to UnityWebRequest instance via `downloadHandler` property.

#### `ApplyRequestBody`

```csharp
public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, string requestBody) {}

public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, IEnumerable<byte> requestBody) {}

public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, byte[] requestBody) {}
```

Set request body to UnityWebRequest instance via `UploadHandlerRaw` class

`requestBody` will convert by `System.Text.Encoding.UTF8.GetBytes()` if passed as `string`

#### `ApplyRequestHeader`

```csharp
public static UnityWebRequest ApplyRequestHeader(this UnityWebRequest self, string name, string value) {}
```

Set request header to UnityWebRequest instance via `SetRequestHeader()` method

#### `ApplyRequestHeaders`

```csharp
public static UnityWebRequest ApplyRequestHeaders(this UnityWebRequest self, IDictionary<string, string> requestHeaders) {}
```

Set request headers to UnityWebRequest instance via `SetRequestHeader()` method
