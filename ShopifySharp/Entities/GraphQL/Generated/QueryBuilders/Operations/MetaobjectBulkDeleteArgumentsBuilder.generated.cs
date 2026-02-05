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
    public sealed class MetaobjectBulkDeleteArgumentsBuilder : ArgumentsBuilderBase<MetaobjectBulkDeletePayload, MetaobjectBulkDeleteArgumentsBuilder>
    {
        protected override MetaobjectBulkDeleteArgumentsBuilder Self => this;

        public MetaobjectBulkDeleteArgumentsBuilder(IQuery<MetaobjectBulkDeletePayload> query) : base(query)
        {
        }

        public MetaobjectBulkDeleteArgumentsBuilder Where(MetaobjectBulkDeleteWhereCondition? @where)
        {
            base.InnerQuery.AddArgument("where", @where);
            return this;
        }
    }
}