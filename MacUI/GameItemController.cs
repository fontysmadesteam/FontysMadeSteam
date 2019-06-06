using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using FontysMadeSteam.Model;
namespace MacUI
{
    public partial class GameItemController : AppKit.NSViewController
    {
        #region Constructors

        // Called when created from unmanaged code
        public GameItemController(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public GameItemController(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Call to load from the XIB/NIB file
        public GameItemController() : base("GameItem", NSBundle.MainBundle)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        //strongly typed view accessor
        public new GameItem View
        {
            get
            {
                return (GameItem)base.View;
            }
        }

        [Export("Game")]
        public Game Game
        {
            get;set;
        }
    }
}
