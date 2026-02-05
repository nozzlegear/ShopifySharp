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
    public sealed class StoreCreditAccountDebitUserErrorQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountDebitUserError, StoreCreditAccountDebitUserErrorQueryBuilder>
    {
        protected override StoreCreditAccountDebitUserErrorQueryBuilder Self => this;

        public StoreCreditAccountDebitUserErrorQueryBuilder() : this("storeCreditAccountDebitUserError")
        {
        }

        public StoreCreditAccountDebitUserErrorQueryBuilder(string name) : base(new Query<StoreCreditAccountDebitUserError>(name))
        {
        }

        public StoreCreditAccountDebitUserErrorQueryBuilder(IQuery<StoreCreditAccountDebitUserError> query) : base(query)
        {
        }

        public StoreCreditAccountDebitUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public StoreCreditAccountDebitUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public StoreCreditAccountDebitUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}