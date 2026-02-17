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
    public sealed class BlogDeleteOperationQueryBuilder : FieldsQueryBuilderBase<BlogDeletePayload, BlogDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<BlogDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public BlogDeleteArgumentsBuilder Arguments { get; }
        protected override BlogDeleteOperationQueryBuilder Self => this;

        public BlogDeleteOperationQueryBuilder() : this("blogDelete")
        {
        }

        public BlogDeleteOperationQueryBuilder(string name) : base(new Query<BlogDeletePayload>(name))
        {
            Arguments = new BlogDeleteArgumentsBuilder(base.InnerQuery);
        }

        public BlogDeleteOperationQueryBuilder(IQuery<BlogDeletePayload> query) : base(query)
        {
            Arguments = new BlogDeleteArgumentsBuilder(base.InnerQuery);
        }

        public BlogDeleteOperationQueryBuilder DeletedBlogId()
        {
            base.InnerQuery.AddField("deletedBlogId");
            return this;
        }

        public BlogDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<BlogDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BlogDeleteUserError>(query);
            return this;
        }
    }
}