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
using Com.Baidu.Navisdk.Util.Verify;

namespace Sample
{
    public class BNKeyVerifyListener : Java.Lang.Object, IBNKeyVerifyListener
    {

        public void OnVerifyFailed(int p0, string p1)
        {

        }

        public void OnVerifySucc()
        {

        }
    }
}