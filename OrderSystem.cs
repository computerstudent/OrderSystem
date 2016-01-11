using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

public class OrderSystem 
{
	public List<Order> orders = new List<Order>();
	
	public OrderSystem ()
	{
		
	}
	
	public void AddOrder (Order order)
	{
		orders.Add(order);
	}

	public void RemoveOrder (Order order)
	{
		orders.Remove(order);
	}	
}