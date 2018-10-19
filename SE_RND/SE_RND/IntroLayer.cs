﻿using System;
using System.Collections.Generic;
using CocosSharp;
using Microsoft.Xna.Framework;

namespace SE_RND
{
    public class IntroLayer : CCLayerColor
    {

        // Define a label variable
        CCLabel label;

        public IntroLayer()
            : base(CCColor4B.Blue)
        {

            // create and initialize a Label
            label = new CCLabel("Hello World this is a Test", "fonts/MarkerFelt", 22, CCLabelFormat.SpriteFont);
            slabel = new CCLabel("Hello World this is a Test2", "fonts/MarkerFelt", 22, CCLabelFormat.SpriteFont);

            // add the label as a child to this Layer
            AddChild(label);
            AddChild(label2);

        }

        protected override void AddedToScene()
        {
            base.AddedToScene();

            // Use the bounds to layout the positioning of our drawable assets
            var bounds = VisibleBoundsWorldspace;

            // position the label on the center of the screen
            label.Position = bounds.Center;

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

