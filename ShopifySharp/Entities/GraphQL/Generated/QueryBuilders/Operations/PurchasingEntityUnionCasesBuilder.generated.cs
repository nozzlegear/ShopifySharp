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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PurchasingEntityUnionCasesBuilder : UnionCasesBuilderBase<PurchasingEntity, PurchasingEntityUnionCasesBuilder>
    {
        protected override PurchasingEntityUnionCasesBuilder Self => this;

        public PurchasingEntityUnionCasesBuilder(string fieldName = "purchasingEntity") : this(new Query<PurchasingEntity>(fieldName))
        {
        }

        public PurchasingEntityUnionCasesBuilder(IQuery<PurchasingEntity> query) : base(query)
        {
        }

        public PurchasingEntityUnionCasesBuilder OnCustomer(Action<CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("... on Customer");
            var queryBuilder = new CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PurchasingEntityUnionCasesBuilder OnPurchasingCompany(Action<PurchasingCompanyQueryBuilder> build)
        {
            var query = new Query<PurchasingCompany>("... on PurchasingCompany");
            var queryBuilder = new PurchasingCompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}