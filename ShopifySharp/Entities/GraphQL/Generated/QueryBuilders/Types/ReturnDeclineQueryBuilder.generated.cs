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
    public sealed class ReturnDeclineQueryBuilder : FieldsQueryBuilderBase<ReturnDecline, ReturnDeclineQueryBuilder>
    {
        protected override ReturnDeclineQueryBuilder Self => this;

        public ReturnDeclineQueryBuilder() : this("returnDecline")
        {
        }

        public ReturnDeclineQueryBuilder(string name) : base(new Query<ReturnDecline>(name))
        {
        }

        public ReturnDeclineQueryBuilder(IQuery<ReturnDecline> query) : base(query)
        {
        }

        public ReturnDeclineQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public ReturnDeclineQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }
    }
}