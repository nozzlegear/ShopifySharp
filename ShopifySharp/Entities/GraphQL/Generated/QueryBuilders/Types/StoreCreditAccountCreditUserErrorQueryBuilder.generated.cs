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
    public sealed class StoreCreditAccountCreditUserErrorQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountCreditUserError, StoreCreditAccountCreditUserErrorQueryBuilder>
    {
        protected override StoreCreditAccountCreditUserErrorQueryBuilder Self => this;

        public StoreCreditAccountCreditUserErrorQueryBuilder() : this("storeCreditAccountCreditUserError")
        {
        }

        public StoreCreditAccountCreditUserErrorQueryBuilder(string name) : base(new Query<StoreCreditAccountCreditUserError>(name))
        {
        }

        public StoreCreditAccountCreditUserErrorQueryBuilder(IQuery<StoreCreditAccountCreditUserError> query) : base(query)
        {
        }

        public StoreCreditAccountCreditUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public StoreCreditAccountCreditUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public StoreCreditAccountCreditUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}