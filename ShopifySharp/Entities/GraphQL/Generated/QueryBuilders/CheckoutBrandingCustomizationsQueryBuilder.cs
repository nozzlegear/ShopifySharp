#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CheckoutBrandingCustomizationsQueryBuilder() : GraphQueryBuilder<CheckoutBrandingCustomizations>("query checkoutBrandingCustomizations")
{
    public CheckoutBrandingCustomizationsQueryBuilder AddFieldBuyerJourney()
    {
        AddField("buyerJourney");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldCartLink()
    {
        AddField("cartLink");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldCheckbox()
    {
        AddField("checkbox");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldChoiceList()
    {
        AddField("choiceList");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldContent()
    {
        AddField("content");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldControl()
    {
        AddField("control");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldDivider()
    {
        AddField("divider");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldExpressCheckout()
    {
        AddField("expressCheckout");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldFavicon()
    {
        AddField("favicon");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldFooter()
    {
        AddField("footer");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldGlobal()
    {
        AddField("global");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldHeader()
    {
        AddField("header");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldHeadingLevel1()
    {
        AddField("headingLevel1");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldHeadingLevel2()
    {
        AddField("headingLevel2");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldHeadingLevel3()
    {
        AddField("headingLevel3");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldMain()
    {
        AddField("main");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldMerchandiseThumbnail()
    {
        AddField("merchandiseThumbnail");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldOrderSummary()
    {
        AddField("orderSummary");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldPrimaryButton()
    {
        AddField("primaryButton");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldSecondaryButton()
    {
        AddField("secondaryButton");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldSelect()
    {
        AddField("select");
        return this;
    }

    public CheckoutBrandingCustomizationsQueryBuilder AddFieldTextField()
    {
        AddField("textField");
        return this;
    }
}