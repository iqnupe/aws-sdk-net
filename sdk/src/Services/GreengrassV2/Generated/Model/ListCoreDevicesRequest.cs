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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListCoreDevices operation.
    /// Retrieves a paginated list of Greengrass core devices.
    /// 
    ///  <note> 
    /// <para>
    /// IoT Greengrass relies on individual devices to send status updates to the Amazon Web
    /// Services Cloud. If the IoT Greengrass Core software isn't running on the device, or
    /// if device isn't connected to the Amazon Web Services Cloud, then the reported status
    /// of that device might not reflect its current status. The status timestamp indicates
    /// when the device status was last updated.
    /// </para>
    ///  
    /// <para>
    /// Core devices send status updates at the following times:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When the IoT Greengrass Core software starts
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the core device receives a deployment from the Amazon Web Services Cloud
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the status of any component on the core device becomes <code>BROKEN</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// At a <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-nucleus-component.html#greengrass-nucleus-component-configuration-fss">regular
    /// interval that you can configure</a>, which defaults to 24 hours
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class ListCoreDevicesRequest : AmazonGreengrassV2Request
    {
        private int? _maxResults;
        private string _nextToken;
        private CoreDeviceStatus _status;
        private string _thingGroupArn;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned per paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The core device status by which to filter. If you specify this parameter, the list
        /// includes only core devices that have this status. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>HEALTHY</code> – The IoT Greengrass Core software and all components run on
        /// the core device without issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNHEALTHY</code> – The IoT Greengrass Core software or a component is in a
        /// failed state on the core device.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CoreDeviceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ThingGroupArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the IoT thing group by which to filter. If you specify this parameter, the list
        /// includes only core devices that have successfully deployed a deployment that targets
        /// the thing group. When you remove a core device from a thing group, the list continues
        /// to include that core device.
        /// </para>
        /// </summary>
        public string ThingGroupArn
        {
            get { return this._thingGroupArn; }
            set { this._thingGroupArn = value; }
        }

        // Check to see if ThingGroupArn property is set
        internal bool IsSetThingGroupArn()
        {
            return this._thingGroupArn != null;
        }

    }
}