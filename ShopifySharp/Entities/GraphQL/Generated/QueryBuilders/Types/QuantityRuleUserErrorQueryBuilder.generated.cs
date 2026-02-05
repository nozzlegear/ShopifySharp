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
    public sealed class QuantityRuleUserErrorQueryBuilder : FieldsQueryBuilderBase<QuantityRuleUserError, QuantityRuleUserErrorQueryBuilder>
    {
        protected override QuantityRuleUserErrorQueryBuilder Self => this;

        public QuantityRuleUserErrorQueryBuilder() : this("quantityRuleUserError")
        {
        }

        public QuantityRuleUserErrorQueryBuilder(string name) : base(new Query<QuantityRuleUserError>(name))
        {
        }

        public QuantityRuleUserErrorQueryBuilder(IQuery<QuantityRuleUserError> query) : base(query)
        {
        }

        public QuantityRuleUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public QuantityRuleUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public QuantityRuleUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}