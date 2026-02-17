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
    public sealed class FulfillmentHoldQueryBuilder : FieldsQueryBuilderBase<FulfillmentHold, FulfillmentHoldQueryBuilder>
    {
        protected override FulfillmentHoldQueryBuilder Self => this;

        public FulfillmentHoldQueryBuilder() : this("fulfillmentHold")
        {
        }

        public FulfillmentHoldQueryBuilder(string name) : base(new Query<FulfillmentHold>(name))
        {
        }

        public FulfillmentHoldQueryBuilder(IQuery<FulfillmentHold> query) : base(query)
        {
        }

        public FulfillmentHoldQueryBuilder DisplayReason()
        {
            base.InnerQuery.AddField("displayReason");
            return this;
        }

        public FulfillmentHoldQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public FulfillmentHoldQueryBuilder HeldByApp(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("heldByApp");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public FulfillmentHoldQueryBuilder HeldByRequestingApp()
        {
            base.InnerQuery.AddField("heldByRequestingApp");
            return this;
        }

        public FulfillmentHoldQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentHoldQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }

        public FulfillmentHoldQueryBuilder ReasonNotes()
        {
            base.InnerQuery.AddField("reasonNotes");
            return this;
        }
    }
}