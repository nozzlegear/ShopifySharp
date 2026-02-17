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
    public sealed class ProductFeedOperationQueryBuilder : FieldsQueryBuilderBase<ProductFeed, ProductFeedOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductFeed>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductFeedArgumentsBuilder Arguments { get; }
        protected override ProductFeedOperationQueryBuilder Self => this;

        public ProductFeedOperationQueryBuilder() : this("productFeed")
        {
        }

        public ProductFeedOperationQueryBuilder(string name) : base(new Query<ProductFeed>(name))
        {
            Arguments = new ProductFeedArgumentsBuilder(base.InnerQuery);
        }

        public ProductFeedOperationQueryBuilder(IQuery<ProductFeed> query) : base(query)
        {
            Arguments = new ProductFeedArgumentsBuilder(base.InnerQuery);
        }

        public ProductFeedOperationQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public ProductFeedOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductFeedOperationQueryBuilder Language()
        {
            base.InnerQuery.AddField("language");
            return this;
        }

        public ProductFeedOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}