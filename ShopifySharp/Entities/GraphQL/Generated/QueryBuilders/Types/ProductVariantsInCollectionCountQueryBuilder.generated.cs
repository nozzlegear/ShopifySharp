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
    public sealed class ProductVariantsInCollectionCountQueryBuilder : FieldsQueryBuilderBase<Count, ProductVariantsInCollectionCountQueryBuilder>, IHasArguments<ProductVariantsInCollectionCountArgumentsBuilder>
    {
        public ProductVariantsInCollectionCountArgumentsBuilder Arguments { get; }
        protected override ProductVariantsInCollectionCountQueryBuilder Self => this;

        public ProductVariantsInCollectionCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new ProductVariantsInCollectionCountArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsInCollectionCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new ProductVariantsInCollectionCountArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsInCollectionCountQueryBuilder SetArguments(Action<ProductVariantsInCollectionCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductVariantsInCollectionCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public ProductVariantsInCollectionCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}