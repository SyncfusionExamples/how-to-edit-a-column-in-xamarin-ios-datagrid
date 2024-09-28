using System;

using UIKit;
using Syncfusion.SfDataGrid;
using CoreGraphics;

namespace EditText
{
	public partial class ViewController : UIViewController
	{

		public ViewController(IntPtr handle)
		: base(handle)
		{
		}
		public ViewController()
		{
		}
		SfDataGrid grid = new SfDataGrid();
		ViewModel viewmodel = new ViewModel();

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.View.BackgroundColor = UIColor.White;
			grid.ItemsSource = viewmodel.Info;
			grid.BackgroundColor = UIColor.White;
			grid.AutoGenerateColumns = false;
			grid.ColumnSizer = ColumnSizer.Star;
			grid.SelectionChanged += Grid_SelectionChanged;
			grid.SelectionMode = SelectionMode.Single;
			var textcolumn = new GridTextColumn
			{
				MappingName = "ID",
				HeaderText = "ID"
			};
			//Creation of a template column
			var textcolumn1 = new GridTextColumn
			{
				MappingName = "Name",
				UserCellType = typeof(CustomCell), //Adding a custom cell into the template column
				HeaderText = "Name"
			};

			var textcolumn2 = new GridTextColumn
			{
				MappingName = "Percentage",
				HeaderText = "Percentage"
			};

			var textcolumn3 = new GridTextColumn
			{
				MappingName = "Remarks",
				HeaderText = "Remarks"
			};
			grid.Columns.Add(textcolumn);
			grid.Columns.Add(textcolumn1);
			grid.Columns.Add(textcolumn2);
			grid.Columns.Add(textcolumn3);

			View.AddSubview(grid);
		}


		void Grid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
		{

		}

		public override void ViewDidLayoutSubviews()
		{

			this.grid.Frame = new CGRect(0, 20, View.Frame.Width, View.Frame.Height - 20);
			base.ViewDidLayoutSubviews();
		}
	}


}

