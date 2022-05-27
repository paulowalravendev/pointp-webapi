namespace PointPWebApi.Shared.Filters;

public class SwaggerSchemaExampleFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        var schemaAttribute = context.MemberInfo?.GetCustomAttributes<SwaggerSchemaExampleAttribute>()
            .FirstOrDefault();
        if (schemaAttribute is null)
            return;
        ApplySchemaAttribute(schema, schemaAttribute);
    }

    private static void ApplySchemaAttribute(OpenApiSchema schema, SwaggerSchemaExampleAttribute schemaAttribute)
    {
        if (schemaAttribute.Example is null && schemaAttribute.ExampleInteger is null)
            return;
        if (schemaAttribute.Type == typeof(int))
            schema.Example = new OpenApiInteger(schemaAttribute.ExampleInteger ?? 0);
        else
            schema.Example = new OpenApiString(schemaAttribute.Example);
    }
}