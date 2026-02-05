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
    public sealed class ShopifyqlTableDataQueryBuilder : FieldsQueryBuilderBase<ShopifyqlTableData, ShopifyqlTableDataQueryBuilder>
    {
        protected override ShopifyqlTableDataQueryBuilder Self => this;

        public ShopifyqlTableDataQueryBuilder() : this("shopifyqlTableData")
        {
        }

        public ShopifyqlTableDataQueryBuilder(string name) : base(new Query<ShopifyqlTableData>(name))
        {
        }

        public ShopifyqlTableDataQueryBuilder(IQuery<ShopifyqlTableData> query) : base(query)
        {
        }

        public ShopifyqlTableDataQueryBuilder Columns(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyqlTableDataColumnQueryBuilder> build)
        {
            var query = new Query<ShopifyqlTableDataColumn>("columns");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyqlTableDataColumnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyqlTableDataColumn>(query);
            return this;
        }

        public ShopifyqlTableDataQueryBuilder Rows()
        {
            base.InnerQuery.AddField("rows");
            return this;
        }
    }
}