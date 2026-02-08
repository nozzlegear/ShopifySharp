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
    public sealed class ProductVariantsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, ProductVariantsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductVariantsCountArgumentsBuilder Arguments { get; }
        protected override ProductVariantsCountOperationQueryBuilder Self => this;

        public ProductVariantsCountOperationQueryBuilder() : this("productVariantsCount")
        {
        }

        public ProductVariantsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new ProductVariantsCountArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new ProductVariantsCountArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public ProductVariantsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}