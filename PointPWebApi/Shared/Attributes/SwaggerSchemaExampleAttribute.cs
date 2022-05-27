namespace PointPWebApi.Shared.Attributes;

[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Struct |
    AttributeTargets.Parameter |
    AttributeTargets.Property |
    AttributeTargets.Enum)]
public class SwaggerSchemaExampleAttribute : Attribute
{
    public string? Example { get; }
    public int? ExampleInteger { get; }
    public Type Type { get; }
    
    public SwaggerSchemaExampleAttribute(string example)
    {
        Example = example;
        Type = typeof(string);
    }
    public SwaggerSchemaExampleAttribute(int example)
    {
        ExampleInteger = example;
        Type = typeof(int);
    }
}