/****************************************************************************
 * Copyright (c) 2015 - 2025 liangxiegame UNDER MIT License
 *
 * http://qframework.cn
 * https://github.com/liangxiegame/QFramework
 * https://gitee.com/liangxiegame/QFramework
 ****************************************************************************/

#if UNITY_EDITOR
using System;

namespace QFramework
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PackageKitRenderOrderAttribute : Attribute
    {
        public int Order { get; private set; }

        public PackageKitRenderOrderAttribute(int order)
        {
            Order = order;
        }

        public PackageKitRenderOrderAttribute(string packageName)
        {
            switch (packageName)
            {
                case "APIDoc":
                    Order = 0;
                    break;
                case "PackageKit":
                    Order = 1;
                    break;
           
                case "CodeGenKit":
                    Order = 3;
                    break;
                case "BuildKit":
                    Order = 10;
                    break;
                case "LiveCodingKit":
                    Order = 11;
                    break;
                case "Account":
                    Order = 100;
                    break;
                case "MyPackage":
                    Order = 110;
                    break;
            }
        }
    }
}
#endif