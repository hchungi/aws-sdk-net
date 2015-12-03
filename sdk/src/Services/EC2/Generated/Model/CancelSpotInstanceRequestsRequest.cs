/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CancelSpotInstanceRequests operation.
    /// Cancels one or more Spot instance requests. Spot instances are instances that Amazon
    /// EC2 starts on your behalf when the bid price that you specify exceeds the current
    /// Spot price. Amazon EC2 periodically sets the Spot price based on available Spot instance
    /// capacity and current Spot instance requests. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
    /// Instance Requests</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// Canceling a Spot instance request does not terminate running Spot instances associated
    /// with the request.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CancelSpotInstanceRequestsRequest : AmazonEC2Request
    {
        private List<string> _spotInstanceRequestIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CancelSpotInstanceRequestsRequest() { }

        /// <summary>
        /// Instantiates CancelSpotInstanceRequestsRequest with the parameterized properties
        /// </summary>
        /// <param name="spotInstanceRequestIds">One or more Spot instance request IDs.</param>
        public CancelSpotInstanceRequestsRequest(List<string> spotInstanceRequestIds)
        {
            _spotInstanceRequestIds = spotInstanceRequestIds;
        }

        /// <summary>
        /// Gets and sets the property SpotInstanceRequestIds. 
        /// <para>
        /// One or more Spot instance request IDs.
        /// </para>
        /// </summary>
        public List<string> SpotInstanceRequestIds
        {
            get { return this._spotInstanceRequestIds; }
            set { this._spotInstanceRequestIds = value; }
        }

        // Check to see if SpotInstanceRequestIds property is set
        internal bool IsSetSpotInstanceRequestIds()
        {
            return this._spotInstanceRequestIds != null && this._spotInstanceRequestIds.Count > 0; 
        }

    }
}