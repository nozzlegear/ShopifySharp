#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class BlogCreateOperationQueryBuilder : FieldsQueryBuilderBase<BlogCreatePayload, BlogCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<BlogCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public BlogCreateArgumentsBuilder Arguments { get; }
        protected override BlogCreateOperationQueryBuilder Self => this;

        public BlogCreateOperationQueryBuilder() : this("blogCreate")
        {
        }

        public BlogCreateOperationQueryBuilder(string name) : base(new Query<BlogCreatePayload>(name))
        {
            Arguments = new BlogCreateArgumentsBuilder(base.InnerQuery);
        }

        public BlogCreateOperationQueryBuilder(IQuery<BlogCreatePayload> query) : base(query)
        {
            Arguments = new BlogCreateArgumentsBuilder(base.InnerQuery);
        }

        public BlogCreateOperationQueryBuilder Blog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("blog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Blog>(query);
            return this;
        }

        public BlogCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<BlogCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BlogCreateUserError>(query);
            return this;
        }
    }
}