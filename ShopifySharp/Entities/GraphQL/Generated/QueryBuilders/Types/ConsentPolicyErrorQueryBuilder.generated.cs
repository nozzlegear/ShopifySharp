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
    public sealed class ConsentPolicyErrorQueryBuilder : FieldsQueryBuilderBase<ConsentPolicyError, ConsentPolicyErrorQueryBuilder>
    {
        protected override ConsentPolicyErrorQueryBuilder Self => this;

        public ConsentPolicyErrorQueryBuilder() : this("consentPolicyError")
        {
        }

        public ConsentPolicyErrorQueryBuilder(string name) : base(new Query<ConsentPolicyError>(name))
        {
        }

        public ConsentPolicyErrorQueryBuilder(IQuery<ConsentPolicyError> query) : base(query)
        {
        }

        public ConsentPolicyErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ConsentPolicyErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ConsentPolicyErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}