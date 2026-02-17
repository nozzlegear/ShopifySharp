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
    public sealed class ResourceAlertQueryBuilder : FieldsQueryBuilderBase<ResourceAlert, ResourceAlertQueryBuilder>
    {
        protected override ResourceAlertQueryBuilder Self => this;

        public ResourceAlertQueryBuilder() : this("resourceAlert")
        {
        }

        public ResourceAlertQueryBuilder(string name) : base(new Query<ResourceAlert>(name))
        {
        }

        public ResourceAlertQueryBuilder(IQuery<ResourceAlert> query) : base(query)
        {
        }

        public ResourceAlertQueryBuilder Actions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourceAlertActionQueryBuilder> build)
        {
            var query = new Query<ResourceAlertAction>("actions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourceAlertActionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourceAlertAction>(query);
            return this;
        }

        public ResourceAlertQueryBuilder Content()
        {
            base.InnerQuery.AddField("content");
            return this;
        }

        public ResourceAlertQueryBuilder DismissibleHandle()
        {
            base.InnerQuery.AddField("dismissibleHandle");
            return this;
        }

        public ResourceAlertQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }

        public ResourceAlertQueryBuilder Severity()
        {
            base.InnerQuery.AddField("severity");
            return this;
        }

        public ResourceAlertQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}