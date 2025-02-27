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
    /// Container for the parameters to the UpdateTrustAnchor operation.
    /// Updates the trust anchor.You establish trust between IAM Roles Anywhere and your certificate
    /// authority (CA) by configuring a trust anchor. A Trust Anchor is defined either as
    /// a reference to a AWS Certificate Manager Private Certificate Authority (ACM PCA),
    /// or by uploading a Certificate Authority (CA) certificate. Your AWS workloads can authenticate
    /// with the trust anchor using certificates issued by the trusted Certificate Authority
    /// (CA) in exchange for temporary AWS credentials.
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <code>rolesanywhere:UpdateTrustAnchor</code>. 
    /// </para>
    /// </summary>
    public partial class UpdateTrustAnchorRequest : AmazonIAMRolesAnywhereRequest
    {
        private string _name;
        private Source _source;
        private string _trustAnchorId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trust anchor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The trust anchor type and its related certificate data.
        /// </para>
        /// </summary>
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

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