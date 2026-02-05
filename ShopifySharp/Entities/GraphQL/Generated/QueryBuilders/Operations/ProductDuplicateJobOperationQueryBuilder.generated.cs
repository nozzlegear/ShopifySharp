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
    public sealed class ProductDuplicateJobOperationQueryBuilder : FieldsQueryBuilderBase<ProductDuplicateJob, ProductDuplicateJobOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductDuplicateJob>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductDuplicateJobArgumentsBuilder Arguments { get; }
        protected override ProductDuplicateJobOperationQueryBuilder Self => this;

        public ProductDuplicateJobOperationQueryBuilder() : this("productDuplicateJob")
        {
        }

        public ProductDuplicateJobOperationQueryBuilder(string name) : base(new Query<ProductDuplicateJob>(name))
        {
            Arguments = new ProductDuplicateJobArgumentsBuilder(base.InnerQuery);
        }

        public ProductDuplicateJobOperationQueryBuilder(IQuery<ProductDuplicateJob> query) : base(query)
        {
            Arguments = new ProductDuplicateJobArgumentsBuilder(base.InnerQuery);
        }

        public ProductDuplicateJobOperationQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public ProductDuplicateJobOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}