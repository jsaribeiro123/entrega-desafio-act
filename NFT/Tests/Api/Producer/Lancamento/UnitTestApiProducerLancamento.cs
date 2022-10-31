namespace Api.Producer.Lancamento.Test;

public class UnitTestApiProducerLancamento
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