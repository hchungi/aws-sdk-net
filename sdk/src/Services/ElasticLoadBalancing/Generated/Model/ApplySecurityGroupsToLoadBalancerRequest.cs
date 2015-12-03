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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the ApplySecurityGroupsToLoadBalancer operation.
    /// Associates one or more security groups with your load balancer in a virtual private
    /// cloud (VPC). The specified security groups override the previously associated security
    /// groups.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/elb-security-groups.html#elb-vpc-security-groups">Security
    /// Groups for Load Balancers in a VPC</a> in the <i>Elastic Load Balancing Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class ApplySecurityGroupsToLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private string _loadBalancerName;
        private List<string> _securityGroups = new List<string>();

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The IDs of the security groups to associate with the load balancer. Note that you
        /// cannot specify the name of the security group.
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

    }
}