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
    public sealed class BlogUpdateOperationQueryBuilder : FieldsQueryBuilderBase<BlogUpdatePayload, BlogUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<BlogUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public BlogUpdateArgumentsBuilder Arguments { get; }
        protected override BlogUpdateOperationQueryBuilder Self => this;

        public BlogUpdateOperationQueryBuilder() : this("blogUpdate")
        {
        }

        public BlogUpdateOperationQueryBuilder(string name) : base(new Query<BlogUpdatePayload>(name))
        {
            Arguments = new BlogUpdateArgumentsBuilder(base.InnerQuery);
        }

        public BlogUpdateOperationQueryBuilder(IQuery<BlogUpdatePayload> query) : base(query)
        {
            Arguments = new BlogUpdateArgumentsBuilder(base.InnerQuery);
        }

        public BlogUpdateOperationQueryBuilder Blog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("blog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Blog>(query);
            return this;
        }

        public BlogUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<BlogUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BlogUpdateUserError>(query);
            return this;
        }
    }
}