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
    public sealed class AbandonedCheckoutsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, AbandonedCheckoutsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AbandonedCheckoutsCountArgumentsBuilder Arguments { get; }
        protected override AbandonedCheckoutsCountOperationQueryBuilder Self => this;

        public AbandonedCheckoutsCountOperationQueryBuilder() : this("abandonedCheckoutsCount")
        {
        }

        public AbandonedCheckoutsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new AbandonedCheckoutsCountArgumentsBuilder(base.InnerQuery);
        }

        public AbandonedCheckoutsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new AbandonedCheckoutsCountArgumentsBuilder(base.InnerQuery);
        }

        public AbandonedCheckoutsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public AbandonedCheckoutsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}