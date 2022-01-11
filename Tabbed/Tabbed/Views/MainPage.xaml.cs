using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tabbed.Views
{
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			this.Children.Add(new Content3Page());
		}
	}
}

