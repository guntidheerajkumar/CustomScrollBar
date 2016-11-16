using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CustomScrollBar
{
	// @interface CustomScrollBar (UIScrollView)
	[Category]
	[BaseType(typeof(UIScrollView))]
	interface UIScrollView_CustomScrollBar
	{
		// @property (readonly, nonatomic) CustomScrollBar * _Nullable customScrollBar;
		[Static]
		[NullAllowed, Export("customScrollBar")]
		CustomScrollBar CustomScrollBar { get; }

		// -(void)AddScrollBar:(CustomScrollBar * _Nullable)scrollBar;
		[Export("AddScrollBar:")]
		void AddScrollBar([NullAllowed] CustomScrollBar scrollBar);

		// -(void)RemoveScrollbar;
		[Export("RemoveScrollbar")]
		void RemoveScrollbar();
	}

	// @interface CustomScrollBar : UIView
	[BaseType(typeof(UIView))]
	interface CustomScrollBar
	{
		// @property (assign, nonatomic) CustomScrollBarStyle style;
		[Export("style", ArgumentSemantic.Assign)]
		CustomScrollBarStyle Style { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets verticalInset;
		[Export("verticalInset", ArgumentSemantic.Assign)]
		UIEdgeInsets VerticalInset { get; set; }

		// @property (assign, nonatomic) CGFloat edgeInset;
		[Export("edgeInset")]
		nfloat EdgeInset { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull trackTintColor;
		[Export("trackTintColor", ArgumentSemantic.Strong)]
		UIColor TrackTintColor { get; set; }

		// @property (assign, nonatomic) CGFloat trackWidth;
		[Export("trackWidth")]
		nfloat TrackWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable handleTintColor;
		[NullAllowed, Export("handleTintColor", ArgumentSemantic.Strong)]
		UIColor HandleTintColor { get; set; }

		// @property (assign, nonatomic) CGFloat handleWidth;
		[Export("handleWidth")]
		nfloat HandleWidth { get; set; }

		// @property (assign, nonatomic) CGFloat handleMinimiumHeight;
		[Export("handleMinimiumHeight")]
		nfloat HandleMinimiumHeight { get; set; }

		// @property (readonly, assign, nonatomic) BOOL dragging;
		[Export("dragging")]
		bool Dragging { get; }

		// @property (assign, nonatomic) CGFloat minimumContentHeightScale;
		[Export("minimumContentHeightScale")]
		nfloat MinimumContentHeightScale { get; set; }

		// @property (readonly, nonatomic, weak) UIScrollView * _Nullable scrollView;
		[NullAllowed, Export("scrollView", ArgumentSemantic.Weak)]
		UIScrollView ScrollView { get; }

		// -(instancetype _Nonnull)initWithStyle:(CustomScrollBarStyle)style;
		[Export("initWithStyle:")]
		IntPtr Constructor(CustomScrollBarStyle style);

		// -(void)addCustomScrollView:(UIScrollView * _Nonnull)scrollView;
		[Export("addCustomScrollView:")]
		void AddCustomScrollView(UIScrollView scrollView);

		// -(void)removeFromScrollView;
		[Export("removeFromScrollView")]
		void RemoveFromScrollView();

		// -(UIEdgeInsets)adjustedTableViewSeparatorInsetForInset:(UIEdgeInsets)inset;
		[Export("adjustedTableViewSeparatorInsetForInset:")]
		UIEdgeInsets AdjustedTableViewSeparatorInsetForInset(UIEdgeInsets inset);

		// -(UIEdgeInsets)adjustedTableViewCellLayoutMarginsForMargins:(UIEdgeInsets)layoutMargins manualOffset:(CGFloat)offset;
		[Export("adjustedTableViewCellLayoutMarginsForMargins:manualOffset:")]
		UIEdgeInsets AdjustedTableViewCellLayoutMarginsForMargins(UIEdgeInsets layoutMargins, nfloat offset);

		// -(void)setHidden:(BOOL)hidden animated:(BOOL)animated;
		[Export("setHidden:animated:")]
		void SetHidden(bool hidden, bool animated);
	}
}
