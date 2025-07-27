namespace ShopifySharp.GraphQL.Parser

open System
open System.IO.Pipelines
open System.Text
open System.Threading.Tasks

type PipeWriterComputationBuilder(writer: PipeWriter) =
    member _.Bind(task': ValueTask, continuation: unit -> ValueTask) : ValueTask =
        ValueTask(task {
            do! task'.ConfigureAwait(false)
            do! continuation ()
        })

    member _.Bind(value: ReadOnlyMemory<byte>, continuation: unit -> ValueTask) : ValueTask =
        ValueTask(task {
            let! _ = writer.WriteAsync(value)
            do! continuation ()
        })

    member _.Bind(value: string, continuation: unit -> ValueTask) : ValueTask =
        ValueTask(task {
            let bytes = Encoding.UTF8.GetBytes(value)
            let! _ = writer.WriteAsync(bytes)
            do! continuation ()
        })

    member _.Bind(value: string, continuation: FlushResult -> ValueTask) : ValueTask =
        ValueTask(task {
            let bytes = Encoding.UTF8.GetBytes(value)
            let! flushResult = writer.WriteAsync(bytes)
            do! continuation flushResult
        })

    member _.Return(_: unit) : ValueTask =
        ValueTask.CompletedTask

    member _.ReturnFrom(task: ValueTask) : ValueTask =
        task

    member _.Zero() : ValueTask =
        ValueTask.CompletedTask

    member _.Delay(f: unit -> ValueTask) : unit -> ValueTask =
        f

    /// The forLoop operator.
    member this.For(collection: seq<_>, func: _ -> ValueTask) : ValueTask =
        ValueTask(task {
            let ie = collection.GetEnumerator()
            try
                while ie.MoveNext() do
                    let value = ie.Current
                    do! func value
            finally
                ie.Dispose()
        })

    member _.Yield _ = ValueTask.CompletedTask

    member _.Yield(value: string) : ValueTask =
        ValueTask(task {
            let bytes = Encoding.UTF8.GetBytes(value)
            let! _ = writer.WriteAsync(bytes)
            ()
        })

    member _.YieldFrom(continuation: PipeWriter -> ValueTask) : ValueTask =
        ValueTask(task {
            do! continuation writer
        })

    member _.Combine(first: ValueTask, second: unit -> ValueTask) : ValueTask =
        ValueTask(task {
            do! first
            do! second ()
        })

    member _.Run(computation: unit -> ValueTask) : ValueTask =
        computation()

module PipeWriter =
    let pipeWriter (writer: PipeWriter) = PipeWriterComputationBuilder(writer)
