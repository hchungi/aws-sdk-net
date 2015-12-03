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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAssessment Request Marshaller
    /// </summary>       
    public class CreateAssessmentRequestMarshaller : IMarshaller<IRequest, CreateAssessmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAssessmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAssessmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Inspector");
            string target = "InspectorService.CreateAssessment";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationArn())
                {
                    context.Writer.WritePropertyName("applicationArn");
                    context.Writer.Write(publicRequest.ApplicationArn);
                }

                if(publicRequest.IsSetAssessmentName())
                {
                    context.Writer.WritePropertyName("assessmentName");
                    context.Writer.Write(publicRequest.AssessmentName);
                }

                if(publicRequest.IsSetDurationInSeconds())
                {
                    context.Writer.WritePropertyName("durationInSeconds");
                    context.Writer.Write(publicRequest.DurationInSeconds);
                }

                if(publicRequest.IsSetUserAttributesForFindings())
                {
                    context.Writer.WritePropertyName("userAttributesForFindings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserAttributesForFindingsListValue in publicRequest.UserAttributesForFindings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AttributeMarshaller.Instance;
                        marshaller.Marshall(publicRequestUserAttributesForFindingsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}