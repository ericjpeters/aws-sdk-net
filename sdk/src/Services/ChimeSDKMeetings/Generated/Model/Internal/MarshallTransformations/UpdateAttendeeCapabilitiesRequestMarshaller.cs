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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMeetings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAttendeeCapabilities Request Marshaller
    /// </summary>       
    public class UpdateAttendeeCapabilitiesRequestMarshaller : IMarshaller<IRequest, UpdateAttendeeCapabilitiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAttendeeCapabilitiesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAttendeeCapabilitiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMeetings");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAttendeeId())
                throw new AmazonChimeSDKMeetingsException("Request object does not have required field AttendeeId set");
            request.AddPathResource("{AttendeeId}", StringUtils.FromString(publicRequest.AttendeeId));
            if (!publicRequest.IsSetMeetingId())
                throw new AmazonChimeSDKMeetingsException("Request object does not have required field MeetingId set");
            request.AddPathResource("{MeetingId}", StringUtils.FromString(publicRequest.MeetingId));
            request.ResourcePath = "/meetings/{MeetingId}/attendees/{AttendeeId}/capabilities";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapabilities())
                {
                    context.Writer.WritePropertyName("Capabilities");
                    context.Writer.WriteObjectStart();

                    var marshaller = AttendeeCapabilitiesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Capabilities, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAttendeeCapabilitiesRequestMarshaller _instance = new UpdateAttendeeCapabilitiesRequestMarshaller();        

        internal static UpdateAttendeeCapabilitiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAttendeeCapabilitiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}