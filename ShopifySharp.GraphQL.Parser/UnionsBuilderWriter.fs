namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type UnionsBuilderWriter(type': VisitedTypes, context: IParsedContext) =
    let collectUnionFields (visitedType: VisitedTypes): UnionCasesBuilderWriter array =
        let fields =
            match visitedType with
            | Class class' -> class'.Fields
            | Interface interface' -> interface'.Fields
            | InputObject inputObject -> inputObject.Fields
            | UnionType _
            | Operation _ ->
                Array.empty
            | _ ->
                Array.empty

        fields
        |> Array.choose (fun field ->
            match AstNodeMapper.unwrapFieldType field.ValueType with
            | FieldValueType.GraphObjectType (NamedType.UnionType (unionTypeName, unionCaseNames)) ->
                // Look up the actual union type instead of using the parent type
                match context.TryFindGraphObjectType unionTypeName with
                | Some unionType ->
                    Some (UnionCasesBuilderWriter(unionType, field.Name, unionCaseNames, field.Deprecation, context))
                | None ->
                    // Union type must be found - fail if it's not in the context
                    failwith $"Union type '{unionTypeName}' not found in parsed context for field '{field.Name}' in type '{type'.Name}'"
            | _ -> None)

    let unionFieldBuilders =
        match type' with
        | VisitedTypes.Operation operation ->
            match operation.ReturnType with
            | ReturnType.VisitedType visitedType ->
                // If the visited type is an interface, create union builders from its implementations
                match visitedType with
                | VisitedTypes.Interface interfaceRecord ->
                    let implTypeNames = context.GetInterfaceImplementationTypeNames interfaceRecord.Name
                    if Array.length implTypeNames > 0 then
                        [| UnionCasesBuilderWriter(type', interfaceRecord.Name, implTypeNames, None, context)|]
                    else
                        Array.empty
                | _ ->
                    collectUnionFields visitedType
            | ReturnType.FieldType fieldType ->
                match AstNodeMapper.unwrapFieldType fieldType with
                | FieldValueType.GraphObjectType (NamedType.UnionType (unionTypeName, unionCaseNames)) ->
                    [| UnionCasesBuilderWriter(type', unionTypeName, unionCaseNames, operation.Deprecation, context)|]
                | FieldValueType.GraphObjectType (NamedType.Interface interfaceName) ->
                    let implTypeNames = context.GetInterfaceImplementationTypeNames interfaceName
                    if Array.length implTypeNames > 0 then
                        [| UnionCasesBuilderWriter(type', interfaceName, implTypeNames, None, context)|]
                    else
                        Array.empty
                | _ ->
                    Array.empty
        | VisitedTypes.UnionType unionType ->
            // TODO: naming is probably janky here
            [| UnionCasesBuilderWriter(type', unionType.Name, Array.map (fun (x: VisitedTypes) -> x.Name) unionType.Cases, unionType.Deprecation, context)|]
        | visitedType ->
            collectUnionFields visitedType

    static member CanAddUnions type' =
        // TODO: improve this by checking if the type actually has unions available
        match type' with
        | VisitedTypes.Class _ -> true
        | Interface _ -> true
        | InputObject _-> false
        | UnionType _-> true
        | Enum _ -> false
        | Operation operation->
            match operation.ReturnType with
            | ReturnType.FieldType fieldType ->
                match AstNodeMapper.unwrapFieldType fieldType with
                | FieldValueType.GraphObjectType (NamedType.Interface _) -> true
                | _ -> false
            | ReturnType.VisitedType type' -> UnionsBuilderWriter.CanAddUnions type'

    member _.UnionFieldBuilders = unionFieldBuilders

    member _.WriteToPipewriter writer: ValueTask =
        if not (UnionsBuilderWriter.CanAddUnions type') then
            ValueTask.CompletedTask
        else
            pipeWriter writer {
                for builder in unionFieldBuilders do
                    yield! builder.WriteToPipewriter
                    do! NewLine + NewLine
            }
