// Because StrongOf uses generics and Entity Framework (EF) does not support generics, you have to provide a value converter for each type
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace StrongOfExample;

public class UserIdValueConverter : ValueConverter<UserId, Guid>
{
    public UserIdValueConverter(ConverterMappingHints? mappingHints = null)
        : base(id => id.Value, value => new(value), mappingHints)
    { }
}