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
    public sealed class ShopifyqlTableDataColumnQueryBuilder : FieldsQueryBuilderBase<ShopifyqlTableDataColumn, ShopifyqlTableDataColumnQueryBuilder>
    {
        protected override ShopifyqlTableDataColumnQueryBuilder Self => this;

        public ShopifyqlTableDataColumnQueryBuilder() : this("shopifyqlTableDataColumn")
        {
        }

        public ShopifyqlTableDataColumnQueryBuilder(string name) : base(new Query<ShopifyqlTableDataColumn>(name))
        {
        }

        public ShopifyqlTableDataColumnQueryBuilder(IQuery<ShopifyqlTableDataColumn> query) : base(query)
        {
        }

        public ShopifyqlTableDataColumnQueryBuilder ColumnOrigin()
        {
            base.InnerQuery.AddField("columnOrigin");
            return this;
        }

        public ShopifyqlTableDataColumnQueryBuilder DataType()
        {
            base.InnerQuery.AddField("dataType");
            return this;
        }

        public ShopifyqlTableDataColumnQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public ShopifyqlTableDataColumnQueryBuilder DynamicColumnMetadata(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyqlDynamicColumnMetadataQueryBuilder> build)
        {
            var query = new Query<ShopifyqlDynamicColumnMetadata>("dynamicColumnMetadata");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyqlDynamicColumnMetadataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyqlDynamicColumnMetadata>(query);
            return this;
        }

        public ShopifyqlTableDataColumnQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ShopifyqlTableDataColumnQueryBuilder ShortDisplayName()
        {
            base.InnerQuery.AddField("shortDisplayName");
            return this;
        }

        public ShopifyqlTableDataColumnQueryBuilder SubType()
        {
            base.InnerQuery.AddField("subType");
            return this;
        }
    }
}