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
    public sealed class CartTransformQueryBuilder : FieldsQueryBuilderBase<CartTransform, CartTransformQueryBuilder>
    {
        protected override CartTransformQueryBuilder Self => this;

        public CartTransformQueryBuilder() : this("cartTransform")
        {
        }

        public CartTransformQueryBuilder(string name) : base(new Query<CartTransform>(name))
        {
        }

        public CartTransformQueryBuilder(IQuery<CartTransform> query) : base(query)
        {
        }

        public CartTransformQueryBuilder BlockOnFailure()
        {
            base.InnerQuery.AddField("blockOnFailure");
            return this;
        }

        public CartTransformQueryBuilder FunctionId()
        {
            base.InnerQuery.AddField("functionId");
            return this;
        }

        public CartTransformQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CartTransformQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public CartTransformQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }
    }
}