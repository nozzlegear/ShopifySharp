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
    public sealed class ProductOptionValueSwatchQueryBuilder : FieldsQueryBuilderBase<ProductOptionValueSwatch, ProductOptionValueSwatchQueryBuilder>
    {
        protected override ProductOptionValueSwatchQueryBuilder Self => this;

        public ProductOptionValueSwatchQueryBuilder() : this("productOptionValueSwatch")
        {
        }

        public ProductOptionValueSwatchQueryBuilder(string name) : base(new Query<ProductOptionValueSwatch>(name))
        {
        }

        public ProductOptionValueSwatchQueryBuilder(IQuery<ProductOptionValueSwatch> query) : base(query)
        {
        }

        public ProductOptionValueSwatchQueryBuilder Color()
        {
            base.InnerQuery.AddField("color");
            return this;
        }

        public ProductOptionValueSwatchQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaImageQueryBuilder> build)
        {
            var query = new Query<MediaImage>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaImage>(query);
            return this;
        }
    }
}