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
    public sealed class DiscountAutomaticAppCreateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticAppCreatePayload, DiscountAutomaticAppCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticAppCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountAutomaticAppCreateArgumentsBuilder Arguments { get; }
        protected override DiscountAutomaticAppCreateOperationQueryBuilder Self => this;

        public DiscountAutomaticAppCreateOperationQueryBuilder() : this("discountAutomaticAppCreate")
        {
        }

        public DiscountAutomaticAppCreateOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticAppCreatePayload>(name))
        {
            Arguments = new DiscountAutomaticAppCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticAppCreateOperationQueryBuilder(IQuery<DiscountAutomaticAppCreatePayload> query) : base(query)
        {
            Arguments = new DiscountAutomaticAppCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticAppCreateOperationQueryBuilder AutomaticAppDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticApp>("automaticAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticApp>(query);
            return this;
        }

        public DiscountAutomaticAppCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}