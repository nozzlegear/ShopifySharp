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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class MetaobjectDefinitionOperationQueryBuilder : FieldsQueryBuilderBase<MetaobjectDefinition, MetaobjectDefinitionOperationQueryBuilder>, IGraphOperationQueryBuilder<MetaobjectDefinition>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MetaobjectDefinitionArgumentsBuilder Arguments { get; }
        protected override MetaobjectDefinitionOperationQueryBuilder Self => this;

        public MetaobjectDefinitionOperationQueryBuilder() : this("metaobjectDefinition")
        {
        }

        public MetaobjectDefinitionOperationQueryBuilder(string name) : base(new Query<MetaobjectDefinition>(name))
        {
            Arguments = new MetaobjectDefinitionArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDefinitionOperationQueryBuilder(IQuery<MetaobjectDefinition> query) : base(query)
        {
            Arguments = new MetaobjectDefinitionArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDefinitionOperationQueryBuilder Access(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectAccessQueryBuilder> build)
        {
            var query = new Query<MetaobjectAccess>("access");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectAccessQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectAccess>(query);
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder Capabilities(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilitiesQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilities>("capabilities");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilitiesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilities>(query);
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder CreatedByApp(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("createdByApp");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder CreatedByStaff(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("createdByStaff");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder DisplayNameKey()
        {
            base.InnerQuery.AddField("displayNameKey");
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder FieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectFieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectFieldDefinition>("fieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectFieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectFieldDefinition>(query);
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder HasThumbnailField()
        {
            base.InnerQuery.AddField("hasThumbnailField");
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder Metaobjects(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectConnectionQueryBuilder> build)
        {
            var query = new Query<MetaobjectConnection>("metaobjects");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectConnection>(query);
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder MetaobjectsCount()
        {
            base.InnerQuery.AddField("metaobjectsCount");
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder StandardTemplate(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetaobjectDefinitionTemplateQueryBuilder> build)
        {
            var query = new Query<StandardMetaobjectDefinitionTemplate>("standardTemplate");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardMetaobjectDefinitionTemplateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetaobjectDefinitionTemplate>(query);
            return this;
        }

        public MetaobjectDefinitionOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}