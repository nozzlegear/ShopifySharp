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
    public sealed class ProductsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, ProductsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductsCountArgumentsBuilder Arguments { get; }
        protected override ProductsCountOperationQueryBuilder Self => this;

        public ProductsCountOperationQueryBuilder() : this("productsCount")
        {
        }

        public ProductsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new ProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public ProductsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new ProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public ProductsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public ProductsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}