# sha2-hash
Get the SHA256 hash for the running binary. Secondarily, compare string vs. string builder.

## High-Level Diagnostics Breakdown

### GetSha2HashSb (System.Text.StringBuilder) - Functions

|Name|Total \(Allocations\)|Total Size \(Bytes\)|Self \(Allocations\)|Self Size \(Bytes\)|
|-|-|-|-|-|
| Sha2Hash \(PID: 25456\)|3,440|203,475|19|6,574|
| mscorlib.dll|3,384|196,279|3,384|196,279|
| sha2hash.exe|3,346|180,903|37|622|

### GetSha2HashStr (System.String) - Functions

|Name|Total \(Allocations\)|Total Size \(Bytes\)|Self \(Allocations\)|Self Size \(Bytes\)|
|-|-|-|-|-|
| Sha2Hash \(PID: 27604\)|3,471|206,443|19|6,574|
| mscorlib.dll|3,415|199,259|3,415|199,259|
| sha2hash.exe|3,377|183,871|37|610|

### GetSha2HashSb (System.Text.StringBuilder) - Allocations (Just Diff)

|Type|Allocations|Bytes|
|-|-|-|
| System.String|1,998|123,872|
| System.Char\[\]|55|3,186|
| System.Text.StringBuilder|39|1,092|
| Total|2,092|128,150|

### GetSha2HashStr (System.String) - Allocations (Just Diff)

|Type|Allocations|Bytes|
|-|-|-|
| System.String|2,037|127,256|
| System.Char\[\]|51|2,882|
| System.Text.StringBuilder|35|980|
| Total|2,123|131,118|
