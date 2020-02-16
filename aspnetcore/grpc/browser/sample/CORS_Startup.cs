#region snippet_1
public void ConfigureServices(IServiceCollection services)
{
    services.AddGrpc();

    services.AddCors(o => o.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               .WithExposedHeaders("Grpc-Status", "Grpc-Message");
    }));
}
#endregion
