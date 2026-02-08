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
    public sealed class FlowGenerateSignatureOperationQueryBuilder : FieldsQueryBuilderBase<FlowGenerateSignaturePayload, FlowGenerateSignatureOperationQueryBuilder>, IGraphOperationQueryBuilder<FlowGenerateSignaturePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FlowGenerateSignatureArgumentsBuilder Arguments { get; }
        protected override FlowGenerateSignatureOperationQueryBuilder Self => this;

        public FlowGenerateSignatureOperationQueryBuilder() : this("flowGenerateSignature")
        {
        }

        public FlowGenerateSignatureOperationQueryBuilder(string name) : base(new Query<FlowGenerateSignaturePayload>(name))
        {
            Arguments = new FlowGenerateSignatureArgumentsBuilder(base.InnerQuery);
        }

        public FlowGenerateSignatureOperationQueryBuilder(IQuery<FlowGenerateSignaturePayload> query) : base(query)
        {
            Arguments = new FlowGenerateSignatureArgumentsBuilder(base.InnerQuery);
        }

        public FlowGenerateSignatureOperationQueryBuilder Payload()
        {
            base.InnerQuery.AddField("payload");
            return this;
        }

        public FlowGenerateSignatureOperationQueryBuilder Signature()
        {
            base.InnerQuery.AddField("signature");
            return this;
        }

        public FlowGenerateSignatureOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}