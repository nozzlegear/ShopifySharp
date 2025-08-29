namespace ShopifySharp.GraphQL.Parser

open System.Collections.Generic
open GraphQLParser.Visitors

type Casing
    = Pascal
    | Camel

type Indentation
    = Outdented
    | Indented

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

type FieldArgument =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      ValueType: FieldType }

type Field =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      Arguments: FieldArgument[]
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

type UnionType =
    { Name: string
      XmlSummary: string[]
      Deprecation: string option
      Types: string[] }
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

type UnionRelationship =
    { UnionTypeName: string
      UnionCaseName: string }

type InterfaceRelationship =
    { InterfaceName: string
      ImplementationName: string }

type VisitedTypes =
    | Class of class': Class
    | Interface of interface': Interface
    | Enum of enum': VisitedEnum
    | InputObject of inputObject: InputObject
    | UnionType of unionType: UnionType

[<RequireQualifiedAccess>]
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
    abstract member TypeIsKnownUnionCase: unionCaseName: string -> bool
    abstract member IsNamedType: namedType: NamedType -> bool
    abstract member TryFindUnionRelationship: unionCaseName: string -> UnionRelationship option
    abstract member GetInterfaceImplementationTypeNames: interfaceName: string -> string[]

type ParserContext(casingType, assumeNullability, ct) =
    let visitedTypes: HashSet<VisitedTypes> = HashSet()
    let unionRelationships: HashSet<UnionRelationship> = HashSet()
    let interfaceRelationships: HashSet<InterfaceRelationship> = HashSet()
    let namedTypes: HashSet<NamedType> = HashSet()
    let (~%) comp = ignore comp

    member _.CasingType: Casing = casingType

    member _.CancellationToken = ct

    member _.VisitedTypes with get() = visitedTypes

    member this.GetVisitedTypes () =
        Array.ofSeq visitedTypes

    member this.SetVisitedType (type': VisitedTypes): unit =
        %visitedTypes.Add type'

    member _.AddUnionRelationship unionName unionCaseNames: unit =
        for unionCase in unionCaseNames do
            { UnionTypeName = unionName
              UnionCaseName = unionCase }
            |> unionRelationships.Add
            |> ignore

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

        member ctx.TypeIsKnownUnionCase unionCaseName: bool =
            (ctx :> IParsedContext).TryFindUnionRelationship unionCaseName
            |> Option.isSome

        member _.IsNamedType name: bool =
            namedTypes.Contains name

        member _.TryFindUnionRelationship unionCaseName: UnionRelationship option =
            unionRelationships
            |> Seq.tryFind (fun r -> r.UnionCaseName = unionCaseName)

        member this.GetInterfaceImplementationTypeNames interfaceName =
            interfaceRelationships
            |> Seq.filter (fun x -> x.InterfaceName = interfaceName)
            |> Seq.map _.ImplementationName
            |> Array.ofSeq

    interface IASTVisitorContext with
        member _.CancellationToken = ct
