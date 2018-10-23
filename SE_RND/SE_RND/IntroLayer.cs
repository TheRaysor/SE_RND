using System;
using System.Collections.Generic;
using CocosSharp;
using Microsoft.Xna.Framework;

namespace SE_RND
{
    public class IntroLayer : CCLayerColor
    {

        // Define a label variable
        CCLabel label, slable;

        public IntroLayer()
            : base(CCColor4B.Blue)
        {

            // create and initialize a Label
            label = new CCLabel("Tap to start !", "fonts/MarkerFelt", 33, CCLabelFormat.SpriteFont);
            slable = new CCLabel("Score:", "fonts/MarkerFelt", 22, CCLabelFormat.SpriteFont);

            // add the label as a child to this Layer
            AddChild(label);
            AddChild(slable);

        }

        protected override void AddedToScene()
        {
            base.AddedToScene();

            // Use the bounds to layout the positioning of our drawable assets
            var bounds = VisibleBoundsWorldspace;

            // position the label on the center of the screen
            label.Position = bounds.Center;
            slable.PositionX = 20;
            slable.PositionY = 20;

            // Register for touch events
            var touchListener = new CCEventListenerTouchAllAtOnce();
            touchListener.OnTouchesEnded = OnTouchesEnded;
            AddEventListener(touchListener, this);
        }

        void OnTouchesEnded(List<CCTouch> touches, CCEvent touchEvent)
        {
            if (touches.Count > 0)
            {
                // Perform touch handling here
            }
        }
    }
}

