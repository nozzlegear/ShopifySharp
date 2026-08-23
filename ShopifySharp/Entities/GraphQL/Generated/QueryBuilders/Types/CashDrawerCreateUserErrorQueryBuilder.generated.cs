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
    public sealed class CashDrawerCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<CashDrawerCreateUserError, CashDrawerCreateUserErrorQueryBuilder>
    {
        protected override CashDrawerCreateUserErrorQueryBuilder Self => this;

        public CashDrawerCreateUserErrorQueryBuilder() : this("cashDrawerCreateUserError")
        {
        }

        public CashDrawerCreateUserErrorQueryBuilder(string name) : base(new Query<CashDrawerCreateUserError>(name))
        {
        }

        public CashDrawerCreateUserErrorQueryBuilder(IQuery<CashDrawerCreateUserError> query) : base(query)
        {
        }

        public CashDrawerCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CashDrawerCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CashDrawerCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}