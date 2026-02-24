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
    public sealed class MetafieldReferenceAddressesV2QueryBuilder : FieldsQueryBuilderBase<MailingAddressConnection, MetafieldReferenceAddressesV2QueryBuilder>, IHasArguments<MetafieldReferenceAddressesV2ArgumentsBuilder>
    {
        public MetafieldReferenceAddressesV2ArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceAddressesV2QueryBuilder Self => this;

        public MetafieldReferenceAddressesV2QueryBuilder(string name) : base(new Query<MailingAddressConnection>(name))
        {
            Arguments = new MetafieldReferenceAddressesV2ArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceAddressesV2QueryBuilder(IQuery<MailingAddressConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceAddressesV2ArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceAddressesV2QueryBuilder SetArguments(Action<MetafieldReferenceAddressesV2ArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceAddressesV2QueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressEdgeQueryBuilder> build)
        {
            var query = new Query<MailingAddressEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddressEdge>(query);
            return this;
        }

        public MetafieldReferenceAddressesV2QueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public MetafieldReferenceAddressesV2QueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}