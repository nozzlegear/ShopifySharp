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
    public sealed class MetaobjectDefinitionQueryBuilder : FieldsQueryBuilderBase<MetaobjectDefinition, MetaobjectDefinitionQueryBuilder>
    {
        protected override MetaobjectDefinitionQueryBuilder Self => this;

        public MetaobjectDefinitionQueryBuilder() : this("metaobjectDefinition")
        {
        }

        public MetaobjectDefinitionQueryBuilder(string name) : base(new Query<MetaobjectDefinition>(name))
        {
        }

        public MetaobjectDefinitionQueryBuilder(IQuery<MetaobjectDefinition> query) : base(query)
        {
        }

        public MetaobjectDefinitionQueryBuilder Access(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectAccessQueryBuilder> build)
        {
            var query = new Query<MetaobjectAccess>("access");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectAccessQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectAccess>(query);
            return this;
        }

        public MetaobjectDefinitionQueryBuilder Capabilities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectCapabilitiesQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilities>("capabilities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectCapabilitiesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilities>(query);
            return this;
        }

        public MetaobjectDefinitionQueryBuilder CreatedByApp(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("createdByApp");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public MetaobjectDefinitionQueryBuilder CreatedByStaff(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("createdByStaff");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public MetaobjectDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public MetaobjectDefinitionQueryBuilder DisplayNameKey()
        {
            base.InnerQuery.AddField("displayNameKey");
            return this;
        }

        public MetaobjectDefinitionQueryBuilder FieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectFieldDefinition>("fieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectFieldDefinition>(query);
            return this;
        }

        public MetaobjectDefinitionQueryBuilder HasThumbnailField()
        {
            base.InnerQuery.AddField("hasThumbnailField");
            return this;
        }

        public MetaobjectDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetaobjectDefinitionQueryBuilder Metaobjects(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectConnectionQueryBuilder> build)
        {
            var query = new Query<MetaobjectConnection>("metaobjects");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectConnection>(query);
            return this;
        }

        public MetaobjectDefinitionQueryBuilder MetaobjectsCount()
        {
            base.InnerQuery.AddField("metaobjectsCount");
            return this;
        }

        public MetaobjectDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetaobjectDefinitionQueryBuilder StandardTemplate(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StandardMetaobjectDefinitionTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetaobjectDefinitionTemplate>("standardTemplate");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StandardMetaobjectDefinitionTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetaobjectDefinitionTemplate>(query);
            return this;
        }

        public MetaobjectDefinitionQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}