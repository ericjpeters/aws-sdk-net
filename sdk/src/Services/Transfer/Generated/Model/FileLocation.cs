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
    /// Specifies the Amazon S3 or EFS file details to be used in the step.
    /// </summary>
    public partial class FileLocation
    {
        private EfsFileLocation _efsFileLocation;
        private S3FileLocation _s3FileLocation;

        /// <summary>
        /// Gets and sets the property EfsFileLocation. 
        /// <para>
        /// Specifies the Amazon EFS ID and the path for the file being used.
        /// </para>
        /// </summary>
        public EfsFileLocation EfsFileLocation
        {
            get { return this._efsFileLocation; }
            set { this._efsFileLocation = value; }
        }

        // Check to see if EfsFileLocation property is set
        internal bool IsSetEfsFileLocation()
        {
            return this._efsFileLocation != null;
        }

        /// <summary>
        /// Gets and sets the property S3FileLocation. 
        /// <para>
        /// Specifies the S3 details for the file being used, such as bucket, Etag, and so forth.
        /// </para>
        /// </summary>
        public S3FileLocation S3FileLocation
        {
            get { return this._s3FileLocation; }
            set { this._s3FileLocation = value; }
        }

        // Check to see if S3FileLocation property is set
        internal bool IsSetS3FileLocation()
        {
            return this._s3FileLocation != null;
        }

    }
}