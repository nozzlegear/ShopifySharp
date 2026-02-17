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
    public sealed class ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderThirdPartyConfirmation, ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder>
    {
        protected override ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder Self => this;

        public ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder() : this("reverseFulfillmentOrderThirdPartyConfirmation")
        {
        }

        public ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderThirdPartyConfirmation>(name))
        {
        }

        public ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder(IQuery<ReverseFulfillmentOrderThirdPartyConfirmation> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}