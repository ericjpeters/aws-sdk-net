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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the GetReservedNodeExchangeConfigurationOptions operation.
    /// </summary>
    public partial class GetReservedNodeExchangeConfigurationOptionsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<ReservedNodeConfigurationOption> _reservedNodeConfigurationOptionList = new List<ReservedNodeConfigurationOption>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token provided by a previous <code>GetReservedNodeExchangeConfigurationOptions</code>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedNodeConfigurationOptionList. 
        /// <para>
        /// the configuration options for the reserved-node exchange. These options include information
        /// about the source reserved node and target reserved node. Details include the node
        /// type, the price, the node count, and the offering type.
        /// </para>
        /// </summary>
        public List<ReservedNodeConfigurationOption> ReservedNodeConfigurationOptionList
        {
            get { return this._reservedNodeConfigurationOptionList; }
            set { this._reservedNodeConfigurationOptionList = value; }
        }

        // Check to see if ReservedNodeConfigurationOptionList property is set
        internal bool IsSetReservedNodeConfigurationOptionList()
        {
            return this._reservedNodeConfigurationOptionList != null && this._reservedNodeConfigurationOptionList.Count > 0; 
        }

    }
}