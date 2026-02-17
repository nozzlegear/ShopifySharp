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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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