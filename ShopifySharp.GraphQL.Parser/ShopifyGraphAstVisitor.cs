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
    };

    public static string? MapScalarNameToTypeName(string scalarName) =>
        TypeMap.GetValueOrDefault(scalarName);

    public string MapGraphTypeToTypeName(GraphQLType graphType) =>
        graphType switch
        {
            GraphQLNamedType graphQlNamedType => MapScalarNameToTypeName(graphQlNamedType.Name.StringValue) ?? graphQlNamedType.Name.StringValue,
            GraphQLListType graphQlListType => $"[{MapGraphTypeToTypeName(graphQlListType.Type)}]",
            GraphQLNonNullType graphQlNonNullType => MapGraphTypeToTypeName(graphQlNonNullType.Type) + "!",
            _ => throw new ArgumentOutOfRangeException(nameof(graphType))
        };

    protected override async ValueTask VisitSchemaDefinitionAsync(GraphQLSchemaDefinition schemaDefinition, WriterContext context)
    {
        await context.WriteLineAsync("would write comments " + (schemaDefinition.Comments?.Count ?? 0));
        await context.WriteLineAsync("would write description " + (schemaDefinition.Description?.Value ?? "[none]"));
        await context.WriteLineAsync("would write directives " + (schemaDefinition.Directives?.Count ?? 0));
        await VisitAsync(schemaDefinition.OperationTypes, context).ConfigureAwait(false);
    }

    protected override async ValueTask VisitRootOperationTypeDefinitionAsync(GraphQLRootOperationTypeDefinition definition, WriterContext context)
    {
        await context.WriteLineAsync("root operation: " + definition.Type?.Name.StringValue);
        await base.VisitRootOperationTypeDefinitionAsync(definition, context);
    }

    protected override ValueTask VisitDirectiveAsync(GraphQLDirective directive, WriterContext context)
    {
        return base.VisitDirectiveAsync(directive, context);
    }

    protected override ValueTask VisitCommentAsync(GraphQLComment comment, WriterContext context)
    {
        return base.VisitCommentAsync(comment, context);
    }

    protected override async ValueTask VisitDescriptionAsync(GraphQLDescription description, WriterContext context)
    {
        await context.WriteLineAsync("/// <summary>");
        await context.WriteLineAsync("/// " + description.Value);
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
            var inputField = inputFieldsDefinition[i];

            if (inputField.Name.Value.IsEmpty)
                continue;

            var fieldType = MapGraphTypeToTypeName(inputField.Type);

            await VisitAsync(inputField.Description, context).ConfigureAwait(false);

            var pascalCasedName = char.ToUpper(inputField.Name.Value.Span[0]) + inputField.Name.Value.Span[1..].ToString();

            await context.WriteLineAsync($"[System.Text.Json.JsonProperty(\"{inputField.Name.Value}\")]");
            await context.WriteLineAsync($$"""public {{fieldType}} {{pascalCasedName}} { get; set; }""");

            if (i + 1 < inputFieldsDefinition.Count)
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
}
