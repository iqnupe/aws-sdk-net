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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAgreement operation.
    /// Delete the agreement that's specified in the provided <code>AgreementId</code>.
    /// </summary>
    public partial class DeleteAgreementRequest : AmazonTransferRequest
    {
        private string _agreementId;
        private string _serverId;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// A unique identifier for the agreement. This identifier is returned when you create
        /// an agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string AgreementId
        {
            get { return this._agreementId; }
            set { this._agreementId = value; }
        }

        // Check to see if AgreementId property is set
        internal bool IsSetAgreementId()
        {
            return this._agreementId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// The server ID associated with the agreement that you are deleting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

    }
}