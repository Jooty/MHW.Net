# MHW.Net
A C# library to parse the data from https://mhw-db.com

## Supports:
- Decorations
- Charms
- Armor sets
- Armor
- Weapons

All classes are static, so you don't need to instantiate anything.
```cs
using MHW.Net;

// currently only supports gathering by ID.
MHW.GetArmor(30)
```
