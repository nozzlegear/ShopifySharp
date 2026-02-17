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
    public sealed class ReturnLineItemTypeQueryBuilder : FieldsQueryBuilderBase<IReturnLineItemType, ReturnLineItemTypeQueryBuilder>
    {
        protected override ReturnLineItemTypeQueryBuilder Self => this;

        public ReturnLineItemTypeQueryBuilder() : this("returnLineItemType")
        {
        }

        public ReturnLineItemTypeQueryBuilder(string name) : base(new Query<IReturnLineItemType>(name))
        {
        }

        public ReturnLineItemTypeQueryBuilder(IQuery<IReturnLineItemType> query) : base(query)
        {
        }

        public ReturnLineItemTypeQueryBuilder CustomerNote()
        {
            base.InnerQuery.AddField("customerNote");
            return this;
        }

        public ReturnLineItemTypeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReturnLineItemTypeQueryBuilder ProcessableQuantity()
        {
            base.InnerQuery.AddField("processableQuantity");
            return this;
        }

        public ReturnLineItemTypeQueryBuilder ProcessedQuantity()
        {
            base.InnerQuery.AddField("processedQuantity");
            return this;
        }

        public ReturnLineItemTypeQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public ReturnLineItemTypeQueryBuilder RefundableQuantity()
        {
            base.InnerQuery.AddField("refundableQuantity");
            return this;
        }

        public ReturnLineItemTypeQueryBuilder RefundedQuantity()
        {
            base.InnerQuery.AddField("refundedQuantity");
            return this;
        }

        [Obsolete("Use `returnReasonDefinition` instead. This field will be removed in the future.")]
        public ReturnLineItemTypeQueryBuilder ReturnReason()
        {
            base.InnerQuery.AddField("returnReason");
            return this;
        }

        public ReturnLineItemTypeQueryBuilder ReturnReasonDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinition>("returnReasonDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinition>(query);
            return this;
        }

        public ReturnLineItemTypeQueryBuilder ReturnReasonNote()
        {
            base.InnerQuery.AddField("returnReasonNote");
            return this;
        }

        public ReturnLineItemTypeQueryBuilder UnprocessedQuantity()
        {
            base.InnerQuery.AddField("unprocessedQuantity");
            return this;
        }
    }
}