namespace Api.Producer.Report.Test;

public class UnitTestApiProducerReport
{
    [Fact]
    public async Task TestRootEndpointOk()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        var response = await client.GetStringAsync("/");
    
        Assert.Equal("This is a GET", response);
    }
}