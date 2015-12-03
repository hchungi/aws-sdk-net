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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The output from the DescribeEndpoint operation.
    /// </summary>
    public partial class DescribeEndpointResponse : AmazonWebServiceResponse
    {
        private string _endpointAddress;

        /// <summary>
        /// Gets and sets the property EndpointAddress. 
        /// <para>
        /// The address.
        /// </para>
        /// </summary>
        public string EndpointAddress
        {
            get { return this._endpointAddress; }
            set { this._endpointAddress = value; }
        }

        // Check to see if EndpointAddress property is set
        internal bool IsSetEndpointAddress()
        {
            return this._endpointAddress != null;
        }

    }
}