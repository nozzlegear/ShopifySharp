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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class RowCountQueryBuilder : FieldsQueryBuilderBase<RowCount, RowCountQueryBuilder>
    {
        protected override RowCountQueryBuilder Self => this;

        public RowCountQueryBuilder() : this("rowCount")
        {
        }

        public RowCountQueryBuilder(string name) : base(new Query<RowCount>(name))
        {
        }

        public RowCountQueryBuilder(IQuery<RowCount> query) : base(query)
        {
        }

        public RowCountQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public RowCountQueryBuilder ExceedsMax()
        {
            base.InnerQuery.AddField("exceedsMax");
            return this;
        }
    }
}