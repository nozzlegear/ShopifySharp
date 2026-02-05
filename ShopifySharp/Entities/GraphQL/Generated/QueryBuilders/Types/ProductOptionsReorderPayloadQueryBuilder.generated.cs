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
    public sealed class ProductOptionsReorderPayloadQueryBuilder : FieldsQueryBuilderBase<ProductOptionsReorderPayload, ProductOptionsReorderPayloadQueryBuilder>
    {
        protected override ProductOptionsReorderPayloadQueryBuilder Self => this;

        public ProductOptionsReorderPayloadQueryBuilder() : this("productOptionsReorderPayload")
        {
        }

        public ProductOptionsReorderPayloadQueryBuilder(string name) : base(new Query<ProductOptionsReorderPayload>(name))
        {
        }

        public ProductOptionsReorderPayloadQueryBuilder(IQuery<ProductOptionsReorderPayload> query) : base(query)
        {
        }

        public ProductOptionsReorderPayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductOptionsReorderPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionsReorderUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductOptionsReorderUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionsReorderUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionsReorderUserError>(query);
            return this;
        }
    }
}