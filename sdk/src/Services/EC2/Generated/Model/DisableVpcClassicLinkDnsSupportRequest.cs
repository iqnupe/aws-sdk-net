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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DisableVpcClassicLinkDnsSupport operation.
    /// Disables ClassicLink DNS support for a VPC. If disabled, DNS hostnames resolve to
    /// public IP addresses when addressed between a linked EC2-Classic instance and instances
    /// in the VPC to which it's linked. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
    /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You must specify a VPC ID in the request.
    /// </para>
    ///  <note> 
    /// <para>
    /// We are retiring EC2-Classic on August 15, 2022. We recommend that you migrate from
    /// EC2-Classic to a VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
    /// from EC2-Classic to a VPC</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DisableVpcClassicLinkDnsSupportRequest : AmazonEC2Request
    {
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}