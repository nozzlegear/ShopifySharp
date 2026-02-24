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
    public sealed class MetafieldReferenceAgreementsQueryBuilder : FieldsQueryBuilderBase<SalesAgreementConnection, MetafieldReferenceAgreementsQueryBuilder>, IHasArguments<MetafieldReferenceAgreementsArgumentsBuilder>
    {
        public MetafieldReferenceAgreementsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceAgreementsQueryBuilder Self => this;

        public MetafieldReferenceAgreementsQueryBuilder(string name) : base(new Query<SalesAgreementConnection>(name))
        {
            Arguments = new MetafieldReferenceAgreementsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceAgreementsQueryBuilder(IQuery<SalesAgreementConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceAgreementsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceAgreementsQueryBuilder SetArguments(Action<MetafieldReferenceAgreementsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceAgreementsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SalesAgreementEdgeQueryBuilder> build)
        {
            var query = new Query<SalesAgreementEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SalesAgreementEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SalesAgreementEdge>(query);
            return this;
        }

        public MetafieldReferenceAgreementsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SalesAgreementQueryBuilder> build)
        {
            var query = new Query<ISalesAgreement>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SalesAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISalesAgreement>(query);
            return this;
        }

        public MetafieldReferenceAgreementsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}