﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TiuShop.API
{
    public class Common
    {
        public static string url = "http://192.168.1.4/Code/TiuShop/API/Controller";

        public static string imgUrl = "http://192.168.1.4";

        public static string KEY_USERID = "USERID";

        public static string STATUS_SUCCESS = "Success";
        public static string STATUS_FAIL = "Fail";

        public static string LAYOUT_REGISTER = "REGISTER";
        public static string LAYOUT_ORDER = "ORDER";

        public static string NEW_PRODUCT = "new";
        public static string DISCOUNT_PRODUCT = "discount";

        public static string MAN_PRODUCT = "man";
        public static string WOMAN_PRODUCT = "woman";
        public static string BOTH_PRODUCT = "both";
        public static string ALL_PRODUCT = "all";

        public static int WAITING_CONFIRM = 0;
        public static int WAITING_GOOD = 1;
        public static int DELIVERING = 2;
        public static int ORDER_SUCCESS = 3;
        public static int ORDER_CANCEL = 4;
    }
}
