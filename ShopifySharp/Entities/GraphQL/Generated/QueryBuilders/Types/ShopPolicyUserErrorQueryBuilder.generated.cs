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
    public sealed class ShopPolicyUserErrorQueryBuilder : FieldsQueryBuilderBase<ShopPolicyUserError, ShopPolicyUserErrorQueryBuilder>
    {
        protected override ShopPolicyUserErrorQueryBuilder Self => this;

        public ShopPolicyUserErrorQueryBuilder() : this("shopPolicyUserError")
        {
        }

        public ShopPolicyUserErrorQueryBuilder(string name) : base(new Query<ShopPolicyUserError>(name))
        {
        }

        public ShopPolicyUserErrorQueryBuilder(IQuery<ShopPolicyUserError> query) : base(query)
        {
        }

        public ShopPolicyUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ShopPolicyUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ShopPolicyUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}