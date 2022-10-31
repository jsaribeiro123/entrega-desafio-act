namespace Api.Consumer.Report.Test;

public class UnitTest1
{
    [Fact]
    public async Task TestRootEndpointNotOk()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        var response = await client.GetStringAsync("/");
    
        Assert.Equal("This is a GET", response);
    }
        [Fact]
    public async Task TestRootEndpointOk()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        var response = await client.GetStringAsync("/");
    
        Assert.Equal("This is a GET", response);
    }
}