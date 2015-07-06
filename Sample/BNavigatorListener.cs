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
using Com.Baidu.Navisdk.UI.Routeguide;
using Com.Baidu.Navisdk;

namespace Sample
{
    public class BNavigatorListener : Java.Lang.Object, IBNavigatorListener
    {
        private Activity mActivity;

        public BNavigatorListener(Activity activity)
        {
            mActivity = activity;
        }

        public void NotifyGPSStatusData(int p0)
        {

        }

        public void NotifyLoacteData(Com.Baidu.Navisdk.Model.Datastruct.LocData p0)
        {

        }

        public void NotifyNmeaData(string p0)
        {

        }

        public void NotifySensorData(Com.Baidu.Navisdk.Model.Datastruct.SensorData p0)
        {

        }

        public void NotifyStartNav()
        {
            BaiduNaviManager.Instance.DismissWaitProgressDialog();
        }

        public void NotifyViewModeChanged(int p0)
        {

        }

        public void OnPageJump(int p0, Java.Lang.Object p1)
        {
            //µ¼º½½áÊø
            if (BNavigatorListenerConsts.PageJumpWhenGuideEnd == p0)
            {
                mActivity.Finish();
            }
            else if (BNavigatorListenerConsts.PageJumpWhenRoutePlanFail == p0)
            {
                mActivity.Finish();
            }
        }

        public void OnYawingRequestStart()
        {

        }

        public void OnYawingRequestSuccess()
        {

        }
    }
}