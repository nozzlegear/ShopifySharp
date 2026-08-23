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
    public sealed class ProductVariantResourcePublicationsCountQueryBuilder : FieldsQueryBuilderBase<Count, ProductVariantResourcePublicationsCountQueryBuilder>, IHasArguments<ProductVariantResourcePublicationsCountArgumentsBuilder>
    {
        public ProductVariantResourcePublicationsCountArgumentsBuilder Arguments { get; }
        protected override ProductVariantResourcePublicationsCountQueryBuilder Self => this;

        public ProductVariantResourcePublicationsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new ProductVariantResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantResourcePublicationsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new ProductVariantResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantResourcePublicationsCountQueryBuilder SetArguments(Action<ProductVariantResourcePublicationsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductVariantResourcePublicationsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public ProductVariantResourcePublicationsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}