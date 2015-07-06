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
using Com.Baidu.Navisdk;

namespace Sample
{
    [Activity(Label = "RouteGuideDemo")]
    public class RouteGuideDemo : Activity
    {
        private StartNavigationListener mStartNavigationListener;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.layout1);
            mStartNavigationListener = new StartNavigationListener(this);

            FindViewById<Button>(Resource.Id.button1).Click += (e, s) =>
            {
                BaiduNaviManager.Instance.LaunchNavigator(this,
                    40.05087, 116.30142, "百度大厦",
                    39.90882, 116.39750, "北京天安门",
                    1, true, BaiduNaviManager.StrategyForceOnlinePriority,
                    mStartNavigationListener);
            };
        }
    }
}