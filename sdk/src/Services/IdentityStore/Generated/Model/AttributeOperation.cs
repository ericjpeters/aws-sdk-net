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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// An operation that applies to the requested group. This operation might add, replace,
    /// or remove an attribute.
    /// </summary>
    public partial class AttributeOperation
    {
        private string _attributePath;
        private Amazon.Runtime.Documents.Document _attributeValue;

        /// <summary>
        /// Gets and sets the property AttributePath. 
        /// <para>
        /// A string representation of the path to a given attribute or sub-attribute. Supports
        /// JMESPath.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AttributePath
        {
            get { return this._attributePath; }
            set { this._attributePath = value; }
        }

        // Check to see if AttributePath property is set
        internal bool IsSetAttributePath()
        {
            return this._attributePath != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The value of the attribute. This is a <code>Document</code> type. This type is not
        /// supported by Java V1, Go V1, and older versions of the AWS CLI.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AttributeValue
        {
            get { return this._attributeValue; }
            set { this._attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return !this._attributeValue.IsNull();
        }

    }
}