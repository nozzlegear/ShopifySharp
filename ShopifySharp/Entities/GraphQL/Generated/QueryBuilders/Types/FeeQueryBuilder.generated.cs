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
    public sealed class FeeQueryBuilder : FieldsQueryBuilderBase<IFee, FeeQueryBuilder>
    {
        protected override FeeQueryBuilder Self => this;

        public FeeQueryBuilder() : this("fee")
        {
        }

        public FeeQueryBuilder(string name) : base(new Query<IFee>(name))
        {
        }

        public FeeQueryBuilder(IQuery<IFee> query) : base(query)
        {
        }

        public FeeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}