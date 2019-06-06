using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace MacUI
{
    public partial class GameItem : AppKit.NSView
    {
        #region Constructors

        // Called when created from unmanaged code
        public GameItem(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public GameItem(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion
    }
}
