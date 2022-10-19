# Google.Protobuf.NativeAOT.Samples

In the `NativeAOT` deployment mode of `.NET 7.0`, use the serialization function of `Google.Protobuf`.

## How to publish

Bash:

```bash
allen@MM-Computer:~/repo/Google.Protobuf.NativeAOT.Samples$ ./publish.sh
```

PowerShell:

```powershell
PS D:\repo\Google.Protobuf.NativeAOT.Samples> .\publish.ps1
```

## How to run

Bash:

```bash
allen@MM-Computer:~/repo/Google.Protobuf.NativeAOT.Samples/dist$ ./Google.Protobuf.NativeAOT.ConsoleApp
```

PowerShell:

```powershell
PS D:\repo\Google.Protobuf.NativeAOT.Samples\dist> .\Google.Protobuf.NativeAOT.ConsoleApp.exe
```

Output:
```powershell
{ "id": 1, "firstName": "Allen", "lastName": "Cai", "subject": "\"Google.Protobuf\" run in the NativeAOT", "age": 30, "roles": [ "admin" ], "attributes": { "Debug": "False" }, "enabled": true, "createdTime": "2022-10-19T17:56:38.776526500Z", "amount": 987654340, "height": 180.1 }
Press any key to continue...
```