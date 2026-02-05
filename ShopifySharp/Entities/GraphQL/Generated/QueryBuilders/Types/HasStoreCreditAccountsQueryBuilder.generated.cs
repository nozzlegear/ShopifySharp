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
    public sealed class HasStoreCreditAccountsQueryBuilder : FieldsQueryBuilderBase<IHasStoreCreditAccounts, HasStoreCreditAccountsQueryBuilder>
    {
        protected override HasStoreCreditAccountsQueryBuilder Self => this;

        public HasStoreCreditAccountsQueryBuilder() : this("hasStoreCreditAccounts")
        {
        }

        public HasStoreCreditAccountsQueryBuilder(string name) : base(new Query<IHasStoreCreditAccounts>(name))
        {
        }

        public HasStoreCreditAccountsQueryBuilder(IQuery<IHasStoreCreditAccounts> query) : base(query)
        {
        }

        public HasStoreCreditAccountsQueryBuilder StoreCreditAccounts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountConnection>("storeCreditAccounts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountConnection>(query);
            return this;
        }
    }
}