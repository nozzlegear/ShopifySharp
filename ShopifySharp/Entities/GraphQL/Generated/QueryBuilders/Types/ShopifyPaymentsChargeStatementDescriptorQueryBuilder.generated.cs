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
    public sealed class ShopifyPaymentsChargeStatementDescriptorQueryBuilder : FieldsQueryBuilderBase<IShopifyPaymentsChargeStatementDescriptor, ShopifyPaymentsChargeStatementDescriptorQueryBuilder>
    {
        protected override ShopifyPaymentsChargeStatementDescriptorQueryBuilder Self => this;

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder() : this("shopifyPaymentsChargeStatementDescriptor")
        {
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder(string name) : base(new Query<IShopifyPaymentsChargeStatementDescriptor>(name))
        {
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder(IQuery<IShopifyPaymentsChargeStatementDescriptor> query) : base(query)
        {
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder Default()
        {
            base.InnerQuery.AddField("default");
            return this;
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder Prefix()
        {
            base.InnerQuery.AddField("prefix");
            return this;
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder OnShopifyPaymentsDefaultChargeStatementDescriptor(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDefaultChargeStatementDescriptor>("... on ShopifyPaymentsDefaultChargeStatementDescriptor");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDefaultChargeStatementDescriptorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder OnShopifyPaymentsJpChargeStatementDescriptor(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsJpChargeStatementDescriptor>("... on ShopifyPaymentsJpChargeStatementDescriptor");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public ShopifyPaymentsChargeStatementDescriptorQueryBuilder ShopifyPaymentsChargeStatementDescriptor(Action<ShopifyPaymentsChargeStatementDescriptorInterfaceCasesBuilder> build)
        {
            var query = new Query<IShopifyPaymentsChargeStatementDescriptor>("shopifyPaymentsChargeStatementDescriptor");
            var unionBuilder = new ShopifyPaymentsChargeStatementDescriptorInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}