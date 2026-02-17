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

        public MetaobjectThumbnailQueryBuilder File(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FileQueryBuilder> build)
        {
            var query = new Query<IFile>("file");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FileQueryBuilder(query);
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