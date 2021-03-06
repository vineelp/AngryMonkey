using System;
using System.Collections.Generic;
using CocosSharp;

namespace GoneBananas
{
    public class GameStartLayer : CCLayerColor
    {
        public GameStartLayer () : base ()
        {
            var touchListener = new CCEventListenerTouchAllAtOnce ();
            touchListener.OnTouchesEnded = (touches, ccevent) => Window.DefaultDirector.ReplaceScene (GameLayer.GameScene (Window));

            AddEventListener (touchListener, this);

            Color = CCColor3B.Black;
            Opacity = 255;
        }

        protected override void AddedToScene ()
        {
            base.AddedToScene ();

            var label = new CCLabelTtf("Your Angry monkey is waiting for you. \nTap the Screen and take revenge", "arial", 24) {
                Position = VisibleBoundsWorldspace.Center,
                Color = CCColor3B.Green,
                HorizontalAlignment = CCTextAlignment.Center,
                VerticalAlignment = CCVerticalTextAlignment.Center,
                AnchorPoint = CCPoint.AnchorMiddle
            };

            AddChild (label);
        }

        public static CCScene GameStartLayerScene (CCWindow mainWindow)
        {
            var scene = new CCScene (mainWindow);
            var layer = new GameStartLayer ();

            scene.AddChild (layer);

            return scene;
        }
    }
}