# 海康威视SDK

## 安装

> windows

```ps1
dotnet add package HK.Net.Core
dotnet add package HK.Net.Runtime.Win64 # 32位系统 dotnet add package HK.Net.Runtime.Win32
```

> linux

```shell
dotnet add package HK.Net.Core
dotnet add package HK.Net.Runtime.Linux64 # 32位系统 dotnet add package HK.Net.Runtime.Linux32
```

## 使用

```csharp
using HK.Net.Core;

CHCNetSDK.NET_DVR_Init();

// ...
```

具体应用参考海康官网示例代码 [地址](https://open.hikvision.com/download/5cda567cf47ae80dd41a54b3?type=10)