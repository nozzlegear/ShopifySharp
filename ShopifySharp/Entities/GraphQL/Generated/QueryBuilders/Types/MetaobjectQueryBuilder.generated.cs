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
    public sealed class MetaobjectQueryBuilder : FieldsQueryBuilderBase<Metaobject, MetaobjectQueryBuilder>
    {
        protected override MetaobjectQueryBuilder Self => this;

        public MetaobjectQueryBuilder() : this("metaobject")
        {
        }

        public MetaobjectQueryBuilder(string name) : base(new Query<Metaobject>(name))
        {
        }

        public MetaobjectQueryBuilder(IQuery<Metaobject> query) : base(query)
        {
        }

        public MetaobjectQueryBuilder Capabilities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectCapabilityDataQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilityData>("capabilities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectCapabilityDataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilityData>(query);
            return this;
        }

        public MetaobjectQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public MetaobjectQueryBuilder CreatedBy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("createdBy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public MetaobjectQueryBuilder CreatedByApp(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("createdByApp");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public MetaobjectQueryBuilder CreatedByStaff(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("createdByStaff");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public MetaobjectQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public MetaobjectQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public MetaobjectQueryBuilder Field(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder> build)
        {
            var query = new Query<MetaobjectField>("field");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectField>(query);
            return this;
        }

        public MetaobjectQueryBuilder Fields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder> build)
        {
            var query = new Query<MetaobjectField>("fields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectField>(query);
            return this;
        }

        public MetaobjectQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public MetaobjectQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetaobjectQueryBuilder ReferencedBy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldRelationConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldRelationConnection>("referencedBy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldRelationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldRelationConnection>(query);
            return this;
        }

        public MetaobjectQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public MetaobjectQueryBuilder ThumbnailField(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder> build)
        {
            var query = new Query<MetaobjectField>("thumbnailField");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectField>(query);
            return this;
        }

        public MetaobjectQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MetaobjectQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}