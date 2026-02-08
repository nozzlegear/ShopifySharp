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
    public sealed class GiftCardsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, GiftCardsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public GiftCardsCountArgumentsBuilder Arguments { get; }
        protected override GiftCardsCountOperationQueryBuilder Self => this;

        public GiftCardsCountOperationQueryBuilder() : this("giftCardsCount")
        {
        }

        public GiftCardsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new GiftCardsCountArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new GiftCardsCountArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public GiftCardsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}