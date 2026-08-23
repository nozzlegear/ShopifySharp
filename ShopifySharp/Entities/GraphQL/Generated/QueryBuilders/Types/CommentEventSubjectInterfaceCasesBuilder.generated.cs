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
    public sealed class CommentEventSubjectInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICommentEventSubject, CommentEventSubjectInterfaceCasesBuilder>
    {
        protected override CommentEventSubjectInterfaceCasesBuilder Self => this;

        public CommentEventSubjectInterfaceCasesBuilder(string fieldName = "commentEventSubject") : this(new Query<ICommentEventSubject>(fieldName))
        {
        }

        public CommentEventSubjectInterfaceCasesBuilder(IQuery<ICommentEventSubject> query) : base(query)
        {
        }

        public CommentEventSubjectInterfaceCasesBuilder OnCompany(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("... on Company");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CommentEventSubjectInterfaceCasesBuilder OnCompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("... on CompanyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CommentEventSubjectInterfaceCasesBuilder OnCustomer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("... on Customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CommentEventSubjectInterfaceCasesBuilder OnDraftOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("... on DraftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CommentEventSubjectInterfaceCasesBuilder OnInventoryTransfer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("... on InventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CommentEventSubjectInterfaceCasesBuilder OnOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("... on Order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CommentEventSubjectInterfaceCasesBuilder OnPriceRule(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleQueryBuilder> build)
        {
            var query = new Query<PriceRule>("... on PriceRule");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}