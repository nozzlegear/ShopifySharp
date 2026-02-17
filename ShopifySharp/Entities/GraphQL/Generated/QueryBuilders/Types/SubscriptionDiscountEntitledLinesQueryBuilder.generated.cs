#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
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

        public SubscriptionDiscountEntitledLinesQueryBuilder Lines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLineConnection>("lines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLineConnection>(query);
            return this;
        }
    }
}