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
    public sealed class DiscountAutomaticBxgyUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticBxgyUpdatePayload, DiscountAutomaticBxgyUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticBxgyUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountAutomaticBxgyUpdateArgumentsBuilder Arguments { get; }
        protected override DiscountAutomaticBxgyUpdateOperationQueryBuilder Self => this;

        public DiscountAutomaticBxgyUpdateOperationQueryBuilder() : this("discountAutomaticBxgyUpdate")
        {
        }

        public DiscountAutomaticBxgyUpdateOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticBxgyUpdatePayload>(name))
        {
            Arguments = new DiscountAutomaticBxgyUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticBxgyUpdateOperationQueryBuilder(IQuery<DiscountAutomaticBxgyUpdatePayload> query) : base(query)
        {
            Arguments = new DiscountAutomaticBxgyUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticBxgyUpdateOperationQueryBuilder AutomaticDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("automaticDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public DiscountAutomaticBxgyUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}