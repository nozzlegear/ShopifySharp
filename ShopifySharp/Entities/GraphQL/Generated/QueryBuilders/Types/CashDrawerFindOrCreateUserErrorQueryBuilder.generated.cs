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
    public sealed class CashDrawerFindOrCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<CashDrawerFindOrCreateUserError, CashDrawerFindOrCreateUserErrorQueryBuilder>
    {
        protected override CashDrawerFindOrCreateUserErrorQueryBuilder Self => this;

        public CashDrawerFindOrCreateUserErrorQueryBuilder() : this("cashDrawerFindOrCreateUserError")
        {
        }

        public CashDrawerFindOrCreateUserErrorQueryBuilder(string name) : base(new Query<CashDrawerFindOrCreateUserError>(name))
        {
        }

        public CashDrawerFindOrCreateUserErrorQueryBuilder(IQuery<CashDrawerFindOrCreateUserError> query) : base(query)
        {
        }

        public CashDrawerFindOrCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CashDrawerFindOrCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CashDrawerFindOrCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}