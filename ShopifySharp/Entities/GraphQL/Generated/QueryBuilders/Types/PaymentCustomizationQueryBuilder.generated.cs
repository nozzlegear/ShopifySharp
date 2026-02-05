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
    public sealed class PaymentCustomizationQueryBuilder : FieldsQueryBuilderBase<PaymentCustomization, PaymentCustomizationQueryBuilder>
    {
        protected override PaymentCustomizationQueryBuilder Self => this;

        public PaymentCustomizationQueryBuilder() : this("paymentCustomization")
        {
        }

        public PaymentCustomizationQueryBuilder(string name) : base(new Query<PaymentCustomization>(name))
        {
        }

        public PaymentCustomizationQueryBuilder(IQuery<PaymentCustomization> query) : base(query)
        {
        }

        public PaymentCustomizationQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }

        public PaymentCustomizationQueryBuilder ErrorHistory(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsErrorHistoryQueryBuilder> build)
        {
            var query = new Query<FunctionsErrorHistory>("errorHistory");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsErrorHistoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsErrorHistory>(query);
            return this;
        }

        public PaymentCustomizationQueryBuilder FunctionId()
        {
            base.InnerQuery.AddField("functionId");
            return this;
        }

        public PaymentCustomizationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PaymentCustomizationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public PaymentCustomizationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public PaymentCustomizationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public PaymentCustomizationQueryBuilder ShopifyFunction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder> build)
        {
            var query = new Query<ShopifyFunction>("shopifyFunction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunction>(query);
            return this;
        }

        public PaymentCustomizationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}