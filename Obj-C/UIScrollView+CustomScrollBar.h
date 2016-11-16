
#import <UIKit/UIKit.h>

@class CustomScrollBar;

@interface UIScrollView (CustomScrollBar)

/** The scroll bar view currently added to this scroll view */
@property (nullable, nonatomic, readonly) CustomScrollBar *customScrollBar;

/**
 Adds a new scroll bar instance to this scroll bar
 @param scrollBar The scroll bar in which to add
 */
- (void)AddScrollBar:(nullable CustomScrollBar *)scrollBar;

/**
 Removes the current scroll bar (if any) from the scroll bar
 */
- (void)RemoveScrollbar;

@end
