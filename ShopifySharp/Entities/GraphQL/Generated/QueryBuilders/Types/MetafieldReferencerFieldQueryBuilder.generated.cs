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
    public sealed class MetafieldReferencerFieldQueryBuilder : FieldsQueryBuilderBase<MetaobjectField, MetafieldReferencerFieldQueryBuilder>, IHasArguments<MetafieldReferencerFieldArgumentsBuilder>
    {
        public MetafieldReferencerFieldArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerFieldQueryBuilder Self => this;

        public MetafieldReferencerFieldQueryBuilder(string name) : base(new Query<MetaobjectField>(name))
        {
            Arguments = new MetafieldReferencerFieldArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerFieldQueryBuilder(IQuery<MetaobjectField> query) : base(query)
        {
            Arguments = new MetafieldReferencerFieldArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerFieldQueryBuilder SetArguments(Action<MetafieldReferencerFieldArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerFieldQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectFieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectFieldDefinition>(query);
            return this;
        }

        public MetafieldReferencerFieldQueryBuilder JsonValue()
        {
            base.InnerQuery.AddField("jsonValue");
            return this;
        }

        public MetafieldReferencerFieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldReferencerFieldQueryBuilder References(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldReferenceConnection>("references");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldReferenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldReferenceConnection>(query);
            return this;
        }

        public MetafieldReferencerFieldQueryBuilder Thumbnail(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectThumbnailQueryBuilder> build)
        {
            var query = new Query<MetaobjectThumbnail>("thumbnail");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectThumbnailQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectThumbnail>(query);
            return this;
        }

        public MetafieldReferencerFieldQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MetafieldReferencerFieldQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }

        public MetafieldReferencerFieldQueryBuilder Reference(Action<MetafieldReferenceUnionCasesBuilder> build)
        {
            var query = new Query<MetafieldReference>("reference");
            var unionBuilder = new MetafieldReferenceUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}