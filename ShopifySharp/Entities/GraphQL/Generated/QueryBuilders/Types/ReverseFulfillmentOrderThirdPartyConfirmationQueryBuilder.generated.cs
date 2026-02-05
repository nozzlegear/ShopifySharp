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