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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLaunchConfigurationTemplate operation.
    /// Creates a new ReplicationConfigurationTemplate.
    /// </summary>
    public partial class UpdateLaunchConfigurationTemplateRequest : AmazonMgnRequest
    {
        private string _launchConfigurationTemplateID;
        private PostLaunchActions _postLaunchActions;

        /// <summary>
        /// Gets and sets the property LaunchConfigurationTemplateID. 
        /// <para>
        /// Update Launch configuration Target instance right sizing request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string LaunchConfigurationTemplateID
        {
            get { return this._launchConfigurationTemplateID; }
            set { this._launchConfigurationTemplateID = value; }
        }

        // Check to see if LaunchConfigurationTemplateID property is set
        internal bool IsSetLaunchConfigurationTemplateID()
        {
            return this._launchConfigurationTemplateID != null;
        }

        /// <summary>
        /// Gets and sets the property PostLaunchActions. 
        /// <para>
        /// Update Launch configuration Target instance right sizing request.
        /// </para>
        /// </summary>
        public PostLaunchActions PostLaunchActions
        {
            get { return this._postLaunchActions; }
            set { this._postLaunchActions = value; }
        }

        // Check to see if PostLaunchActions property is set
        internal bool IsSetPostLaunchActions()
        {
            return this._postLaunchActions != null;
        }

    }
}