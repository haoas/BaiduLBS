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

namespace Sample
{
    public class StartNavigationListener : Java.Lang.Object,Com.Baidu.Navisdk.BaiduNaviManager.IOnStartNavigationListener
    {
        private Activity mActivity;

        public StartNavigationListener(Activity activity)
        {
            mActivity = activity;
        }

        public void OnJumpToDownloader()
        {

        }

        public void OnJumpToNavigator(Bundle p0)
        {
            Intent intent = new Intent(mActivity, typeof(BNavigatorActivity));
            intent.PutExtras(p0);
            mActivity.StartActivity(intent);
        }
    }
}