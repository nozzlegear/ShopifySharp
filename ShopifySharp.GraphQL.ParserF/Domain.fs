namespace ShopifySharp.GraphQL.ParserF

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

type VisitedTypes =
    | Class of class': Class
    | Interface of interface': Interface
    | Enum of enum': VisitedEnum
    | InputObject of inputObject: InputObject
    | UnionType of unionType: UnionType

type ParserContext(casingType, ct) =
    let visitedTypes: HashSet<VisitedTypes> = HashSet()
    let knownUnionCases: HashSet<string> = HashSet()
    let (~%) comp = ignore comp

    member _.CasingType: Casing = casingType
    member _.CancellationToken = ct
    member _.VisitedTypes with get() = visitedTypes

    member this.SetVisitedType (type': VisitedTypes): unit =
        %visitedTypes.Add type'

    member this.GetVisitedTypes () =
        Array.ofSeq visitedTypes

    member _.AddKnownUnionCases unionCaseNames: unit =
        for unionCase in unionCaseNames do
            %knownUnionCases.Add unionCase

    member this.TypeIsKnownUnionCase unionCaseName: bool =
        knownUnionCases.Contains unionCaseName

    interface IASTVisitorContext with
        member _.CancellationToken = ct
