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
    public sealed class UnverifiedReturnLineItemQueryBuilder : FieldsQueryBuilderBase<UnverifiedReturnLineItem, UnverifiedReturnLineItemQueryBuilder>
    {
        protected override UnverifiedReturnLineItemQueryBuilder Self => this;

        public UnverifiedReturnLineItemQueryBuilder() : this("unverifiedReturnLineItem")
        {
        }

        public UnverifiedReturnLineItemQueryBuilder(string name) : base(new Query<UnverifiedReturnLineItem>(name))
        {
        }

        public UnverifiedReturnLineItemQueryBuilder(IQuery<UnverifiedReturnLineItem> query) : base(query)
        {
        }

        public UnverifiedReturnLineItemQueryBuilder CustomerNote()
        {
            base.InnerQuery.AddField("customerNote");
            return this;
        }

        public UnverifiedReturnLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public UnverifiedReturnLineItemQueryBuilder ProcessableQuantity()
        {
            base.InnerQuery.AddField("processableQuantity");
            return this;
        }

        public UnverifiedReturnLineItemQueryBuilder ProcessedQuantity()
        {
            base.InnerQuery.AddField("processedQuantity");
            return this;
        }

        public UnverifiedReturnLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public UnverifiedReturnLineItemQueryBuilder RefundableQuantity()
        {
            base.InnerQuery.AddField("refundableQuantity");
            return this;
        }

        public UnverifiedReturnLineItemQueryBuilder RefundedQuantity()
        {
            base.InnerQuery.AddField("refundedQuantity");
            return this;
        }

        [Obsolete("Use `returnReasonDefinition` instead. This field will be removed in the future.")]
        public UnverifiedReturnLineItemQueryBuilder ReturnReason()
        {
            base.InnerQuery.AddField("returnReason");
            return this;
        }

        public UnverifiedReturnLineItemQueryBuilder ReturnReasonDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinition>("returnReasonDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinition>(query);
            return this;
        }

        public UnverifiedReturnLineItemQueryBuilder ReturnReasonNote()
        {
            base.InnerQuery.AddField("returnReasonNote");
            return this;
        }

        public UnverifiedReturnLineItemQueryBuilder UnitPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public UnverifiedReturnLineItemQueryBuilder UnprocessedQuantity()
        {
            base.InnerQuery.AddField("unprocessedQuantity");
            return this;
        }
    }
}