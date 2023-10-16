using Bunit;
using Microsoft.Extensions.DependencyInjection;
using GridDemo.Pages;
using GridDemo.NorthwindEmployees;

namespace TestGridDemo
{
	[Collection("GridDemo")]
	public class TestMaster_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbGridModule),
				typeof(IgbDataGridToolbarModule));
			ctx.Services.AddScoped<INorthwindEmployeesService>(sp => new MockNorthwindEmployeesService());
			var componentUnderTest = ctx.RenderComponent<Master_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}