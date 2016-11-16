
#import <objc/runtime.h>
#import "UIScrollView+CustomScrollBar.h"
#import "CustomScrollBar.h"

static void * CustomScrollBarPropertyKey = &CustomScrollBarPropertyKey;

@implementation UIScrollView (CustomScrollBar)

- (CustomScrollBar *)CustomScrollBar
{
    return objc_getAssociatedObject(self, CustomScrollBarPropertyKey);
}

- (void)setTo_scrollBar:(CustomScrollBar *)scrollBar
{
    objc_setAssociatedObject(self, CustomScrollBarPropertyKey, scrollBar, OBJC_ASSOCIATION_RETAIN);
}

- (void)AddScrollBar:(CustomScrollBar *)scrollBar
{
    [scrollBar addCustomScrollView:self];
}

- (void)RemoveScrollbar
{
    [self.customScrollBar removeFromScrollView];
}

@end
