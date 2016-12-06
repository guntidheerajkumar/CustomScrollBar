# CustomScrollBar

An interactive scroll bar for traversing comically massive scroll views.

### Usage

```
List<string> lstData = new List<string>();
for (int i = 0; i < 400; i++) {
	lstData.Add("Row " + i.ToString());
}

var scrollBar = new CustomScrollBar.CustomScrollBar();
SampleTableView.AddScrollBar(scrollBar);
SampleTableView.SeparatorInset = scrollBar.AdjustedTableViewSeparatorInsetForInset(SampleTableView.SeparatorInset);
SampleTableView.Source = new TableSource(lstData);
SampleTableView.ReloadData();
```

###Output

![](https://github.com/guntidheerajkumar/CustomScrollBar/blob/master/Output.gif)
