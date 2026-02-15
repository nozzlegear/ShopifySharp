namespace ShopifySharp.GraphQL.Parser

/// Tracks which types are reachable from operations through type references
type TypeReferenceTracker = Set<string>

module ReachabilityAnalyzer =
    /// Recursively extracts type names from a FieldType
    let rec extractTypeNamesFromFieldType (fieldType: FieldType): string seq =
        match fieldType with
        | ValueType (FieldValueType.GraphObjectType namedType) ->
            seq { namedType.Name }
        | ValueType _ ->
            Seq.empty
        | NullableType innerType ->
            extractTypeNamesFromFieldType innerType
        | NonNullableType innerType ->
            extractTypeNamesFromFieldType innerType
        | CollectionType innerType ->
            extractTypeNamesFromFieldType innerType

    /// Extracts type names from a Field's ValueType and all its arguments
    let extractTypeNamesFromField (field: Field): string seq =
        seq {
            yield! extractTypeNamesFromFieldType field.ValueType
            for arg in field.Arguments do
                yield! extractTypeNamesFromFieldType arg.ValueType
        }

    /// Extracts type names from an Operation's return type and arguments
    let extractTypeNamesFromOperation (operation: Operation): string seq =
        seq {
            // Extract from return type
            match operation.ReturnType with
            | ReturnType.VisitedType visitedType ->
                yield visitedType.Name
            | ReturnType.FieldType fieldType ->
                yield! extractTypeNamesFromFieldType fieldType

            // Extract from arguments
            for arg in operation.Arguments do
                yield! extractTypeNamesFromFieldType arg.ValueType
        }

    /// Extracts type names referenced by a Class
    let extractTypeNamesFromClass (class': Class): string seq =
        seq {
            // Extract from fields
            for field in class'.Fields do
                yield! extractTypeNamesFromField field

            // Extract from inherited types
            for inheritedTypeName in class'.InheritedTypeNames do
                yield inheritedTypeName

            // Extract from known inherited types (Connection/Edge)
            match class'.KnownInheritedType with
            | Some (ClassInheritedType.Connection (ConnectionType.ConnectionWithNodesAndEdges (nodesType, edgesType))) ->
                yield! extractTypeNamesFromFieldType nodesType
                yield! extractTypeNamesFromFieldType edgesType
            | Some (ClassInheritedType.Connection (ConnectionType.ConnectionWithNodes nodesType)) ->
                yield! extractTypeNamesFromFieldType nodesType
            | Some (ClassInheritedType.Connection (ConnectionType.ConnectionWithEdges edgesType)) ->
                yield! extractTypeNamesFromFieldType edgesType
            | Some (ClassInheritedType.Connection ConnectionType.Connection) -> ()
            | Some ClassInheritedType.Edge -> ()
            | None -> ()
        }

    /// Extracts type names referenced by an Interface
    let extractTypeNamesFromInterface (interface': Interface): string seq =
        seq {
            // Extract from fields
            for field in interface'.Fields do
                yield! extractTypeNamesFromField field

            // Extract from inherited types
            for inheritedTypeName in interface'.InheritedTypeNames do
                yield inheritedTypeName
        }

    /// Extracts type names referenced by a UnionType
    let extractTypeNamesFromUnion (unionType: UnionType): string seq =
        seq {
            for case in unionType.Cases do
                yield case.Name
        }

    /// Extracts type names referenced by any VisitedType
    let extractTypeNamesFromVisitedType (visitedType: VisitedTypes): string seq =
        match visitedType with
        | VisitedTypes.Class class' ->
            extractTypeNamesFromClass class'
        | VisitedTypes.Interface interface' ->
            extractTypeNamesFromInterface interface'
        | VisitedTypes.UnionType unionType ->
            extractTypeNamesFromUnion unionType
        | VisitedTypes.Operation operation ->
            extractTypeNamesFromOperation operation
        | VisitedTypes.Enum _ ->
            Seq.empty
        | VisitedTypes.InputObject inputObject ->
            // InputObjects can reference other types in their fields
            seq {
                for field in inputObject.Fields do
                    yield! extractTypeNamesFromField field
            }

    /// Performs reachability analysis starting from a collection of operations
    let analyzeReachabilityFromOperations (operations: seq<Operation>) (parsedContext: IParsedContext): TypeReferenceTracker =

        /// Recursively searches the types referenced by <paramref name="typesToCheckThisPass"/>, finding the types *they* reference.
        let rec expand (currentPass: int) (typesToCheckThisPass: TypeReferenceTracker) (checkedTypes: TypeReferenceTracker): TypeReferenceTracker =
            let checkedTypes: TypeReferenceTracker = Set.unionMany [typesToCheckThisPass; checkedTypes]
            let newlyReferencedTypes =
                seq {
                    // For each referenced type, find the types *they* reference and add them to a plain string list
                    for typeName in typesToCheckThisPass do
                        match parsedContext.TryFindGraphObjectType typeName with
                        | Some visitedType -> yield! extractTypeNamesFromVisitedType visitedType
                        | None -> ()
                }
                |> Set.ofSeq
                // Exclude types already seen to prevent infinite loops from circular references
                |> fun s -> Set.difference s checkedTypes

            if not (Set.isEmpty newlyReferencedTypes) then
                printfn $"Pass {currentPass}: Found {Set.count newlyReferencedTypes} additional reachable types (total: {Set.count newlyReferencedTypes + Set.count checkedTypes})"

                // Expand the check with another pass on the newly discovered types
                expand (currentPass + 1) newlyReferencedTypes checkedTypes
            else
                // No new types were found, we've expanded as far as we can
                checkedTypes

        let operationsArray = Array.ofSeq operations

        printfn $"Analyzing type reachability from {operationsArray.Length} operations..."

        // Initial pass: collect all types that are directly referenced by operations
        let referencedTypes =
            seq {
                for operation in operationsArray do
                    yield! extractTypeNamesFromOperation operation
            }
        let referencedTypes: TypeReferenceTracker = Set.ofSeq referencedTypes

        printfn $"Pass 1: Found {Set.count referencedTypes} types directly referenced by operations"

        // Recursively expand the search into all the types that were found by the initial pass
        let referencedTypes: TypeReferenceTracker = expand 2 referencedTypes Set.empty

        printfn $"Reachability analysis complete: {referencedTypes.Count} reachable types found"
        referencedTypes

    /// Performs a type reachability analysis, starting from all operations in the context
    let analyzeReachability (context: ParserContext): TypeReferenceTracker =
        let parsedContext = context :> IParsedContext

        // Collect all types directly referenced by the operations in the context
        let operations =
            context.GetVisitedTypes()
            |> Array.filter _.IsOperation
            |> Array.choose (function | VisitedTypes.Operation op -> Some op | _ -> None)

        analyzeReachabilityFromOperations operations parsedContext
