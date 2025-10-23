namespace ShopifySharp.GraphQL.Parser

open System
open System.Runtime.CompilerServices
open GraphQLParser
open GraphQLParser.AST
open FSharp.Span.Utils.SafeLowLevelOperators
open FSharp.Span.Utils

module AstNodeMapper =
    type private Presence
        = Present of fieldType: GraphQLType
        | NotPresent

    type private FieldsDefinition =
        | InputFields of inputFields: GraphQLInputFieldsDefinition
        | ObjectFields of xFields: GraphQLFieldsDefinition

    let rec private mapGraphTypeToName (fieldType: GraphQLType): string =
        match fieldType with
        | :? GraphQLNamedType as namedType ->
            namedType.Name.StringValue
        | :? GraphQLListType as listType ->
            mapGraphTypeToName listType.Type
        | :? GraphQLNonNullType as nonNullType ->
            mapGraphTypeToName nonNullType.Type
        | _ ->
            raise (SwitchExpressionException fieldType)

    let private typeMap: Map<string, FieldValueType> = Map.ofList [
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

    let rec private mapGraphTypeToFieldType (fieldType: GraphQLType): FieldType =
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
        | _ ->
            raise (SwitchExpressionException fieldType)

    let private removeNewLines (value: char readonlyspan): string =
        let newlineChar = '\n';
        let spanValue = value;
        let hasNewLine = spanValue.Contains(newlineChar)

        if not hasNewLine then
            value.ToString()
        else
            let destination: char span = stackalloc spanValue.Length
            value.Replace(destination, newlineChar, ' ');
            destination.ToString();

    let private getDeprecationMessage (directives: GraphQLDirectives | null): string option =
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

    let private mapDescriptionToXmlSummary (description: GraphQLDescription): string[] =
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

    let private mapToArguments (argument: GraphQLArgumentsDefinition | null): FieldOrOperationArgument[] =
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

    let private mapToFields (fieldsDefinition: FieldsDefinition): Field[] =
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

    let private getBestConnectionTypeInterfaceName (fields: GraphQLFieldsDefinition): ConnectionType =
        let check (nodesFieldPresence: Presence, edgesFieldPresence: Presence) (field: GraphQLFieldDefinition) =
            if nodesFieldPresence.IsPresent && edgesFieldPresence.IsPresent
            then nodesFieldPresence, edgesFieldPresence
            else match field.Name.StringValue.ToLowerInvariant() with
                 | "nodes" -> Present field.Type, edgesFieldPresence
                 | "edges" -> nodesFieldPresence, Present field.Type
                 | _ -> nodesFieldPresence, edgesFieldPresence

        let nodeFieldPresence, edgesFieldPresence =
            fields.Items
            |> Seq.fold check (NotPresent, NotPresent)

        match nodeFieldPresence, edgesFieldPresence with
        | Present nodesFieldType, Present edgesFieldType ->
            ConnectionWithNodesAndEdges (mapGraphTypeToFieldType nodesFieldType, mapGraphTypeToFieldType edgesFieldType)
        | Present nodesFieldType, NotPresent ->
            ConnectionWithNodes (mapGraphTypeToFieldType nodesFieldType)
        | NotPresent, Present edgesFieldType ->
            ConnectionWithEdges (mapGraphTypeToFieldType edgesFieldType)
        | NotPresent, NotPresent ->
            ConnectionType.Connection

    let private mapToUnionTypeMemberNames (unionMemberTypes: GraphQLUnionMemberTypes): string[] =
        unionMemberTypes.Items
        |> Array.ofSeq
        |> Array.map _.Name.StringValue

    let private strToInterfaceName =
        sprintf "I%s"

    let rec private mapToInheritedTypeNames (implementsInterface: GraphQLImplementsInterfaces): string[] =
        if isNull implementsInterface then
            Array.empty
        else
            implementsInterface.Items
            |> Array.ofSeq
            |> Array.map (_.Name.StringValue >> strToInterfaceName)

    let mapObjectTypeDefinition (objectTypeDefinition: GraphQLObjectTypeDefinition): Class =
        let objectTypeName = objectTypeDefinition.Name.StringValue

        if objectTypeName = "QueryRoot" || objectTypeName = "Mutation" then
            failwith $"ObjectTypeDefinition must not be QueryRoot or Mutation, but was {objectTypeName}"

        let classInheritedType =
            if objectTypeName.EndsWith("Edge", StringComparison.Ordinal) then
                Some Edge
            else if objectTypeName.EndsWith("Connection", StringComparison.OrdinalIgnoreCase) then
                getBestConnectionTypeInterfaceName objectTypeDefinition.Fields
                |> Connection
                |> Some
            else
               None

        { Name = objectTypeDefinition.Name.StringValue
          XmlSummary = mapDescriptionToXmlSummary objectTypeDefinition.Description
          Deprecation = getDeprecationMessage objectTypeDefinition.Directives
          Fields = mapToFields (ObjectFields objectTypeDefinition.Fields)
          KnownInheritedType = classInheritedType
          InheritedTypeNames = mapToInheritedTypeNames objectTypeDefinition.Interfaces }

    let mapInterfaceTypeDefinition (interfaceTypeDefinition: GraphQLInterfaceTypeDefinition): Interface =
        { Name = strToInterfaceName interfaceTypeDefinition.Name.StringValue
          XmlSummary = mapDescriptionToXmlSummary interfaceTypeDefinition.Description
          Deprecation = getDeprecationMessage interfaceTypeDefinition.Directives
          Fields = mapToFields (ObjectFields interfaceTypeDefinition.Fields)
          InheritedTypeNames = mapToInheritedTypeNames interfaceTypeDefinition.Interfaces }

    let mapEnumCases (enumValuesDefinition: GraphQLEnumValuesDefinition): VisitedEnumCase[] =
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

    let mapEnumTypeDefinition (enumTypeDefinition: GraphQLEnumTypeDefinition): VisitedEnum =
        { Name = enumTypeDefinition.Name.StringValue
          XmlSummary = mapDescriptionToXmlSummary enumTypeDefinition.Description
          Deprecation = getDeprecationMessage enumTypeDefinition.Directives
          Cases = mapEnumCases enumTypeDefinition.Values }

    let mapInputObjectTypeDefinition (inputObjectTypeDefinition: GraphQLInputObjectTypeDefinition): InputObject =
        { Name = inputObjectTypeDefinition.Name.StringValue
          XmlSummary = mapDescriptionToXmlSummary inputObjectTypeDefinition.Description
          Deprecation = getDeprecationMessage inputObjectTypeDefinition.Directives
          Fields = mapToFields (InputFields inputObjectTypeDefinition.Fields) }

    let rec mapUnionTypeDefinition (context: IParsedContext) (unionTypeDefinition: GraphQLUnionTypeDefinition): UnionType =
        let unionCaseNodes = [|
            for unionCaseName in unionTypeDefinition.Types do
                match context.TryFindDocumentNode unionCaseName.Name.Value with
                | None -> failwith $"Could not find union case with name {unionCaseName.Name.StringValue}"
                | Some caseNode -> yield caseNode
        |]

        { Name = unionTypeDefinition.Name.StringValue
          XmlSummary = mapDescriptionToXmlSummary unionTypeDefinition.Description
          Deprecation = getDeprecationMessage unionTypeDefinition.Directives
          Cases = Array.map (map context) unionCaseNodes }

    and map (context: IParsedContext) (node: ASTNode): VisitedTypes =
        match node with
        | :? GraphQLUnionTypeDefinition as unionType -> VisitedTypes.UnionType (mapUnionTypeDefinition context unionType)
        | :? GraphQLInputObjectTypeDefinition as input -> VisitedTypes.InputObject (mapInputObjectTypeDefinition input)
        | :? GraphQLEnumTypeDefinition as enum -> VisitedTypes.Enum (mapEnumTypeDefinition enum)
        | :? GraphQLInterfaceTypeDefinition as interface' -> VisitedTypes.Interface (mapInterfaceTypeDefinition interface')
        | :? GraphQLObjectTypeDefinition as objectType -> VisitedTypes.Class (mapObjectTypeDefinition objectType)
        | _ -> raise (SwitchExpressionException(node.GetType()))

    let mapRootFieldDefinition (fieldDefinition: GraphQLFieldDefinition) (context: IParsedContext): QueryOrMutation =
        let returnTypeName =
            mapGraphTypeToName fieldDefinition.Type
            |> _.ToCharArray()
            |> ROM

        let returnType =
            if typeMap.ContainsKey (returnTypeName.ToString()) then
                mapGraphTypeToFieldType fieldDefinition.Type
                |> ReturnType.FieldType
            else
                let returnType = context.Document.Definitions.Find(function
                    | :? GraphQLInterfaceTypeDefinition as interfaceType -> interfaceType.Name.Value = returnTypeName
                    | :? GraphQLObjectTypeDefinition as objectType -> objectType.Name.Value = returnTypeName
                    | :? GraphQLUnionTypeDefinition as unionType -> unionType.Name.Value = returnTypeName
                    | :? GraphQLEnumTypeDefinition as enumType -> enumType.Name.Value = returnTypeName
                    | :? GraphQLName as graphTypeName -> graphTypeName.Value = returnTypeName
                    | _ -> false)

                if isNull returnType then
                    failwith $"Failed to locate return type {fieldDefinition.Type}"

                map context returnType
                |> ReturnType.VisitedType

        { Name = fieldDefinition.Name.StringValue
          XmlSummary = mapDescriptionToXmlSummary fieldDefinition.Description
          Deprecation = getDeprecationMessage fieldDefinition.Directives
          Arguments = mapToArguments fieldDefinition.Arguments
          ReturnType = returnType }
