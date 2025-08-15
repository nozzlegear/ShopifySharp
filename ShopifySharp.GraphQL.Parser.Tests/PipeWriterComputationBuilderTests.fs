module ShopifySharp.GraphQL.Parser.Tests.PipeWriterComputationBuilderTests

open System
open System.IO
open System.IO.Pipelines
open System.Text
open System.Threading.Tasks
open Faqt
open Faqt.Operators
open Xunit
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.PipeWriter

type PipeWriterComputationBuilderTests() =

    let createPipeWriter() =
        let stream = new MemoryStream()
        PipeWriter.Create(stream), stream

    [<Fact>]
    member _.``pipeWriter should create computation builder``() =
        // Setup
        let writer, stream = createPipeWriter()
        
        try
            // Act
            let sut = pipeWriter writer

            // Assert
            %sut.Should().BeOfType<PipeWriterComputationBuilder>()
        finally
            stream.Dispose()

    [<Fact>]
    member _.``Return should complete successfully``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        
        try
            // Act
            let result = sut.Return(())
            result.GetAwaiter().GetResult()

            // Assert
            %result.IsCompleted.Should().BeTrue()
        finally
            stream.Dispose()

    [<Fact>]
    member _.``ReturnFrom should return the provided task``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        let testTask = ValueTask.CompletedTask
        
        try
            // Act
            let result = sut.ReturnFrom(testTask)

            // Assert
            %result.Should().Be(testTask)
        finally
            stream.Dispose()

    [<Fact>]
    member _.``Zero should return completed task``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        
        try
            // Act
            let result = sut.Zero()

            // Assert
            %result.IsCompleted.Should().BeTrue()
        finally
            stream.Dispose()

    [<Fact>]
    member _.``Yield with string should write to pipe``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        let testString = "Hello, World!"
        
        try
            // Act
            let task = sut.Yield(testString)
            task.GetAwaiter().GetResult()
            writer.Complete()

            // Assert
            let writtenBytes = stream.ToArray()
            let writtenString = Encoding.UTF8.GetString(writtenBytes)
            %writtenString.Should().Be(testString)
        finally
            stream.Dispose()

    [<Fact>]
    member _.``Bind with string should write to pipe and continue``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        let testString = "Test string"
        let mutable continuationCalled = false
        
        try
            // Act
            let task = sut.Bind(testString, fun () -> 
                continuationCalled <- true
                ValueTask.CompletedTask)
            task.GetAwaiter().GetResult()
            writer.Complete()

            // Assert
            %continuationCalled.Should().BeTrue()
            let writtenBytes = stream.ToArray()
            let writtenString = Encoding.UTF8.GetString(writtenBytes)
            %writtenString.Should().Be(testString)
        finally
            stream.Dispose()

    [<Fact>]
    member _.``Bind with ReadOnlyMemory should write to pipe and continue``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        let testBytes = Encoding.UTF8.GetBytes("Test bytes")
        let testMemory = ReadOnlyMemory<byte>(testBytes)
        let mutable continuationCalled = false
        
        try
            // Act
            let task = sut.Bind(testMemory, fun () -> 
                continuationCalled <- true
                ValueTask.CompletedTask)
            task.GetAwaiter().GetResult()
            writer.Complete()

            // Assert
            %continuationCalled.Should().BeTrue()
            let writtenBytes = stream.ToArray()
            %writtenBytes.Should().Be(testBytes)
        finally
            stream.Dispose()

    [<Fact>]
    member _.``Bind with ValueTask should wait and continue``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        let mutable continuationCalled = false
        let testTask = ValueTask.CompletedTask
        
        try
            // Act
            let task = sut.Bind(testTask, fun () -> 
                continuationCalled <- true
                ValueTask.CompletedTask)
            task.GetAwaiter().GetResult()

            // Assert
            %continuationCalled.Should().BeTrue()
        finally
            stream.Dispose()

    [<Fact>]
    member _.``For should iterate over collection and execute function``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        let items = ["item1"; "item2"; "item3"]
        let mutable processedItems = []
        
        try
            // Act
            let task = sut.For(items, fun item ->
                processedItems <- item :: processedItems
                ValueTask.CompletedTask)
            task.GetAwaiter().GetResult()

            // Assert
            %processedItems.Should().HaveLength(3)
            %processedItems.Should().Contain("item1")
            %processedItems.Should().Contain("item2")
            %processedItems.Should().Contain("item3")
        finally
            stream.Dispose()

    [<Fact>]
    member _.``YieldFrom should call continuation with writer``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        let mutable receivedWriter: PipeWriter option = None
        
        try
            // Act
            let task = sut.YieldFrom(fun w ->
                receivedWriter <- Some w
                ValueTask.CompletedTask)
            task.GetAwaiter().GetResult()

            // Assert
            %receivedWriter.Should().BeSome()
            %receivedWriter.Value.Should().Be(writer)
        finally
            stream.Dispose()

    [<Fact>]
    member _.``Combine should execute first task then second``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        let mutable firstExecuted = false
        let mutable secondExecuted = false
        
        let firstTask = ValueTask(task {
            firstExecuted <- true
        })
        
        let secondFunc = fun () -> 
            secondExecuted <- true
            ValueTask.CompletedTask
        
        try
            // Act
            let task = sut.Combine(firstTask, secondFunc)
            task.GetAwaiter().GetResult()

            // Assert
            %firstExecuted.Should().BeTrue()
            %secondExecuted.Should().BeTrue()
        finally
            stream.Dispose()

    [<Fact>]
    member _.``Run should execute computation``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        let mutable computationExecuted = false
        
        let computation = fun () ->
            computationExecuted <- true
            ValueTask.CompletedTask
        
        try
            // Act
            let task = sut.Run(computation)
            task.GetAwaiter().GetResult()

            // Assert
            %computationExecuted.Should().BeTrue()
        finally
            stream.Dispose()

    [<Fact>]
    member _.``Delay should return function that can be executed later``() =
        // Setup
        let writer, stream = createPipeWriter()
        let sut = PipeWriterComputationBuilder(writer)
        let mutable functionExecuted = false
        
        let func = fun () ->
            functionExecuted <- true
            ValueTask.CompletedTask
        
        try
            // Act
            let delayed = sut.Delay(func)
            %functionExecuted.Should().BeFalse()
            
            let task = delayed()
            task.GetAwaiter().GetResult()

            // Assert
            %functionExecuted.Should().BeTrue()
        finally
            stream.Dispose()

    [<Fact>]
    member _.``computation expression should work with multiple operations``() =
        // Setup
        let writer, stream = createPipeWriter()
        
        try
            // Act
            let task = pipeWriter writer {
                do! "First line\n"
                do! "Second line\n"
                return ()
            }
            task.GetAwaiter().GetResult()
            writer.Complete()

            // Assert
            let writtenBytes = stream.ToArray()
            let writtenString = Encoding.UTF8.GetString(writtenBytes)
            %writtenString.Should().Be("First line\nSecond line\n")
        finally
            stream.Dispose()
