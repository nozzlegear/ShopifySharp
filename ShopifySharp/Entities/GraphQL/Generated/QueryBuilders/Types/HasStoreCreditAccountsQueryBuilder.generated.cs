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

        public HasStoreCreditAccountsQueryBuilder StoreCreditAccounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountConnection>("storeCreditAccounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountConnection>(query);
            return this;
        }

        public HasStoreCreditAccountsQueryBuilder OnCompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("... on CompanyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasStoreCreditAccountsQueryBuilder OnCustomer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("... on Customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasStoreCreditAccountsQueryBuilder HasStoreCreditAccounts(Action<HasStoreCreditAccountsInterfaceCasesBuilder> build)
        {
            var query = new Query<IHasStoreCreditAccounts>("hasStoreCreditAccounts");
            var unionBuilder = new HasStoreCreditAccountsInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}