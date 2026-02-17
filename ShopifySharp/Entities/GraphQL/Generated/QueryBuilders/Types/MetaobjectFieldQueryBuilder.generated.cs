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
    public sealed class MetaobjectFieldQueryBuilder : FieldsQueryBuilderBase<MetaobjectField, MetaobjectFieldQueryBuilder>
    {
        protected override MetaobjectFieldQueryBuilder Self => this;

        public MetaobjectFieldQueryBuilder() : this("metaobjectField")
        {
        }

        public MetaobjectFieldQueryBuilder(string name) : base(new Query<MetaobjectField>(name))
        {
        }

        public MetaobjectFieldQueryBuilder(IQuery<MetaobjectField> query) : base(query)
        {
        }

        public MetaobjectFieldQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectFieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectFieldDefinition>(query);
            return this;
        }

        public MetaobjectFieldQueryBuilder JsonValue()
        {
            base.InnerQuery.AddField("jsonValue");
            return this;
        }

        public MetaobjectFieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetaobjectFieldQueryBuilder References(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceConnection>("references");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceConnection>(query);
            return this;
        }

        public MetaobjectFieldQueryBuilder Thumbnail(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectThumbnailQueryBuilder> build)
        {
            var query = new Query<MetaobjectThumbnail>("thumbnail");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectThumbnailQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectThumbnail>(query);
            return this;
        }

        public MetaobjectFieldQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MetaobjectFieldQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }

        public MetaobjectFieldQueryBuilder Reference(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("reference");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}