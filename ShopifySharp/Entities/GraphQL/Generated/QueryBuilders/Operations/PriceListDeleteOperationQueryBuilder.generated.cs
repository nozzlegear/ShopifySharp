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
    public sealed class PriceListDeleteOperationQueryBuilder : FieldsQueryBuilderBase<PriceListDeletePayload, PriceListDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<PriceListDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PriceListDeleteArgumentsBuilder Arguments { get; }
        protected override PriceListDeleteOperationQueryBuilder Self => this;

        public PriceListDeleteOperationQueryBuilder() : this("priceListDelete")
        {
        }

        public PriceListDeleteOperationQueryBuilder(string name) : base(new Query<PriceListDeletePayload>(name))
        {
            Arguments = new PriceListDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PriceListDeleteOperationQueryBuilder(IQuery<PriceListDeletePayload> query) : base(query)
        {
            Arguments = new PriceListDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PriceListDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public PriceListDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListUserError>(query);
            return this;
        }
    }
}