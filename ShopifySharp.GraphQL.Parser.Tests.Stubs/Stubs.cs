using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace ShopifySharp.Credentials
{
    public readonly struct ShopifyApiCredentials
    {
        public string ShopDomain { get; }
        public string AccessToken { get; }

        public ShopifyApiCredentials(string shopDomain, string accessToken)
        {
            ShopDomain = shopDomain;
            AccessToken = accessToken;
        }
    }
}

namespace ShopifySharp.GraphQL
{
    public enum OperationType
    {
        Query,
        Mutation,
    }

    public interface IGraphQLObject;

    public interface IGraphQLUnionType;

    public interface IGraphQLUnionCase;

    public interface IGraphQLInputObject;

    public abstract record GraphQLObject<TNode> : IGraphQLObject where TNode : IGraphQLObject;

    public abstract record GraphQLInputObject<TSelf> : IGraphQLInputObject where TSelf : IGraphQLInputObject;

    public interface IEdge<out TNode>
    {
        string? cursor { get; }
        TNode? node { get; }
    }

    public record Edge<TNode> : IEdge<TNode>, IGraphQLObject
    {
        public string? cursor { get; set; }
        public TNode? node { get; set; }
    }

    public sealed record PageInfo(
        string? startCursor,
        string? endCursor,
        bool hasPreviousPage,
        bool hasNextPage) : IGraphQLObject
    {
        public string? startCursor { get; set; } = startCursor;
        public string? endCursor { get; set; } = endCursor;
        public bool hasNextPage { get; set; } = hasNextPage;
        public bool hasPreviousPage { get; set; } = hasPreviousPage;
    }

    public interface IConnection : IGraphQLObject
    {
        PageInfo? pageInfo { get; }
        int? totalCount { get; }
        Type GetNodeType();
    }

    public interface IHasEdges<out TEdge>
    {
        IReadOnlyList<TEdge> edges { get; }
    }

    public interface IHasNodes<out TNode>
    {
        IReadOnlyList<TNode> nodes { get; }
    }

    public interface IConnectionWithEdges<TNode> : IConnection, IHasEdges<Edge<TNode>> { }

    public interface IConnectionWithNodes<out TNode> : IConnection, IHasNodes<TNode> { }

    public interface IConnectionWithNodesAndEdges<TNode> : IConnection, IHasEdges<Edge<TNode>>, IHasNodes<TNode> { }

    public abstract record ConnectionWithEdges<TNode> : IConnectionWithEdges<TNode>
    {
        public IReadOnlyList<Edge<TNode>> edges { get; set; } = [];
        public PageInfo? pageInfo { get; set; }
        public int? totalCount { get; set; } = null;
        public Type GetNodeType() => typeof(TNode);
    }

    public abstract record ConnectionWithNodes<TNode> : IConnectionWithNodes<TNode>
    {
        public IReadOnlyList<TNode> nodes { get; set; } = [];
        public PageInfo? pageInfo { get; set; }
        public int? totalCount { get; set; } = null;
        public Type GetNodeType() => typeof(TNode);
    }

    public abstract record ConnectionWithNodesAndEdges<TNode> : IConnectionWithNodesAndEdges<TNode>
    {
        public IReadOnlyList<Edge<TNode>> edges { get; set; } = [];
        public IReadOnlyList<TNode> nodes { get; set; } = [];
        public PageInfo? pageInfo { get; set; }
        public int? totalCount { get; set; } = null;
        public Type GetNodeType() => typeof(TNode);
    }
}

namespace ShopifySharp.GraphQL.QueryBuilders
{
    using ShopifySharp.GraphQL;

    public interface IQuery
    {
        string QueryName { get; }
        string? AliasName { get; }
        string Build();
    }

    public interface IArgumentsBuilder<out TSelf> where TSelf : IArgumentsBuilder<TSelf>
    {
        TSelf AddArgument(string key, object? value);
        TSelf AddArguments(IDictionary<string, object?> arguments);
    }

    public interface IUnionCasesBuilder<out TSelf> where TSelf : IUnionCasesBuilder<TSelf>
    {
        TSelf AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?;
    }

    public interface IInterfaceCasesBuilder<out TSelf> where TSelf : IInterfaceCasesBuilder<TSelf>
    {
        TSelf AddInterfaceCase<TConcreteType>(IQuery<TConcreteType> concreteTypeQuery) where TConcreteType : class?;
    }

    public interface IFieldsBuilder<out TSelf> : IUnionCasesBuilder<TSelf>, IInterfaceCasesBuilder<TSelf> where TSelf : IFieldsBuilder<TSelf>
    {
        TSelf AddField(string field);
        TSelf AddField(IQuery subQuery);
        TSelf AddField<TSubSource>(IQuery<TSubSource> subQuery) where TSubSource : class?;
    }

    public interface IQuery<out TSource> : IQuery, IArgumentsBuilder<IQuery<TSource>>, IFieldsBuilder<IQuery<TSource>>
    {
        List<object?> SelectList { get; }
        Dictionary<string, object?> Arguments { get; }
        IQuery<TSource> SetAlias(string alias);
    }

    public class Query<TSource> : IQuery<TSource>
    {
        public string QueryName { get; }
        public string? AliasName { get; protected set; }
        public List<object?> SelectList { get; } = [];
        public Dictionary<string, object?> Arguments { get; } = [];

        public Query(string name)
        {
            QueryName = name;
        }

        public string Build() => "";

        public IQuery<TSource> SetAlias(string alias)
        {
            AliasName = alias;
            return this;
        }

        public IQuery<TSource> AddField(string field)
        {
            SelectList.Add(field);
            return this;
        }

        public IQuery<TSource> AddField(IQuery subQuery)
        {
            SelectList.Add(subQuery);
            return this;
        }

        public IQuery<TSource> AddField<TSubSource>(IQuery<TSubSource> subQuery) where TSubSource : class?
        {
            SelectList.Add(subQuery);
            return this;
        }

        public IQuery<TSource> AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?
        {
            SelectList.Add(unionCaseQuery);
            return this;
        }

        public IQuery<TSource> AddInterfaceCase<TConcreteType>(IQuery<TConcreteType> concreteTypeQuery) where TConcreteType : class?
        {
            SelectList.Add(concreteTypeQuery);
            return this;
        }

        public IQuery<TSource> AddArgument(string key, object? value)
        {
            Arguments.Add(key, value);
            return this;
        }

        public IQuery<TSource> AddArguments(IDictionary<string, object?> arguments)
        {
            foreach (var kv in arguments)
            {
                Arguments.Add(kv.Key, kv.Value);
            }
            return this;
        }
    }

    public interface IGraphOperationQueryBuilder<TResult> : IQuery where TResult : IGraphQLObject
    {
        OperationType OperationType { get; }
    }

    public interface IHasArguments<out TArgumentsBuilder>
    {
        TArgumentsBuilder Arguments { get; }
    }

    public abstract class QueryBuilderBase<T, TSelf> : IQuery
        where T : IGraphQLObject
        where TSelf : QueryBuilderBase<T, TSelf>
    {
        public string QueryName => InnerQuery.QueryName;
        public string? AliasName => InnerQuery.AliasName;
        protected IQuery<T> InnerQuery { get; }
        protected abstract TSelf Self { get; }

        protected QueryBuilderBase(IQuery<T> query)
        {
            InnerQuery = query;
        }

        public string Build() => "";
        public TSelf SetAlias(string alias)
        {
            InnerQuery.SetAlias(alias);
            return Self;
        }
    }

    public abstract class FieldsQueryBuilderBase<T, TSelf> : QueryBuilderBase<T, TSelf>, IFieldsBuilder<TSelf>
        where T : IGraphQLObject
        where TSelf : QueryBuilderBase<T, TSelf>, IFieldsBuilder<TSelf>
    {
        protected FieldsQueryBuilderBase(IQuery<T> query) : base(query) { }

        public TSelf AddField<TSubSource>(IQuery<TSubSource> subQuery) where TSubSource : class?
        {
            InnerQuery.AddField(subQuery);
            return Self;
        }

        public TSelf AddField(IQuery subQuery)
        {
            InnerQuery.AddField(subQuery);
            return Self;
        }

        public TSelf AddField(string field)
        {
            InnerQuery.AddField(field);
            return Self;
        }

        public TSelf AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?
        {
            InnerQuery.AddUnionCase(unionCaseQuery);
            return Self;
        }

        public TSelf AddInterfaceCase<TConcreteType>(IQuery<TConcreteType> concreteTypeQuery) where TConcreteType : class?
        {
            InnerQuery.AddInterfaceCase(concreteTypeQuery);
            return Self;
        }
    }

    public abstract class ArgumentsBuilderBase<TSource, TSelf> : IArgumentsBuilder<TSelf>
        where TSelf : IArgumentsBuilder<TSelf>
    {
        protected readonly IQuery<TSource> InnerQuery;
        protected abstract TSelf Self { get; }

        protected ArgumentsBuilderBase(IQuery<TSource> query)
        {
            InnerQuery = query;
        }

        public TSelf AddArgument(string key, object? value)
        {
            InnerQuery.AddArgument(key, value);
            return Self;
        }

        public TSelf AddArguments(IDictionary<string, object?> arguments)
        {
            InnerQuery.AddArguments(arguments);
            return Self;
        }
    }

    public abstract class UnionCasesBuilderBase<TSource, TSelf> : IUnionCasesBuilder<TSelf>
        where TSelf : IUnionCasesBuilder<TSelf>
    {
        protected readonly IQuery<TSource> InnerQuery;
        protected abstract TSelf Self { get; }

        protected UnionCasesBuilderBase(IQuery<TSource> query)
        {
            InnerQuery = query;
        }

        public TSelf AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?
        {
            InnerQuery.AddUnionCase(unionCaseQuery);
            return Self;
        }
    }

    public abstract class InterfaceCasesBuilderBase<TSource, TSelf> : IInterfaceCasesBuilder<TSelf>
        where TSelf : IInterfaceCasesBuilder<TSelf>
    {
        protected readonly IQuery<TSource> InnerQuery;
        protected abstract TSelf Self { get; }

        protected InterfaceCasesBuilderBase(IQuery<TSource> query)
        {
            InnerQuery = query;
        }

        public TSelf AddInterfaceCase<TConcreteType>(IQuery<TConcreteType> concreteTypeQuery) where TConcreteType : class?
        {
            InnerQuery.AddUnionCase(concreteTypeQuery);
            return Self;
        }
    }
}

namespace ShopifySharp.Infrastructure.Serialization.Json
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class GraphUnionTypeConverter<TUnion> : JsonConverter<TUnion> where TUnion : class
    {
        public override TUnion? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => null;
        public override void Write(Utf8JsonWriter writer, TUnion? value, JsonSerializerOptions options) { }
    }
}
