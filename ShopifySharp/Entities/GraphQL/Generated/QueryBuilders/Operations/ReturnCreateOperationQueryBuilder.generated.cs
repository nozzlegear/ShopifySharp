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
    public sealed class ReturnCreateOperationQueryBuilder : FieldsQueryBuilderBase<ReturnCreatePayload, ReturnCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReturnCreateArgumentsBuilder Arguments { get; }
        protected override ReturnCreateOperationQueryBuilder Self => this;

        public ReturnCreateOperationQueryBuilder() : this("returnCreate")
        {
        }

        public ReturnCreateOperationQueryBuilder(string name) : base(new Query<ReturnCreatePayload>(name))
        {
            Arguments = new ReturnCreateArgumentsBuilder(base.InnerQuery);
        }

        public ReturnCreateOperationQueryBuilder(IQuery<ReturnCreatePayload> query) : base(query)
        {
            Arguments = new ReturnCreateArgumentsBuilder(base.InnerQuery);
        }

        public ReturnCreateOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}