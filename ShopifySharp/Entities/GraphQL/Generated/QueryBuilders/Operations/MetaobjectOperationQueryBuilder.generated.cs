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
    public sealed class MetaobjectOperationQueryBuilder : FieldsQueryBuilderBase<Metaobject, MetaobjectOperationQueryBuilder>, IGraphOperationQueryBuilder<Metaobject>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MetaobjectArgumentsBuilder Arguments { get; }
        protected override MetaobjectOperationQueryBuilder Self => this;

        public MetaobjectOperationQueryBuilder() : this("metaobject")
        {
        }

        public MetaobjectOperationQueryBuilder(string name) : base(new Query<Metaobject>(name))
        {
            Arguments = new MetaobjectArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectOperationQueryBuilder(IQuery<Metaobject> query) : base(query)
        {
            Arguments = new MetaobjectArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectOperationQueryBuilder Capabilities(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilityDataQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilityData>("capabilities");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectCapabilityDataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilityData>(query);
            return this;
        }

        public MetaobjectOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public MetaobjectOperationQueryBuilder CreatedBy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("createdBy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public MetaobjectOperationQueryBuilder CreatedByApp(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("createdByApp");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public MetaobjectOperationQueryBuilder CreatedByStaff(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("createdByStaff");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public MetaobjectOperationQueryBuilder Definition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public MetaobjectOperationQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public MetaobjectOperationQueryBuilder Field(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectFieldQueryBuilder> build)
        {
            var query = new Query<MetaobjectField>("field");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectField>(query);
            return this;
        }

        public MetaobjectOperationQueryBuilder Fields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectFieldQueryBuilder> build)
        {
            var query = new Query<MetaobjectField>("fields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectField>(query);
            return this;
        }

        public MetaobjectOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public MetaobjectOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetaobjectOperationQueryBuilder ReferencedBy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldRelationConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldRelationConnection>("referencedBy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldRelationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldRelationConnection>(query);
            return this;
        }

        public MetaobjectOperationQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public MetaobjectOperationQueryBuilder ThumbnailField(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectFieldQueryBuilder> build)
        {
            var query = new Query<MetaobjectField>("thumbnailField");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectField>(query);
            return this;
        }

        public MetaobjectOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MetaobjectOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}