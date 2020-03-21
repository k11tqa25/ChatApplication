﻿using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    /// <summary>
    /// Helpers to animation pages in specific ways
    /// </summary>
    public static class PageAnimations
    {
        /// <summary>
        /// Slides a page in from the right
        /// </summary>
        /// <param name="page"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRightAsync(this Page page, float seconds)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Add slide from from right animation
            sb.AddSlideFromRight(seconds, page.WindowWidth);

            // Add slide from from right animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)seconds * 1000);
        }
        
        /// <summary>
        /// Slides a page out to the left
        /// </summary>
        /// <param name="page"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeftAsync(this Page page, float seconds)
        {
            // Create the storyboard
            var sb = new Storyboard();

            // Add slide from from right animation
            sb.AddSlideToLeft(seconds, page.WindowWidth);

            // Add slide from from right animation
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)seconds * 1000);
        }
    }
}
