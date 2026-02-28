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
    public sealed class MetaobjectFieldDefinitionCapabilitiesQueryBuilder : FieldsQueryBuilderBase<MetaobjectFieldDefinitionCapabilities, MetaobjectFieldDefinitionCapabilitiesQueryBuilder>
    {
        protected override MetaobjectFieldDefinitionCapabilitiesQueryBuilder Self => this;

        public MetaobjectFieldDefinitionCapabilitiesQueryBuilder() : this("metaobjectFieldDefinitionCapabilities")
        {
        }

        public MetaobjectFieldDefinitionCapabilitiesQueryBuilder(string name) : base(new Query<MetaobjectFieldDefinitionCapabilities>(name))
        {
        }

        public MetaobjectFieldDefinitionCapabilitiesQueryBuilder(IQuery<MetaobjectFieldDefinitionCapabilities> query) : base(query)
        {
        }

        public MetaobjectFieldDefinitionCapabilitiesQueryBuilder AdminFilterable(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldCapabilityAdminFilterableQueryBuilder> build)
        {
            var query = new Query<MetaobjectFieldCapabilityAdminFilterable>("adminFilterable");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldCapabilityAdminFilterableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectFieldCapabilityAdminFilterable>(query);
            return this;
        }
    }
}