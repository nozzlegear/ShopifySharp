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
    public sealed class HasStoreCreditAccountsInterfaceCasesBuilder : InterfaceCasesBuilderBase<IHasStoreCreditAccounts, HasStoreCreditAccountsInterfaceCasesBuilder>
    {
        protected override HasStoreCreditAccountsInterfaceCasesBuilder Self => this;

        public HasStoreCreditAccountsInterfaceCasesBuilder(string fieldName = "owner") : this(new Query<IHasStoreCreditAccounts>(fieldName))
        {
        }

        public HasStoreCreditAccountsInterfaceCasesBuilder(IQuery<IHasStoreCreditAccounts> query) : base(query)
        {
        }

        public HasStoreCreditAccountsInterfaceCasesBuilder OnCompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("... on CompanyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public HasStoreCreditAccountsInterfaceCasesBuilder OnCustomer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("... on Customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}