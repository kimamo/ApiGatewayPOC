using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderManagementApi.Controllers {
	[Route ("api/orderservice")]
	[ApiController]
	public class OrderController : ControllerBase {
		// GET api/orders
		[HttpGet, Route ("orders")]
		public ActionResult GetOrders () {
			var orders = new List<Order> ();
			orders.Add (new Order { OrderNo = "001", Description = "Amanda's Thank you card Order", Amount = 5.85 });
			orders.Add (new Order { OrderNo = "002", Description = "Nancy's  christmas card order", Amount = 6.99 });
			orders.Add (new Order { OrderNo = "003", Description = "Wairimu's  graduation card order", Amount = 4.65 });
			orders.Add (new Order { OrderNo = "004", Description = "Njoki's  thanksgiving card order", Amount = 7.45 });
			orders.Add (new Order { OrderNo = "005", Description = "Charlo's  wedding invitation card order", Amount = 12.50 });
			return Ok (orders);
		}

	}
}