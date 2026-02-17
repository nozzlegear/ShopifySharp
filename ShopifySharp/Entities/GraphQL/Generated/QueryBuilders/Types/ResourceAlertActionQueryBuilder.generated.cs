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
    public sealed class ResourceAlertActionQueryBuilder : FieldsQueryBuilderBase<ResourceAlertAction, ResourceAlertActionQueryBuilder>
    {
        protected override ResourceAlertActionQueryBuilder Self => this;

        public ResourceAlertActionQueryBuilder() : this("resourceAlertAction")
        {
        }

        public ResourceAlertActionQueryBuilder(string name) : base(new Query<ResourceAlertAction>(name))
        {
        }

        public ResourceAlertActionQueryBuilder(IQuery<ResourceAlertAction> query) : base(query)
        {
        }

        public ResourceAlertActionQueryBuilder Primary()
        {
            base.InnerQuery.AddField("primary");
            return this;
        }

        public ResourceAlertActionQueryBuilder Show()
        {
            base.InnerQuery.AddField("show");
            return this;
        }

        public ResourceAlertActionQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ResourceAlertActionQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}