using System;
using Syncfusion.SfDataGrid;
using UIKit;
using System.Drawing;
using Syncfusion.Data;
using CoreGraphics;
using System.Linq;
using Syncfusion.Data.Extensions;
using System.Collections.Generic;

namespace EditText
{
	public class CustomCell:GridCell
	{
		
		private UITextField edit;
		public CustomCell ()
		{
			edit = new UITextField ();
			edit.AllowsEditingTextAttributes = true;
			edit.EditingChanged += Edit_EditingChanged;
			this.AddSubview(edit);
		}

		public override void WillMoveToWindow(UIWindow window)
		{
			List<UIGestureRecognizer> gesturelist; 
			if (this.GestureRecognizers != null)
			{
				gesturelist = new List<UIGestureRecognizer>();
				foreach (var gesture in this.GestureRecognizers)
					gesturelist.Add(gesture);
				gesturelist.FirstOrDefault(ges=> ges is UITapGestureRecognizer).ShouldRecognizeSimultaneously = (gestureRecognizer, otherGestureRecognizer) => true;
			}
			base.WillMoveToWindow(window);
		}


		void Edit_EditingChanged (object sender, EventArgs e)
		{
			var edited = this.DataColumn.Renderer.DataGrid.View.GetItemProperties ();
			edited.SetValue (this.DataColumn.RowData, edit.Text, this.DataColumn.GridColumn.MappingName);

		}
		public override void LayoutSubviews ()
		{
			edit.Frame =  new CGRect(0,0,this.Frame.Width,this.Frame.Height);	
			edit.Text = Convert.ToString(DataColumn.CellValue);
			base.LayoutSubviews ();
		}

	}
}

