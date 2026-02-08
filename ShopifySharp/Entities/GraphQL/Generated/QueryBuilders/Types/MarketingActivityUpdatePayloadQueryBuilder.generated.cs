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
    public sealed class MarketingActivityUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<MarketingActivityUpdatePayload, MarketingActivityUpdatePayloadQueryBuilder>
    {
        protected override MarketingActivityUpdatePayloadQueryBuilder Self => this;

        public MarketingActivityUpdatePayloadQueryBuilder() : this("marketingActivityUpdatePayload")
        {
        }

        public MarketingActivityUpdatePayloadQueryBuilder(string name) : base(new Query<MarketingActivityUpdatePayload>(name))
        {
        }

        public MarketingActivityUpdatePayloadQueryBuilder(IQuery<MarketingActivityUpdatePayload> query) : base(query)
        {
        }

        public MarketingActivityUpdatePayloadQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public MarketingActivityUpdatePayloadQueryBuilder RedirectPath()
        {
            base.InnerQuery.AddField("redirectPath");
            return this;
        }

        public MarketingActivityUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}