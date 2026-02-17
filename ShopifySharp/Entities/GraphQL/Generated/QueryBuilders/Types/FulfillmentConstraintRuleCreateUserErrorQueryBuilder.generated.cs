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
    public sealed class FulfillmentConstraintRuleCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRuleCreateUserError, FulfillmentConstraintRuleCreateUserErrorQueryBuilder>
    {
        protected override FulfillmentConstraintRuleCreateUserErrorQueryBuilder Self => this;

        public FulfillmentConstraintRuleCreateUserErrorQueryBuilder() : this("fulfillmentConstraintRuleCreateUserError")
        {
        }

        public FulfillmentConstraintRuleCreateUserErrorQueryBuilder(string name) : base(new Query<FulfillmentConstraintRuleCreateUserError>(name))
        {
        }

        public FulfillmentConstraintRuleCreateUserErrorQueryBuilder(IQuery<FulfillmentConstraintRuleCreateUserError> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentConstraintRuleCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentConstraintRuleCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}