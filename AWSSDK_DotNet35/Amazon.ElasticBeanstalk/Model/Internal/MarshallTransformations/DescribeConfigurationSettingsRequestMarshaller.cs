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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeConfigurationSettings Request Marshaller
    /// </summary>       
    public class DescribeConfigurationSettingsRequestMarshaller : IMarshaller<IRequest, DescribeConfigurationSettingsRequest>
    {
        public IRequest Marshall(DescribeConfigurationSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "DescribeConfigurationSettings");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplicationName())
                {
                    request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
                }
                if(publicRequest.IsSetEnvironmentName())
                {
                    request.Parameters.Add("EnvironmentName", StringUtils.FromString(publicRequest.EnvironmentName));
                }
                if(publicRequest.IsSetTemplateName())
                {
                    request.Parameters.Add("TemplateName", StringUtils.FromString(publicRequest.TemplateName));
                }
            }
            return request;
        }
    }
}