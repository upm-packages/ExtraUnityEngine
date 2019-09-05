# Extra UnityEngine

Provides extension methods to extend classes/structs under `UnityEngine` namespace

## Installation

```bash
upm add package dev.upm-packages.extraunityengine
```

## Extension methods

### `UnityWebRequest`

#### `ApplyRequestBody`

```csharp
public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, string requestBody)

public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, IEnumerable<byte> requestBody)
```

Set request body to UnityWebRequest instance via `UploadHandlerRaw` class

`requestBody` will convert by `System.Text.Encoding.UTF8.GetBytes()` if passed as `string`

#### `ApplyRequestHeaders`

```csharp
public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, IDictionary<string, string> requestHeaders)
```

Set request headers to UnityWebRequest instance via `SetRequestHeader()` method
