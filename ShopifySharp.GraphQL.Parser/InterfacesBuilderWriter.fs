namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type InterfacesBuilderWriter(type': VisitedTypes, context: IParsedContext) =
    let tryBindInterfaceToWriter (interfaceRecord: Interface) (fieldName: string) =
        let concreteCaseNames = context.GetInterfaceImplementationTypeNames interfaceRecord.Name
        if Array.length concreteCaseNames > 0 then
            Some (InterfaceCasesBuilderWriter (interfaceRecord, fieldName, concreteCaseNames, interfaceRecord.Deprecation, context))
        else
            None

    let tryBindFieldToInterfaceCasesBuilderWriter (field: Field) =
        match AstNodeMapper.unwrapFieldType field.ValueType with
        | FieldValueType.GraphObjectType (NamedType.Interface interfaceName) ->
            match context.TryFindGraphObjectType interfaceName with
            | Some (Interface interfaceRecord) -> tryBindInterfaceToWriter interfaceRecord field.Name
            | _ -> None
        | _ -> None

    let collectFieldsAndMapToInterfaceCasesBuilderWriters (visitedType: VisitedTypes): InterfaceCasesBuilderWriter array =
        let fields =
            match visitedType with
            | Class class' -> class'.Fields
            | Interface interface' -> interface'.Fields
            | InputObject inputObject -> inputObject.Fields
            | _ -> Array.empty

        fields
        |> Array.choose (fun field -> tryBindFieldToInterfaceCasesBuilderWriter field)

    let wrapWriterToArray writerOption =
        writerOption
        |> Option.map (fun writer -> [| writer |])
        |> Option.defaultValue Array.empty

    let interfaceFieldBuilders =
        match type' with
        | Interface interfaceRecord
        | Operation { ReturnType = ReturnType.VisitedType (Interface interfaceRecord) } ->
            // If the type itself or the operation's return type is an interface, create its
            // cases writer. There is no single backing field (an interface can be returned by
            // many fields), so the interface name is used as the field name.
            tryBindInterfaceToWriter interfaceRecord interfaceRecord.Name
            |> wrapWriterToArray
        | Operation { ReturnType = ReturnType.VisitedType visitedType } ->
            // If the operation returns any visited type which is not an interface, collect its
            // fields and map them to interface case writers where applicable.
            collectFieldsAndMapToInterfaceCasesBuilderWriters visitedType
        | Operation { ReturnType = ReturnType.FieldType fieldType } ->
            // If the operation's return type is a FieldType definition that unwraps to an interface,
            // create its cases writer. There is no single backing field here either, so the
            // interface name is used as the field name.
            match AstNodeMapper.unwrapFieldType fieldType with
            | FieldValueType.GraphObjectType (NamedType.Interface interfaceName) ->
                match context.TryFindGraphObjectType interfaceName with
                | Some (Interface interfaceRecord) -> tryBindInterfaceToWriter interfaceRecord interfaceRecord.Name |> wrapWriterToArray
                | _ -> Array.empty
            | _ ->
                Array.empty
        | visitedType ->
            // For any other visited type, collect its fields and map them to interface case
            // writers where applicable.
            collectFieldsAndMapToInterfaceCasesBuilderWriters visitedType

    static member CanAddInterfacesConcreteCases type' =
        match type' with
        | Class _ -> true
        | Interface _ -> true
        | InputObject _-> false
        | UnionType _-> false
        | Enum _ -> false
        | Operation { ReturnType = ReturnType.FieldType fieldType } ->
            match AstNodeMapper.unwrapFieldType fieldType with
            | FieldValueType.GraphObjectType (NamedType.Interface _) -> true
            | _ -> false
        | Operation { ReturnType = ReturnType.VisitedType visitedType } ->
            InterfacesBuilderWriter.CanAddInterfacesConcreteCases visitedType

    member _.InterfaceFieldBuilders = interfaceFieldBuilders

    member _.WriteToPipewriter writer: ValueTask =
        if not (InterfacesBuilderWriter.CanAddInterfacesConcreteCases type') then
            ValueTask.CompletedTask
        else
            pipeWriter writer {
                for builder in interfaceFieldBuilders do
                    yield! builder.WriteToPipewriter
                    do! NewLine + NewLine
            }
