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
    public sealed class ShopifyqlRowMetadataQueryBuilder : FieldsQueryBuilderBase<ShopifyqlRowMetadata, ShopifyqlRowMetadataQueryBuilder>
    {
        protected override ShopifyqlRowMetadataQueryBuilder Self => this;

        public ShopifyqlRowMetadataQueryBuilder() : this("shopifyqlRowMetadata")
        {
        }

        public ShopifyqlRowMetadataQueryBuilder(string name) : base(new Query<ShopifyqlRowMetadata>(name))
        {
        }

        public ShopifyqlRowMetadataQueryBuilder(IQuery<ShopifyqlRowMetadata> query) : base(query)
        {
        }

        public ShopifyqlRowMetadataQueryBuilder NullCellTranslations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyqlNullCellTranslationQueryBuilder> build)
        {
            var query = new Query<ShopifyqlNullCellTranslation>("nullCellTranslations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyqlNullCellTranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyqlNullCellTranslation>(query);
            return this;
        }

        public ShopifyqlRowMetadataQueryBuilder RawResourceIds()
        {
            base.InnerQuery.AddField("rawResourceIds");
            return this;
        }

        public ShopifyqlRowMetadataQueryBuilder TopNRemainderColumnNames()
        {
            base.InnerQuery.AddField("topNRemainderColumnNames");
            return this;
        }
    }
}