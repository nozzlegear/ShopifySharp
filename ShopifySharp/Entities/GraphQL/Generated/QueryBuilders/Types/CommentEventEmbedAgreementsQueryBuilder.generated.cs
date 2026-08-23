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
    public sealed class CommentEventEmbedAgreementsQueryBuilder : FieldsQueryBuilderBase<SalesAgreementConnection, CommentEventEmbedAgreementsQueryBuilder>, IHasArguments<CommentEventEmbedAgreementsArgumentsBuilder>
    {
        public CommentEventEmbedAgreementsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedAgreementsQueryBuilder Self => this;

        public CommentEventEmbedAgreementsQueryBuilder(string name) : base(new Query<SalesAgreementConnection>(name))
        {
            Arguments = new CommentEventEmbedAgreementsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedAgreementsQueryBuilder(IQuery<SalesAgreementConnection> query) : base(query)
        {
            Arguments = new CommentEventEmbedAgreementsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedAgreementsQueryBuilder SetArguments(Action<CommentEventEmbedAgreementsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedAgreementsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SalesAgreementEdgeQueryBuilder> build)
        {
            var query = new Query<SalesAgreementEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SalesAgreementEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SalesAgreementEdge>(query);
            return this;
        }

        public CommentEventEmbedAgreementsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public CommentEventEmbedAgreementsQueryBuilder Nodes(Action<SalesAgreementInterfaceCasesBuilder> build)
        {
            var query = new Query<ISalesAgreement>("nodes");
            var unionBuilder = new SalesAgreementInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}