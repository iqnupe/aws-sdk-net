/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Object for LoRaWAN join resource type event configuration.
    /// </summary>
    public partial class LoRaWANJoinResourceTypeEventConfiguration
    {
        private EventNotificationTopicStatus _wirelessDeviceEventTopic;

        /// <summary>
        /// Gets and sets the property WirelessDeviceEventTopic. 
        /// <para>
        /// Enum to denote whether the wireless device join event topic is enabled or disabled.
        /// </para>
        /// </summary>
        public EventNotificationTopicStatus WirelessDeviceEventTopic
        {
            get { return this._wirelessDeviceEventTopic; }
            set { this._wirelessDeviceEventTopic = value; }
        }

        // Check to see if WirelessDeviceEventTopic property is set
        internal bool IsSetWirelessDeviceEventTopic()
        {
            return this._wirelessDeviceEventTopic != null;
        }

    }
}