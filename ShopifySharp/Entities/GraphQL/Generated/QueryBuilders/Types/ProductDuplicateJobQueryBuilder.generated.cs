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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ProductDuplicateJobQueryBuilder : FieldsQueryBuilderBase<ProductDuplicateJob, ProductDuplicateJobQueryBuilder>
    {
        protected override ProductDuplicateJobQueryBuilder Self => this;

        public ProductDuplicateJobQueryBuilder() : this("productDuplicateJob")
        {
        }

        public ProductDuplicateJobQueryBuilder(string name) : base(new Query<ProductDuplicateJob>(name))
        {
        }

        public ProductDuplicateJobQueryBuilder(IQuery<ProductDuplicateJob> query) : base(query)
        {
        }

        public ProductDuplicateJobQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public ProductDuplicateJobQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}