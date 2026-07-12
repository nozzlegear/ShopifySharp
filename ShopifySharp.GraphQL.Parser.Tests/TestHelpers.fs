namespace ShopifySharp.GraphQL.Parser.Tests

open System
open System.IO
open System.Reflection
open System.Threading.Tasks
open System.Text.Json.Serialization
open Microsoft.CodeAnalysis
open Microsoft.CodeAnalysis.CSharp
open ShopifySharp.GraphQL.Parser
open Faqt
open Faqt.Operators

module SchemaCompiler =
    let compileSchemaWithOptions (assumeNullability: bool) (schema: string) : Assembly =
        let typesTempDir = Path.Combine(Path.GetTempPath(), "ShopifySharp_ParserTests_Types_" + Guid.NewGuid().ToString("N"))
        let servicesTempDir = Path.Combine(Path.GetTempPath(), "ShopifySharp_ParserTests_Services_" + Guid.NewGuid().ToString("N"))
        
        try
            // Run the parser to generate files
            let mem = schema.AsMemory()
            let typesDest = FileSystemDestination.Directory typesTempDir
            let servicesDest = FileSystemDestination.Directory servicesTempDir
            
            let task = Parser.ParseAndWriteAsync (typesDest, servicesDest) Casing.Pascal assumeNullability mem System.Threading.CancellationToken.None
            task.AsTask().GetAwaiter().GetResult()

            let typesFiles = if Directory.Exists typesTempDir then Directory.GetFiles(typesTempDir, "*.cs", SearchOption.AllDirectories) else [||]
            let servicesFiles = if Directory.Exists servicesTempDir then Directory.GetFiles(servicesTempDir, "*.cs", SearchOption.AllDirectories) else [||]
            
            if servicesFiles.Length = 0 then
                failwithf "No C# files generated in services directory. Types files generated: %A" typesFiles

            let generatedFiles = 
                Array.concat [typesFiles; servicesFiles]
                |> Array.map File.ReadAllText

            let syntaxTrees = 
                generatedFiles 
                |> Seq.map (fun code -> CSharpSyntaxTree.ParseText(code))
                |> Array.ofSeq

            let assemblies = [
                typeof<obj>.Assembly // System.Private.CoreLib
                typeof<System.Console>.Assembly
                typeof<System.Collections.Generic.List<_>>.Assembly
                typeof<System.Text.Json.JsonSerializer>.Assembly
                typeof<System.Text.Json.Serialization.JsonPropertyNameAttribute>.Assembly
                typeof<ShopifySharp.Credentials.ShopifyApiCredentials>.Assembly
                Assembly.Load("System.Runtime")
                Assembly.Load("System.Linq")
                Assembly.Load("System.Linq.Expressions")
            ]
            
            let references = 
                assemblies 
                |> List.map (fun a -> MetadataReference.CreateFromFile(a.Location) :> MetadataReference)

            let compilation = 
                CSharpCompilation.Create(
                    "ShopifySharp.Tests",
                    syntaxTrees,
                    references,
                    CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
                )

            use ms = new MemoryStream()
            let result = compilation.Emit(ms)
            if not result.Success then
                let errors = 
                    result.Diagnostics 
                    |> Seq.filter (fun d -> d.Severity = DiagnosticSeverity.Error)
                    |> Seq.map (fun d -> d.ToString())
                    |> String.concat "\n"
                failwithf "Generated code failed to compile:\n%s" errors

            ms.Seek(0L, SeekOrigin.Begin) |> ignore
            Assembly.Load(ms.ToArray())
        finally
            // Clean up temp directories
            if Directory.Exists typesTempDir then Directory.Delete(typesTempDir, true)
            if Directory.Exists servicesTempDir then Directory.Delete(servicesTempDir, true)

    let compileSchema (schema: string) : Assembly =
        compileSchemaWithOptions false schema

module Assert =
    let typeExists (fullName: string) (assembly: Assembly) =
        let t = assembly.GetType(fullName)
        if isNull t then
            let allTypes = assembly.GetExportedTypes() |> Seq.map _.FullName |> String.concat ", "
            failwithf "Type %s not found. Exported types: %s" fullName allTypes
        t

    let implementsInterface (interfaceType: Type) (t: Type) =
        let implements = interfaceType.IsAssignableFrom(t)
        % implements.Should().BeTrue($"Type {t.FullName} should implement {interfaceType.FullName}")

    let inheritsFromGeneric (baseTypeName: string) (t: Type) =
        let rec inherits (current: Type) =
            if current = null then false
            elif current.IsGenericType && current.GetGenericTypeDefinition().Name.StartsWith(baseTypeName) then true
            else inherits current.BaseType
        let ok = inherits t
        % ok.Should().BeTrue($"Type {t.FullName} should inherit from generic base {baseTypeName}")

    let hasProperty (name: string) (expectedType: Type) (t: Type) =
        let prop = t.GetProperty(name, BindingFlags.Public ||| BindingFlags.Instance)
        % prop.Should().NotBeNull($"Type {t.FullName} should have property {name}")
        % prop.PropertyType.Should().Be(expectedType, $"Property {name} type on {t.FullName} should be {expectedType.FullName}")
        prop

    let hasJsonPropertyName (expectedJsonName: string) (prop: PropertyInfo) =
        let attr = prop.GetCustomAttribute<JsonPropertyNameAttribute>()
        % attr.Should().NotBeNull($"Property {prop.Name} should have JsonPropertyNameAttribute")
        % attr.Name.Should().Be(expectedJsonName, $"JsonPropertyName for {prop.Name} should be {expectedJsonName}")

    let isObsolete (prop: PropertyInfo) =
        let attr = prop.GetCustomAttribute<ObsoleteAttribute>()
        % attr.Should().NotBeNull($"Property {prop.Name} should have ObsoleteAttribute")

    let hasMethod (name: string) (t: Type) =
        let m = t.GetMethod(name, BindingFlags.Public ||| BindingFlags.Instance)
        % m.Should().NotBeNull($"Type {t.FullName} should have method {name}")
        m
