# Backports

To use C# 8.0/9.0 features in .NET Standard 2.0, some classes need to be backported. These classes will be removed when the target framework for this project changes to .NET 5.0 or later versions.

- IsExternalInit.cs : for C# 9.0 record types.
- NullableAttributes.cs : for C# 8.0 null reference types.(NRT)
- Range.cs : for C# 8.0 Indices and Ranges.