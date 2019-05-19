using System;

public class Order {
	private Guid id = Guid.NewGuid ();

	public string Description { get; set; }
	public Guid Id { get => id; set => id = value; }
	public string OrderNo { get; set; }
	public double Amount { get; set; }
}