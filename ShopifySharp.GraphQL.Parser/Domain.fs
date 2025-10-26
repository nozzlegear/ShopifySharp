﻿namespace ShopifySharp.GraphQL.Parser

open System.Collections.Generic
open GraphQLParser
open GraphQLParser.AST
open GraphQLParser.Visitors

type Casing
    = Pascal
    | Camel

type Indentation
    = Outdented
    | Indented
    | DoubleIndented
    | TripleIndented
    with
    override x.ToString() =
        match x with
        | Outdented -> ""
        | Indented -> "\t"
        | DoubleIndented -> "\t\t"
        | TripleIndented -> "\t\t\t"
    static member (+) (x, str: string) =
        x.ToString() + str
    static member (+) (x: Indentation, y: Indentation) =
        x.ToString() + y.ToString()

type FieldTypeCollectionHandling
    = UnwrapCollection
    | KeepCollection

type FileSystemDestination =
    | SingleFile of filePath: string
    | Directory of directoryPath: string
    | DirectoryAndTemporaryFile of directoryPath: string * temporaryFilePath: string

type GeneratedCsharpFile =
    { FileName: string
      FileText: string }

[<RequireQualifiedAccess>]
type FieldValueType =
    | ULong
    | Long
    | Int
    | Decimal
    | Float
    | Boolean
    | String
    | DateTime
    | DateOnly
    | TimeSpan
    | GraphObjectType of graphObjectTypeName: string

type FieldType =
    | ValueType of valueType: FieldValueType
    | NullableType of valueType: FieldType
    | NonNullableType of valueType: FieldType
    | CollectionType of collectionType: FieldType

type ConnectionType =
    | ConnectionWithNodesAndEdges of nodesType: FieldType * edgesType: FieldType
    | ConnectionWithNodes of nodesType: FieldType
    | ConnectionWithEdges of edgesType: FieldType
    | Connection

type ClassInheritedType =
    | Edge
    | Connection of connectionType: ConnectionType

type IVisitedType =
    interface end

type FieldOrOperationArgument =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      ValueType: FieldType }

type Field =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      Arguments: FieldOrOperationArgument[]
      ValueType: FieldType }

type Interface =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      Fields: Field[]
      InheritedTypeNames: string [] }
    with interface IVisitedType

type Class =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      Fields: Field[]
      KnownInheritedType: ClassInheritedType option
      InheritedTypeNames: string [] }
    with interface IVisitedType

type InputObject =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      Fields: Field[] }
    with interface IVisitedType

type VisitedEnumCase =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      Value: string option }

type VisitedEnum =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      Cases: VisitedEnumCase[] }
    with interface IVisitedType

type InterfaceRelationship =
    { InterfaceName: string
      ImplementationName: string }

type UnionType =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      Cases: VisitedTypes[] }
    with interface IVisitedType
and VisitedTypes =
    | Class of class': Class
    | Interface of interface': Interface
    | Enum of enum': VisitedEnum
    | InputObject of inputObject: InputObject
    | UnionType of unionType: UnionType
    with
    member x.Name =
        match x with
        | VisitedTypes.Class class' -> class'.Name
        | VisitedTypes.Interface interface' -> interface'.Name
        | VisitedTypes.Enum enum' -> enum'.Name
        | VisitedTypes.InputObject inputObject' -> inputObject'.Name
        | VisitedTypes.UnionType unionType' -> unionType'.Name

[<RequireQualifiedAccess>]
type ReturnType =
    | VisitedType of VisitedTypes
    | FieldType of FieldType

type QueryOrMutation =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      Arguments: FieldOrOperationArgument[]
      ReturnType: ReturnType }

type NamedType =
    | Class of name: string
    | Interface of name: string
    | Enum of name: string
    | InputObject of name: string
    | UnionType of name: string
    with override this.ToString (): string =
          match this with
          | Class name -> name
          | Interface name -> name
          | Enum name -> name
          | InputObject name -> name
          | UnionType name -> name

type IParsedContext =
    abstract member CasingType: Casing with get
    abstract member AssumeNullability: bool with get
    abstract member Document: GraphQLDocument with get
    abstract member TypeIsKnownUnionCase: unionCaseName: string -> bool
    abstract member IsNamedType: namedType: NamedType -> bool
    abstract member GetInterfaceImplementationTypeNames: interfaceName: string -> string[]
    abstract member TryFindGraphObjectType: graphObjectTypeName: string -> VisitedTypes option
    abstract member TryFindDocumentNode: name: ROM -> ASTNode option

type ParserContext(casingType, assumeNullability, document, ct) =
    let visitedTypes: HashSet<VisitedTypes> = HashSet()
    let knownUnionCaseNames: HashSet<string> = HashSet()
    let interfaceRelationships: HashSet<InterfaceRelationship> = HashSet()
    let namedTypes: HashSet<NamedType> = HashSet()
    let queryOrMutationTypes: HashSet<QueryOrMutation> = HashSet()
    let (~%) comp = ignore comp

    member _.CasingType: Casing = casingType

    member _.CancellationToken = ct

    member _.VisitedTypes with get() = visitedTypes

    member this.GetVisitedTypes () =
        Array.ofSeq visitedTypes

    member this.SetVisitedType (type': VisitedTypes): unit =
        %visitedTypes.Add type'

    member this.SetQueryOrMutation (type': QueryOrMutation): unit =
        %queryOrMutationTypes.Add type'

    member this.GetQueryOrMutationTypes () =
        Array.ofSeq queryOrMutationTypes

    member _.AddUnionCases (unionCases: VisitedTypes[]) : unit =
        for case in unionCases do
            %knownUnionCaseNames.Add case.Name

    member _.AddInterfaceRelationship implementationName interfaceNames: unit =
        for interfaceName in interfaceNames do
            { InterfaceName = interfaceName
              ImplementationName = implementationName }
            |> interfaceRelationships.Add
            |> ignore

    member _.AddNamedType namedType: unit =
        %namedTypes.Add namedType

    interface IParsedContext with
        member _.CasingType: Casing = casingType

        member _.AssumeNullability: bool = assumeNullability

        member _.Document: GraphQLDocument = document

        member ctx.TypeIsKnownUnionCase unionCaseName: bool =
            knownUnionCaseNames
            |> Seq.exists (fun r -> r = unionCaseName)

        member _.IsNamedType name: bool =
            namedTypes.Contains name

        member _.TryFindGraphObjectType graphObjectTypeName: VisitedTypes option =
            visitedTypes
            |> Seq.tryFind (fun namedType -> string namedType = graphObjectTypeName)

        member this.GetInterfaceImplementationTypeNames interfaceName =
            interfaceRelationships
            |> Seq.filter (fun x -> x.InterfaceName = interfaceName)
            |> Seq.map _.ImplementationName
            |> Array.ofSeq

        member _.TryFindDocumentNode nodeName =
            let item = document.Definitions.Find(fun node ->
                match box node with
                | :? INamedNode as namedNode when namedNode.Name.Value = nodeName -> true
                | _ -> false
            )
            Option.ofObj item

    interface IASTVisitorContext with
        member _.CancellationToken = ct
