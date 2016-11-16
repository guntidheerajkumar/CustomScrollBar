#import <UIKit/UIKit.h>
#import "UIScrollView+CustomScrollBar.h"

typedef NS_ENUM(NSInteger, CustomScrollBarStyle) {
    CustomScrollBarStyleDefault,
    CustomScrollBarStyleDark
};

NS_ASSUME_NONNULL_BEGIN

@interface CustomScrollBar : UIView

/* The visual style of the scroll bar, either light or dark */
@property (nonatomic, assign) CustomScrollBarStyle style;

/** The amount of padding above and below the scroll bar (Only top and bottom values are counted. Default is {20,20} ) */
@property (nonatomic, assign) UIEdgeInsets verticalInset;

/** The inset, in points of the middle of track from the edge of the scroll view */
@property (nonatomic, assign) CGFloat edgeInset;

/** The tint color of the track */
@property (nonatomic, strong) UIColor *trackTintColor;

/** The width in points, of the track (Default value is 2.0) */
@property (nonatomic, assign) CGFloat trackWidth;

/** The tint color of the handle (Defaults to the system tint color) */
@property (nonatomic, strong, nullable) UIColor *handleTintColor;

/** The width in points, of the handle. (Default value is 4.0) */
@property (nonatomic, assign) CGFloat handleWidth;

/** The minimum height in points the handle may be in relation to the content height. (Default value is 64.0) */
@property (nonatomic, assign) CGFloat handleMinimiumHeight;

/** The user is currently dragging the handle */
@property (nonatomic, assign, readonly) BOOL dragging;

/** The minimum required scale of the scroll view's content height before the scroll bar is shown (Default is 5.0) */
@property (nonatomic, assign) CGFloat minimumContentHeightScale;

/** The scroll view in which this scroll bar has been added. */
@property (nonatomic, weak, readonly) UIScrollView *scrollView;

/** 
 Creates a new instance of the scroll bar view 
 
 @param style The initial style of the scroll bar upon creation
 */
- (instancetype)initWithStyle:(CustomScrollBarStyle)style;

/**
 Adds the scroll bar to a scroll view
 
 @param scrollView The scroll view that will receive this scroll bar
 */
- (void)addCustomScrollView:(UIScrollView *)scrollView;

/**
 Removes the scroll bar from the scroll view and resets the scroll view's state
 */
- (void)removeFromScrollView;

/**
 If added to a table view, this convienience method will compute the appropriate
 inset values for the table separator so they don't underlap the scroll bar
 
 @param inset The original separator inset value of the table view
 */
- (UIEdgeInsets)adjustedTableViewSeparatorInsetForInset:(UIEdgeInsets)inset;

/**
 If added to a table view, this convienience method will compute the appropriate
 insets values for each cell's layout margins in order to appropriately push the cell's
 content inwards
 
 @param layoutMargins The current `layoutMargins` value of the `UITableViewCell` instance.
 @param offset If desired, any additional horizontal offset for this specific use case
 
 */
- (UIEdgeInsets)adjustedTableViewCellLayoutMarginsForMargins:(UIEdgeInsets)layoutMargins manualOffset:(CGFloat)offset;

/**
 Shows or hides the scroll bar from the scroll view with an optional animation
 */
- (void)setHidden:(BOOL)hidden animated:(BOOL)animated;

@end

NS_ASSUME_NONNULL_END

