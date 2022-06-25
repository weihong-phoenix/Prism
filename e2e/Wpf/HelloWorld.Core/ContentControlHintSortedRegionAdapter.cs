

using Prism.Properties;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Windows;

#if HAS_UWP
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
#elif HAS_WINUI
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
#else
using System.Windows.Controls;
using System.Windows.Data;
#endif

namespace Prism.Regions
{
    /// <summary>
    /// Adapter that creates a new <see cref="SingleActiveRegion"/> and monitors its
    /// active view to set it on the adapted <see cref="ContentControl"/>.
    /// </summary>
    public class ContentControlHintSortedRegionAdapter : RegionAdapterBase<ContentControl>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ContentControlHintSortedRegionAdapter"/>.
        /// </summary>
        /// <param name="regionBehaviorFactory">The factory used to create the region behaviors to attach to the created regions.</param>
        public ContentControlHintSortedRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory)
            : base(regionBehaviorFactory)
        {
        }

        /// <summary>
        /// Adapts a <see cref="ContentControl"/> to an <see cref="IRegion"/>.
        /// </summary>
        /// <param name="region">The new region being used.</param>
        /// <param name="regionTarget">The object to adapt.</param>
        protected override void Adapt(IRegion region, ContentControl regionTarget)
        {
            if (regionTarget == null)
                throw new ArgumentNullException(nameof(regionTarget));

            bool contentIsSet = regionTarget.Content != null;
            contentIsSet = contentIsSet || regionTarget.HasBinding(ContentControl.ContentProperty);

            if (contentIsSet)
                throw new InvalidOperationException("ContentControl's Content property is not empty.");

            region.ActiveViews.CollectionChanged += delegate
            {
                regionTarget.Content = region.ActiveViews.FirstOrDefault();
            };

            region.Views.CollectionChanged +=
                (sender, e) =>
                {
                    if (e.Action == NotifyCollectionChangedAction.Add)
                    {
                        //if (region.ActiveViews.Count() == 0)
                        //    region.Activate(e.NewItems[0]);

                        var activedView = region.ActiveViews.FirstOrDefault();

                        var activingView = region.Views.FirstOrDefault();
                        if (activingView != activedView && activingView != null)
                        {
                            region.Activate(activingView);

                            // TESTCODE:
                            {
                                Debug.WriteLine($"### ContentControlSortedRegionAdapter.CollectionChanged.Add, {activingView}");
                            }
                        }
                    }
                };

            // TESTCODE:
            {
                Debug.WriteLine($"### ContentControlSortedRegionAdapter.Adapt, region is {region}, regionTarget is {regionTarget}");
            }
        }

        /// <summary>
        /// Creates a new instance of <see cref="SingleActiveRegion"/>.
        /// </summary>
        /// <returns>A new instance of <see cref="SingleActiveRegion"/>.</returns>
        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }

    internal static partial class DependencyObjectExtensions
    {
        /// <summary>
        /// Determines if a <see cref="DependencyProperty"/> has a binding set
        /// </summary>
        /// <param name="instance">The to use to search for the property</param>
        /// <param name="property">The property to search</param>
        /// <returns><c>true</c> if there is an active binding, otherwise <c>false</c></returns>
        public static bool HasBinding(this FrameworkElement instance, DependencyProperty property)
#if HAS_UWP || HAS_WINUI
            => instance.GetBindingExpression(property) != null;
#else
            => BindingOperations.GetBinding(instance, property) != null;
#endif

    }
}
