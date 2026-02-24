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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ProductDuplicateJobQueryBuilder : FieldsQueryBuilderBase<ProductDuplicateJob, ProductDuplicateJobQueryBuilder>, IHasArguments<ProductDuplicateJobArgumentsBuilder>
    {
        public ProductDuplicateJobArgumentsBuilder Arguments { get; }
        protected override ProductDuplicateJobQueryBuilder Self => this;

        public ProductDuplicateJobQueryBuilder() : this("productDuplicateJob")
        {
        }

        public ProductDuplicateJobQueryBuilder(string name) : base(new Query<ProductDuplicateJob>(name))
        {
            Arguments = new ProductDuplicateJobArgumentsBuilder(base.InnerQuery);
        }

        public ProductDuplicateJobQueryBuilder(IQuery<ProductDuplicateJob> query) : base(query)
        {
            Arguments = new ProductDuplicateJobArgumentsBuilder(base.InnerQuery);
        }

        public ProductDuplicateJobQueryBuilder SetArguments(Action<ProductDuplicateJobArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
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