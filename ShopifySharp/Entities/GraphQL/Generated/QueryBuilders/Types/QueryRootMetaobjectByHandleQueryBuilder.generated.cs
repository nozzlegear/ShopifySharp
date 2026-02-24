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
    public sealed class QueryRootMetaobjectByHandleQueryBuilder : FieldsQueryBuilderBase<Metaobject, QueryRootMetaobjectByHandleQueryBuilder>, IHasArguments<QueryRootMetaobjectByHandleArgumentsBuilder>
    {
        public QueryRootMetaobjectByHandleArgumentsBuilder Arguments { get; }
        protected override QueryRootMetaobjectByHandleQueryBuilder Self => this;

        public QueryRootMetaobjectByHandleQueryBuilder(string name) : base(new Query<Metaobject>(name))
        {
            Arguments = new QueryRootMetaobjectByHandleArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMetaobjectByHandleQueryBuilder(IQuery<Metaobject> query) : base(query)
        {
            Arguments = new QueryRootMetaobjectByHandleArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMetaobjectByHandleQueryBuilder SetArguments(Action<QueryRootMetaobjectByHandleArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder Capabilities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectCapabilityDataQueryBuilder> build)
        {
            var query = new Query<MetaobjectCapabilityData>("capabilities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectCapabilityDataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectCapabilityData>(query);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder CreatedBy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("createdBy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder CreatedByApp(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("createdByApp");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder CreatedByStaff(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("createdByStaff");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder Field(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder> build)
        {
            var query = new Query<MetaobjectField>("field");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectField>(query);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder Fields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder> build)
        {
            var query = new Query<MetaobjectField>("fields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectField>(query);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder ReferencedBy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldRelationConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldRelationConnection>("referencedBy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldRelationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldRelationConnection>(query);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder ThumbnailField(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder> build)
        {
            var query = new Query<MetaobjectField>("thumbnailField");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectField>(query);
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public QueryRootMetaobjectByHandleQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}