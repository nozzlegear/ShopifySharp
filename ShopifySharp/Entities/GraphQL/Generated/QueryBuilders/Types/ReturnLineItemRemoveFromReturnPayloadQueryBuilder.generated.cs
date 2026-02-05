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
    public sealed class ReturnLineItemRemoveFromReturnPayloadQueryBuilder : FieldsQueryBuilderBase<ReturnLineItemRemoveFromReturnPayload, ReturnLineItemRemoveFromReturnPayloadQueryBuilder>
    {
        protected override ReturnLineItemRemoveFromReturnPayloadQueryBuilder Self => this;

        public ReturnLineItemRemoveFromReturnPayloadQueryBuilder() : this("returnLineItemRemoveFromReturnPayload")
        {
        }

        public ReturnLineItemRemoveFromReturnPayloadQueryBuilder(string name) : base(new Query<ReturnLineItemRemoveFromReturnPayload>(name))
        {
        }

        public ReturnLineItemRemoveFromReturnPayloadQueryBuilder(IQuery<ReturnLineItemRemoveFromReturnPayload> query) : base(query)
        {
        }

        public ReturnLineItemRemoveFromReturnPayloadQueryBuilder Return(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnLineItemRemoveFromReturnPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}