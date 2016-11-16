using System;
using Foundation;
using CoreGraphics;
using CustomScrollBar;
using UIKit;
using System.Collections.Generic;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			List<string> lstData = new List<string>();
			for (int i = 0; i < 400; i++) {
				lstData.Add("Row " + i.ToString());
			}

			var scrollBar = new CustomScrollBar.CustomScrollBar();
			SampleTableView.AddScrollBar(scrollBar);
			SampleTableView.SeparatorInset = scrollBar.AdjustedTableViewSeparatorInsetForInset(SampleTableView.SeparatorInset);
			SampleTableView.Source = new TableSource(lstData);
			SampleTableView.ReloadData();
		}
	}

	public class TableSource : UITableViewSource
	{

		List<string> TableItems;
		string CellIdentifier = "TableCell";

		public TableSource(List<string> items)
		{
			TableItems = items;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return TableItems.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
			string item = TableItems[indexPath.Row];

			if (cell == null) { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

			cell.TextLabel.Text = item;

			return cell;
		}
	}
}
