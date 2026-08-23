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
    public sealed class ShopifyqlNullCellTranslationQueryBuilder : FieldsQueryBuilderBase<ShopifyqlNullCellTranslation, ShopifyqlNullCellTranslationQueryBuilder>
    {
        protected override ShopifyqlNullCellTranslationQueryBuilder Self => this;

        public ShopifyqlNullCellTranslationQueryBuilder() : this("shopifyqlNullCellTranslation")
        {
        }

        public ShopifyqlNullCellTranslationQueryBuilder(string name) : base(new Query<ShopifyqlNullCellTranslation>(name))
        {
        }

        public ShopifyqlNullCellTranslationQueryBuilder(IQuery<ShopifyqlNullCellTranslation> query) : base(query)
        {
        }

        public ShopifyqlNullCellTranslationQueryBuilder ColumnName()
        {
            base.InnerQuery.AddField("columnName");
            return this;
        }

        public ShopifyqlNullCellTranslationQueryBuilder DisplayText()
        {
            base.InnerQuery.AddField("displayText");
            return this;
        }
    }
}