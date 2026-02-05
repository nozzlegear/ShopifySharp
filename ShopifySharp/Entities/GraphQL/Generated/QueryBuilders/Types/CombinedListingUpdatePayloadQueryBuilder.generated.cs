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
    public sealed class CombinedListingUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<CombinedListingUpdatePayload, CombinedListingUpdatePayloadQueryBuilder>
    {
        protected override CombinedListingUpdatePayloadQueryBuilder Self => this;

        public CombinedListingUpdatePayloadQueryBuilder() : this("combinedListingUpdatePayload")
        {
        }

        public CombinedListingUpdatePayloadQueryBuilder(string name) : base(new Query<CombinedListingUpdatePayload>(name))
        {
        }

        public CombinedListingUpdatePayloadQueryBuilder(IQuery<CombinedListingUpdatePayload> query) : base(query)
        {
        }

        public CombinedListingUpdatePayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public CombinedListingUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CombinedListingUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<CombinedListingUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CombinedListingUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CombinedListingUpdateUserError>(query);
            return this;
        }
    }
}