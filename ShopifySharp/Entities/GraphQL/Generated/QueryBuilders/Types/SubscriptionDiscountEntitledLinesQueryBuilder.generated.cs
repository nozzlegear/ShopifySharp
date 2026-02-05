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
    public sealed class SubscriptionDiscountEntitledLinesQueryBuilder : FieldsQueryBuilderBase<SubscriptionDiscountEntitledLines, SubscriptionDiscountEntitledLinesQueryBuilder>
    {
        protected override SubscriptionDiscountEntitledLinesQueryBuilder Self => this;

        public SubscriptionDiscountEntitledLinesQueryBuilder() : this("subscriptionDiscountEntitledLines")
        {
        }

        public SubscriptionDiscountEntitledLinesQueryBuilder(string name) : base(new Query<SubscriptionDiscountEntitledLines>(name))
        {
        }

        public SubscriptionDiscountEntitledLinesQueryBuilder(IQuery<SubscriptionDiscountEntitledLines> query) : base(query)
        {
        }

        public SubscriptionDiscountEntitledLinesQueryBuilder All()
        {
            base.InnerQuery.AddField("all");
            return this;
        }

        public SubscriptionDiscountEntitledLinesQueryBuilder Lines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("lines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }
    }
}