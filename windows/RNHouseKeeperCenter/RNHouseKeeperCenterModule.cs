using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace House.Keeper.Center.RNHouseKeeperCenter
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNHouseKeeperCenterModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNHouseKeeperCenterModule"/>.
        /// </summary>
        internal RNHouseKeeperCenterModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNHouseKeeperCenter";
            }
        }
    }
}
