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
    public sealed class DraftOrderTagOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderTag, DraftOrderTagOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderTag>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DraftOrderTagArgumentsBuilder Arguments { get; }
        protected override DraftOrderTagOperationQueryBuilder Self => this;

        public DraftOrderTagOperationQueryBuilder() : this("draftOrderTag")
        {
        }

        public DraftOrderTagOperationQueryBuilder(string name) : base(new Query<DraftOrderTag>(name))
        {
            Arguments = new DraftOrderTagArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderTagOperationQueryBuilder(IQuery<DraftOrderTag> query) : base(query)
        {
            Arguments = new DraftOrderTagArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderTagOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public DraftOrderTagOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DraftOrderTagOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}