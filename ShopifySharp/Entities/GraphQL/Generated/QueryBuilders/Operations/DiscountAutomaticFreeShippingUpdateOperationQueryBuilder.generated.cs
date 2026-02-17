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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DiscountAutomaticFreeShippingUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticFreeShippingUpdatePayload, DiscountAutomaticFreeShippingUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticFreeShippingUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountAutomaticFreeShippingUpdateArgumentsBuilder Arguments { get; }
        protected override DiscountAutomaticFreeShippingUpdateOperationQueryBuilder Self => this;

        public DiscountAutomaticFreeShippingUpdateOperationQueryBuilder() : this("discountAutomaticFreeShippingUpdate")
        {
        }

        public DiscountAutomaticFreeShippingUpdateOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticFreeShippingUpdatePayload>(name))
        {
            Arguments = new DiscountAutomaticFreeShippingUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticFreeShippingUpdateOperationQueryBuilder(IQuery<DiscountAutomaticFreeShippingUpdatePayload> query) : base(query)
        {
            Arguments = new DiscountAutomaticFreeShippingUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticFreeShippingUpdateOperationQueryBuilder AutomaticDiscountNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("automaticDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public DiscountAutomaticFreeShippingUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}