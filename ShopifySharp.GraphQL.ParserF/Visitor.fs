namespace ShopifySharp.GraphQL.ParserF

open System
open System.Runtime.CompilerServices
open System.Threading.Tasks
open FSharp.Span.Utils.SafeLowLevelOperators
open GraphQLParser.AST
open GraphQLParser.Visitors
open FSharp.Span.Utils

type private FieldsDefinition =
    | InputFields of inputFields: GraphQLInputFieldsDefinition
    | ObjectFields of xFields: GraphQLFieldsDefinition

type Visitor() =
    inherit ASTVisitor<ParserContext>()

    let (~%) job = ignore job

    let removeNewLines (value: char readonlyspan): string =
        let newlineChar = '\n';
        let spanValue = value;
        let hasNewLine = spanValue.Contains(newlineChar)

        if not hasNewLine then
            value.ToString()
        else
            let destination: char span = stackalloc spanValue.Length
            value.Replace(destination, newlineChar, ' ');
            destination.ToString();

    let getDeprecationMessage (directives: GraphQLDirectives | null): string option =
        if isNull directives
        then None
        else directives.Items
             |> Seq.tryFind (fun i -> i.Name.StringValue = "deprecated")
             |> Option.bind (fun deprecation ->
                 deprecation.Arguments.Items
                 |> Seq.tryPick (fun arg ->
                     if arg.Name.StringValue = "reason" && arg.Value.Kind = ASTNodeKind.StringValue
                     then Some (arg.Value :?> GraphQLStringValue)
                     else None
                 )
                 |> Option.map (fun reason -> removeNewLines reason.Value.Span)
             )

    let mapDescriptionToXmlSummary (description: GraphQLDescription): string[] =
        if isNull description then
            Array.empty
        else
            // Split the description on each new line
            let segments = description.Value.Span.ToString().Split([|Environment.NewLine|], StringSplitOptions.RemoveEmptyEntries)

            [|
                yield "/// <summary>"
                for segment in segments do
                    yield $"/// {segment}"
                yield "/// </summary>"
            |]

    let typeMap: Map<string, FieldValueType> = Map.ofList [
        "UnsignedInt64", FieldValueType.ULong
        "Money", FieldValueType.Decimal
        "Decimal", FieldValueType.Decimal
        "Float", FieldValueType.Decimal
        "DateTime", FieldValueType.DateTime // GraphQL DateTimes are always UTC
        "Date", FieldValueType.DateOnly
        "UtcOffset", FieldValueType.TimeSpan
        "URL", FieldValueType.String
        "HTML", FieldValueType.String
        "JSON", FieldValueType.String
        "FormattedString", FieldValueType.String
        "ARN", FieldValueType.String
        "StorefrontID", FieldValueType.String
        "Color", FieldValueType.String
        "BigInt", FieldValueType.Long
        "String", FieldValueType.String
        "Boolean", FieldValueType.Boolean
        "Integer", FieldValueType.Int
        "Int", FieldValueType.Int
        "ID", FieldValueType.String
    ]

    let rec mapGraphTypeToFieldType (fieldType: GraphQLType): FieldType =
        match fieldType with
        | :? GraphQLNamedType as namedType ->
            Map.tryFind namedType.Name.StringValue typeMap
            |> Option.defaultWith (fun _ -> FieldValueType.GraphObjectType namedType.Name.StringValue)
            |> FieldType.ValueType
        | :? GraphQLListType as listType ->
            mapGraphTypeToFieldType listType.Type
            |> FieldType.CollectionType
        | :? GraphQLNonNullType as nonNullType ->
            mapGraphTypeToFieldType nonNullType.Type
            |> FieldType.NonNullableType
        | _ -> raise (SwitchExpressionException fieldType)

    let mapToArguments (argument: GraphQLArgumentsDefinition | null): FieldArgument[] =
        if isNull argument then
            Array.empty
        else
            argument.Items
            |> Array.ofSeq
            |> Array.map (fun argument ->
                { Name = argument.Name.StringValue
                  Deprecation = getDeprecationMessage argument.Directives
                  XmlSummary = mapDescriptionToXmlSummary argument.Description
                  ValueType = mapGraphTypeToFieldType argument.Type })

    let mapToFields (fieldsDefinition: FieldsDefinition): Field[] =
        let createField (fieldType: FieldType) name directives description arguments =
            { Name = name
              XmlSummary = mapDescriptionToXmlSummary description
              Deprecation = getDeprecationMessage directives
              Arguments = arguments
              ValueType = fieldType }
        
        match fieldsDefinition with
        | InputFields inputFields ->
            inputFields.Items
            |> Array.ofSeq
            |> Array.map (fun field ->
                let fieldType = mapGraphTypeToFieldType field.Type
                createField fieldType field.Name.StringValue field.Directives field.Description Array.empty)
        | ObjectFields objectFields ->
            objectFields.Items
            |> Array.ofSeq
            |> Array.map (fun field ->
                let fieldType = mapGraphTypeToFieldType field.Type
                createField fieldType field.Name.StringValue field.Directives field.Description (mapToArguments field.Arguments))

    let strToInterfaceName =
        sprintf "I%s"

    let rec mapToInheritedTypeNames (implementsInterface: GraphQLImplementsInterfaces): string[] =
        if isNull implementsInterface then
            Array.empty
        else
            implementsInterface.Items
            |> Array.ofSeq
            |> Array.map (_.Name.StringValue >> strToInterfaceName)

    let mapToEnumCases (enumValuesDefinition: GraphQLEnumValuesDefinition): VisitedEnumCase[] =
        enumValuesDefinition.Items
        |> Array.ofSeq
        |> Array.map (fun enumCase ->
            { Name = enumCase.Name.StringValue
              XmlSummary = mapDescriptionToXmlSummary enumCase.Description
              Deprecation = getDeprecationMessage enumCase.Directives
              Value = match enumCase.EnumValue.Name.StringValue with
                      | value when String.IsNullOrWhiteSpace value -> None
                      | value when value = enumCase.Name.StringValue -> None
                      | value -> Some value })

    let mapToUnionTypeMemberNames (unionMemberTypes: GraphQLUnionMemberTypes): string[] =
        unionMemberTypes.Items
        |> Array.ofSeq
        |> Array.map _.Name.StringValue

    override this.VisitObjectTypeDefinitionAsync(objectTypeDefinition, context) =
        let generated: Class =
            { Name = objectTypeDefinition.Name.StringValue
              XmlSummary = mapDescriptionToXmlSummary objectTypeDefinition.Description
              Deprecation = getDeprecationMessage objectTypeDefinition.Directives
              Fields = mapToFields (ObjectFields objectTypeDefinition.Fields)
              InheritedTypeNames = mapToInheritedTypeNames objectTypeDefinition.Interfaces }

        // Mark the type as visited
        VisitedTypes.Class generated
        |> context.SetVisitedType

        ValueTask.CompletedTask

    override this.VisitInterfaceTypeDefinitionAsync(interfaceTypeDefinition, context) =
        let generated: Interface =
            { Name = strToInterfaceName interfaceTypeDefinition.Name.StringValue
              XmlSummary = mapDescriptionToXmlSummary interfaceTypeDefinition.Description
              Deprecation = getDeprecationMessage interfaceTypeDefinition.Directives
              Fields = mapToFields (ObjectFields interfaceTypeDefinition.Fields)
              InheritedTypeNames = mapToInheritedTypeNames interfaceTypeDefinition.Interfaces }

        VisitedTypes.Interface generated
        |> context.SetVisitedType

        ValueTask.CompletedTask

    override this.VisitEnumTypeDefinitionAsync(enumTypeDefinition, context) =
        let generated: VisitedEnum =
            { Name = enumTypeDefinition.Name.StringValue
              XmlSummary = mapDescriptionToXmlSummary enumTypeDefinition.Description
              Deprecation = getDeprecationMessage enumTypeDefinition.Directives
              Cases = mapToEnumCases enumTypeDefinition.Values }

        VisitedTypes.Enum generated
        |> context.SetVisitedType

        ValueTask.CompletedTask

    override this.VisitInputObjectTypeDefinitionAsync(inputObjectTypeDefinition, context) =
        let generated: InputObject =
            { Name = inputObjectTypeDefinition.Name.StringValue
              XmlSummary = mapDescriptionToXmlSummary inputObjectTypeDefinition.Description
              Deprecation = getDeprecationMessage inputObjectTypeDefinition.Directives
              Fields = mapToFields (InputFields inputObjectTypeDefinition.Fields) }

        VisitedTypes.InputObject generated
        |> context.SetVisitedType

        ValueTask.CompletedTask

    override this.VisitUnionTypeDefinitionAsync(unionTypeDefinition, context) =
        let generated: UnionType =
            { Name = unionTypeDefinition.Name.StringValue
              XmlSummary = mapDescriptionToXmlSummary unionTypeDefinition.Description
              Deprecation = getDeprecationMessage unionTypeDefinition.Directives
              Types = mapToUnionTypeMemberNames unionTypeDefinition.Types }

        VisitedTypes.UnionType generated
        |> context.SetVisitedType

        ValueTask.CompletedTask
