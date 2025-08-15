module ShopifySharp.GraphQL.Parser.Tests.WriterTests

open System
open System.IO
open System.Threading
open Faqt
open Faqt.Operators
open Xunit
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.Writer

type WriterTests() =

    let createTestContext casing assumeNullability =
        let cancellationToken = CancellationToken.None
        let context = ParserContext(casing, assumeNullability, cancellationToken)
        
        // Add some test types
        let testClass = VisitedTypes.Class {
            Name = "User"
            XmlSummary = [| "/// <summary>"; "/// A user entity"; "/// </summary>" |]
            Deprecation = None
            Fields = [| 
                { Name = "id"
                  XmlSummary = [| "/// <summary>"; "/// User ID"; "/// </summary>" |]
                  Deprecation = None
                  Arguments = [||]
                  ValueType = ValueType FieldValueType.String }
                { Name = "name"
                  XmlSummary = [||]
                  Deprecation = None
                  Arguments = [||]
                  ValueType = NullableType (ValueType FieldValueType.String) }
            |]
            KnownInheritedType = None
            InheritedTypeNames = [||]
        }
        
        let testEnum: VisitedEnum = {
            Name = "UserStatus"
            XmlSummary = [||]
            Deprecation = None
            Cases = [|
                { Name = "Active"; XmlSummary = [||]; Deprecation = None; Value = None }
                { Name = "Inactive"; XmlSummary = [||]; Deprecation = None; Value = None }
            |]
        }
        
        context.SetVisitedType(testClass)
        context.SetVisitedType(VisitedTypes.Enum testEnum)
        context

    [<Fact>]
    member _.``writeVisitedTypesToFileSystem should create single file when destination is SingleFile``() =
        // Setup
        let tempFile = Path.GetTempFileName()
        let destination = SingleFile tempFile
        let context = createTestContext Pascal false
        
        try
            // Act
            let task = writeVisitedTypesToFileSystem destination context
            task.GetAwaiter().GetResult()

            // Assert
            %File.Exists(tempFile).Should().BeTrue()
            let content = File.ReadAllText(tempFile)
            %content.Should().NotBeEmpty()
            %content.Should().Contain("record User")
            %content.Should().Contain("enum UserStatus")
        finally
            if File.Exists(tempFile) then File.Delete(tempFile)

    [<Fact>]
    member _.``writeVisitedTypesToFileSystem should create directory when destination is Directory``() =
        // Setup
        let tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString())
        let destination = Directory tempDir
        let context = createTestContext Pascal false
        
        try
            // Act
            let task = writeVisitedTypesToFileSystem destination context
            task.GetAwaiter().GetResult()

            // Assert
            %System.IO.Directory.Exists(tempDir).Should().BeTrue()
            let files = System.IO.Directory.GetFiles(tempDir, "*.cs")
            %files.Should().NotBeEmpty()
            
            let hasUserFile = files |> Array.exists (fun f -> Path.GetFileName(f) = "User.cs")
            let hasUserStatusFile = files |> Array.exists (fun f -> Path.GetFileName(f) = "UserStatus.cs")
            %hasUserFile.Should().BeTrue()
            %hasUserStatusFile.Should().BeTrue()
        finally
            if System.IO.Directory.Exists(tempDir) then 
                System.IO.Directory.Delete(tempDir, true)

    [<Theory>]
    [<CombinatorialData>]
    member _.``writeVisitedTypesToFileSystem should respect casing in generated code``(
        [<CombinatorialValues("pascal", "camel")>] casingType: string
    ) =
        // Setup
        let casing =
            match casingType with
            | "pascal" -> Pascal
            | "camel" -> Camel
            | _ -> failwithf $"Unhandled {nameof casingType} value \"{casingType}\""
        let tempFile = Path.GetTempFileName()
        let destination = SingleFile tempFile
        let context = createTestContext casing false
        
        try
            // Act
            let task = writeVisitedTypesToFileSystem destination context
            task.GetAwaiter().GetResult()

            // Assert
            %File.Exists(tempFile).Should().BeTrue()
            let content = File.ReadAllText(tempFile)
            %content.Should().NotBeEmpty()
            
            match casing with
            | Pascal -> 
                %content.Should().Contain("Id")
                %content.Should().Contain("Name")
            | Camel ->
                %content.Should().Contain("id")
                %content.Should().Contain("name")
        finally
            if File.Exists(tempFile) then File.Delete(tempFile)

    [<Theory>]
    [<CombinatorialData>]
    member _.``writeVisitedTypesToFileSystem should respect nullability assumption``(
        assumeNullability: bool
    ) =
        // Setup
        let tempFile = Path.GetTempFileName()
        let destination = SingleFile tempFile
        let context = createTestContext Pascal assumeNullability
        
        try
            // Act
            let task = writeVisitedTypesToFileSystem destination context
            task.GetAwaiter().GetResult()

            // Assert
            %File.Exists(tempFile).Should().BeTrue()
            let content = File.ReadAllText(tempFile)
            %content.Should().NotBeEmpty()

            if assumeNullability then
                %content.Should().Contain("public string? Id { get; set; } = null;")
            else
                %content.Should().Contain("public string Id { get; set; } = default;")
        finally
            if File.Exists(tempFile) then File.Delete(tempFile)

    [<Fact>]
    member _.``writeVisitedTypesToFileSystem should include XML documentation``() =
        // Setup
        let tempFile = Path.GetTempFileName()
        let destination = SingleFile tempFile
        let context = createTestContext Pascal false
        
        try
            // Act
            let task = writeVisitedTypesToFileSystem destination context
            task.GetAwaiter().GetResult()

            // Assert
            %File.Exists(tempFile).Should().BeTrue()
            let content = File.ReadAllText(tempFile)
            %content.Should().NotBeEmpty()
            %content.Should().Contain("/// <summary>")
            %content.Should().Contain("/// A user entity")
            %content.Should().Contain("/// User ID")
        finally
            if File.Exists(tempFile) then File.Delete(tempFile)

    [<Fact>]
    member _.``writeVisitedTypesToFileSystem should handle empty context``() =
        // Setup
        let tempFile = Path.GetTempFileName()
        let destination = SingleFile tempFile
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        
        try
            // Act
            let task = writeVisitedTypesToFileSystem destination context
            task.GetAwaiter().GetResult()

            // Assert
            %File.Exists(tempFile).Should().BeTrue()
            let content = File.ReadAllText(tempFile)
            // Should have at least basic namespace structure
            %content.Should().NotBeEmpty()
        finally
            if File.Exists(tempFile) then File.Delete(tempFile)

    [<Fact>]
    member _.``writeVisitedTypesToFileSystem should handle DirectoryAndTemporaryFile destination``() =
        // Setup
        let tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString())
        let tempFile = Path.GetTempFileName()
        let destination = DirectoryAndTemporaryFile (tempDir, tempFile)
        let context = createTestContext Pascal false
        
        try
            // Act
            let task = writeVisitedTypesToFileSystem destination context
            task.GetAwaiter().GetResult()

            // Assert
            %System.IO.Directory.Exists(tempDir).Should().BeTrue()
            %File.Exists(tempFile).Should().BeTrue()
            
            let directoryFiles = System.IO.Directory.GetFiles(tempDir, "*.cs")
            %directoryFiles.Should().NotBeEmpty()
            
            let tempFileContent = File.ReadAllText(tempFile)
            %tempFileContent.Should().NotBeEmpty()
        finally
            if System.IO.Directory.Exists(tempDir) then 
                System.IO.Directory.Delete(tempDir, true)
            if File.Exists(tempFile) then File.Delete(tempFile)

    [<Fact>]
    member _.``writeVisitedTypesToFileSystem should create valid C# code``() =
        // Setup
        let tempFile = Path.GetTempFileName()
        let destination = SingleFile tempFile
        let context = createTestContext Pascal false
        
        try
            // Act
            let task = writeVisitedTypesToFileSystem destination context
            task.GetAwaiter().GetResult()

            // Assert
            %File.Exists(tempFile).Should().BeTrue()
            let content = File.ReadAllText(tempFile)
            %content.Should().NotBeEmpty()
            
            // Basic C# syntax checks
            %content.Should().Contain("namespace")
            %content.Should().Contain("public")
            %content.Should().Contain("{")
            %content.Should().Contain("}")
            
            // Should contain proper class and enum declarations
            %content.Should().Contain("public record User")
            %content.Should().Contain("public enum UserStatus")
        finally
            if File.Exists(tempFile) then File.Delete(tempFile)

    [<Fact>]
    member _.``writeVisitedTypesToFileSystem should handle cancelled cancellation token``() =
        // Setup
        let tempFile = Path.GetTempFileName()
        let destination = SingleFile tempFile
        let cancellationTokenSource = new CancellationTokenSource()
        let context = ParserContext(Pascal, false, cancellationTokenSource.Token)
        cancellationTokenSource.Cancel()
        
        try
            // Act & Assert
            let act = fun () ->
                let task = writeVisitedTypesToFileSystem destination context
                task.GetAwaiter().GetResult()

            %act.Should().Throw<OperationCanceledException, _>()
        finally
            if File.Exists(tempFile) then File.Delete(tempFile)
