// ReSharper disable InconsistentNaming
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
    where T1 : GraphQLUnionCase
    where T2 : GraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3> : GraphQLUnionType
    where T1 : GraphQLUnionCase
    where T2 : GraphQLUnionCase
    where T3 : GraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4> : GraphQLUnionType
    where T1 : GraphQLUnionCase
    where T2 : GraphQLUnionCase
    where T3 : GraphQLUnionCase
    where T4 : GraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5> : GraphQLUnionType
    where T1 : GraphQLUnionCase
    where T2 : GraphQLUnionCase
    where T3 : GraphQLUnionCase
    where T4 : GraphQLUnionCase
    where T5 : GraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5, T6> : GraphQLUnionType
    where T1 : GraphQLUnionCase
    where T2 : GraphQLUnionCase
    where T3 : GraphQLUnionCase
    where T4 : GraphQLUnionCase
    where T5 : GraphQLUnionCase
    where T6 : GraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5, T6, T7> : GraphQLUnionType
    where T1 : GraphQLUnionCase
    where T2 : GraphQLUnionCase
    where T3 : GraphQLUnionCase
    where T4 : GraphQLUnionCase
    where T5 : GraphQLUnionCase
    where T6 : GraphQLUnionCase
    where T7 : GraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5, T6, T7, T8> : GraphQLUnionType
    where T1 : GraphQLUnionCase
    where T2 : GraphQLUnionCase
    where T3 : GraphQLUnionCase
    where T4 : GraphQLUnionCase
    where T5 : GraphQLUnionCase
    where T6 : GraphQLUnionCase
    where T7 : GraphQLUnionCase
    where T8 : GraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5, T6, T7, T8, T9> : GraphQLUnionType
    where T1 : GraphQLUnionCase
    where T2 : GraphQLUnionCase
    where T3 : GraphQLUnionCase
    where T4 : GraphQLUnionCase
    where T5 : GraphQLUnionCase
    where T6 : GraphQLUnionCase
    where T7 : GraphQLUnionCase
    where T8 : GraphQLUnionCase
    where T9 : GraphQLUnionCase;

public record GraphQLUnionType<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : GraphQLUnionType
    where T1 : GraphQLUnionCase
    where T2 : GraphQLUnionCase
    where T3 : GraphQLUnionCase
    where T4 : GraphQLUnionCase
    where T5 : GraphQLUnionCase
    where T6 : GraphQLUnionCase
    where T7 : GraphQLUnionCase
    where T8 : GraphQLUnionCase
    where T9 : GraphQLUnionCase
    where T10 : GraphQLUnionCase;
