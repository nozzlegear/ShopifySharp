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
    public sealed class FulfillmentConstraintRuleDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRuleDeleteUserError, FulfillmentConstraintRuleDeleteUserErrorQueryBuilder>
    {
        protected override FulfillmentConstraintRuleDeleteUserErrorQueryBuilder Self => this;

        public FulfillmentConstraintRuleDeleteUserErrorQueryBuilder() : this("fulfillmentConstraintRuleDeleteUserError")
        {
        }

        public FulfillmentConstraintRuleDeleteUserErrorQueryBuilder(string name) : base(new Query<FulfillmentConstraintRuleDeleteUserError>(name))
        {
        }

        public FulfillmentConstraintRuleDeleteUserErrorQueryBuilder(IQuery<FulfillmentConstraintRuleDeleteUserError> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentConstraintRuleDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentConstraintRuleDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}