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
    public sealed class FlowGenerateSignaturePayloadQueryBuilder : FieldsQueryBuilderBase<FlowGenerateSignaturePayload, FlowGenerateSignaturePayloadQueryBuilder>
    {
        protected override FlowGenerateSignaturePayloadQueryBuilder Self => this;

        public FlowGenerateSignaturePayloadQueryBuilder() : this("flowGenerateSignaturePayload")
        {
        }

        public FlowGenerateSignaturePayloadQueryBuilder(string name) : base(new Query<FlowGenerateSignaturePayload>(name))
        {
        }

        public FlowGenerateSignaturePayloadQueryBuilder(IQuery<FlowGenerateSignaturePayload> query) : base(query)
        {
        }

        public FlowGenerateSignaturePayloadQueryBuilder Payload()
        {
            base.InnerQuery.AddField("payload");
            return this;
        }

        public FlowGenerateSignaturePayloadQueryBuilder Signature()
        {
            base.InnerQuery.AddField("signature");
            return this;
        }

        public FlowGenerateSignaturePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}