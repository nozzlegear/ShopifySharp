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
    public sealed class MarketingActivityCreatePayloadQueryBuilder : FieldsQueryBuilderBase<MarketingActivityCreatePayload, MarketingActivityCreatePayloadQueryBuilder>
    {
        protected override MarketingActivityCreatePayloadQueryBuilder Self => this;

        public MarketingActivityCreatePayloadQueryBuilder() : this("marketingActivityCreatePayload")
        {
        }

        public MarketingActivityCreatePayloadQueryBuilder(string name) : base(new Query<MarketingActivityCreatePayload>(name))
        {
        }

        public MarketingActivityCreatePayloadQueryBuilder(IQuery<MarketingActivityCreatePayload> query) : base(query)
        {
        }

        public MarketingActivityCreatePayloadQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        [Obsolete("Marketing activity app extensions are deprecated and will be removed in the near future.")]
        public MarketingActivityCreatePayloadQueryBuilder RedirectPath()
        {
            base.InnerQuery.AddField("redirectPath");
            return this;
        }

        public MarketingActivityCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}