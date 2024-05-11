using System.Diagnostics.Metrics;;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<HatCoMetrics>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPost("/complete-sale/{QuantitySold}", (int QuantitySold, HatCoMetrics metrics) =>
{
	// ... business logic such as saving the sale to a database ...
	metrics.HatsSold(QuantitySold);
});

app.Run();
public class HatCoMetrics
{
	private readonly Counter<int> _hatsSold;

	public HatCoMetrics(IMeterFactory meterFactory)
	{
		var meter = meterFactory.Create("HatCo.Store");
		_hatsSold = meter.CreateCounter<int>("hatco.store.hats_sold");
	}

	public void HatsSold(int quantity)
	{
		_hatsSold.Add(quantity);
	}
}