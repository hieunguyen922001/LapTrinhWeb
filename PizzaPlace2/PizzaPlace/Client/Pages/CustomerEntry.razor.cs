using Microsoft.AspNetCore.Components;
using PizzaPlace.Shared;

namespace PizzaPlace.Client.Pages
{
	partial class CustomerEntry
	{
		[Parameter]
		public string Title { get; set; }
		[Parameter]
		public string ButtonTitle { get; set; } = default!;
		[Parameter]
		public string ButtonClass { get; set; } = default!;
		[Parameter]
		public Customer Customer { get; set; }  = default!;
		[Parameter]
		public EventCallback ValidSubmit { get; set; } = default!;
		[Parameter]
		public EventCallback<Customer> CustomerChanged { get; set; }
		public void FieldChanged(string fieldName)
        {
			CustomerChanged.InvokeAsync(Customer);
			isInvalid = !inputWatcher.Validate();
        }
		private InputWatcher inputWatcher = default!;
		bool isInvalid = true;
	}
}
