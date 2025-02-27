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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the DisableTrustAnchor operation.
    /// Disables a trust anchor. When disabled, <a href="https://docs.aws.amazon.com/rolesanywhere/latest/APIReference/API_CreateSession.html">CreateSession</a>
    /// requests specifying this trust anchor are unauthorized.
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <code>rolesanywhere:DisableTrustAnchor</code>. 
    /// </para>
    /// </summary>
    public partial class DisableTrustAnchorRequest : AmazonIAMRolesAnywhereRequest
    {
        private string _trustAnchorId;

        /// <summary>
        /// Gets and sets the property TrustAnchorId. 
        /// <para>
        /// The unique identifier of the trust anchor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string TrustAnchorId
        {
            get { return this._trustAnchorId; }
            set { this._trustAnchorId = value; }
        }

        // Check to see if TrustAnchorId property is set
        internal bool IsSetTrustAnchorId()
        {
            return this._trustAnchorId != null;
        }

    }
}