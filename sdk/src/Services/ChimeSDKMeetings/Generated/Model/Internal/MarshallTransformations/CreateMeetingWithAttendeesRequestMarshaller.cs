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
    /// CreateMeetingWithAttendees Request Marshaller
    /// </summary>       
    public class CreateMeetingWithAttendeesRequestMarshaller : IMarshaller<IRequest, CreateMeetingWithAttendeesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMeetingWithAttendeesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMeetingWithAttendeesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMeetings");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "POST";

            request.AddSubResource("operation", "create-attendees");
            request.ResourcePath = "/meetings";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttendees())
                {
                    context.Writer.WritePropertyName("Attendees");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAttendeesListValue in publicRequest.Attendees)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CreateAttendeeRequestItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestAttendeesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetExternalMeetingId())
                {
                    context.Writer.WritePropertyName("ExternalMeetingId");
                    context.Writer.Write(publicRequest.ExternalMeetingId);
                }

                if(publicRequest.IsSetMediaRegion())
                {
                    context.Writer.WritePropertyName("MediaRegion");
                    context.Writer.Write(publicRequest.MediaRegion);
                }

                if(publicRequest.IsSetMeetingFeatures())
                {
                    context.Writer.WritePropertyName("MeetingFeatures");
                    context.Writer.WriteObjectStart();

                    var marshaller = MeetingFeaturesConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MeetingFeatures, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMeetingHostId())
                {
                    context.Writer.WritePropertyName("MeetingHostId");
                    context.Writer.Write(publicRequest.MeetingHostId);
                }

                if(publicRequest.IsSetNotificationsConfiguration())
                {
                    context.Writer.WritePropertyName("NotificationsConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationsConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NotificationsConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPrimaryMeetingId())
                {
                    context.Writer.WritePropertyName("PrimaryMeetingId");
                    context.Writer.Write(publicRequest.PrimaryMeetingId);
                }

                if(publicRequest.IsSetTenantIds())
                {
                    context.Writer.WritePropertyName("TenantIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTenantIdsListValue in publicRequest.TenantIds)
                    {
                            context.Writer.Write(publicRequestTenantIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateMeetingWithAttendeesRequestMarshaller _instance = new CreateMeetingWithAttendeesRequestMarshaller();        

        internal static CreateMeetingWithAttendeesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMeetingWithAttendeesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}