module ShopifySharp.GraphQL.Parser.Tests.DomainTests

open System.Threading
open Faqt
open Faqt.Operators
open Xunit
open ShopifySharp.GraphQL.Parser

type DomainTests() =

    [<Theory>]
    [<CombinatorialData>]
    member _.``NamedType ToString should return name``(
        [<CombinatorialValues("TestClass", "TestInterface", "TestEnum", "TestInput", "TestUnion")>] typeName: string
    ) =
        // Setup
        let testCases = [
            NamedType.Class typeName
            NamedType.Interface typeName
            NamedType.Enum typeName
            NamedType.InputObject typeName
            NamedType.UnionType typeName
        ]

        for namedType in testCases do
            // Act
            let result = namedType.ToString()

            // Assert
            %result.Should().Be(typeName)

    [<Theory>]
    [<CombinatorialData>]
    member _.``ParserContext.CasingType should return correct casing type``(
        [<CombinatorialValues("pascal", "camel")>] casingType: string
    ) =
        // Setup
        let casing =
            match casingType with
            | "pascal" -> Pascal
            | "camel" -> Camel
            | _ -> failwithf $"Unhandled {nameof casingType} value \"{casingType}\""
        let cancellationToken = CancellationToken.None
        let sut = ParserContext(casing, false, cancellationToken)

        // Act & Assert
        %sut.CasingType.Should().Be(casing)

    [<Theory>]
    [<CombinatorialData>]
    member _.``ParserContext AssumeNullability should return nullability setting``(
        assumeNullability: bool
    ) =
        // Setup
        let cancellationToken = CancellationToken.None
        let sut = ParserContext(Pascal, assumeNullability, cancellationToken)
        let context = sut :> IParsedContext

        // Act & Assert
        %context.AssumeNullability.Should().Be(assumeNullability)

    [<Fact>]
    member _.``ParserContext SetVisitedType should add type to collection``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let sut = ParserContext(Pascal, false, cancellationToken)
        let testClass = VisitedTypes.Class {
            Name = "TestClass"
            XmlSummary = [||]
            Deprecation = None
            Fields = [||]
            KnownInheritedType = None
            InheritedTypeNames = [||]
        }

        // Act
        sut.SetVisitedType(testClass)
        let result = sut.GetVisitedTypes()

        // Assert
        %result.Should().HaveLength(1)
        match result[0] with
        | VisitedTypes.Class c -> %c.Name.Should().Be("TestClass")
        | _ -> failwith "Expected Class type"

    [<Fact>]
    member _.``ParserContext AddUnionRelationship should add relationship``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let sut = ParserContext(Pascal, false, cancellationToken)
        let context = sut :> IParsedContext
        let unionName = "TestUnion"
        let unionCases = [| "Case1"; "Case2" |]

        // Act
        sut.AddUnionRelationship unionName unionCases

        // Assert
        for unionCase in unionCases do
            %context.TypeIsKnownUnionCase(unionCase).Should().BeTrue()

    [<Fact>]
    member _.``ParserContext TryFindUnionRelationship should return relationship when exists``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let sut = ParserContext(Pascal, false, cancellationToken)
        let context = sut :> IParsedContext
        let unionName = "TestUnion"
        let unionCase = "TestCase"

        sut.AddUnionRelationship unionName [| unionCase |]

        // Act
        let result = context.TryFindUnionRelationship unionCase

        // Assert
        %result.Should().BeSome()
        %result.Value.UnionTypeName.Should().Be(unionName)
        %result.Value.UnionCaseName.Should().Be(unionCase)

    [<Fact>]
    member _.``ParserContext TryFindUnionRelationship should return None when not exists``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let sut = ParserContext(Pascal, false, cancellationToken)
        let context = sut :> IParsedContext

        // Act
        let result = context.TryFindUnionRelationship "NonExistentCase"

        // Assert
        %result.Should().BeNone()

    [<Fact>]
    member _.``ParserContext AddNamedType should add type``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let sut = ParserContext(Pascal, false, cancellationToken)
        let context = sut :> IParsedContext
        let namedType = NamedType.Class "TestClass"

        // Act
        sut.AddNamedType namedType

        // Assert
        %context.IsNamedType(namedType).Should().BeTrue()

    [<Fact>]
    member _.``ParserContext IsNamedType should return false when type not added``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let sut = ParserContext(Pascal, false, cancellationToken)
        let context = sut :> IParsedContext
        let namedType = NamedType.Class "TestClass"

        // Act & Assert
        %context.IsNamedType(namedType).Should().BeFalse()

    [<Fact>]
    member _.``ParserContext TypeIsKnownUnionCase should return false when case not added``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let sut = ParserContext(Pascal, false, cancellationToken)
        let context = sut :> IParsedContext

        // Act & Assert
        %context.TypeIsKnownUnionCase("NonExistentCase").Should().BeFalse()
