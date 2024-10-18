# Primitive Obsession

## Problems
- Non-specific data types (parameters can be swapped - no compiler error -> see Project PrimitiveObsession)
- Invalid values are easily possible

## Solutions
- Value Objects (Project ValueObjectExample)
  - Records -> overhead due to strong typing (Project ValueObjectExample)
  - Structs -> not supported by Entity Framework
  - Library: StrongOf -> same overhead as records (Project StrongOfExample)
    - BUT comparison is possible and most used extension methods are available

## Best Solution with Extension Types
Should be included in C# 14
> At the time, we were aiming for key parts of the feature to be in C# 13, but the design and implementation are going to take more time. Look for Extension Types in early C# 14 (.NET 10) previews. [1]

[1]: https://devblogs.microsoft.com/dotnet/csharp-13-explore-preview-features/#update-on-extension-types
