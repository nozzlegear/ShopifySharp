#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PublishedProductsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, PublishedProductsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PublishedProductsCountArgumentsBuilder Arguments { get; }
        protected override PublishedProductsCountOperationQueryBuilder Self => this;

        public PublishedProductsCountOperationQueryBuilder() : this("publishedProductsCount")
        {
        }

        public PublishedProductsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new PublishedProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public PublishedProductsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new PublishedProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public PublishedProductsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public PublishedProductsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}