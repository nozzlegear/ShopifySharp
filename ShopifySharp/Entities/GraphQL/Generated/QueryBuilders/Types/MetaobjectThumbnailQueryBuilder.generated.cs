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
    public sealed class MetaobjectThumbnailQueryBuilder : FieldsQueryBuilderBase<MetaobjectThumbnail, MetaobjectThumbnailQueryBuilder>
    {
        protected override MetaobjectThumbnailQueryBuilder Self => this;

        public MetaobjectThumbnailQueryBuilder() : this("metaobjectThumbnail")
        {
        }

        public MetaobjectThumbnailQueryBuilder(string name) : base(new Query<MetaobjectThumbnail>(name))
        {
        }

        public MetaobjectThumbnailQueryBuilder(IQuery<MetaobjectThumbnail> query) : base(query)
        {
        }

        public MetaobjectThumbnailQueryBuilder File(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileQueryBuilder> build)
        {
            var query = new Query<IFile>("file");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IFile>(query);
            return this;
        }

        public MetaobjectThumbnailQueryBuilder Hex()
        {
            base.InnerQuery.AddField("hex");
            return this;
        }
    }
}