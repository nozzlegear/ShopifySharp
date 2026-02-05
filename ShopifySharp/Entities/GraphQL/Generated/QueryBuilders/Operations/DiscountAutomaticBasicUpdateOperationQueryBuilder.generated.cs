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
    public sealed class DiscountAutomaticBasicUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticBasicUpdatePayload, DiscountAutomaticBasicUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticBasicUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountAutomaticBasicUpdateArgumentsBuilder Arguments { get; }
        protected override DiscountAutomaticBasicUpdateOperationQueryBuilder Self => this;

        public DiscountAutomaticBasicUpdateOperationQueryBuilder() : this("discountAutomaticBasicUpdate")
        {
        }

        public DiscountAutomaticBasicUpdateOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticBasicUpdatePayload>(name))
        {
            Arguments = new DiscountAutomaticBasicUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticBasicUpdateOperationQueryBuilder(IQuery<DiscountAutomaticBasicUpdatePayload> query) : base(query)
        {
            Arguments = new DiscountAutomaticBasicUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticBasicUpdateOperationQueryBuilder AutomaticDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("automaticDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public DiscountAutomaticBasicUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}