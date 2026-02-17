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
    public sealed class FulfillmentServiceDeleteOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentServiceDeletePayload, FulfillmentServiceDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentServiceDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentServiceDeleteArgumentsBuilder Arguments { get; }
        protected override FulfillmentServiceDeleteOperationQueryBuilder Self => this;

        public FulfillmentServiceDeleteOperationQueryBuilder() : this("fulfillmentServiceDelete")
        {
        }

        public FulfillmentServiceDeleteOperationQueryBuilder(string name) : base(new Query<FulfillmentServiceDeletePayload>(name))
        {
            Arguments = new FulfillmentServiceDeleteArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentServiceDeleteOperationQueryBuilder(IQuery<FulfillmentServiceDeletePayload> query) : base(query)
        {
            Arguments = new FulfillmentServiceDeleteArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentServiceDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public FulfillmentServiceDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}