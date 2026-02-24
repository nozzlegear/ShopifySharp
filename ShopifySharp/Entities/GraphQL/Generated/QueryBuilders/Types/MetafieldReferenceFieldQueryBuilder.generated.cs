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
    public sealed class MetafieldReferenceFieldQueryBuilder : FieldsQueryBuilderBase<MetaobjectField, MetafieldReferenceFieldQueryBuilder>, IHasArguments<MetafieldReferenceFieldArgumentsBuilder>
    {
        public MetafieldReferenceFieldArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceFieldQueryBuilder Self => this;

        public MetafieldReferenceFieldQueryBuilder(string name) : base(new Query<MetaobjectField>(name))
        {
            Arguments = new MetafieldReferenceFieldArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceFieldQueryBuilder(IQuery<MetaobjectField> query) : base(query)
        {
            Arguments = new MetafieldReferenceFieldArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceFieldQueryBuilder SetArguments(Action<MetafieldReferenceFieldArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceFieldQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectFieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectFieldDefinition>(query);
            return this;
        }

        public MetafieldReferenceFieldQueryBuilder JsonValue()
        {
            base.InnerQuery.AddField("jsonValue");
            return this;
        }

        public MetafieldReferenceFieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldReferenceFieldQueryBuilder References(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceConnection>("references");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceConnection>(query);
            return this;
        }

        public MetafieldReferenceFieldQueryBuilder Thumbnail(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectThumbnailQueryBuilder> build)
        {
            var query = new Query<MetaobjectThumbnail>("thumbnail");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectThumbnailQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectThumbnail>(query);
            return this;
        }

        public MetafieldReferenceFieldQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MetafieldReferenceFieldQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }

        public MetafieldReferenceFieldQueryBuilder Reference(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("reference");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}