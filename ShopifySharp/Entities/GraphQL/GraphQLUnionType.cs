// ReSharper disable InconsistentNaming
// ReSharper disable UnusedTypeParameter
namespace ShopifySharp.GraphQL;

public interface IGraphQLUnionType;

public record GraphQLUnionType : IGraphQLUnionType;

public interface IGraphQLUnionType<T1, T2> : IGraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase;

public interface IGraphQLUnionType<T1, T2, T3> : IGraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase;

public interface IGraphQLUnionType<T1, T2, T3, T4> : IGraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase;

public interface IGraphQLUnionType<T1, T2, T3, T4, T5> : IGraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase;

public interface IGraphQLUnionType<T1, T2, T3, T4, T5, T6> : IGraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase
    where T6 : IGraphQLUnionCase;

public interface IGraphQLUnionType<T1, T2, T3, T4, T5, T6, T7> : IGraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase
    where T6 : IGraphQLUnionCase
    where T7 : IGraphQLUnionCase;

public interface IGraphQLUnionType<T1, T2, T3, T4, T5, T6, T7, T8> : IGraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase
    where T6 : IGraphQLUnionCase
    where T7 : IGraphQLUnionCase
    where T8 : IGraphQLUnionCase;

public interface IGraphQLUnionType<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IGraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase
    where T6 : IGraphQLUnionCase
    where T7 : IGraphQLUnionCase
    where T8 : IGraphQLUnionCase
    where T9 : IGraphQLUnionCase;

public interface IGraphQLUnionType<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IGraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase
    where T6 : IGraphQLUnionCase
    where T7 : IGraphQLUnionCase
    where T8 : IGraphQLUnionCase
    where T9 : IGraphQLUnionCase
    where T10 : IGraphQLUnionCase;

public record GraphQLUnionType<T1, T2> : GraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3> : GraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4> : GraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5> : GraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5, T6> : GraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase
    where T6 : IGraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5, T6, T7> : GraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase
    where T6 : IGraphQLUnionCase
    where T7 : IGraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5, T6, T7, T8> : GraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase
    where T6 : IGraphQLUnionCase
    where T7 : IGraphQLUnionCase
    where T8 : IGraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5, T6, T7, T8, T9> : GraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase
    where T6 : IGraphQLUnionCase
    where T7 : IGraphQLUnionCase
    where T8 : IGraphQLUnionCase
    where T9 : IGraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : GraphQLUnionType
    where T1 : IGraphQLUnionCase
    where T2 : IGraphQLUnionCase
    where T3 : IGraphQLUnionCase
    where T4 : IGraphQLUnionCase
    where T5 : IGraphQLUnionCase
    where T6 : IGraphQLUnionCase
    where T7 : IGraphQLUnionCase
    where T8 : IGraphQLUnionCase
    where T9 : IGraphQLUnionCase
    where T10 : IGraphQLUnionCase;
