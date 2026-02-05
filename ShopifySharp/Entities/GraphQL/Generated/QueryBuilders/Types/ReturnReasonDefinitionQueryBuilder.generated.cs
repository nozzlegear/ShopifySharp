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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ReturnReasonDefinitionQueryBuilder : FieldsQueryBuilderBase<ReturnReasonDefinition, ReturnReasonDefinitionQueryBuilder>
    {
        protected override ReturnReasonDefinitionQueryBuilder Self => this;

        public ReturnReasonDefinitionQueryBuilder() : this("returnReasonDefinition")
        {
        }

        public ReturnReasonDefinitionQueryBuilder(string name) : base(new Query<ReturnReasonDefinition>(name))
        {
        }

        public ReturnReasonDefinitionQueryBuilder(IQuery<ReturnReasonDefinition> query) : base(query)
        {
        }

        public ReturnReasonDefinitionQueryBuilder Deleted()
        {
            base.InnerQuery.AddField("deleted");
            return this;
        }

        public ReturnReasonDefinitionQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public ReturnReasonDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReturnReasonDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}