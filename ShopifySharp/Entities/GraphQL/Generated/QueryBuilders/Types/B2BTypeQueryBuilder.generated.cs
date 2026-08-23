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
    public sealed class B2BTypeQueryBuilder : FieldsQueryBuilderBase<B2BType, B2BTypeQueryBuilder>
    {
        protected override B2BTypeQueryBuilder Self => this;

        public B2BTypeQueryBuilder() : this("b2BType")
        {
        }

        public B2BTypeQueryBuilder(string name) : base(new Query<B2BType>(name))
        {
        }

        public B2BTypeQueryBuilder(IQuery<B2BType> query) : base(query)
        {
        }

        public B2BTypeQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}