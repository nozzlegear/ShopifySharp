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
    public sealed class MarketingActivityDeleteExternalPayloadQueryBuilder : FieldsQueryBuilderBase<MarketingActivityDeleteExternalPayload, MarketingActivityDeleteExternalPayloadQueryBuilder>
    {
        protected override MarketingActivityDeleteExternalPayloadQueryBuilder Self => this;

        public MarketingActivityDeleteExternalPayloadQueryBuilder() : this("marketingActivityDeleteExternalPayload")
        {
        }

        public MarketingActivityDeleteExternalPayloadQueryBuilder(string name) : base(new Query<MarketingActivityDeleteExternalPayload>(name))
        {
        }

        public MarketingActivityDeleteExternalPayloadQueryBuilder(IQuery<MarketingActivityDeleteExternalPayload> query) : base(query)
        {
        }

        public MarketingActivityDeleteExternalPayloadQueryBuilder DeletedMarketingActivityId()
        {
            base.InnerQuery.AddField("deletedMarketingActivityId");
            return this;
        }

        public MarketingActivityDeleteExternalPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}