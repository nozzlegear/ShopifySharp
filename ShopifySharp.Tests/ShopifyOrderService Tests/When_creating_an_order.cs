using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests
{
    [Subject(typeof(ShopifyOrderService))]
    public class When_creating_an_order
    {
        Establish context = () =>
        {
            Service = new ShopifyOrderService(Utils.MyShopifyUrl, Utils.AccessToken);
        };

        Because of = () =>
        {
            var newOrder = OrderCreation.GenerateOrder();
            newOrder.NoteAttributes = new List<ShopifyNoteAttribute>()
            {
                new ShopifyNoteAttribute() { Name = "Test Name", Value = "Test Value" }
            };

            newOrder.LineItems.First().Properties = new List<ShopifyLineItemProperty>
            {
                new ShopifyLineItemProperty() { Name = "Test Name", Value = "Test Value" }
            };

            Order = Service.CreateAsync(newOrder).Await().AsTask.Result;
        };

        It should_create_an_order = () =>
        {
            Order.ShouldNotBeNull();
            Order.Id.HasValue.ShouldBeTrue();
            Order.ContactEmail.ShouldNotBeNull();
            Order.NoteAttributes.Count().ShouldBeGreaterThanOrEqualTo(1);
            Order.NoteAttributes.Any(n => n.Name == "Test Name" && n.Value as string == "Test Value").ShouldBeTrue();
        };

        It should_have_properties_set = () =>
        {
            var properties = Order.LineItems.First().Properties;
            properties.Count().ShouldBeGreaterThanOrEqualTo(1);
            properties.Any(n => n.Name == "Test Name" && n.Value as string == "Test Value").ShouldBeTrue();

        };

        Cleanup after = () =>
        {
            if(Order != null)
            {
                Service.DeleteAsync(Order.Id.Value).Await();
            }
        };

        static ShopifyOrderService Service;

        static ShopifyOrder Order;
    }
}
