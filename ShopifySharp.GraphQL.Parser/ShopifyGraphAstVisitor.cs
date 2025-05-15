using GraphQLParser.AST;
using GraphQLParser.Visitors;

namespace ShopifySharp.GraphQL.Parser;

[Serializable]
public class TypeNameNotFoundException(string scalarName)
    : KeyNotFoundException($"Unable to find type name for scalar \"{scalarName}\".")
{
    public string ScalarName { get; } = scalarName;
}

public class ShopifyGraphAstVisitor: ASTVisitor<WriterContext>
{
    private static readonly Dictionary<string, string> TypeMap = new()
    {
        { "UnsignedInt64", "ulong" },
        { "Money", "decimal" },
        { "Decimal", "decimal" },
        { "Float", "decimal" },
        { "DateTime", "DateTime" }, //GraphQL DateTimes are always UTC
        { "Date", "DateOnly" },
        { "UtcOffset", "TimeSpan" },
        { "URL", "string" },
        { "HTML", "string" },
        { "JSON", "string" },
        { "FormattedString", "string" },
        { "ARN", "string" },
        { "StorefrontID", "string" },
        { "Color", "string" },
        { "BigInt", "long" },
        { "String", "string" },
        { "Boolean", "bool" },
        { "Integer", "int" },
        { "ID", "string" },
    };

    public static string MakePascalCase(GraphQLName name) =>
        char.ToUpper(name.Value.Span[0]) + name.Value.Span[1..].ToString();

    public static string? MapScalarNameToTypeName(string scalarName) =>
        TypeMap.GetValueOrDefault(scalarName);

    public string MapGraphTypeToTypeName(GraphQLType graphType) =>
        graphType switch
        {
            GraphQLNamedType graphQlNamedType => MapScalarNameToTypeName(graphQlNamedType.Name.StringValue) ?? graphQlNamedType.Name.StringValue,
            GraphQLListType graphQlListType => $"[{MapGraphTypeToTypeName(graphQlListType.Type)}]",
            GraphQLNonNullType graphQlNonNullType => MapGraphTypeToTypeName(graphQlNonNullType.Type),
            _ => throw new ArgumentOutOfRangeException(nameof(graphType))
        };

    public async Task WriteJsonPropertyAttributeAsync(GraphQLName propertyName, WriterContext context) =>
        await context.WriteLineAsync($"[System.Text.Json.JsonProperty(\"{propertyName.StringValue}\")]");

    protected override async ValueTask VisitDescriptionAsync(GraphQLDescription description, WriterContext context)
    {
        var segments = new List<string>();
        var span = description.Value.Span;

        // Must split the line before any await call, as spans cannot survive the async/yield boundary and the compiler will throw an error
        foreach (var segment in span.Split(Environment.NewLine))
            segments.Add(span[segment].ToString());

        await context.WriteLineAsync("/// <summary>");

        foreach (var segment in segments)
            await context.WriteLineAsync("/// " + segment);

        await context.WriteLineAsync("/// </summary>");
    }

    protected override async ValueTask VisitArgumentsDefinitionAsync(GraphQLArgumentsDefinition? argumentsDefinition, WriterContext context)
    {
        if (argumentsDefinition is null)
            return;

        foreach (var argument in argumentsDefinition.Items)
        {
            await context.WriteLineAsync("argument name: " + argument.Name);
            await context.WriteLineAsync("argument desc: " + argument.Description?.Value);
            await context.WriteLineAsync("argument default value: " + argument.DefaultValue?.Kind);
            await context.WriteLineAsync("argument is child definition: " + argument.IsChildDefinition);
        }
    }

    protected override async ValueTask VisitInputObjectTypeDefinitionAsync(GraphQLInputObjectTypeDefinition inputObjectTypeDefinition, WriterContext context)
    {
        await VisitAsync(inputObjectTypeDefinition.Comments, context).ConfigureAwait(false);
        await VisitAsync(inputObjectTypeDefinition.Description, context).ConfigureAwait(false);

        await context.WriteLineAsync($"public record {inputObjectTypeDefinition.Name}");
        await context.WriteLineAsync("{");
        context.Indent();

        if (inputObjectTypeDefinition.Directives is not null)
            await VisitDirectivesAsync(inputObjectTypeDefinition.Directives!, context);

        if (inputObjectTypeDefinition.Fields is not null)
            await VisitInputFieldsDefinitionAsync(inputObjectTypeDefinition.Fields, context);

        context.Outdent();
        await context.WriteLineAsync("}");
    }

    protected override async ValueTask VisitInputFieldsDefinitionAsync(GraphQLInputFieldsDefinition? inputFieldsDefinition, WriterContext context)
    {
        if (inputFieldsDefinition is null)
            return;

        for (var i = 0; i < inputFieldsDefinition.Count; i++)
        {
            var isLastItem = i + 1 >= inputFieldsDefinition.Count;
            var inputField = inputFieldsDefinition[i];

            if (inputField.Name.Value.IsEmpty)
                continue;

            var fieldType = MapGraphTypeToTypeName(inputField.Type);

            await VisitAsync(inputField.Description, context).ConfigureAwait(false);

            await WriteJsonPropertyAttributeAsync(inputField.Name, context);
            await context.WriteLineAsync($$"""public {{fieldType}} {{MakePascalCase(inputField.Name)}} { get; set; }""");

            if (!isLastItem)
                await context.WriteEmptyLineAsync();
        }
    }

    protected override async ValueTask VisitEnumTypeDefinitionAsync(GraphQLEnumTypeDefinition enumTypeDefinition, WriterContext context)
    {
        await VisitAsync(enumTypeDefinition.Comments, context).ConfigureAwait(false);
        await VisitAsync(enumTypeDefinition.Description, context).ConfigureAwait(false);

        await context.WriteLineAsync($"public enum {enumTypeDefinition.Name.StringValue}");
        await context.WriteLineAsync("{");
        context.Indent();

        await VisitAsync(enumTypeDefinition.Directives, context).ConfigureAwait(false);
        await VisitAsync(enumTypeDefinition.Values, context).ConfigureAwait(false);

        context.Outdent();
        await context.WriteLineAsync("}");
    }

    protected override async ValueTask VisitEnumValuesDefinitionAsync(GraphQLEnumValuesDefinition enumValuesDefinition, WriterContext context)
    {
        await VisitAsync(enumValuesDefinition.Comments, context).ConfigureAwait(false);

        for (var i = 0; i < enumValuesDefinition.Count; i++)
        {
            var isLastItem = i + 1 >= enumValuesDefinition.Count;
            var enumValueDefinition = enumValuesDefinition.Items[i];

            await VisitAsync(enumValueDefinition.Comments, context).ConfigureAwait(false);
            await VisitAsync(enumValueDefinition.Description, context).ConfigureAwait(false);
            await VisitAsync(enumValueDefinition.Directives, context).ConfigureAwait(false);

            await WriteJsonPropertyAttributeAsync(enumValueDefinition.EnumValue.Name, context);
            await context.WriteLineAsync(enumValueDefinition.EnumValue.Name.StringValue + (isLastItem ? "" : ","));

            if (!isLastItem)
                await context.WriteEmptyLineAsync();
        }
    }

    protected override async ValueTask VisitObjectTypeDefinitionAsync(GraphQLObjectTypeDefinition objectTypeDefinition, WriterContext context)
    {
        await VisitAsync(objectTypeDefinition.Comments, context).ConfigureAwait(false);
        await VisitAsync(objectTypeDefinition.Description, context).ConfigureAwait(false);

        await context.WriteLineAsync("public record " + MakePascalCase(objectTypeDefinition.Name));
        await VisitAsync(objectTypeDefinition.Interfaces, context).ConfigureAwait(false);

        await context.WriteLineAsync("{");
        context.Indent();

        if (objectTypeDefinition.Directives is not null)
            await VisitAsync(objectTypeDefinition.Directives, context).ConfigureAwait(false);

        if (objectTypeDefinition.Fields is not null)
            await VisitAsync(objectTypeDefinition.Fields, context).ConfigureAwait(false);

        context.Outdent();
        await context.WriteLineAsync("}");
    }

    protected override async ValueTask VisitFieldsDefinitionAsync(GraphQLFieldsDefinition fieldsDefinition, WriterContext context)
    {
        await VisitAsync(fieldsDefinition.Comments, context).ConfigureAwait(false);

        // Visitor may change AST while being traversed so foreach yields
        // System.InvalidOperationException: 'Collection was modified; enumeration operation may not execute.'
        for (var i = 0; i < fieldsDefinition.Items.Count; ++i)
        {
            var isLastItem = i + 1 >= fieldsDefinition.Items.Count;

            await VisitAsync(fieldsDefinition.Items[i], context).ConfigureAwait(false);

            if (!isLastItem)
                await context.WriteEmptyLineAsync();
        }
    }

    protected override async ValueTask VisitFieldDefinitionAsync(GraphQLFieldDefinition fieldDefinition, WriterContext context)
    {
        var fieldType = MapGraphTypeToTypeName(fieldDefinition.Type);

        await VisitAsync(fieldDefinition.Comments, context).ConfigureAwait(false);
        await VisitAsync(fieldDefinition.Description, context).ConfigureAwait(false);

        await WriteJsonPropertyAttributeAsync(fieldDefinition.Name, context);
        await context.WriteLineAsync($$"""public {{fieldType}} {{MakePascalCase(fieldDefinition.Name)}} { get; set; }""");

        await VisitAsync(fieldDefinition.Arguments, context).ConfigureAwait(false);
        await VisitAsync(fieldDefinition.Directives, context).ConfigureAwait(false);
    }

    protected override async ValueTask VisitInterfaceTypeDefinitionAsync(GraphQLInterfaceTypeDefinition interfaceTypeDefinition, WriterContext context)
    {
        await VisitAsync(interfaceTypeDefinition.Comments, context).ConfigureAwait(false);
        await VisitAsync(interfaceTypeDefinition.Description, context).ConfigureAwait(false);

        await context.WriteLineAsync("public interface I" + MakePascalCase(interfaceTypeDefinition.Name));
        await VisitAsync(interfaceTypeDefinition.Interfaces, context).ConfigureAwait(false);

        await context.WriteLineAsync("{");
        context.Indent();

        if (interfaceTypeDefinition.Directives is not null)
            await VisitAsync(interfaceTypeDefinition.Directives, context).ConfigureAwait(false);

        if (interfaceTypeDefinition.Fields is not null)
            await VisitAsync(interfaceTypeDefinition.Fields, context).ConfigureAwait(false);

        context.Outdent();
        await context.WriteLineAsync("}");
    }
}
