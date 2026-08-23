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
    public sealed class ShopifyPaymentsChargeStatementDescriptorInterfaceCasesBuilder : InterfaceCasesBuilderBase<IShopifyPaymentsChargeStatementDescriptor, ShopifyPaymentsChargeStatementDescriptorInterfaceCasesBuilder>
    {
        protected override ShopifyPaymentsChargeStatementDescriptorInterfaceCasesBuilder Self => this;

        public ShopifyPaymentsChargeStatementDescriptorInterfaceCasesBuilder(string fieldName = "shopifyPaymentsChargeStatementDescriptor") : this(new Query<IShopifyPaymentsChargeStatementDescriptor>(fieldName))
        {
        }

        public ShopifyPaymentsChargeStatementDescriptorInterfaceCasesBuilder(IQuery<IShopifyPaymentsChargeStatementDescriptor> query) : base(query)
        {
        }

        public ShopifyPaymentsChargeStatementDescriptorInterfaceCasesBuilder OnShopifyPaymentsDefaultChargeStatementDescriptor(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDefaultChargeStatementDescriptor>("... on ShopifyPaymentsDefaultChargeStatementDescriptor");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public ShopifyPaymentsChargeStatementDescriptorInterfaceCasesBuilder OnShopifyPaymentsJpChargeStatementDescriptor(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsJpChargeStatementDescriptor>("... on ShopifyPaymentsJpChargeStatementDescriptor");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}