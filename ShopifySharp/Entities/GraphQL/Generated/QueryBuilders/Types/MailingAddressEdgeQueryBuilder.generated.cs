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
    public sealed class MailingAddressEdgeQueryBuilder : FieldsQueryBuilderBase<MailingAddressEdge, MailingAddressEdgeQueryBuilder>
    {
        protected override MailingAddressEdgeQueryBuilder Self => this;

        public MailingAddressEdgeQueryBuilder() : this("mailingAddressEdge")
        {
        }

        public MailingAddressEdgeQueryBuilder(string name) : base(new Query<MailingAddressEdge>(name))
        {
        }

        public MailingAddressEdgeQueryBuilder(IQuery<MailingAddressEdge> query) : base(query)
        {
        }

        public MailingAddressEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MailingAddressEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }
    }
}