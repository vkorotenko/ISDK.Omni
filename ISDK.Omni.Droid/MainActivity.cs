using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace ISDK.Omni.Droid
{
    [Activity(Label = "View for TabsViewModel")]    
    [Register("ISDK.Omni.Droid.TabsView")]
    public class TabsView : MvxTabActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TabsView);
        }
    }
}