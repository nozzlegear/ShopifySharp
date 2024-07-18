using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using ShopifySharp.Filters;
using Xunit;
using Xunit.Abstractions;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;
// ReSharper disable PossibleInvalidOperationException

namespace ShopifySharp.Tests.Services;

[Trait("Category", "Customer")]
public class CustomerServiceTests(
    CustomerServiceTestsFixture fixture,
    ITestOutputHelper testOutputHelper)
    : IClassFixture<CustomerServiceTestsFixture>
{
    private CustomerServiceTestsFixture Fixture { get; } = fixture;

    [Fact]
    public async Task Counts_Customers()
    {
        var count = await Fixture.Service.CountAsync();

        Assert.True(count > 0);
    }

    [Fact]
    public async Task Lists_Customers()
    {
        var list = await Fixture.Service.ListAsync();

        Assert.True(list.Items.Count() > 0);
    }

    [Fact]
    public async Task Deletes_Customers()
    {
        var created = await Fixture.Create();
        bool threw = false;

        try
        {
            await Fixture.Service.DeleteAsync(created.Id.Value);
        }
        catch (ShopifyException ex)
        {
            testOutputHelper.WriteLine($"{nameof(Deletes_Customers)} failed. {ex.Message}");

            threw = true;
        }

        Assert.False(threw);
    }

    [Fact]
    public async Task Gets_Customers()
    {
        var customer = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value);

        Assert.NotNull(customer);
        Assert.Equal(Fixture.FirstName, customer.FirstName);
        Assert.Equal(Fixture.LastName, customer.LastName);
        Assert.Equal(Fixture.Note, customer.Note);
        Assert.NotNull(customer.Addresses);
        Assert.NotNull(customer.DefaultAddress);
    }

    [Fact]
    public async Task Gets_Customers_With_Options()
    {
        var customer = await Fixture.Service.GetAsync(Fixture.Created.First().Id.Value, "first_name,last_name");

        Assert.NotNull(customer);
        Assert.Equal(Fixture.FirstName, customer.FirstName);
        Assert.Equal(Fixture.LastName, customer.LastName);
        EmptyAssert.NullOrEmpty(customer.Note);
        EmptyAssert.NullOrEmpty(customer.Addresses);
        Assert.Null(customer.DefaultAddress);

    }

    [Fact]
    public async Task Creates_Customers()
    {
        var customer = await Fixture.Create();

        Assert.NotNull(customer);
        Assert.Equal(Fixture.FirstName, customer.FirstName);
        Assert.Equal(Fixture.LastName, customer.LastName);
        Assert.Equal(Fixture.Note, customer.Note);
        Assert.NotNull(customer.Addresses);
    }

    [Fact]
    public async Task Creates_Customers_With_Options()
    {
        var customer = await Fixture.Create(options: new CustomerCreateOptions()
        {
            Password = "loktarogar",
            PasswordConfirmation = "loktarogar",
            SendEmailInvite = false,
            SendWelcomeEmail = false,
        });

        Assert.NotNull(customer);
        Assert.Equal(Fixture.FirstName, customer.FirstName);
        Assert.Equal(Fixture.LastName, customer.LastName);
        Assert.Equal(Fixture.Note, customer.Note);
        Assert.NotNull(customer.Addresses);
    }

    [Fact]
    public async Task Updates_Customers()
    {
        string firstName = "Jane";
        var created = await Fixture.Create();
        long id = created.Id.Value;

        created.FirstName = firstName;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created);

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(firstName, updated.FirstName);
    }

    [Fact]
    public async Task Updates_Customers_With_Options()
    {
        string firstName = "Jane";
        var created = await Fixture.Create();
        long id = created.Id.Value;

        created.FirstName = firstName;
        created.Id = null;

        var updated = await Fixture.Service.UpdateAsync(id, created, new CustomerUpdateOptions()
        {
            Password = "loktarogar",
            PasswordConfirmation = "loktarogar"
        });

        // Reset the id so the Fixture can properly delete this object.
        created.Id = id;

        Assert.Equal(firstName, updated.FirstName);
    }

    [Fact]
    public async Task Searches_For_Customers()
    {
        var searchTry = 0;

        // Setup
        var customer = await Fixture.Create();
        var filter = new CustomerSearchListFilter
        {
            Query = $"email:{customer.Email}",
        };

        // Act
        var search = await Fixture.Service.SearchAsync(filter);

        while (!search.Items.Any() && searchTry < 4)
        {
            // The search index has a bit of a delay to it. Try up to 4 times before asserting.
            searchTry++;
            await Task.Delay(1000);
            search = await Fixture.Service.SearchAsync(filter);
        }

        // Assert
        search.Should()
            .NotBeNull();
        search.Items.Should()
            .NotBeEmpty()
            .And.HaveCount(1)
            .And.AllSatisfy(c => c.Email.Should().Be(customer.Email));
    }

    [Fact]
    public async Task Can_Be_Partially_Updated()
    {
        string newFirstName = "Sheev";
        string newLastName = "Palpatine";
        var created = await Fixture.Create();
        var updated = await Fixture.Service.UpdateAsync(created.Id.Value, new Customer()
        {
            FirstName = newFirstName,
            LastName = newLastName
        });

        Assert.Equal(created.Id, updated.Id);
        Assert.Equal(newFirstName, updated.FirstName);
        Assert.Equal(newLastName, updated.LastName);

        // In previous versions of ShopifySharp, the updated JSON would have sent 'email=null' or 'note=null', clearing out the email address.
        Assert.Equal(created.Email, updated.Email);
        Assert.Equal(created.Note, updated.Note);
    }

    [Fact]
    public async Task SendInvite_Customers_Default()
    {
        var created = await Fixture.Create();
        var invite = await Fixture.Service.SendInviteAsync(created.Id.Value);

        Assert.NotNull(invite);
    }

    [Fact]
    public async Task SendInvite_Customers_Custom()
    {
        var created = await Fixture.Create();
        var options = new CustomerInvite()
        {
            Subject = "Custom Subject courtesy of ShopifySharp",
            CustomMessage = "Custom Message courtesy of ShopifySharp"
        };

        var invite = await Fixture.Service.SendInviteAsync(created.Id.Value, options);

        Assert.NotNull(invite);
        Assert.Equal(options.Subject, invite.Subject);
        Assert.Equal(options.CustomMessage, invite.CustomMessage);
    }

    [Fact]
    public async Task GetAccountActivationUrl_Customers()
    {
        var created = await Fixture.Create();
        var url = await Fixture.Service.GetAccountActivationUrl(created.Id.Value);

        Assert.NotEmpty(url);
        Assert.Contains("account/activate", url);
    }
}

public class CustomerServiceTestsFixture : IAsyncLifetime
{
    public CustomerService Service { get; } = new CustomerService(Utils.MyShopifyUrl, Utils.AccessToken);

    public List<Customer> Created { get; } = new List<Customer>();

    public string FirstName => "John";

    public string LastName => "Doe";

    public string Note => "Test note about this customer.";

    public async Task InitializeAsync()
    {
        Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());

        // Create one customer for use with count, list, get, etc. tests.
        await Create();
    }

    public async Task DisposeAsync()
    {
        foreach (var obj in Created)
        {
            try
            {
                await Service.DeleteAsync(obj.Id.Value);
            }
            catch (ShopifyHttpException ex)
            {
                if (ex.HttpStatusCode != HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failed to delete created Customer with id {obj.Id.Value}. {ex.Message}");
                }
            }
        }
    }

    public async Task<Customer> Create(bool skipAddToCreatedList = false, CustomerCreateOptions options = null)
    {
        var obj = await Service.CreateAsync(new Customer()
        {
            FirstName = FirstName,
            LastName = LastName,
            Email = Guid.NewGuid().ToString() + "@example.com",
            Addresses = new List<Address>()
            {
                new Address()
                {
                    Address1 = "123 4th Street",
                    City = "Minneapolis",
                    Province = "Minnesota",
                    ProvinceCode = "MN",
                    Zip = "55401",
                    Phone = "555-555-5555",
                    FirstName = "John",
                    LastName = "Doe",
                    Company = "Tomorrow Corporation",
                    Country = "United States",
                    CountryCode = "US",
                    Default = true,
                }
            },
            VerifiedEmail = true,
            Note = Note,
            State = "enabled"
        }, options ?? new CustomerCreateOptions
        {
            SendEmailInvite = false,
            SendWelcomeEmail = false,
        });

        if (!skipAddToCreatedList)
        {
            Created.Add(obj);
        }

        return obj;
    }
}
