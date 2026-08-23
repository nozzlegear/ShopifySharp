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
    public sealed class CashDrawerUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<CashDrawerUpdateUserError, CashDrawerUpdateUserErrorQueryBuilder>
    {
        protected override CashDrawerUpdateUserErrorQueryBuilder Self => this;

        public CashDrawerUpdateUserErrorQueryBuilder() : this("cashDrawerUpdateUserError")
        {
        }

        public CashDrawerUpdateUserErrorQueryBuilder(string name) : base(new Query<CashDrawerUpdateUserError>(name))
        {
        }

        public CashDrawerUpdateUserErrorQueryBuilder(IQuery<CashDrawerUpdateUserError> query) : base(query)
        {
        }

        public CashDrawerUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CashDrawerUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CashDrawerUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}