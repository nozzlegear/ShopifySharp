#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class MetafieldRelationQueryBuilder() : GraphQueryBuilder<MetafieldRelation>("metafieldRelation")
{
    public MetafieldRelationQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetafieldRelationQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public MetafieldRelationQueryBuilder AddFieldNamespace()
    {
        AddField("namespace");
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<AppInstallationQueryBuilder, AppInstallationQueryBuilder> build)
    {
        AddUnion<AppInstallation, AppInstallationQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<ArticleQueryBuilder, ArticleQueryBuilder> build)
    {
        AddUnion<Article, ArticleQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<BlogQueryBuilder, BlogQueryBuilder> build)
    {
        AddUnion<Blog, BlogQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddUnion<Collection, CollectionQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<CompanyQueryBuilder, CompanyQueryBuilder> build)
    {
        AddUnion<Company, CompanyQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<CompanyLocationQueryBuilder, CompanyLocationQueryBuilder> build)
    {
        AddUnion<CompanyLocation, CompanyLocationQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddUnion<Customer, CustomerQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<DeliveryCustomizationQueryBuilder, DeliveryCustomizationQueryBuilder> build)
    {
        AddUnion<DeliveryCustomization, DeliveryCustomizationQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<DiscountAutomaticNodeQueryBuilder, DiscountAutomaticNodeQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticNode, DiscountAutomaticNodeQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<DiscountCodeNodeQueryBuilder, DiscountCodeNodeQueryBuilder> build)
    {
        AddUnion<DiscountCodeNode, DiscountCodeNodeQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<DiscountNodeQueryBuilder, DiscountNodeQueryBuilder> build)
    {
        AddUnion<DiscountNode, DiscountNodeQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<DraftOrderQueryBuilder, DraftOrderQueryBuilder> build)
    {
        AddUnion<DraftOrder, DraftOrderQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddUnion<FulfillmentOrder, FulfillmentOrderQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddUnion<Location, LocationQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<MarketQueryBuilder, MarketQueryBuilder> build)
    {
        AddUnion<Market, MarketQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<MetaobjectQueryBuilder, MetaobjectQueryBuilder> build)
    {
        AddUnion<Metaobject, MetaobjectQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddUnion<Order, OrderQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<PageQueryBuilder, PageQueryBuilder> build)
    {
        AddUnion<Page, PageQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<PaymentCustomizationQueryBuilder, PaymentCustomizationQueryBuilder> build)
    {
        AddUnion<PaymentCustomization, PaymentCustomizationQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddUnion<Product, ProductQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddUnion<ProductVariant, ProductVariantQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseReferencer(Func<ShopQueryBuilder, ShopQueryBuilder> build)
    {
        AddUnion<Shop, ShopQueryBuilder>("referencer", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddUnion<Collection, CollectionQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<CompanyQueryBuilder, CompanyQueryBuilder> build)
    {
        AddUnion<Company, CompanyQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddUnion<Customer, CustomerQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<GenericFileQueryBuilder, GenericFileQueryBuilder> build)
    {
        AddUnion<GenericFile, GenericFileQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<MediaImageQueryBuilder, MediaImageQueryBuilder> build)
    {
        AddUnion<MediaImage, MediaImageQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<MetaobjectQueryBuilder, MetaobjectQueryBuilder> build)
    {
        AddUnion<Metaobject, MetaobjectQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<Model3dQueryBuilder, Model3dQueryBuilder> build)
    {
        AddUnion<Model3d, Model3dQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddUnion<Order, OrderQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<PageQueryBuilder, PageQueryBuilder> build)
    {
        AddUnion<Page, PageQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddUnion<Product, ProductQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddUnion<ProductVariant, ProductVariantQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<TaxonomyValueQueryBuilder, TaxonomyValueQueryBuilder> build)
    {
        AddUnion<TaxonomyValue, TaxonomyValueQueryBuilder>("target", build);
        return this;
    }

    public MetafieldRelationQueryBuilder AddUnionCaseTarget(Func<VideoQueryBuilder, VideoQueryBuilder> build)
    {
        AddUnion<Video, VideoQueryBuilder>("target", build);
        return this;
    }
}