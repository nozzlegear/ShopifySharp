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
    public sealed class FulfillmentConstraintRuleUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRuleUpdateUserError, FulfillmentConstraintRuleUpdateUserErrorQueryBuilder>
    {
        protected override FulfillmentConstraintRuleUpdateUserErrorQueryBuilder Self => this;

        public FulfillmentConstraintRuleUpdateUserErrorQueryBuilder() : this("fulfillmentConstraintRuleUpdateUserError")
        {
        }

        public FulfillmentConstraintRuleUpdateUserErrorQueryBuilder(string name) : base(new Query<FulfillmentConstraintRuleUpdateUserError>(name))
        {
        }

        public FulfillmentConstraintRuleUpdateUserErrorQueryBuilder(IQuery<FulfillmentConstraintRuleUpdateUserError> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentConstraintRuleUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentConstraintRuleUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}