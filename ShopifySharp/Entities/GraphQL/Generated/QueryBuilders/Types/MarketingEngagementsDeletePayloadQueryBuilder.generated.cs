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
    public sealed class MarketingEngagementsDeletePayloadQueryBuilder : FieldsQueryBuilderBase<MarketingEngagementsDeletePayload, MarketingEngagementsDeletePayloadQueryBuilder>
    {
        protected override MarketingEngagementsDeletePayloadQueryBuilder Self => this;

        public MarketingEngagementsDeletePayloadQueryBuilder() : this("marketingEngagementsDeletePayload")
        {
        }

        public MarketingEngagementsDeletePayloadQueryBuilder(string name) : base(new Query<MarketingEngagementsDeletePayload>(name))
        {
        }

        public MarketingEngagementsDeletePayloadQueryBuilder(IQuery<MarketingEngagementsDeletePayload> query) : base(query)
        {
        }

        public MarketingEngagementsDeletePayloadQueryBuilder Result()
        {
            base.InnerQuery.AddField("result");
            return this;
        }

        public MarketingEngagementsDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}