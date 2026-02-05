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
    public sealed class AppSubscriptionTrialExtendUserErrorQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionTrialExtendUserError, AppSubscriptionTrialExtendUserErrorQueryBuilder>
    {
        protected override AppSubscriptionTrialExtendUserErrorQueryBuilder Self => this;

        public AppSubscriptionTrialExtendUserErrorQueryBuilder() : this("appSubscriptionTrialExtendUserError")
        {
        }

        public AppSubscriptionTrialExtendUserErrorQueryBuilder(string name) : base(new Query<AppSubscriptionTrialExtendUserError>(name))
        {
        }

        public AppSubscriptionTrialExtendUserErrorQueryBuilder(IQuery<AppSubscriptionTrialExtendUserError> query) : base(query)
        {
        }

        public AppSubscriptionTrialExtendUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public AppSubscriptionTrialExtendUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public AppSubscriptionTrialExtendUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}